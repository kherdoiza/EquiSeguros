using EquiSeguros.Models.BussinesEntity;
using EquiSeguros.Models.EntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquiSeguros.Controllers
{
    public class AseguradoController : Controller
    {
        // GET: Asegurado
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AseguradoForm()
        {
            TipoDocManager tipo = new TipoDocManager();
            ViewBag.tipos = tipo.ConsultarTiposDoc();

            TipoPerManager tippersona = new TipoPerManager();
            ViewBag.tippersonas = tippersona.ConsultarTiposPersona();

            EstadoCivilManager estadocivil = new EstadoCivilManager();
            ViewBag.estados = estadocivil.ConsultarEstadosCivil();

            return View();
        }

        [HttpPost]
        public ViewResult AseguradoForm(Asegurado asegurado)
        {
            if (ModelState.IsValid)
            {
                AseguradoManager manager = new AseguradoManager();
                manager.CrearAsegurado(asegurado);

                return View("DirPrueba");

            }
            else
            {
                return View();
            }
        }


    }
}