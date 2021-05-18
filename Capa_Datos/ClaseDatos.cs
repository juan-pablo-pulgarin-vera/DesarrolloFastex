using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
using System.Configuration;
using System.Data;

using Capa_Entidad;


namespace Capa_Datos
{
    public class ClaseDatosDairo
    {
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public String D_Registro(ClaseEntidadDairo obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_registro", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdPersona", obje.IdPersona);
            cmd.Parameters.AddWithValue("@TipoDocumento", obje.TipoDocumento);
            cmd.Parameters.AddWithValue("@NumeroDocumento ", obje.NumeroDocumento);
            cmd.Parameters.AddWithValue("@FechaNacimiento", obje.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre);
            cmd.Parameters.AddWithValue("@CorreoElectronico", obje.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Pais", obje.Pais);
            cmd.Parameters.AddWithValue("@Departamento", obje.Departamento);
            cmd.Parameters.AddWithValue("@Ciudad ", obje.Ciudad);
            cmd.Parameters.AddWithValue("@DireccionResidencia", obje.DireccionResidencia);
            cmd.Parameters.AddWithValue("@Telefono ", obje.Telefono);
            cmd.Parameters.AddWithValue("@Cargo", obje.Cargo);
            cmd.Parameters.AddWithValue("@Contrasena", obje.Contrasena);
            cmd.Parameters.AddWithValue("@TipoPersona", obje.TipoPersona);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cnn.State == ConnectionState.Open) cnn.Close();
            cnn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cnn.Close();
            return accion;
        }

    }

    public class ClaseDatosCRUDCliente
    {
        
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_clientesCRUD()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_clientes", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_clientesCRUD(ClaseEntidadCRUDcliente obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String D_mantenimiento_clientesCRUD(ClaseEntidadCRUDcliente obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdPersona", obje.IdPersona);
            cmd.Parameters.AddWithValue("@TipoDocumento", obje.TipoDocumento);
            cmd.Parameters.AddWithValue("@NumeroDocumento ", obje.NumeroDocumento);
            cmd.Parameters.AddWithValue("@FechaNacimiento", obje.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre);
            cmd.Parameters.AddWithValue("@CorreoElectronico", obje.CorreoElectronico);
            cmd.Parameters.AddWithValue("@Pais", obje.Pais);
            cmd.Parameters.AddWithValue("@Departamento", obje.Departamento);
            cmd.Parameters.AddWithValue("@Ciudad ", obje.Ciudad);
            cmd.Parameters.AddWithValue("@DireccionResidencia", obje.DireccionResidencia);
            cmd.Parameters.AddWithValue("@Telefono ", obje.Telefono);
            cmd.Parameters.AddWithValue("@Cargo", obje.Cargo);
            cmd.Parameters.AddWithValue("@Contrasena", obje.Contrasena);
            cmd.Parameters.AddWithValue("@TipoPersona", obje.TipoPersona);

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{

    public class ClaseDatosJuanpablo
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);

        public DataTable d_listar_pedido() 
        {
            SqlCommand cmd = new SqlCommand("sp_listar_pedido", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        
        }


        
        public DataTable d_buscar_pedido(claseEntidadJuanpablo obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_pedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre",obje.nombre); 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        
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
            cmd.Parameters.AddWithValue("@IdDetallePedido", obje.iddetalle);
            cmd.Parameters.AddWithValue("@IdPedido", obje.idpedido2);
            cmd.Parameters.AddWithValue("@IdProducto", obje.idproducto);
            cmd.Parameters.AddWithValue("@MarcaProducto", obje.marca);
            cmd.Parameters.AddWithValue("@Color", obje.color);
            cmd.Parameters.AddWithValue("@Cantidad", obje.catidad);
            cmd.Parameters.AddWithValue("@Talla", obje.talla);
            cmd.Parameters.AddWithValue("@ValorUnidad", obje.valoreUnidad);
            cmd.Parameters.AddWithValue("@vendedor", obje.vendedor);
            cmd.Parameters.AddWithValue("@total", obje.total);
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
    
    public class ClaseDatosLogin
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_user(ClaseEntidadLogin obje)
        {
            SqlCommand cmd = new SqlCommand("sp_login", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.NDocumento);
            cmd.Parameters.AddWithValue("@contrasena", obje.Contrasena);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

