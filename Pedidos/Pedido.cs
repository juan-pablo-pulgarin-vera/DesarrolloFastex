using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class Formpe : Form
    {
        public Formpe()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }



        Form car = new Carrito();
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            car.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
       
            car.Show();
        }

        private void Formpe_Load(object sender, EventArgs e)
        {
            if (Login.area == "Vendedor")

            {
                btlVendedor.Enabled = true;

            }


            else if (Login.area == "Cliente")

            {
                btlVendedor.Enabled = false;

            }
        }

        private void btlVendedor_Click(object sender, EventArgs e)
        {
            Application.Run(new CRUD_Clientes());
        }
    }
}
