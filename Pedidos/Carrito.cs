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
    public partial class Carrito : Form
    {
        claseEntidadJuanpablo objeto = new claseEntidadJuanpablo();
        ClaseNegocioJuanpablo segundo = new ClaseNegocioJuanpablo();

        claseEntidadJuanpablo objeto1 = new claseEntidadJuanpablo();
        ClaseNegocioJuanpablo segundo1 = new ClaseNegocioJuanpablo();
        public Carrito()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        public void mantenimientopedido(string opcion) 
        {
            objeto.idpedido = idpedido.Text;
            objeto.idpersona = idpersona.Text;
            objeto.documento = double.Parse(numerodocumento.Text);
            objeto.direccion = direccion.Text;
            objeto.nombre = nombrepersona.Text;
            objeto.telefono = double.Parse (telefono.Text);
            objeto.referencia = referencia.Text;
            objeto.flete = double.Parse(flete.Text);
            objeto.total = double.Parse(valortotal.Text);
            objeto.opcion = opcion;
            string men = segundo.N_mantenimiento_pedido(objeto);
            MessageBox.Show(men, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
        }

        public void limpiarpedido() 
        {


            idpedido.Text="";
            idpersona.Text="";
           numerodocumento.Text="";
            direccion.Text="";
            nombrepersona.Text="";
           telefono.Text="";
            referencia.Text="";
            flete.Text="";
            valortotal.Text="";

        }

        public void mantenimientodeatallepedido(string accion) 
        {
            objeto1.iddetalle = iddetalle.Text;
            objeto1.idpedido2 = idpedido2.Text;
            objeto1.idproducto = idproducto.Text;
            objeto1.marca = nomzapatos.Text;
            objeto1.color = color.Text;
            objeto1.catidad = double.Parse(cantidad.Text);
            objeto1.talla = talla.Text;
            objeto1.valoreUnidad = double.Parse(valorunid.Text);
            objeto1.accion = accion;
            string men = segundo.N_mantenimiento_Detallepeido(objeto1);
            MessageBox.Show(men, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
        }

        public void limpiardetallepedido() 
        {
            iddetalle.Text="";
            idpedido2.Text="";
            idproducto.Text="";
            nomzapatos.Text="";
            color.Text="";
            cantidad.Text="";
            talla.Text="";
            valorunid.Text="";
        }

        private void limpiar1_Click(object sender, EventArgs e)
        {
            limpiarpedido();
        }

        private void registro1_Click(object sender, EventArgs e)
        {

            if (idpedido.Text == "")
            {
                if (MessageBox.Show("¿Desea registrar la informaión de " + nombrepersona.Text + "?", "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimientopedido("1");
                    limpiarpedido();

                }

            }
        }

       

      


        private void registrar2_Click(object sender, EventArgs e)
        {

            if (iddetalle.Text == "")
            {
                if (MessageBox.Show("¿Desea registrar la informaión de " + nomzapatos.Text + "?", "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimientodeatallepedido("1");
                    limpiardetallepedido();

                }

            }
        }

      
         public void nike1()
         {

            idproducto.Text = "2Aw234";
            nomzapatos.Text = "Nike monarck";
            valorunid.Text = "200.000";
            

         }

        public void nike2()
        {

            idproducto.Text = "yY3w234";
            nomzapatos.Text = "Nike yellow";
            valorunid.Text = "250.000";
            color.Text = "Amarillo";

        }

        public void nike3()
        {

            idproducto.Text = "25y2Aw234";
            nomzapatos.Text = "Nike luk";
            valorunid.Text = "500.000";
            color.Text = "Blanco";

        }
        public void nike4()
        {
            idproducto.Text = "srclp532";
            nomzapatos.Text = "Nike venom";
            valorunid.Text = "100.000";
         
        }

        public void puma1()
        {
            idproducto.Text = "pepw234";
            nomzapatos.Text = "Puma rock";
            valorunid.Text = "80.000";

        }
        public void puma2()
        {
            idproducto.Text = "Eso134";
            nomzapatos.Text = "Puma stark";
            valorunid.Text = "100.000";

        }

        public void puma3()
        {
            idproducto.Text = "Eso134";
            nomzapatos.Text = "Puma stark";
            valorunid.Text = "100.000";

        }
    }
}
