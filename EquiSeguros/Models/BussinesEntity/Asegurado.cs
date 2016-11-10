using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.BussinesEntity
{
    public class Asegurado
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string  ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public int  TipoDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int EstadoCivil { get; set; }
        public int TipoPersona { get; set; }
    }
}