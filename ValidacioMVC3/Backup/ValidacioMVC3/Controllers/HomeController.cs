using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidacioMVC3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var termek = new Adat.Termek();

            termek.Id = 1;
            termek.Kod = "HV-789-7b";
            termek.Listaar = 458.5M;
            termek.MaximumRendelheto = 8;
            termek.MinimumRendelheto = 2;
            termek.Megnevezes = "Szánkó";

            return View(termek);
        }

        
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Adat.Termek termek)
        {
            return View(termek);
        }


    }
}
