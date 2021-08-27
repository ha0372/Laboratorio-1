using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaboratorioI.Models;

namespace LaboratorioI.Controllers
{
    public class NotasController : Controller
    {
        // GET: Notas
        public ActionResult Index()
        {
            return View();
        }

        const double l = 0.4;
        const double p = 0.6;

        public ActionResult Resultado(string nombre, double lab1, double lab2, double lab3, double par1, double par2, double par3)
        {
            using (EstudianteEntities estudiante = new EstudianteEntities())
            {
                TblNotasEstudiante stud = new TblNotasEstudiante();

                stud.Nombre = nombre;
                stud.lab1 = (decimal?)lab1;
                stud.lab2 = (decimal?)lab2;
                stud.lab3 = (decimal?)lab3;
                stud.par1 = (decimal?)par1;
                stud.par2 = (decimal?)par2;
                stud.par3 = (decimal?)par3;
                estudiante.TblNotasEstudiante.Add(stud);
                estudiante.SaveChanges();
            }

            
            ViewBag.total1 = (lab1 *l )+(par1*p);
            ViewBag.total2 = (lab2 * l) + (par2 * p);
            ViewBag.total3 = (lab3 * l) + (par3 * p);

            ViewBag.nombre = nombre;
            ViewBag.lab1 = lab1;
            ViewBag.lab2 = lab2;
            ViewBag.lab3 = lab3;
            ViewBag.par1 = par1;
            ViewBag.par2 = par2;
            ViewBag.par3 = par3;

            return View();
        }

        public ActionResult ResultadoEstudiantes()
        {
            using (EstudianteEntities estudiante = new EstudianteEntities())
            {
                var listEstudiantes = estudiante.TblNotasEstudiante.ToList();

                return View(listEstudiantes);
            }


        }

        /*public ActionResult CalculoNotas(string nombre, decimal lab1, decimal lab2, decimal lab3, decimal par1, decimal par2, decimal par3)
        {

            using (EstudianteEntities estudiante = new EstudianteEntities())
            {
                TblNotasEstudiante stud = new TblNotasEstudiante();

                stud.Nombre = nombre;
                stud.lab1 = lab1;
                stud.lab2 = lab2;
                stud.lab3 = lab3;
                stud.par1 = par1;
                stud.par2 = par2;
                stud.par3 = par3;
                estudiante.TblNotasEstudiante.Add(stud);
                estudiante.SaveChanges();
            }



            ViewBag.nombre = nombre;
            ViewBag.lab1 = lab1;
            ViewBag.lab2 = lab2;
            ViewBag.lab3 = lab3;
            ViewBag.par1 = par1;
            ViewBag.par2 = par2;
            ViewBag.par3 = par3;




            return Redirect("/Notas/Resultado");
        }*/


    }
}