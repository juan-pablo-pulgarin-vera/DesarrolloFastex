using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Negocio;
using Capa_Entidad;

namespace Pedidos
{
    public partial class Registrar : Form
    {
        ClaseEntidadDairo objent = new ClaseEntidadDairo();
        ClaseNegocioDairo objneg = new ClaseNegocioDairo();
        public Registrar()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objent.IdPersona = textBoxIDPersona.Text;
            objent.TipoDocumento = textBoxDocumento.Text;
            objent.NumeroDocumento = Convert.ToDouble(textBoxNDocumento.Text);
            objent.FechaNacimiento = textBoxFechaNacimiento.Text;
            objent.Nombre = textBoxNombreCompleto.Text;
            objent.CorreoElectronico = textBoxEmail.Text;
            objent.Ciudad= textBoxCiudad.Text;
            objent.Pais = textBoxPais.Text;
            objent.Departamento = textBoxDepartamento.Text;
            objent.TipoPersona = textBoxTipoPersona.Text;
            objent.DireccionResidencia = textBoxDireccion.Text;
            objent.Telefono = Convert.ToDouble(textBoxTelefono.Text);
            objent.Cargo = textBoxCargo.Text;
            objent.Contrasena = textBoxContrasena.Text;
            objent.accion = accion;

            String men = objneg.N_Registrar(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            textBoxIDPersona.Text = "";
            textBoxDocumento.Text = "";
            textBoxNDocumento.Text = "";
            textBoxFechaNacimiento.Text = "";
            textBoxNombreCompleto.Text = "";
            textBoxEmail.Text = "";
            textBoxPais.Text = "";
            textBoxCiudad.Text = "";
            textBoxDireccion.Text = "";
            textBoxDepartamento.Text = "";
            textBoxTelefono.Text = "";
            textBoxCargo.Text = "";
            textBoxContrasena.Text = "";
            textBoxTipoPersona.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            mantenimiento("1");
            limpiar();
            
        }
    }
}
