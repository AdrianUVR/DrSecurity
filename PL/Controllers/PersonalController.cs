using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal

        public ActionResult GetAll()
        {


            ML.Result result = BL.Personal.GetAll();
            ML.Personal personal = new ML.Personal();



            if (result.Correct)
            {
                personal.Personales = result.Objects;

                return View(personal);

            }
            else
            {
                return View(personal);
            }



        }
        [HttpPost]
        public ActionResult Form(ML.Personal personal)
        {
            ML.Result result = new ML.Result();
            if (personal.IdPersona == 0)
            {
                result = BL.Personal.Add(personal);
                if (result.Correct)
                {
                    ViewBag.Message = "Se agrefo correctamente el personal";
                }
                else
                {
                    ViewBag.Massage = "No se agrego nada";
                }
                return View("Form");
            }
            else
            {
                result = BL.Personal.Update(personal);
                if (result.Correct)
                {
                    ViewBag.Massage = "Se actualizo el registro";
                }
                else
                {

                    ViewBag.Massage = "No se Actualizo el registro";

                }

                return View("Form");
            }

        }

        public static ML.Result Add(ML.Personal Personal)
        {
            ML.Result result = BL.Personal.Add(Personal);
            ML.Personal personal1 = new ML.Personal();
            if (result.Correct)
            {
                Personal.Personales = result.Objects;


            }
            else
            {

            }
            return result;
        }

        public ActionResult Delete(int IdPersonal)
        {
            ML.Result result = BL.Personal.Delete(IdPersonal);
            ML.Personal personal = new ML.Personal();


            if (result.Correct)
            {
                personal.Personales = result.Objects;

                return View("GetAll");

            }
            else
            {
                return View(personal);
            }

        }
    }
}