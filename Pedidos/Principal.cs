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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void DCLIENTE_Click(object sender, EventArgs e)
        {
            Form obj = new CRUD_Clientes();
            obj.Show();
        }

        private void DPEDIDO_Click(object sender, EventArgs e)
        {
            Form obj = new lblIdentificadorproducto();
            obj.Show();
        }

        private void COM_Click(object sender, EventArgs e)
        {
            Form obj = new Formpe();
            obj.Show();
        }
    }
}
