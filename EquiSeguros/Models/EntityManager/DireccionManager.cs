using EquiSeguros.Models.BussinesEntity;
using EquiSeguros.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class DireccionManager
    {

        public void InsertarDireccion(Direccion direccion)
        {
            using (Entities db = new Entities())
            {
                try
                {
                    DB.PersonaDir personaDir = new DB.PersonaDir();
                    personaDir.IdPersona = direccion.IdPersona;
                    personaDir.CodTipoDir = direccion.TipoDireccion;
                    personaDir.CodPais = direccion.Pais;
                    personaDir.CodProvincia = direccion.Provincia;
                    personaDir.TxtCallePrin = direccion.CallePrincipal;
                    personaDir.TxtCalleSec = direccion.Callesecundaria;
                    personaDir.TxtLugrReferencia = direccion.Referencia;
                    personaDir.Longitud = direccion.Longitud;
                    personaDir.Latitud = direccion.Latitud;
                    db.PersonaDir.Add(personaDir);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    db.GetValidationErrors();
                    Console.Write(e);
                }
            }
        }// fin InsertarDireccion
    }
}