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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            InsertarDatosEnElGrid();
            InsertarInventario();
            ConsumoDeHoy();
            ContarFacturas();
            ContarUsuarios();
            CategoriasLoad();
        }

        void InsertarDatosEnElGrid()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var productos = dbcontext.Productos.ToList();
                guna2DataGridView1.DataSource = productos;
            }
        }

        void InsertarInventario()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var productos = dbcontext.Inventarios.ToList();
                dataGridView2.DataSource = productos;
            }
        }

        void CategoriasLoad()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var productos = dbcontext.Categorias.ToList();
                Categorias.DataSource = productos;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ContarUsuarios()
        {
            using (LuxeLaneContext dbcontext = new LuxeLaneContext())
            {
                var userCount = dbcontext.Usuarios.Count();
                labelUsuarios.Text = $"{userCount}";
            }


        }

        private void ContarProductos()
        {
            using (LuxeLaneContext dbcontext = new LuxeLaneContext())
            {
                var prodCount = dbcontext.Productos.Count();
                labelProductos.Text = $"{prodCount}";
            }


        }
        private void ContarFacturas()
        {
            using (LuxeLaneContext dbcontext = new LuxeLaneContext())
            {
                var facturas = dbcontext.Facturas.Count();
                labelfACTURAS.Text = $"{facturas}";
            }


        }

        private void ConsumoDeHoy()
        {
            using (LuxeLaneContext dbcontext = new LuxeLaneContext())
            {
                var today = DateTime.Today;
                var tomorrow = today.AddDays(1);
                var totalesDeHoy = dbcontext.Facturas.Where(x => x.FechaVenta >= today && x.FechaVenta < tomorrow).ToList();
                decimal total = 0;
                foreach (var item in totalesDeHoy)
                {
                    total += item.Total;
                }

                labelVentasHoy.Text = total.ToString();
            }
        }
        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
