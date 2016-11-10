using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models
{
    public class Direccion
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int TipoDireccion { get; set; }
        public int Provincia { get; set; }
        public int Canton { get; set; }
        public string CallePrincipal { get; set; }
        public string Callesecundaria { get; set; }
        public string Numero { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
    }
}