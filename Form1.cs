using LuxeLane.Modelos;

namespace LuxeLane
{
    public partial class Form1 : Form
    {
        private readonly LuxeLaneContext _context;
        private int retries = 0;
        public Form1()
        {
            InitializeComponent();
            using (var db = new LuxeLaneContext())
            {
                var usernames = db.Usuarios.Select(u => u.NombreUsuario).ToList();
                guna2ComboBox1.Items.Clear();

                foreach (var username in usernames)
                {
                    guna2ComboBox1.Items.Add(username);
                }


            }
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                TxContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                TxContraseña.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string? username = guna2ComboBox1.Text;

            string? contrasena = TxContraseña.Text;
            using (var db = new LuxeLaneContext())
            {
                var credenciales = db.Usuarios.FirstOrDefault(x => x.NombreUsuario == username);
                if (credenciales != null && credenciales.Contraseña == contrasena)
                {
                    UserSession.UserRole = db.Usuarios.Where(un => un.NombreUsuario == username).Select(r => r.Rol).FirstOrDefault();
                    UserSession.UserName = guna2ComboBox1.Text;
                    PrincipalLuxe menuPrincipal = new PrincipalLuxe();
                    MessageBox.Show("Se inicio sesion exitosamente.");
                    menuPrincipal.Show();
                }
                else if (credenciales != null && credenciales.Contraseña != contrasena)
                {

                    MessageBox.Show("La contraseña es incorrecta.");

                    if (retries < 3)
                    {
                        retries++;
                        if (retries == 3)
                        {
                            MessageBox.Show("Se ha alcanzado el limite de intentos. ");
                            guna2ComboBox1.Enabled = false;
                            TxContraseña.Enabled = false;
                        }
                    }
                }

            }
        }
    }
    }

