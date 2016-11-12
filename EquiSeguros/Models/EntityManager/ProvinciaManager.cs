using EquiSeguros.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class ProvinciaManager
    {
        public void InsertarProvincia(BussinesEntity.Provincia provincia)
        {
            using (Entities db = new Entities())
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

        public List<BussinesEntity.Provincia> ConsultaProvincia()
        {
            using (Entities db = new Entities())
            {
                List<BussinesEntity.Provincia> resultado = new List<BussinesEntity.Provincia>();
                List<DB.Provincia> lista = db.Provincia.ToList();
                lista.ForEach(x =>
                {
                    BussinesEntity.Provincia provincia = new BussinesEntity.Provincia();
                    provincia.CodPais = x.CodPais;
                    provincia.TxtDescripcion = x.TxtDescripcion;
                    resultado.Add(provincia);
                });

                return resultado;
            }
        }

    }
}