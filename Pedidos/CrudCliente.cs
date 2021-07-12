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
    public partial class CrudCliente : Form
    {
        ClaseEntidadCRUDcliente objent = new ClaseEntidadCRUDcliente();
        ClassNegocioCRUDCliente objneg = new ClassNegocioCRUDCliente();
        public CrudCliente()
        {
            InitializeComponent();
        }
        void mantenimientoCRUDClientes(String accion)
        {
            objent.IdPersona = id.Text;
            objent.TipoDocumento = tipdoc.Text;
            objent.NumeroDocumento = Convert.ToDouble(numdoc.Text);
            objent.FechaNacimiento = fech.Text;
            objent.Nombre = nom.Text;
            objent.CorreoElectronico = ema.Text;
            objent.Ciudad = ciu.Text;
            objent.Pais = pais.Text;
            objent.Departamento = depar.Text;
            objent.TipoPersona = tiper.Text;
            objent.DireccionResidencia = dir.Text;
            objent.Telefono = Convert.ToDouble(tel.Text);
            objent.Cargo = car.Text;
            objent.Contrasena = con.Text;
            objent.accion = accion;
            String men = objneg.N_mantenimiento_clientesCRUD(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            id.Text = "";
            tipdoc.Text = "";
            numdoc.Text = "";
            fech.Text = "";
            nom.Text = "";
            ema.Text = "";
            ciu.Text = "";
            pais.Text = "";
            depar.Text = "";
            dir.Text = "";
            tel.Text = "";
            car.Text = "";
            con.Text = "";
            tiper.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + nom.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimientoCRUDClientes("1");
                    limpiar();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + nom.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimientoCRUDClientes("2");
                    limpiar();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (id.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + nom.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimientoCRUDClientes("3");
                    limpiar();
                }
            }
        }

        private void bus_TextChanged(object sender, EventArgs e)
        {
            if (bus.Text != "")
            {
                objent.Nombre = bus.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_clientesCRUD(objent);
                listar.DataSource = dt;
            }
            else
            {
                listar.DataSource = objneg.N_listar_clientesCRUD();
            }
        }

        private void CrudCliente_Load(object sender, EventArgs e)
        {
            listar.DataSource = objneg.N_listar_clientesCRUD();
        }

        private void listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = listar.CurrentCell.RowIndex;

            id.Text = listar[0, fila].Value.ToString();
            tipdoc.Text = listar[1, fila].Value.ToString();
            numdoc.Text = listar[2, fila].Value.ToString();
            fech.Text = listar[3, fila].Value.ToString();
            nom.Text = listar[4, fila].Value.ToString();
            ema.Text = listar[5, fila].Value.ToString();
            ciu.Text = listar[6, fila].Value.ToString();
            pais.Text = listar[7, fila].Value.ToString();
            depar.Text = listar[8, fila].Value.ToString();
            dir.Text = listar[9, fila].Value.ToString();
            tel.Text = listar[10, fila].Value.ToString();
            car.Text = listar[11, fila].Value.ToString();
            con.Text = listar[12 ,fila].Value.ToString();
            tiper.Text = listar[13, fila].Value.ToString();
        }
    }
    
}
