//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EquiSeguros.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonaDir
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
    
        public virtual Persona Persona { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual TipoDireccion TipoDireccion { get; set; }
    }
}