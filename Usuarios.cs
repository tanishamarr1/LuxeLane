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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            InsertarDatosEnElGrid();
            InsertarAlIdsComboBox();
        }

        private bool isEditing = false;
        void InsertarDatosEnElGrid()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var listaUsers = dbcontext.Usuarios.ToList();
                dataGridView1.DataSource = listaUsers;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AñadirUsuario()
        {
            DialogResult dialog = MessageBox.Show("Quieres añadir este usuario?", "Añadir Usuario", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (LuxeLaneContext dbcontext = new LuxeLaneContext())
                {
                    var user = new Usuario
                    {
                        NombreUsuario = Nombre.Text,
                        Contraseña = Contraseña.Text,
                        Rol = comboBox1.Text,
                    };

                    dbcontext.Usuarios.Add(user);
                    dbcontext.SaveChanges();
                }
                MessageBox.Show("Usuario Añadido. ");
                InsertarDatosEnElGrid();
            }
            else
            {
                MessageBox.Show("Accion cancelada. ");
                return;
            }
        }

        private void EditarUsuario()
        {

            DialogResult dialogUpdate = MessageBox.Show("Quieres actualizar este usuario?", "Actualizar Usuario", MessageBoxButtons.YesNo);
            if (dialogUpdate == DialogResult.Yes)
            {
                DataGridViewRow newRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                using (LuxeLaneContext dbContext = new LuxeLaneContext())
                {
                    int id = (int)newRow.Cells["UsuarioId"].Value;
                    var userToUpdate = dbContext.Usuarios.Find(id);
                    userToUpdate!.NombreUsuario = Nombre.Text;
                    userToUpdate.Contraseña = Contraseña.Text;
                    userToUpdate.Rol = comboBox1.Text;
                    userToUpdate.FechaRegistro = DateTime.Now;
                    dbContext.Usuarios.Update(userToUpdate);
                    dbContext.SaveChanges();

                }
                InsertarDatosEnElGrid();
                Nombre.Clear();
                Contraseña.Clear();
                MessageBox.Show("Usuario Actualizado. ", "Actualizacion", MessageBoxButtons.OK);
                isEditing = false;
                return;
            }
            else
            {
                isEditing = false;
                Nombre.Clear();
                Contraseña.Clear();
                MessageBox.Show("Accion cancelada. ");
                return;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                EditarUsuario();
                return;
            }

            AñadirUsuario();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DeleteUsers()
        {
            DialogResult dialogUpdate = MessageBox.Show("Quieres eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo);
            if (dialogUpdate == DialogResult.Yes)
            {
                DataGridViewRow newRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                using (LuxeLaneContext dbContext = new LuxeLaneContext())
                {
                    int id = (int)newRow.Cells[0].Value;
                    var Delete = dbContext.Usuarios.Find(id);
                    dbContext.Usuarios.Remove(Delete);
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
            DeleteUsers();
        }

        private void InsertarAlIdsComboBox()
        {
            using (LuxeLaneContext DBContext = new())
            {
                var listaDeRoles = DBContext.Usuarios.Select(x => x.Rol).ToList();
                foreach (var product in listaDeRoles)
                {
                    comboBox1.Items.Add(product!);
                }
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ObtenerDatosDelUsuario()
        {
            isEditing = true;
            DataGridViewRow newRow = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            Nombre.Text = (string)newRow.Cells["NombreUsuario"].Value;
            Contraseña.Text = (string)newRow.Cells["Contraseña"].Value;
            comboBox1.Text = (string)newRow.Cells["Rol"].Value;
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ObtenerDatosDelUsuario();
        }
    }
}
