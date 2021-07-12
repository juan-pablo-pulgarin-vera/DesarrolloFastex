using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Negocio;

namespace Pedidos
{
    public partial class Login : Form
    {
        ClaseEntidadLogin objeuser = new ClaseEntidadLogin();
        ClaseNegocioLogin objnuser = new ClaseNegocioLogin();
        Principal form1 = new Principal();
        public Login()
        {
            InitializeComponent();
        }

        public static string usuario_nombre;
        public static string area;

        void p_logueo()
        {

            DataTable dt = new DataTable();
            objeuser.NDocumento = textBoxUsuarioLogin.Text;
            objeuser.Contrasena = textBoxContrasenaLogin.Text;


            dt = objnuser.N_user(objeuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][4].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][11].ToString();

                form1.ShowDialog();

                Login login = new Login();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Principal());
                
               

                

                textBoxUsuarioLogin.Clear();
                textBoxContrasenaLogin.Clear();


            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_logueo();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar form = new Registrar();
            form.Show();

            Login form1 = new Login();
        }

        
    }
}
