using EquiSeguros.Models.BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class TipoDocManager
    {
        public List<TipoDoc> ConsultarTiposDoc()
        {
            //using (CotizadorEntitiesDb db = new CotizadorEntitiesDb())
            //{
            List<TipoDoc> datos = new List<TipoDoc>();
            // List<tmarca> lista = db.tmarca.ToList();
            //lista.ForEach(x =>
            //{
            TipoDoc tipo = new TipoDoc();
            tipo.Id = 1;
            tipo.Descripcion = "Cédula";
            datos.Add(tipo);

            TipoDoc tipo2 = new TipoDoc();
            tipo2.Id = 2;
            tipo2.Descripcion = "Ruc";
            datos.Add(tipo2);

            TipoDoc tipo3 = new TipoDoc();
            tipo3.Id = 3;
            tipo3.Descripcion = "Pasaporte";
            datos.Add(tipo3);

            //});
            return datos;

            //}

        }
    }
}