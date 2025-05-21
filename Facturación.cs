using Guna.UI2.WinForms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using LuxeLane.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tulpep.NotificationWindow;

namespace LuxeLane
{
    public partial class Facturación : Form
    {
        public Facturación()
        {
            InitializeComponent();
            InsertarDatosEnElGrid();
            InsertarDatosProductos();
            InsertarCategorias();



        }
        private Config rutaclase = new Config { Id = 1, RutaGuardarFacturas = @"C:\Facturas Luxe" };
        private const int IdRutaExistente = 1;
        private string? rutaAlPdf;
        List<OrdenTicket> productosComprados = new();

        void CalcularTotal()
        {

            double price = Convert.ToDouble(txtPrecio.Text);
            double cantidad = Convert.ToDouble(CantidadNumeric.Value);
            double total = price * cantidad;
            txtTotalsh.Text = total.ToString();

        }




        void InsertarDatosProductos()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var productosgrid = dbcontext.Productos.ToList();
                DATAGRID1.DataSource = productosgrid;
            }
        }

        void InsertarDatosEnElGrid()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var invoiceDetails = dbcontext.Facturas.ToList();
                DetallesFacturaGrid.DataSource = invoiceDetails;

            }
        }
        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ObtenerNombreYPrecioProducto()
        {
            string productId = comboIdProducto.SelectedItem!.ToString();
            using (LuxeLaneContext DBContext = new())
            {
                var product = DBContext.Productos.Where(x => x.ProductoId.ToString() == productId).FirstOrDefault();
                string? nameToUse = product!.NombreProducto;
                decimal? priceToUse = product.Precio;
                txtNombreProducto.Text = nameToUse;
                txtPrecio.Text = priceToUse.ToString();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DATAGRID1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Delete()
        {
            DialogResult dialogUpdate = MessageBox.Show("Quieres eliminar este producto?", "Eliminar producto", MessageBoxButtons.YesNo);
            if (dialogUpdate == DialogResult.Yes)
            {
                DataGridViewRow newRow = DATAGRID1.Rows[DATAGRID1.CurrentCell.RowIndex];
                using (LuxeLaneContext dbContext = new LuxeLaneContext())
                {
                    int id = (int)newRow.Cells[0].Value;
                    var Delete = dbContext.Productos.Find(id);
                    dbContext.Productos.Remove(Delete);
                    dbContext.SaveChanges();
                }
                InsertarDatosEnElGrid();
            }
            else
            {
                MessageBox.Show("Accion cancelada. ");
                return;
            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }
        private void InsertarCategorias()
        {
            using (LuxeLaneContext DBContext = new())
            {
                var categoriasList = DBContext.Categorias.Select(x => x.NombreCategoria).ToList();
                foreach (var categorias in categoriasList)
                {
                    comboCategoria.Items.Add(categorias!);
                }
            }
        }

        private string ticketBuild()
        {

            string? pname = txtNombreProducto.Text;
            string? category = comboCategoria.SelectedItem.ToString();
            string? originalPrice = txtPrecio.Text;
            string? qty = CantidadNumeric.Value.ToString();
            string? totalPrice = txtTotalsh.Text;

            productosComprados.Add(new OrdenTicket { PName = pname, Category = category, OriginalPrice = originalPrice, QTY = qty, TotalPrice = totalPrice });


            string dataTicket = $"\t\t\t\t\t\t\t LuxeLane \t\t\t\t\t\r\n" +
                    $"\t\t\t\t\t\t\t\tSTREETWEAR!\t\t\t\t\r\n\r\n" +
                    $"\t\t\t\t\t\t\t\tFACTURA DE VENTA\t\t\t\t\r\n\r\n" +
                    $"Producto                  Categoria         Precio          Cantidad        Total\r\n" +
                    $"--------------------------------------------------------------------------------------------------\r\n";

            productosComprados.ForEach(producto =>
                dataTicket += $"\t{producto.PName,-15} {producto.Category,20} {producto.OriginalPrice,16} {producto.QTY,12} {producto.TotalPrice,20}\r\n"
            );

            dataTicket += $"---------------------------------------------------------------------------------------------\r\n" +
                          $"\t\t\t\t\tTOTAL: {txtTotalsh.Text}$\r\n" +
                          $"\t\t\t\t\tPAGO: {txtPago.Text}$\r\n" +
                          $"\t\t\t\t\tDEVUELTA: {txtDevuelta.Text}$\r\n" +
                          $"\t\t\t\t**CLIENTE: {txtClienteID.Text}**\r\n" +
                          $"\t\t\t\tGRACIAS POR SU PREFERENCIA CON luxeLane\r\n";


            return dataTicket;
        }

        string WritePdf(string filePath)
        {

            Document document = new Document();


            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));


            document.Open();


            document.Add(new Paragraph(ticketBuild()));


            document.Close();

            return filePath;
        }

        void OpenTheInvoice(string filePath)
        {
            if (filePath is null)
            {
                MessageBox.Show("No se hizo la factura");
                return;
            }

            var psi = new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void InsertarId()
        {
            using (LuxeLaneContext DBContext = new())
            {
                string? nombreCategoria = comboCategoria.SelectedItem.ToString();
                var products = DBContext.Productos.Where(x => x.Categoria.NombreCategoria == nombreCategoria).Select(x => x.ProductoId);
                foreach (var product in products)
                {
                    comboIdProducto.Items.Add(product!);
                }
            }
        }
        private void comboIdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtenerNombreYPrecioProducto();
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertarId();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        void GuardarPdf()
        {
            using (LuxeLaneContext _DBContext = new())
            {
                string? directorio = rutaclase!.RutaGuardarFacturas;
                string? path = directorio + @"\" + "factura.pdf";
                string rutaPdf = WritePdf(path!);
                rutaAlPdf = rutaPdf;
            };
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using var dbcontext = new LuxeLaneContext();
            var factura = new Factura
            {

                ClienteId = Convert.ToInt32(txtClienteID.Text),
                UsuarioId = Convert.ToInt32(UsuarioId.Text),
                Total = Convert.ToDecimal(txtTotalsh.Text),
                FechaVenta = DateTime.Now,
            };

            var restQty = CantidadNumeric.Value;
            var idProducto = comboIdProducto!.SelectedItem!.ToString();
            int idprod = Convert.ToInt32(idProducto);
            var producto = dbcontext.Productos.Find(idprod);
            if (producto != null)
            {
                producto.Qty -= restQty;
                dbcontext.SaveChanges();
            }
            if (producto!.Qty < 10)
            {
                var noti = new PopupNotifier();
                noti.TitleText = "Stock bajo";
                noti.TitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
                noti.TitleColor = Color.Red;
                noti.ContentFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
                noti.ContentText = $"El producto {producto.NombreProducto} tiene bajo stock";
                noti.ContentPadding = new Padding(10);
                noti.Popup();
                var notification = new Notifications
                {
                    Title = "Stock bajo",
                    Message = $"El producto {producto.NombreProducto} tiene stock bajo",
                };
                dbcontext.Notifications.Add(notification);
            }

            dbcontext.Facturas.Add(factura);
            dbcontext.SaveChanges();

            InsertarDatosEnElGrid();
            GuardarPdf();

            var dialog = MessageBox.Show("Desea cargar la factura?", "Factura guardada.", MessageBoxButtons.YesNo);
            if (dialog is DialogResult.Yes)
            {
                OpenTheInvoice(rutaAlPdf!);
                return;
            }
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Facturación_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenTheInvoice(rutaAlPdf!);
        }

        private void txtDevuelta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            long total = Convert.ToInt64(txtTotalsh.Text);
            long pago = Convert.ToInt64(txtPago.Text);
            long resultado = pago - total;
            txtDevuelta.Text = resultado.ToString();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                string textoBusqueda = guna2TextBox1.Text.ToLower();

                if (string.IsNullOrWhiteSpace(textoBusqueda))
                {
                    InsertarDatosEnElGrid();
                    return;
                }

                var lista = dbcontext.Productos
                    .Where(x => x.NombreProducto.ToLower().Contains(textoBusqueda))
                    .ToList();

                DATAGRID1.DataSource = lista;
            }
        }
    }
}
