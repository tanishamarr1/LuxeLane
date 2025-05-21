namespace LuxeLane
{
    partial class CambiarTema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkTemaOscuro = new CheckBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button7 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chkTemaOscuro
            // 
            chkTemaOscuro.AutoSize = true;
            chkTemaOscuro.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkTemaOscuro.Location = new Point(52, 248);
            chkTemaOscuro.Name = "chkTemaOscuro";
            chkTemaOscuro.Size = new Size(177, 34);
            chkTemaOscuro.TabIndex = 1;
            chkTemaOscuro.Text = "TEMA OSCURO";
            chkTemaOscuro.UseVisualStyleBackColor = true;
            chkTemaOscuro.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_themes_78;
            pictureBox1.Location = new Point(71, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 136, 164);
            panel1.Controls.Add(button7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 39);
            panel1.TabIndex = 3;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Right;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.icons8_cerrar_ventana_30__1_;
            button7.Location = new Point(235, 0);
            button7.Name = "button7";
            button7.Size = new Size(60, 39);
            button7.TabIndex = 3;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 90);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 4;
            label1.Text = "CAMBIAR TEMA";
            // 
            // CambiarTema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(295, 360);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(chkTemaOscuro);
            Name = "CambiarTema";
            StartPosition = FormStartPosition.Manual;
            Text = "CambiarTema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkTemaOscuro;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Button button7;
    }
}