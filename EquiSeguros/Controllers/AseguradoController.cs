using EquiSeguros.Models.BussinesEntity;
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
            return View();
        }

        
    }
}