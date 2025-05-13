namespace LuxeLane
{
    partial class PrincipalLuxe
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalLuxe));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnFacturacion = new Button();
            btnUsuarios = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnStock = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button3 = new Button();
            button9 = new Button();
            labelFecha = new Label();
            button8 = new Button();
            button7 = new Button();
            PanelFormularios = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            PanelTemas = new Guna.UI2.WinForms.Guna2ShadowPanel();
            pictureBox4 = new PictureBox();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            chkTemaOscuro = new CheckBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            PanelFormularios.SuspendLayout();
            PanelTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 136, 164);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnFacturacion);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnClientes);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 852);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(229, 206, 212);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 206, 212);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_settings_40;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 576);
            button1.Name = "button1";
            button1.Size = new Size(277, 62);
            button1.TabIndex = 13;
            button1.Text = "CONFIGURACIÓN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(229, 206, 212);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 206, 212);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_themes_40;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 514);
            button2.Name = "button2";
            button2.Size = new Size(277, 62);
            button2.TabIndex = 12;
            button2.Text = "CAMBIAR TEMA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 783);
            panel4.Name = "panel4";
            panel4.Size = new Size(277, 69);
            panel4.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 29);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 10;
            label1.Text = "USERNAME";
            // 
            // btnFacturacion
            // 
            btnFacturacion.Dock = DockStyle.Top;
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatAppearance.CheckedBackColor = Color.FromArgb(229, 206, 212);
            btnFacturacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 206, 212);
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnFacturacion.ForeColor = Color.White;
            btnFacturacion.Image = (Image)resources.GetObject("btnFacturacion.Image");
            btnFacturacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnFacturacion.Location = new Point(0, 452);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(277, 62);
            btnFacturacion.TabIndex = 7;
            btnFacturacion.Text = "FACTURACIÓN";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += button6_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.CheckedBackColor = Color.FromArgb(229, 206, 212);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 206, 212);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 390);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(277, 62);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "USUARIOS";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += button5_Click;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.CheckedBackColor = Color.FromArgb(229, 206, 212);
            btnProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 206, 212);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnProductos.ForeColor = Color.White;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 328);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(277, 62);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += button4_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.CheckedBackColor = Color.FromArgb(229, 206, 212);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 206, 212);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 266);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(277, 62);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "CLIENTES";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += button3_Click;
            // 
            // btnStock
            // 
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatAppearance.CheckedBackColor = Color.FromArgb(229, 206, 212);
            btnStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 206, 212);
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnStock.ForeColor = Color.White;
            btnStock.Image = (Image)resources.GetObject("btnStock.Image");
            btnStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnStock.Location = new Point(0, 204);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(277, 62);
            btnStock.TabIndex = 3;
            btnStock.Text = "STOCK";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += button2_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.CheckedBackColor = Color.FromArgb(229, 206, 212);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 206, 212);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 142);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(277, 62);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 142);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.LOGO_LUXELANE_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(229, 136, 164);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(labelFecha);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(277, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1530, 39);
            panel3.TabIndex = 1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.icons8_campana_30;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(43, 39);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Right;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = Properties.Resources.icons8_menos_30;
            button9.Location = new Point(1386, 0);
            button9.Name = "button9";
            button9.Size = new Size(43, 39);
            button9.TabIndex = 2;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = Color.White;
            labelFecha.Location = new Point(49, 9);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(67, 25);
            labelFecha.TabIndex = 0;
            labelFecha.Text = "label2";
            // 
            // button8
            // 
            button8.Dock = DockStyle.Right;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.icons8_maximizar_30;
            button8.Location = new Point(1429, 0);
            button8.Name = "button8";
            button8.Size = new Size(41, 39);
            button8.TabIndex = 1;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Right;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.icons8_cerrar_ventana_30__1_;
            button7.Location = new Point(1470, 0);
            button7.Name = "button7";
            button7.Size = new Size(60, 39);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // PanelFormularios
            // 
            PanelFormularios.Controls.Add(PanelTemas);
            PanelFormularios.Controls.Add(pictureBox3);
            PanelFormularios.CustomizableEdges = customizableEdges2;
            PanelFormularios.Dock = DockStyle.Fill;
            PanelFormularios.Location = new Point(277, 39);
            PanelFormularios.Name = "PanelFormularios";
            PanelFormularios.ShadowDecoration.CustomizableEdges = customizableEdges3;
            PanelFormularios.Size = new Size(1530, 813);
            PanelFormularios.TabIndex = 8;
            PanelFormularios.Paint += guna2CustomGradientPanel1_Paint;
            // 
            // PanelTemas
            // 
            PanelTemas.BackColor = Color.Transparent;
            PanelTemas.Controls.Add(pictureBox4);
            PanelTemas.Controls.Add(guna2ImageButton1);
            PanelTemas.Controls.Add(chkTemaOscuro);
            PanelTemas.Controls.Add(label2);
            PanelTemas.FillColor = Color.White;
            PanelTemas.Location = new Point(21, 227);
            PanelTemas.Name = "PanelTemas";
            PanelTemas.ShadowColor = Color.Black;
            PanelTemas.Size = new Size(309, 310);
            PanelTemas.TabIndex = 2;
            PanelTemas.Visible = false;
            PanelTemas.Paint += PanelTemas_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_themes_78;
            pictureBox4.Location = new Point(111, 146);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 78);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(19, 37);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton1.Size = new Size(39, 34);
            guna2ImageButton1.TabIndex = 2;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // chkTemaOscuro
            // 
            chkTemaOscuro.AutoSize = true;
            chkTemaOscuro.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkTemaOscuro.Location = new Point(70, 248);
            chkTemaOscuro.Name = "chkTemaOscuro";
            chkTemaOscuro.Size = new Size(142, 29);
            chkTemaOscuro.TabIndex = 1;
            chkTemaOscuro.Text = "Tema oscuro";
            chkTemaOscuro.UseVisualStyleBackColor = true;
            chkTemaOscuro.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 92);
            label2.Name = "label2";
            label2.Size = new Size(186, 32);
            label2.TabIndex = 0;
            label2.Text = "CAMBIAR TEMA";
            label2.Click += label2_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.LOGO_LUXELANE_removebg_preview;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1530, 813);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // PrincipalLuxe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1807, 852);
            Controls.Add(PanelFormularios);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrincipalLuxe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrincipalLuxe";
            Load += PrincipalLuxe_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            PanelFormularios.ResumeLayout(false);
            PanelTemas.ResumeLayout(false);
            PanelTemas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDashboard;
        private PictureBox pictureBox1;
        private Button btnFacturacion;
        private Button btnUsuarios;
        private Button btnProductos;
        private Button btnClientes;
        private Button btnStock;
        private Panel panel3;
        private Button button9;
        private Button button8;
        private Button button7;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelFormularios;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox3;
        private Label labelFecha;
        private Button button1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2ShadowPanel PanelTemas;
        private CheckBox chkTemaOscuro;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private PictureBox pictureBox4;
        private Button button3;
        private NotifyIcon notifyIcon1;
    }
}