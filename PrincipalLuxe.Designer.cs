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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button10 = new Button();
            btnFacturacion = new Button();
            btnUsuarios = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnStock = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            PanelFormularios = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            labelFecha = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            PanelFormularios.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 136, 164);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button10);
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
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 781);
            panel4.Name = "panel4";
            panel4.Size = new Size(277, 71);
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
            label1.Location = new Point(79, 31);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 10;
            label1.Text = "USERNAME";
            // 
            // button10
            // 
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderColor = Color.White;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.CheckedBackColor = Color.FromArgb(229, 206, 212);
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 206, 212);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(0, 622);
            button10.Name = "button10";
            button10.Size = new Size(277, 64);
            button10.TabIndex = 8;
            button10.Text = "SALIR";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
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
            btnFacturacion.Location = new Point(0, 542);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(277, 80);
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
            btnUsuarios.Location = new Point(0, 462);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(277, 80);
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
            btnProductos.Location = new Point(0, 382);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(277, 80);
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
            btnClientes.Location = new Point(0, 302);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(277, 80);
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
            btnStock.Location = new Point(0, 222);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(277, 80);
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
            btnDashboard.Size = new Size(277, 80);
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
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(277, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1530, 39);
            panel3.TabIndex = 1;
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
            PanelFormularios.Controls.Add(labelFecha);
            PanelFormularios.CustomizableEdges = customizableEdges3;
            PanelFormularios.Dock = DockStyle.Fill;
            PanelFormularios.Location = new Point(277, 39);
            PanelFormularios.Name = "PanelFormularios";
            PanelFormularios.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PanelFormularios.Size = new Size(1530, 813);
            PanelFormularios.TabIndex = 8;
            PanelFormularios.Paint += guna2CustomGradientPanel1_Paint;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFecha.Location = new Point(614, 420);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(333, 128);
            labelFecha.TabIndex = 0;
            labelFecha.Text = "label2";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
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
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            PanelFormularios.ResumeLayout(false);
            PanelFormularios.PerformLayout();
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
        private Button button10;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelFormularios;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label labelFecha;
        private System.Windows.Forms.Timer timer1;
    }
}