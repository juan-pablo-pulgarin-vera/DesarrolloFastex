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

