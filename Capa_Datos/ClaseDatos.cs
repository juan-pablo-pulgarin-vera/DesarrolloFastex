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
    public class ClaseDatos
    {
    }

    public class YesicaD
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);

        public DataTable D_Listar_Productos()
        {
            SqlCommand cmd = new SqlCommand("sp_listarproductos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Buscar_Productos(YesicaE obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscarproductos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String D_Mantenimiento_Productos(YesicaE obje)
        {
            string movimiento = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimientoproductos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Idproducto", obje.identificador);
            cmd.Parameters.AddWithValue("@Marcaproducto", obje.marca);
            cmd.Parameters.AddWithValue("@Nombreproducto", obje.nombre);
            cmd.Parameters.AddWithValue("@Talla", obje.talla);
            cmd.Parameters.AddWithValue("@Color", obje.color);
            cmd.Parameters.AddWithValue("@Preciounidad", obje.preciounidad);
            cmd.Parameters.Add("@movimiento", SqlDbType.VarChar, 50).Value = obje.movimiento;
            cmd.Parameters["@movimiento"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            movimiento = cmd.Parameters["@movimiento"].Value.ToString();
            cn.Close();
            return movimiento;
        }
    }
}
