using EquiSeguros.Models.BussinesEntity;
using EquiSeguros.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class EstadoCivilManager
    {
        public List<EstadoCivilView> ConsultarEstadosCivil()
        {
            using (EquiSegurosEntities db = new EquiSegurosEntities())
            {
                List<EstadoCivilView> resultado = new List<EstadoCivilView>();
                List<EstadoCivil> lista = db.EstadoCivil.ToList();

                lista.ForEach(x =>
                {
                    EstadoCivilView estadoCivil = new EstadoCivilView();
                    estadoCivil.Id = x.Id;
                    estadoCivil.Descripcion = x.Descripcion;
                    resultado.Add(estadoCivil);
                });

                return resultado;
            }
        }
    }
}