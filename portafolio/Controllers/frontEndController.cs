using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using portafolio.Models;
namespace portafolio.Controllers
{
    public class frontEndController : Controller
    {
        UsuarioDao dao = new UsuarioDao();
        // GET: frontEnd
        public ActionResult Index()
        {
            if (!string.IsNullOrEmpty((string)Session["login"] as string))
            {
                if (Session["login"].ToString() == "true")
                {
                    return View();
                }

            }

          
            return RedirectToAction("../admin/Index");
        }
        public ActionResult detailFrontend()
        {
            return PartialView(dao.todoFrontend());
        }
        public ActionResult addFrontend()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult editFrontend(int id)
        {
            frontend registro = dao.GetFront(id);
            return PartialView(registro);
           
        }
        [HttpPost]
        public ActionResult editFrontend(frontendPro registro) {
            dao.EdiFront(registro);
            return Redirect("/frontEnd/Index");
        }
        [HttpPost]
        public ActionResult addFrontend(frontendPro fronend)
        {
            dao.agregarFrontEnd(fronend);
            return Redirect("/frontEnd/Index");
            //return View("Index");
        }
        [HttpPost]
        public ActionResult deleteFrontend(string id)
        {
            frontendPro fronend = new frontendPro();
            fronend.id = Convert.ToInt32(id);
            dao.deleteFrontend(fronend.id);
            return RedirectToAction("Index");

        }
    }
}