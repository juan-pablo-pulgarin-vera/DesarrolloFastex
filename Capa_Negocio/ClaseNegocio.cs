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


    public class ClaseNegocioJuanpablo
    {
        ClaseDatosJuanpablo objd = new ClaseDatosJuanpablo();
        public string N_mantenimiento_pedido(claseEntidadJuanpablo obje)
        {
            return objd.D_mantenimiento_pedido(obje);
        }

        public string N_mantenimiento_Detallepeido(claseEntidadJuanpablo obje)
        {
            return objd.D_mantenimiento_Detallepedido(obje);
        }
    
    }
}
