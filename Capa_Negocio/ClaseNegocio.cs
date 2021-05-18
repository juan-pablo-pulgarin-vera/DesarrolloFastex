using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class ClaseNegocio
    {
    }

    public class YesicaN
    {
        YesicaD objd = new YesicaD();

        public DataTable N_Listar_Productos()
        {
            return objd.D_Listar_Productos();
        }

        public DataTable  N_Buscar_Productos(YesicaE obje)
        {
            return objd.D_Buscar_Productos(obje);
        }

        public string N_Mantenimiento_Productos(YesicaE obje)
        {
            return objd.D_Mantenimiento_Productos(obje);
        }

    }
}
