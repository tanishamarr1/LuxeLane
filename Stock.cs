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

namespace LuxeLane
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            panelFacturas.Visible = false;
            PanelCategorias.Visible = false;
            InsertarDatosEnElGrid();
            InsertarFacturas();
        }

        void InsertarDatosEnElGrid()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var lista = dbcontext.Productos.ToList();
                dataGridView1.DataSource = lista;
            }
        }

        void InsertarFacturas()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var lista = dbcontext.Facturas.ToList();
                datagridFacturas.DataSource = lista;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            PanelCategorias.Visible = false;
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            PanelCategorias.Visible = true;
        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void datagridFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            panelFacturas.Visible = false;
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            panelFacturas.Visible = true;
        }

        void RegistrarCategoria()
        {
            try
            {
                using (var _DBContext = new LuxeLaneContext())
                {
                    var nuevoCategoria = new Categoria
                    {
                        NombreCategoria = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                    };
                    _DBContext.Categorias.Add(nuevoCategoria);
                    _DBContext.SaveChanges();

                    MessageBox.Show("Categoria añadida correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salio mal! ");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RegistrarCategoria();
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

                dataGridView1.DataSource = lista;
            }

        }
    }
}
