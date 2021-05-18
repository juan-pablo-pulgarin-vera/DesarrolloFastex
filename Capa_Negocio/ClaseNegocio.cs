using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Entidad;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class ClaseNegocioDairo
    {
        ClaseDatosDairo objd = new ClaseDatosDairo();

        public String N_Registrar(ClaseEntidadDairo obje)
        {
            return objd.D_Registro(obje);
        }
    }

    public class ClassNegocioCRUDCliente
    {
        ClaseDatosCRUDCliente objd = new ClaseDatosCRUDCliente();

        public DataTable N_listar_clientesCRUD()
        {
            return objd.D_listar_clientesCRUD();
        }

        public DataTable N_buscar_clientesCRUD(ClaseEntidadCRUDcliente obje)
        {
            return objd.D_buscar_clientesCRUD(obje);
        }

        public String N_mantenimiento_clientesCRUD(ClaseEntidadCRUDcliente obje)
        {
            return objd.D_mantenimiento_clientesCRUD(obje);
        }


    }

    public class ClaseNegocioLogin
    {
        ClaseDatosLogin objd = new ClaseDatosLogin();

        public DataTable N_user(ClaseEntidadLogin obje)
        {
            return objd.D_user(obje);
        }


    }
}
