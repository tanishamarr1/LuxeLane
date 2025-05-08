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

namespace LuxeLane
{
    public partial class PrincipalLuxe : Form
    {

        private Form _activeForm;
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
            DeshabilitarBotones();
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
            string? userName = UserSession.UserName;
            label1.Text = userName;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
            OpenChildForm(new Productos());
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
            };
            buttons.ForEach(button => button.Enabled = false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
