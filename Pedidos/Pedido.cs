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

  

        private void label1_Click(object sender, EventArgs e)
        {
            Form carr = new Carrito();

            carr.Show();
        }
        Carrito obj = new Carrito();
        private void nike1_Click(object sender, EventArgs e)
        {
            Form h1 = new Carrito();
            h1.Show();
            obj.nike1();
            obj.Show();
            
        }

        private void Nike2_Click(object sender, EventArgs e)
        {
            Form h2 = new Carrito();
            h2.Show();
            obj.nike2();
            obj.Show();
        }

        private void Nike3_Click(object sender, EventArgs e)
        {
            Form h3 = new Carrito();
            h3.Show();
            obj.nike3();
            obj.Show();
        }

        private void Nike4_Click(object sender, EventArgs e)
        {
            Form h4 = new Carrito();
            h4.Show();
            obj.nike4();
            obj.Show();
        }

        private void puma1_Click(object sender, EventArgs e)
        {
            Form p1 = new Carrito();
            p1.Show();
            obj.puma1();
            obj.Show();
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
        private void puma2_Click(object sender, EventArgs e)
        {
            Form p2 = new Carrito();
            p2.Show();
            obj.puma2();
            obj.Show();
        }
    }
}
