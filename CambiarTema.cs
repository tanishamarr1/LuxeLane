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
    public partial class CambiarTema : Form
    {
        public CambiarTema()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
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

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTemaOscuro.Checked)
            {
                AplicarTemaOscuro(this);
            }
            
        }
    }
}
