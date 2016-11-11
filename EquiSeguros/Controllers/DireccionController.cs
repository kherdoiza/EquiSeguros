using EquiSeguros.Models.BussinesEntity;
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

            List<Pais> paises = new List<Pais>();
            Pais pais = new Pais();
            pais.CodPais = 1;
            pais.TxtDescripcion = "Ecuador";
            paises.Add(pais);
            Pais pais1 = new Pais();
            pais1.CodPais = 2;
            pais1.TxtDescripcion = "Colombia";
            paises.Add(pais1);
            ViewBag.Paises = paises;

            List<Provincia> provincias = new List<Provincia>();
            Provincia provincia = new Provincia();
            provincia.CodPais = 1;
            provincia.CodProvincia = 1;
            provincia.TxtDescripcion = "Pichincha";
            provincias.Add(provincia);
            Provincia provincia1 = new Provincia();
            provincia1.CodPais = 1;
            provincia1.CodProvincia = 2;
            provincia1.TxtDescripcion = "Guayas";
            provincias.Add(provincia1);
            ViewBag.Provincias = provincias;

            List<TipoDireccion> tiposDireccion = new List<TipoDireccion>();
            TipoDireccion tipoDireccion = new TipoDireccion();
            tipoDireccion.CodTipoDireccion = 1;
            tipoDireccion.TxtDescripcion = "Domicilio";
            tiposDireccion.Add(tipoDireccion);
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
                //MarcaManager manager = new MarcaManager();
                //manager.CrarMarca(marca);
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}