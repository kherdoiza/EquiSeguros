using EquiSeguros.Models.BussinesEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class EstadoCivilManager
    {
        public List<EstadoCivil> ConsultarEstadosCivil()
        {
            //using (CotizadorEntitiesDb db = new CotizadorEntitiesDb())
            //{
            List<EstadoCivil> datos = new List<EstadoCivil>();
            // List<tmarca> lista = db.tmarca.ToList();
            //lista.ForEach(x =>
            //{
            EstadoCivil tipo = new EstadoCivil();
            tipo.Id = 1;
            tipo.Descripcion = "Soltero";
            datos.Add(tipo);

            EstadoCivil tipo2 = new EstadoCivil();
            tipo2.Id = 2;
            tipo2.Descripcion = "Casado";
            datos.Add(tipo2);

            EstadoCivil tipo3 = new EstadoCivil();
            tipo3.Id = 3;
            tipo3.Descripcion = "Divorciado";
            datos.Add(tipo3);

            //});
            return datos;

            //}

        }
    }
}