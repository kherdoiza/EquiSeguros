using EquiSeguros.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class ProvinciaManager
    {
        public void InsertarProvincia(BussinesEntity.ProvinciaView provincia)
        {
            using (EquiSegurosEntities db = new EquiSegurosEntities())
            {
                try
                {
                    DB.Provincia insertProvincia = new DB.Provincia();
                    insertProvincia.CodPais = provincia.CodPais;
                    insertProvincia.CodProvincia = provincia.CodProvincia;
                    insertProvincia.TxtDescripcion = provincia.TxtDescripcion;
                    db.Provincia.Add(insertProvincia);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    db.GetValidationErrors();
                    Console.Write(e);
                }
            }
        }// fin InsertarProvincia

        public List<BussinesEntity.ProvinciaView> ConsultaProvincia()
        {
            using (EquiSegurosEntities db = new EquiSegurosEntities())
            {
                List<BussinesEntity.ProvinciaView> resultado = new List<BussinesEntity.ProvinciaView>();
                List<DB.Provincia> lista = db.Provincia.ToList();
                lista.ForEach(x =>
                {
                    BussinesEntity.ProvinciaView provincia = new BussinesEntity.ProvinciaView();
                    provincia.CodPais = x.CodPais;
                    provincia.TxtDescripcion = x.TxtDescripcion;
                    resultado.Add(provincia);
                });

                return resultado;
            }
        }

    }
}