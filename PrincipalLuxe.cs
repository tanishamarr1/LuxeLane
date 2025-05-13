using Guna.UI2.WinForms;
using LuxeLane.Modelos;
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
            VerificarStockBajo();
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
        private void AplicarTemaOscuro(Control control)
        {
            control.BackColor = Color.FromArgb(30, 30, 30);
            control.ForeColor = Color.White;

            foreach (Control c in control.Controls)
                AplicarTemaOscuro(c);

            if (control is DataGridView dgv)
            {
                dgv.BackgroundColor = Color.FromArgb(45, 45, 45);
                dgv.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
                dgv.DefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.EnableHeadersVisualStyles = false;
            }
        }

        private void AplicarTemaClaro(Control control)
        {
            control.BackColor = SystemColors.Control;
            control.ForeColor = Color.Black;

            foreach (Control c in control.Controls)
                AplicarTemaClaro(c);

            if (control is DataGridView dgv)
            {
                dgv.BackgroundColor = Color.White;
                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.ForeColor = Color.Black;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgv.EnableHeadersVisualStyles = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (chkTemaOscuro.Checked)
            {
                AplicarTemaOscuro(this);
            }
            else
            {
                AplicarTemaClaro(this);
            }
        }

        private void chkTemaOscuro_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            PanelTemas.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            PanelTemas.Visible = true;
        }

        private void PanelTemas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Configuracion());
        }

        void VerificarStockBajo()
        {
            using (var dbcontext = new LuxeLaneContext())
            {
                var bajoStock = dbcontext.Inventarios.ToList();

                if (bajoStock.Any())
                {
                    // Mostrar notificación del sistema
                    notifyIcon1.BalloonTipTitle = "⚠️ Alerta de Stock Bajo";
                    notifyIcon1.BalloonTipText = $"Hay {bajoStock.Count} productos con menos de 10 unidades.";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.ShowBalloonTip(5000); // muestra por 5 segundos


                }
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            MessageBox.Show("Haz clic aquí para ver los productos con stock bajo.");
            // o abrir otro formulario con detalle
        }

        private void PrincipalLuxe_Load(object sender, EventArgs e)
        {
            VerificarStockBajo();
            timer1.Start(); 
        }
    }
}
