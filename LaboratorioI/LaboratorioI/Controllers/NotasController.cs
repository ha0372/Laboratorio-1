using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaboratorioI.Controllers
{
    public class NotasController : Controller
    {
        // GET: Notas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalculoNotas(string nombre, double lab1, double lab2 , double lab3, double par1, double par2, double par3)
        {
            return View();
        }
    }
}