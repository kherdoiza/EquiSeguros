using EquiSeguros.Models.BussinesEntity;
using EquiSeguros.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquiSeguros.Models.EntityManager
{
    public class AseguradoManager
    {
        public void CrearAsegurado(Asegurado asegurado)
        {
            using (EquiSegurosEntities db = new EquiSegurosEntities())
            {
                DB.Persona persona = new DB.Persona();
                persona.Nombre = asegurado.Nombres;
                persona.ApellidoPaterno = asegurado.ApellidoPaterno;
                persona.ApellidoMaterno = asegurado.ApellidoMaterno;
                persona.Documento = asegurado.Documento;
                persona.TipoDocumento = asegurado.TipoDocumento;
                persona.FechaNacimiento = asegurado.FechaNacimiento;
                persona.TipoPersona = asegurado.TipoPersona;
                persona.EstadoCivil = asegurado.EstadoCivil;
                db.Persona.Add(persona);
                db.SaveChanges();
            }
        }

        public List<Asegurado> ConsultaAsegurado()
        {
            using (EquiSegurosEntities db = new EquiSegurosEntities())
            {
                List<Asegurado> resultado = new List<Asegurado>();
                List<DB.Persona> listaPersona = db.Persona.ToList();
                listaPersona.ForEach(x =>
                {
                    Asegurado asegurado = new Asegurado();
                    asegurado.Id = x.Id;
                    asegurado.Nombres = x.Nombre;
                    asegurado.ApellidoPaterno = x.ApellidoPaterno;
                    asegurado.ApellidoMaterno = x.ApellidoMaterno;
                    asegurado.Documento = x.Documento;
                    asegurado.FechaNacimiento = x.FechaNacimiento;
                    asegurado.TipoDocumento = x.TipoDocumento;
                    asegurado.TipoPersona = x.TipoPersona;
                    asegurado.EstadoCivil = x.EstadoCivil;
                    resultado.Add(asegurado);
                });
                return resultado;
            }
        }

    }

}