//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EquiSeguros.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Provincia
    {
        public int CodProvincia { get; set; }
        public int CodPais { get; set; }
        public string TxtDescripcion { get; set; }
    
        public virtual Pais Pais { get; set; }
    }
}
