using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxeLane
{
    public partial class Contacto : Form
    {
        public Contacto()
        {
            InitializeComponent();
        }

        private void Contacto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void SendEmailAsync()
        {
            string usuario = nombreUsuariolTextBox.Text;
            string emailUsuario = emailUsuarioTextBox.Text;
            string subject = subjectTextBox.Text;
            string message = msgTextBox.Text;



            try
            {
                string? mail = "luxelanee1@gmail.com";
                string? pwd = "gvpp kzmf trgb aqpv";
                using (MailMessage email = new MailMessage())
                {
                    email.From = new MailAddress(mail);
                    email.To.Add("tanishamaria2@gmail.com");
                    email.Subject = subject;
                    email.Body = $"Usuario: {usuario} \r\nEmail Usuario: {emailUsuario} \r\n\r\nMensaje: \r\n\r\n{message}";
                    email.IsBodyHtml = false;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential(mail, pwd);
                        smtp.EnableSsl = true;
                        smtp.Send(email);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SendEmailAsync();
        }
    }
}
