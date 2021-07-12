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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void mODIFICARCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form obj = new CrudCliente();
            obj.MdiParent= this;
            obj.Show();


        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form obj = new lblIdentificadorproducto();
            obj.MdiParent = this;
            obj.Show();

        }

        private void mODIFICARPEDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form obj = new Formpe();
            obj.MdiParent = this;
            obj.Show();

        }

       
    }
}
