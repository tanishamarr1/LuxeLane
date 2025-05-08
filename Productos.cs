using LuxeLane.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LuxeLane
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
            BackColor = System.Drawing.Color.White;
            InsertarDatosEnElGrid();
        }

        private bool isEditing = false;
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ObtenerDatosDelProducto()
        {
            isEditing = true;
            DataGridViewRow newRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            txtNombre.Text = (string)newRow.Cells["NombreProducto"].Value;
            Descripcion.Text = (string)newRow.Cells["Descripcion"].Value;
            Precio.Text = Convert.ToString(newRow.Cells["Precio"].Value);
            Categoria.Text = Convert.ToString(newRow.Cells["CategoriaId"].Value);
            Stock.Text = Convert.ToString(newRow.Cells["StockId"].Value);
            Talla.Text = Convert.ToString(newRow.Cells["Talla"].Value);
            Color.Text = (string)newRow.Cells["Color"].Value;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                EditarProducto();
                return;
            }

            RegistrarProducto();
        }

        void RegistrarProducto()
        {
            try
            {
                using (var _DBContext = new LuxeLaneContext())
                {
                    var nuevoServicio = new Producto
                    {
                        NombreProducto = txtNombre.Text,
                        Descripcion = Descripcion.Text,
                        Precio = Convert.ToDecimal(Precio.Text),
                        CategoriaId = Convert.ToInt16(Categoria.Text),
                        StockId = Convert.ToInt32(Stock.Text),
                        Talla = Talla.Text,
                        Color = Color.Text
                    };
                    _DBContext.Productos.Add(nuevoServicio);
                    _DBContext.SaveChanges();


                    MessageBox.Show("Producto añadido correctamente.");
                    InsertarDatosEnElGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal! ");
            }
        }

        void InsertarDatosEnElGrid()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var lista = dbcontext.Productos.ToList();
                dataGridView1.DataSource = lista;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            PanelProductos.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            PanelProductos.Visible = true;
        }
        private void DeleteProducto()
        {
            DialogResult dialogUpdate = MessageBox.Show("Quieres eliminar este producto?", "Eliminar Producto", MessageBoxButtons.YesNo);
            if (dialogUpdate == DialogResult.Yes)
            {
                DataGridViewRow newRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DeleteProducto();
        }

        private void EditarProducto()
        {

            DialogResult dialogUpdate = MessageBox.Show("Quieres actualizar este producto?", "Actualizar Producto", MessageBoxButtons.YesNo);
            if (dialogUpdate == DialogResult.Yes)
            {
                DataGridViewRow newRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                using (LuxeLaneContext dbContext = new LuxeLaneContext())
                {
                    int id = (int)newRow.Cells["ProductoId"].Value;
                    var userToUpdate = dbContext.Productos.Find(id);
                    userToUpdate!.NombreProducto = txtNombre.Text;
                    userToUpdate.Descripcion = Descripcion.Text;
                    userToUpdate.Precio = Convert.ToDecimal(Precio.Text);
                    userToUpdate.StockId = Convert.ToInt16(Stock.Text);
                    userToUpdate.CategoriaId = Convert.ToInt16(Categoria.Text);
                    userToUpdate.Talla = Talla.Text;
                    userToUpdate.Color = Color.Text;
                    userToUpdate.FechaRegistro = DateTime.Now;
                    dbContext.Productos.Update(userToUpdate);
                    dbContext.SaveChanges();

                }
                InsertarDatosEnElGrid();
                txtNombre.Clear();
                Descripcion.Clear();
                Stock.Clear();
                Categoria.Clear();
                Talla.Clear();
                Color.Clear();
                Precio.Clear();
                MessageBox.Show("Producto Actualizado. ", "Actualizacion", MessageBoxButtons.OK);

                return;
            }
            else
            {
                isEditing = false;
                txtNombre.Clear();
                Descripcion.Clear();
                Stock.Clear();
                Categoria.Clear();
                Talla.Clear();
                Color.Clear();
                Precio.Clear();
                MessageBox.Show("Accion cancelada. ");
                return;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ObtenerDatosDelProducto();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
