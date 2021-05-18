using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ClaseEntidad
    {
    }

    public class ClaseEntidadDairo
    {
        public String IdPersona { get; set; }
        public String TipoDocumento { get; set; }
        public Double NumeroDocumento { get; set; }
        public String FechaNacimiento { get; set; }
        public String Nombre { get; set; }
        public String CorreoElectronico { get; set; }
        public String Pais { get; set; }
        public String Ciudad { get; set; }
        public String Departamento{ get; set; }
        public String DireccionResidencia { get; set; }
        public Double Telefono { get; set; }
        public String Cargo { get; set; }
        public String Contrasena { get; set; }
        public String TipoPersona { get; set; }
        public String accion { get; set; }

    }

    public class ClaseEntidadCRUDcliente
    {
        public String IdPersona { get; set; }
        public String TipoDocumento { get; set; }
        public Double NumeroDocumento { get; set; }
        public String FechaNacimiento { get; set; }
        public String Nombre { get; set; }
        public String CorreoElectronico { get; set; }
        public String Pais { get; set; }
        public String Ciudad { get; set; }
        public String Departamento { get; set; }
        public String DireccionResidencia { get; set; }
        public Double Telefono { get; set; }
        public String Cargo { get; set; }
        public String Contrasena { get; set; }
        public String TipoPersona { get; set; }
        public String accion { get; set; }
    }

    public class ClaseEntidadLogin
    {
        public String NDocumento { get; set; }
        public String Contrasena { get; set; }
    }

}
