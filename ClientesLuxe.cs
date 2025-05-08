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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LuxeLane
{
    public partial class ClientesLuxe : Form
    {
        public ClientesLuxe()
        {
            InitializeComponent();
            InsertarDatosEnElGrid();
        }
        void InsertarDatosEnElGrid()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var listaClientes = dbcontext.Clientes.ToList();
                guna2DataGridView1.DataSource = listaClientes;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            panelCliente.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panelCliente.Visible = true;
        }

        private void AñadirCliente()
        {
            DialogResult dialog = MessageBox.Show("Quieres añadir este cliente?", "Añadir Cliente", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (LuxeLaneContext dbcontext = new LuxeLaneContext())
                {
                    var newCliente = new Cliente
                    {
                        Nombre = txtNombre.Text,
                        Telefono = txtTelefono.Text,
                        Direccion = txtDireccion.Text,
                    };

                    dbcontext.Clientes.Add(newCliente);
                    dbcontext.SaveChanges();
                }
                MessageBox.Show("Cliente Añadido. ");
                InsertarDatosEnElGrid();
            }
            else
            {
                MessageBox.Show("Accion cancelada. ");
                return;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AñadirCliente();
        }

        private void ClientesLuxe_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }
    }
}
