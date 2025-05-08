namespace LuxeLane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button3 = new Button();
            TxContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            panel2 = new Panel();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(327, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(492, 115);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(492, 187);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_LUXELANE_removebg_preview;
            pictureBox1.Location = new Point(12, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 136, 164);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 53);
            panel1.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.icons8_cerrar_ventana_30__1_;
            button3.Location = new Point(715, 0);
            button3.Name = "button3";
            button3.Size = new Size(62, 53);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TxContraseña
            // 
            TxContraseña.BorderColor = Color.FromArgb(229, 136, 164);
            TxContraseña.BorderRadius = 9;
            TxContraseña.CustomizableEdges = customizableEdges1;
            TxContraseña.DefaultText = "";
            TxContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TxContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TxContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TxContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TxContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TxContraseña.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TxContraseña.IconLeft = (Image)resources.GetObject("TxContraseña.IconLeft");
            TxContraseña.Location = new Point(494, 215);
            TxContraseña.Name = "TxContraseña";
            TxContraseña.PasswordChar = '●';
            TxContraseña.PlaceholderForeColor = Color.FromArgb(229, 136, 164);
            TxContraseña.PlaceholderText = "";
            TxContraseña.SelectedText = "";
            TxContraseña.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TxContraseña.Size = new Size(247, 41);
            TxContraseña.TabIndex = 11;
            TxContraseña.Tag = "";
            TxContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 12;
            guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(229, 136, 164);
            guna2Button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(492, 295);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(116, 41);
            guna2Button1.TabIndex = 12;
            guna2Button1.Text = "ENTRAR";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderRadius = 12;
            guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(229, 136, 164);
            guna2Button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(628, 295);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(111, 41);
            guna2Button2.TabIndex = 13;
            guna2Button2.Text = "CANCELAR";
            // 
            // guna2CheckBox1
            // 
            guna2CheckBox1.AutoSize = true;
            guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.CheckedState.BorderRadius = 0;
            guna2CheckBox1.CheckedState.BorderThickness = 0;
            guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CheckBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2CheckBox1.Location = new Point(494, 264);
            guna2CheckBox1.Name = "guna2CheckBox1";
            guna2CheckBox1.Size = new Size(141, 21);
            guna2CheckBox1.TabIndex = 14;
            guna2CheckBox1.Text = "Mostrar contraseña";
            guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.UncheckedState.BorderRadius = 0;
            guna2CheckBox1.UncheckedState.BorderThickness = 0;
            guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            guna2CheckBox1.CheckedChanged += guna2CheckBox1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(229, 136, 164);
            panel2.Location = new Point(31, 383);
            panel2.Name = "panel2";
            panel2.Size = new Size(708, 17);
            panel2.TabIndex = 15;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.BorderColor = Color.FromArgb(229, 136, 164);
            guna2ComboBox1.BorderRadius = 9;
            guna2ComboBox1.CustomizableEdges = customizableEdges7;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(493, 140);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2ComboBox1.Size = new Size(246, 36);
            guna2ComboBox1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 206, 212);
            ClientSize = new Size(777, 395);
            Controls.Add(guna2ComboBox1);
            Controls.Add(panel2);
            Controls.Add(guna2CheckBox1);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(TxContraseña);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button3;
        private Guna.UI2.WinForms.Guna2TextBox TxContraseña;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}
