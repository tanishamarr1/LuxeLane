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

    }
    }

