using Guna.UI2.WinForms;
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

namespace LuxeLane
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            using (var db = new LuxeLaneContext())
            {
                var usernames = db.Usuarios.Select(u => u.NombreUsuario).ToList();
                User.Items.Clear();

                foreach (var username in usernames)
                {
                    User.Items.Add(username);
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var contactForm = new Contacto();
            contactForm.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            {
                string rutaMysqldump = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe"; // o la ruta correcta en tu sistema
                string usuario = "Tannymarr";
                string contraseña = "TannyMarrRodriguez20,_";
                string baseDeDatos = "luxelane";


                string rutaBackup = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                                                 $"backup_{DateTime.Now:yyyyMMdd_HHmmss}.sql");

                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = rutaMysqldump,
                        Arguments = $"-u {usuario} -p{contraseña} {baseDeDatos}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process proceso = Process.Start(psi))
                    {
                        using (StreamReader reader = proceso.StandardOutput)
                        {
                            string resultado = reader.ReadToEnd();
                            File.WriteAllText(rutaBackup, resultado);
                        }

                        proceso.WaitForExit();
                    }

                    MessageBox.Show($"Backup guardado en:\n{rutaBackup}", "Backup exitoso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el backup:\n" + ex.Message, "Error");
                }
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"No hay nuevas actualizaciones para el sistema.");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Términos terminos = new Términos();
            terminos.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string selectedUser = User.Text;
            string contraseña = Contraseña.Text;
            using (var db = new LuxeLaneContext())
            {
                var usuario = db.Usuarios.FirstOrDefault(u => u.NombreUsuario == selectedUser);

                if (usuario != null && usuario.Contraseña == contraseña)
                {
                    UserSession.UserRole = usuario.Rol;
                    UserSession.UserName = usuario.NombreUsuario;

                    MessageBox.Show("Sesión cambiada exitosamente a " + usuario.NombreUsuario);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            PrincipalLuxe._instance.lbl1.Text = selectedUser;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }
    }
}

