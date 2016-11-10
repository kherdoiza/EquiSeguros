using EquiSeguros.Models.BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class TipoPerManager
    {
        public List<TipoPersona> ConsultarTiposPersona()
        {
            //using (CotizadorEntitiesDb db = new CotizadorEntitiesDb())
            //{
            List<TipoPersona> datos = new List<TipoPersona>();
            // List<tmarca> lista = db.tmarca.ToList();
            //lista.ForEach(x =>
            //{
            TipoPersona tipo = new TipoPersona();
            tipo.Id = 1;
            tipo.Descripcion = "Natural";
            datos.Add(tipo);

            TipoPersona tipo2 = new TipoPersona();
            tipo2.Id = 2;
            tipo2.Descripcion = "Jurídica";
            datos.Add(tipo2);

            //});
            return datos;

            //}

        }
    }
}