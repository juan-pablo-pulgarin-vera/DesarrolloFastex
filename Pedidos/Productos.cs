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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        YesicaE objent = new YesicaE();
        YesicaN objneg = new YesicaN();

        void Mantenimiento(string movimiviento)
        {
            objent.identificador = txtIdentificador.Text;
            objent.nombre = txtNombre.Text;
            objent.marca = txtMarca.Text;
            objent.talla = txtTalla.Text;
            objent.color = txtColor.Text;
            objent.preciounidad = Convert.ToDouble(txtPreciounidad.Text);
            objent.movimiento = movimiviento;
            string men = objneg.N_Mantenimiento_Productos(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void Limpiar()
        {
            txtIdentificador.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtTalla.Text = "";
            txtColor.Text = "";
            txtPreciounidad.Text = "";
            dataGridViewProductos.DataSource = objneg.N_Listar_Productos();
        }

        private void productos_Load(object sender, EventArgs e)
        {
            dataGridViewProductos.DataSource = objneg.N_Listar_Productos();
        }

        private void bttnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere registrar el producto " + txtNombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                Mantenimiento("1");
                Limpiar();
            }
           
        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdentificador.Text != "")
            {
                if (MessageBox.Show("Quiere modificar el producto " + txtNombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento("2");
                    Limpiar();
                }
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdentificador.Text != "")
            {
                if (MessageBox.Show("Quiere eliminar el producto " + txtNombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento("3");
                    Limpiar();
                }
            }
        }

        private void txtBuscarnombreproducto_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarnombreproducto.Text != "")
            {
                objent.nombre = txtBuscarnombreproducto.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_Buscar_Productos(objent);
                dataGridViewProductos.DataSource = dt;
            }
            else
            {
                dataGridViewProductos.DataSource = objneg.N_Listar_Productos();
            }
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridViewProductos.CurrentCell.RowIndex;

            txtIdentificador.Text = dataGridViewProductos[0, fila].Value.ToString();
            txtMarca.Text = dataGridViewProductos[1, fila].Value.ToString();
            txtNombre.Text = dataGridViewProductos[2, fila].Value.ToString();
            txtTalla.Text = dataGridViewProductos[3, fila].Value.ToString();
            txtColor.Text = dataGridViewProductos[4, fila].Value.ToString();
            txtPreciounidad.Text = dataGridViewProductos[5, fila].Value.ToString();
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
