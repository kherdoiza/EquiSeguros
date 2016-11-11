﻿using EquiSeguros.Models.BussinesEntity;
using EquiSeguros.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class PaisManager
    {
        public void InsertarPais(BussinesEntity.Pais pais)
        {
            using (Entities db = new Entities())
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

        public List<BussinesEntity.Pais> ConsultaPais()
        {
            using (Entities db = new Entities())
            {
                List<BussinesEntity.Pais> resultado = new List<BussinesEntity.Pais>();
                List<DB.Pais> lista = db.Pais.ToList();
                lista.ForEach(x =>
                {
                    BussinesEntity.Pais pais = new BussinesEntity.Pais();
                    pais.CodPais = x.CodPais;
                    pais.TxtDescripcion = x.TxtDescripcion;
                    resultado.Add(pais);
                });

                return resultado;
            }
        }

    }
}