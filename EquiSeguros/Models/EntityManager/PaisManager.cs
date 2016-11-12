using EquiSeguros.Models.BussinesEntity;
using EquiSeguros.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class PaisManager
    {
        public void InsertarPais(BussinesEntity.PaisView pais)
        {
            using (EquiSegurosEntities db = new EquiSegurosEntities())
            {
                try
                {
                    DB.Pais insertPais = new DB.Pais();
                    insertPais.CodPais = pais.CodPais;
                    insertPais.TxtDescripcion = pais.TxtDescripcion;
                    db.Pais.Add(insertPais);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    db.GetValidationErrors();
                    Console.Write(e);
                }
            }
        }// fin InsertarPais

        public List<BussinesEntity.PaisView> ConsultaPais()
        {
            using (EquiSegurosEntities db = new EquiSegurosEntities())
            {
                List<BussinesEntity.PaisView> resultado = new List<BussinesEntity.PaisView>();
                List<DB.Pais> lista = db.Pais.ToList();
                lista.ForEach(x =>
                {
                    BussinesEntity.PaisView pais = new BussinesEntity.PaisView();
                    pais.CodPais = x.CodPais;
                    pais.TxtDescripcion = x.TxtDescripcion;
                    resultado.Add(pais);
                });

                return resultado;
            }
        }

    }
}