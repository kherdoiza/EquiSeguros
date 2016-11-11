using EquiSeguros.Models.BussinesEntity;
using EquiSeguros.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class TipoPerManager
    {
        public List<TipoPersonaView> ConsultarTiposPersona()
        {
            using (Entities db = new Entities())
            {
                List<TipoPersonaView> resultado = new List<TipoPersonaView>();
                List<TipoPersona> lista = db.TipoPersona.ToList();

                lista.ForEach(x =>
                {
                    TipoPersonaView tipoPersona = new TipoPersonaView();
                    tipoPersona.Id = x.Id;
                    tipoPersona.Descripcion = x.Descripcion;
                    resultado.Add(tipoPersona);
                });

                return resultado;
            }
        }
    }
}