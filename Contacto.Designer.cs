namespace LuxeLane
{
    partial class Contacto
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacto));
            subjectTextBox = new TextBox();
            msgTextBox = new TextBox();
            nombreUsuariolTextBox = new TextBox();
            emailUsuarioTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(190, 370);
            subjectTextBox.Multiline = true;
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(279, 83);
            subjectTextBox.TabIndex = 1;
            // 
            // msgTextBox
            // 
            msgTextBox.Location = new Point(190, 482);
            msgTextBox.Multiline = true;
            msgTextBox.Name = "msgTextBox";
            msgTextBox.Size = new Size(279, 82);
            msgTextBox.TabIndex = 2;
            // 
            // nombreUsuariolTextBox
            // 
            nombreUsuariolTextBox.Location = new Point(190, 266);
            nombreUsuariolTextBox.Name = "nombreUsuariolTextBox";
            nombreUsuariolTextBox.Size = new Size(279, 23);
            nombreUsuariolTextBox.TabIndex = 3;
            // 
            // emailUsuarioTextBox
            // 
            emailUsuarioTextBox.Location = new Point(190, 313);
            emailUsuarioTextBox.Name = "emailUsuarioTextBox";
            emailUsuarioTextBox.Size = new Size(279, 23);
            emailUsuarioTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 266);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 509);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 6;
            label2.Text = "MENSAJE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(99, 398);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 7;
            label3.Text = "ASUNTO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 314);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 8;
            label4.Text = "EMAIL:";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 137);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_LUXELANE_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(558, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 4;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(223, 132, 159);
            guna2Button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(136, 607);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(273, 58);
            guna2Button1.TabIndex = 10;
            guna2Button1.Text = "ENVIAR";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_asistente_50;
            pictureBox2.Location = new Point(204, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // Contacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(549, 701);
            Controls.Add(pictureBox2);
            Controls.Add(guna2Button1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailUsuarioTextBox);
            Controls.Add(nombreUsuariolTextBox);
            Controls.Add(msgTextBox);
            Controls.Add(subjectTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Contacto";
            Text = "SOPORTE TÉCNICO";
            Load += Contacto_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox subjectTextBox;
        private TextBox msgTextBox;
        private TextBox nombreUsuariolTextBox;
        private TextBox emailUsuarioTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private PictureBox pictureBox2;
    }
}