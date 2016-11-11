using EquiSeguros.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class TipoDirManager
    {

        public void InsertarTiposDoc(BussinesEntity.TipoDireccionView tipDir)
        {
            using (Entities db = new Entities())
            {
                try
                {
                    DB.TipoDocumento tipoDoc = new DB.TipoDocumento();
                    tipoDoc.Id = tipDir.CodTipoDireccion;
                    tipoDoc.Descripcion = tipDir.TxtDescripcion;
                    db.TipoDocumento.Add(tipoDoc);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    db.GetValidationErrors();
                    Console.Write(e);
                }
            }
        }// fin InsertarTiposDoc

        public List<BussinesEntity.TipoDireccionView> ConsultarTiposDoc()
        {
            /*
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
            // comentado para extraer de la bdd BV
             */

            using (Entities db = new Entities())
            {
                List<BussinesEntity.TipoDireccionView> resultado = new List<BussinesEntity.TipoDireccionView>();
                List<DB.TipoDireccion> lista = db.TipoDireccion.ToList();
                lista.ForEach(x =>
                {
                    BussinesEntity.TipoDireccionView tipoDir = new BussinesEntity.TipoDireccionView();
                    tipoDir.CodTipoDireccion = x.CodTipoDir;
                    tipoDir.TxtDescripcion = x.TxtDescripcion;
                    resultado.Add(tipoDir);
                });

                return resultado;
            }


        }//fin ConsultarTiposDoc

    }
}