using EquiSeguros.Models.BussinesEntity;
using EquiSeguros.Models.EntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EquiSeguros.Controllers
{
    public class DireccionController : Controller
    {
        [HttpGet]
        public ActionResult DireccionForm()
        {
            Asegurado asegurado = new Asegurado();
            asegurado.Id = 1;

            List<PaisView> paises = new List<PaisView>();
            paises = new PaisManager().ConsultaPais();
            /*Pais pais = new Pais();
            pais.CodPais = 1;
            pais.TxtDescripcion = "Ecuador";
            paises.Add(pais);
            Pais pais1 = new Pais();
            pais1.CodPais = 2;
            pais1.TxtDescripcion = "Colombia";
            paises.Add(pais1);*/
            ViewBag.Paises = paises;

            List<ProvinciaView> provincias = new List<ProvinciaView>();
            provincias = new ProvinciaManager().ConsultaProvincia();
            /*Provincia provincia = new Provincia();
            provincia.CodPais = 1;
            provincia.CodProvincia = 1;
            provincia.TxtDescripcion = "Pichincha";
            provincias.Add(provincia);
            Provincia provincia1 = new Provincia();
            provincia1.CodPais = 1;
            provincia1.CodProvincia = 2;
            provincia1.TxtDescripcion = "Guayas";
            provincias.Add(provincia1);*/
            ViewBag.Provincias = provincias;
            

            TipoDirManager a = new TipoDirManager(); 
            List<TipoDireccionView> tiposDireccion = a.ConsultarTiposDoc();
            
            ViewBag.TipoDireccion = tiposDireccion;

            ViewBag.Asegurado = asegurado;
            Direccion dir = new Direccion();
            dir.IdPersona = asegurado.Id;
            return View(dir);
        }

        [HttpPost]
        public ActionResult DireccionForm(Direccion direccion)
        {
            if (ModelState.IsValid)
            {
                DireccionManager manager = new DireccionManager();
                manager.InsertarDireccion(direccion);
                return View(direccion);
            }
            else
            {
                return View();
            }
        }
    }
}