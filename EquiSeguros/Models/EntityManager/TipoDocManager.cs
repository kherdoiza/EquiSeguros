using EquiSeguros.Models.BussinesEntity;
using EquiSeguros.Models.DB;
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
            using (EquiSegurosEntities db = new EquiSegurosEntities())
            {
                List<TipoDoc> resultado = new List<TipoDoc>();
                List<TipoDocumento> lista = db.TipoDocumento.ToList();

                lista.ForEach(x =>
                {
                    TipoDoc tipoDocumento = new TipoDoc();
                    tipoDocumento.Id = x.Id;
                    tipoDocumento.Descripcion = x.Descripcion;
                    resultado.Add(tipoDocumento);
                });

                return resultado;
            }
        }
    }
}