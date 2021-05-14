using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{

    public class ClaseDatosJuanpablo
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);
        public string D_mantenimiento_pedido(claseEntidadJuanpablo obje)
        {
            string opcion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_pedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdPedido", obje.idpedido);
            cmd.Parameters.AddWithValue("@IdPersona", obje.idpersona);
            cmd.Parameters.AddWithValue("@NumeroDocumentoCliente", obje.documento);
            cmd.Parameters.AddWithValue("@NombreCliente", obje.nombre);
            cmd.Parameters.AddWithValue("@DireccionEntrega", obje.direccion);
            cmd.Parameters.AddWithValue("@telefono", obje.telefono);
            cmd.Parameters.AddWithValue("@Flete", obje.flete);
            cmd.Parameters.AddWithValue("@Referencia", obje.referencia);
            cmd.Parameters.AddWithValue("@TotalValor", obje.total);
            cmd.Parameters.Add("@opcion", SqlDbType.VarChar, 50).Value = obje.opcion;
            cmd.Parameters["@opcion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            opcion = cmd.Parameters["@opcion"].Value.ToString();
            cn.Close();
            return opcion;

        }
       

        public string D_mantenimiento_Detallepedido(claseEntidadJuanpablo obje)
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_Detallespedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdDetallePedido", obje.idpedido);
            cmd.Parameters.AddWithValue("@IdPedido", obje.idpedido2);
            cmd.Parameters.AddWithValue("@IdProducto", obje.idproducto);
            cmd.Parameters.AddWithValue("@MarcaProducto", obje.marca);
            cmd.Parameters.AddWithValue("@Color", obje.color);
            cmd.Parameters.AddWithValue("@Cantidad", obje.color);
            cmd.Parameters.AddWithValue("@Talla", obje.talla);
            cmd.Parameters.AddWithValue("@ValorUnidad", obje.valoreUnidad);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;

        }
    }
}
