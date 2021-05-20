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
    public partial class lblIdentificadorproducto : Form
    {
        public lblIdentificadorproducto()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

       
        YesicaE objent = new YesicaE();
        YesicaN objneg = new YesicaN();

        void Mantenimiento(string movimiviento)
        {
            objent.identificador  = identidicador1.Text;
            objent.nombre = nombre.Text;
            objent.marca = marca.Text;
            objent.talla = talla.Text;
            objent.color = color.Text;
            objent.preciounidad = Convert.ToDouble(preciounidad.Text);
            objent.movimiento = movimiviento;
            string men = objneg.N_Mantenimiento_Productos(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Limpiar()
        {
            identidicador1.Text = "";
            nombre.Text = "";
            marca.Text = "";
            talla.Text = "";
            color.Text = "";
            preciounidad.Text = "";
            lista.DataSource = objneg.N_Listar_Productos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lista.DataSource = objneg.N_Listar_Productos();
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere registrar el producto " + nombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                Mantenimiento("1");
                Limpiar();
            }

        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            if (identidicador1.Text != "")
            {
                if (MessageBox.Show("Quiere modificar el producto " + nombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento("2");
                    Limpiar();
                }
            }

        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (identidicador1.Text != "")
            {
               if (MessageBox.Show("Quiere eliminar el producto " + nombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento("3");
                    Limpiar();
                }
            }

        }

        private void bus_TextChanged(object sender, EventArgs e)
        {
            if (bus.Text != "")
            {
                objent.nombre = bus.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_Buscar_Productos(objent);
                lista.DataSource = dt;
            }
            else
            {
               lista.DataSource = objneg.N_Listar_Productos();
            }

        }

        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = lista.CurrentCell.RowIndex;

            identidicador1.Text = lista[0, fila].Value.ToString();
            marca.Text = lista[1, fila].Value.ToString();
            nombre.Text = lista[2, fila].Value.ToString();
            talla.Text = lista[3, fila].Value.ToString();
            color.Text = lista[4, fila].Value.ToString();
            preciounidad.Text = lista[5, fila].Value.ToString();

        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
