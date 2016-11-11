using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.BussinesEntity
{
    public class PersonaDir
    {
        public int IdPersona { get; set; }
        public int CodTipoDir { get; set; }
        public int CodPais { get; set; }
        public int CodProvincia { get; set; }
        public string TxtCallePrin { get; set; }
        public string TxtCalleSec { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        public string TxtLugrReferencia { get; set; }

    }
}