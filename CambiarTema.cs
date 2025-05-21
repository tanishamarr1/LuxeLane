using Org.BouncyCastle.Tls;
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
            // Proceder a la siguiente pantalla
            this.Close();
        }

        //private void AplicarTemaOscuro(Control control)
        //{
        //    control.BackColor = Color.FromArgb(30, 30, 30);
        //    control.ForeColor = Color.White;

        //    foreach (Control c in control.Controls)
        //        AplicarTemaOscuro(c);

        //    if (control is DataGridView dgv)
        //    {
        //        dgv.BackgroundColor = Color.FromArgb(45, 45, 45);
        //        dgv.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
        //        dgv.DefaultCellStyle.ForeColor = Color.White;
        //        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
        //        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //        dgv.EnableHeadersVisualStyles = false;
        //    }
        //}

        private void AplicarTemaClaro(Control control)
        {
            if (control == null) return;

            control.BackColor = SystemColors.Control;
            control.ForeColor = SystemColors.ControlText;

            foreach (Control c in control.Controls)
                AplicarTemaClaro(c);

            switch (control)
            {
                case DataGridView dgv:
                    dgv.BackgroundColor = SystemColors.Window;
                    dgv.DefaultCellStyle.BackColor = SystemColors.Window;
                    dgv.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                    dgv.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                    dgv.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
                    dgv.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                    dgv.RowHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                    dgv.RowHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                    dgv.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
                    dgv.EnableHeadersVisualStyles = true;
                    break;

                case TextBox or RichTextBox:
                    control.BackColor = SystemColors.Window;
                    control.ForeColor = SystemColors.ControlText;
                    break;

                case ComboBox cb:
                    cb.BackColor = SystemColors.Window;
                    cb.ForeColor = SystemColors.ControlText;
                    break;

                case ListBox lb:
                    lb.BackColor = SystemColors.Window;
                    lb.ForeColor = SystemColors.ControlText;
                    break;

                case Button btn:
                    btn.FlatStyle = FlatStyle.Standard;
                    btn.BackColor = SystemColors.Control;
                    btn.ForeColor = SystemColors.ControlText;
                    break;
            }
        }


        private void AplicarTemaOscuro(Control control)
        {
            if (control == null) return;

            control.BackColor = Color.FromArgb(30, 30, 30);
            control.ForeColor = Color.White;

            foreach (Control c in control.Controls)
                AplicarTemaOscuro(c);

            switch (control)
            {
                case DataGridView dgv:
                    dgv.BackgroundColor = Color.FromArgb(45, 45, 45);
                    dgv.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
                    dgv.DefaultCellStyle.ForeColor = Color.White;
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(70, 70, 70);
                    dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 80, 80);
                    dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                    dgv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                    dgv.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 80, 80);
                    dgv.RowHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                    dgv.EnableHeadersVisualStyles = false;
                    break;

                case TextBox or RichTextBox:
                    control.BackColor = Color.FromArgb(40, 40, 40);
                    control.ForeColor = Color.White;
                    break;

                case ComboBox cb:
                    cb.BackColor = Color.FromArgb(40, 40, 40);
                    cb.ForeColor = Color.White;
                    break;

                case ListBox lb:
                    lb.BackColor = Color.FromArgb(40, 40, 40);
                    lb.ForeColor = Color.White;
                    break;

                case Button btn:
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.FromArgb(50, 50, 50);
                    btn.ForeColor = Color.White;
                    break;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            List<Control> list = new List<Control>() 
            { 
                PrincipalLuxe._instance,
                Facturación._instance
            };
            
            if (chkTemaOscuro.Checked)
            {
                foreach(var control in list)
                {
                    AplicarTemaOscuro(control);
                }
            }
            else
                AplicarTemaClaro(PrincipalLuxe._instance);

        }
    }
}
