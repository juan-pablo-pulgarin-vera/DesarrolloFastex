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
    public partial class CRUD_Clientes : Form
    {
        ClaseEntidadCRUDcliente objent = new ClaseEntidadCRUDcliente();
        ClassNegocioCRUDCliente objneg = new ClassNegocioCRUDCliente();
        public CRUD_Clientes()
        {
            InitializeComponent();
        }

        void mantenimientoCRUDClientes(String accion)
        {
            objent.IdPersona = textBoxIDCRUD.Text;
            objent.TipoDocumento = textBoxTipoDocuementoCRUD.Text;
            objent.NumeroDocumento = Convert.ToDouble(textBoxNDocumentoCRUD.Text);
            objent.FechaNacimiento = textBoxFechaNacimientoCRUD.Text;
            objent.Nombre = textBoxNombreCRUD.Text;
            objent.CorreoElectronico = textBoxEmailCRUD.Text;
            objent.Ciudad = textBoxCiudadCRUD.Text;
            objent.Pais = textBoxPaisCRUD.Text;
            objent.Departamento = textBoxDepartamentoCRUD.Text;
            objent.TipoPersona = textBoxTipoPersonaCRUD.Text;
            objent.DireccionResidencia = textBoxDireccionCRUD.Text;
            objent.Telefono = Convert.ToDouble(textBoxTelefonoCRUD.Text);
            objent.Cargo = textBoxCargoCRUD.Text;
            objent.Contrasena = textBoxContrasenaCRUD.Text;
            objent.accion = accion;
            String men = objneg.N_mantenimiento_clientesCRUD(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            textBoxIDCRUD.Text = "";
            textBoxTipoDocuementoCRUD.Text = "";
            textBoxNDocumentoCRUD.Text = "";
            textBoxFechaNacimientoCRUD.Text = "";
            textBoxNombreCRUD.Text = "";
            textBoxEmailCRUD.Text = "";
            textBoxCiudadCRUD.Text = "";
            textBoxPaisCRUD.Text = "";
            textBoxDepartamentoCRUD.Text = "";
            textBoxDireccionCRUD.Text = "";
            textBoxTelefonoCRUD.Text = "";
            textBoxCargoCRUD.Text = "";
            textBoxContrasenaCRUD.Text = "";
            textBoxTipoPersonaCRUD.Text = "";
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxIDCRUD.Text == "")
            {
                if (MessageBox.Show("¿Deseas registrar a " + textBoxNombreCRUD.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimientoCRUDClientes("1");
                    limpiar();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxIDCRUD.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a " + textBoxNombreCRUD.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimientoCRUDClientes("2");
                    limpiar();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxIDCRUD.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a " + textBoxNombreCRUD.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimientoCRUDClientes("3");
                    limpiar();
                }
            }
        }

        private void textBoxBuscarCRUD_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBuscarCRUD.Text != "")
            {
                objent.Nombre = textBoxBuscarCRUD.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_clientesCRUD(objent);
                lista.DataSource = dt;
            }
            else
            {
                lista.DataSource = objneg.N_listar_clientesCRUD();
            }
        }

       

        private void CRUD_Clientes_Load(object sender, EventArgs e)
        {
            lista.DataSource = objneg.N_listar_clientesCRUD();
        }

        private void lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = lista.CurrentCell.RowIndex;

            textBoxIDCRUD.Text = lista[0, fila].Value.ToString();
            textBoxTipoDocuementoCRUD.Text = lista[1, fila].Value.ToString();
            textBoxNDocumentoCRUD.Text = lista[2, fila].Value.ToString();
            textBoxFechaNacimientoCRUD.Text = lista[3, fila].Value.ToString();
            textBoxNombreCRUD.Text = lista[4, fila].Value.ToString();
            textBoxEmailCRUD.Text = lista[5, fila].Value.ToString();
            textBoxCiudadCRUD.Text = lista[6, fila].Value.ToString();
            textBoxPaisCRUD.Text = lista[7, fila].Value.ToString();
            textBoxDepartamentoCRUD.Text = lista[8, fila].Value.ToString();
            textBoxDireccionCRUD.Text = lista[9, fila].Value.ToString();
            textBoxTelefonoCRUD.Text = lista[10, fila].Value.ToString();
            textBoxCargoCRUD.Text = lista[11, fila].Value.ToString();
            textBoxContrasenaCRUD.Text = lista[12, fila].Value.ToString();
            textBoxTipoPersonaCRUD.Text = lista[13, fila].Value.ToString();
        }
    }
}
