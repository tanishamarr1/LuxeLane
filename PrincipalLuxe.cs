using Guna.UI2.WinForms;
using LuxeLane.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace LuxeLane
{
    public partial class PrincipalLuxe : Form
    {

        private Form _activeForm;
        public static PrincipalLuxe _instance;
        public System.Windows.Forms.Label lbl1;


        private void OpenChildForm(Form childForm)
        {

            if (_activeForm != null)
                _activeForm.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelFormularios.Controls.Add(childForm);
            PanelFormularios.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        public PrincipalLuxe()
        {
            InitializeComponent();
            lbl1 = label1;
            _instance = this;
        }

        private void PrincipalLuxe_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
            DeshabilitarBotones();
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
            string? userName = UserSession.UserName;
            label1.Text = userName;
            using var dbContext = new LuxeLaneContext();
            var notis = dbContext.Notifications.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        public void ActualizarNombreUsuario()
        {
            label1.Text = UserSession.UserName;
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Stock());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClientesLuxe());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductsLane());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Usuarios());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Facturación());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToLongTimeString();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool ElUsuarioEsAdmin()
        {
            return UserSession.UserRole == "Admin";

        }
        private void DeshabilitarBotones()
        {

            if (!ElUsuarioEsAdmin())
            {
                DesabBotones();
            }
        }

        private void DesabBotones()
        {
            List<Button> buttons = new List<Button>()
            {
               btnDashboard,
                btnClientes,
                btnStock,
                btnUsuarios,
                btnProductos,
                BtnCambiarTema,
                BtnConfiguracion,
            };
            buttons.ForEach(button => button.Enabled = false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkTemaOscuro_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            CambiarTema form = new CambiarTema();
            form.Show();
        }

        private void PanelTemas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Configuracion());
        }

       
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("Haz clic aquí para ver los productos con stock bajo.");
           
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            
            using var dbContext = new LuxeLaneContext();
            var notificationes = dbContext.Notifications.ToList();
            if (notificationes.Any())
            {
                var notis = new PopupNotifier
                {
                    TitleText = "Notificaciones",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold),
                    ContentFont = new Font("Arial", 10),
                    AnimationDuration = 1000,
                };
                notificationes.ForEach(x => notis.ContentText += "\n" + x.Message);
                notis.Popup();
                return;
            }

            MessageBox.Show("No hay notificaciones pendientes.");


        }

        private void limpiarNotisBtn_Click(object sender, EventArgs e)
        {
            using var dbContext = new LuxeLaneContext();
            var notificationes = dbContext.Notifications.ToList();
            foreach (var noti in notificationes)
            {
                dbContext.Notifications.Remove(noti);
                dbContext.SaveChanges();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        
    }
}
