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
            listar.DataSource = segundo.N_listar_pedidos();
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
            listar.DataSource = segundo.N_listar_pedidos();
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
            objeto1.vendedor = vende.Text;
            objeto1.total = double.Parse(valortotal.Text);
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

        private void registrar2_Click(object sender, EventArgs e)
        {   

            if (iddetalle.Text == "" || idpedido.Text == "")
            {
                if (MessageBox.Show("¿Desea registrar la informaión de " + nomzapatos.Text + "?", "mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimientodeatallepedido("1");
                    mantenimientopedido("1");
                    limpiardetallepedido();
                    
                    limpiarpedido();
                }

            }

          
        }

      
         public void nike1()
         {
         
            idproducto.Text = "2Aw234";
            referencia.Text = "2Aw234";
            nomzapatos.Text = "Nike monarck";
            valorunid.Text = "200.000";
 

         }

        public void nike2()
        {

            idproducto.Text = "yY3w234";
            referencia.Text = "yY3w234";
            nomzapatos.Text = "Nike yellow";
            valorunid.Text = "250.000";
            color.Text = "Amarillo";
            this.color.Enabled = false;

        }

        public void nike3()
        {

            idproducto.Text = "25y2Aw234";
            referencia.Text = "25y2Aw234";
            nomzapatos.Text = "Nike luk";
            valorunid.Text = "500.000";
            color.Text = "Blanco";
            this.color.Enabled = false;

        }
        public void nike4()
        {
            idproducto.Text = "srclp532";
            referencia.Text = "srclp532";
            nomzapatos.Text = "Nike venom";
            valorunid.Text = "100.000";
         
        }

        public void puma1()
        {
            idproducto.Text = "pepw234";
            referencia.Text = "pepw234";
            nomzapatos.Text = "Puma rock";
            valorunid.Text = "80.000";

        }
        public void puma2()
        {
            idproducto.Text = "Eso134";
            referencia.Text = "Eso134";
            nomzapatos.Text = "Puma stark";
            valorunid.Text = "100.000";

        }

        public void puma3()
        {
            idproducto.Text = "750wrq";
            referencia.Text = "750wrq";
            nomzapatos.Text = "Puma pup";
            valorunid.Text = "1.000.000";

        }

        public void puma4()
        {
            idproducto.Text = "5865n";
            referencia.Text = "5865n";
            nomzapatos.Text = "Puma vark";
            valorunid.Text = "280.000";

        }
        public void adidas1()
        {
            idproducto.Text = "hyQ41";
            referencia.Text = "hyQ41";
            nomzapatos.Text = "Adidas mark";
            valorunid.Text = "420.000";

        }
        public void adidas2()
        {
            idproducto.Text = "759uw";
            referencia.Text = "759uw";
            nomzapatos.Text = "Adidas rocks";
            valorunid.Text = "150.000";

        }
        public void adidas3()
        {
            idproducto.Text = "2Aw234";
            referencia.Text = "2Aw234";
            nomzapatos.Text = "Adidas blue";
            valorunid.Text = "90.000";

        }
        public void adidas4()
        {
            idproducto.Text = "xxa231";
            referencia.Text = "xxa231";
            nomzapatos.Text = "Adidas blacs";
            valorunid.Text = "180.000";

        }

        private void busca_TextChanged(object sender, EventArgs e)
        {
            if (nombrepersona.Text !="") {
                objeto.nombre = busca.Text;
                DataTable dt = new DataTable();
                dt = segundo.N_buscar_pedidos(objeto);
                listar.DataSource = dt;
            }
            else { listar.DataSource = segundo.N_listar_pedidos(); }
        }

        private void listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { int fila = listar.CurrentCell.RowIndex;
            
            idpersona.Text= listar[0, fila].Value.ToString();
            numerodocumento.Text = listar[1, fila].Value.ToString();
            nombrepersona.Text = listar[2, fila].Value.ToString();
            direccion.Text = listar[3, fila].Value.ToString();
            telefono.Text = listar[4, fila].Value.ToString();
           
        }

        private void calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process calc = new System.Diagnostics.Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();


            calc.WaitForExit();
        }

     
    }
}
