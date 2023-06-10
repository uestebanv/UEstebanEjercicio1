using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class EjerciciosController : Controller
    {
        // GET: Ejercicios
        public ActionResult Index()
        {
            BL.Opcion result = BL.Opcion.GetAll();
            BL.Opcion opcion = new BL.Opcion();
            if (result.Correct)
            {
                opcion.Opciones = result.Opciones;
                return View(opcion);
            }
            else
            {
                return View(opcion);
            }
        }


        //[HttpPost]
        //public ActionResult Index(int option)
        //{
        //    BL.Opcion result = BL.Opcion.GetAll();
        //    BL.Opcion opcion = new BL.Opcion();
        //    opcion.Opciones = result.Opciones;
        //    return View(opcion);

        //    if (option == 1)
        //    {

        //    }
        //    else if (option == 1)
        //    {


        //    }
        //    else if (option == 2)
        //    {

        //    }
        //    return View();
        //}
    }
}