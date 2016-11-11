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
            List<Pais> paises = new List<Pais>();
            Pais pais = new Pais();

            pais.CodPais = 1;
            pais.TxtDescripcion = "Ecuador";
            paises.Add(pais);
            pais.CodPais = 2;
            pais.TxtDescripcion = "Colombia";
            paises.Add(pais);

            ViewBag.Paises = paises;
            return View();
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