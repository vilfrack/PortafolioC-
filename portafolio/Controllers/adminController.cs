using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using portafolio.Models;

namespace portafolio.Controllers
{
    public class adminController : Controller
    {
        UsuarioDao dao = new UsuarioDao();
        private static string mensaje = "";                    
        // GET: admin
        public ActionResult Index()
        {
            ViewBag.Errores = mensaje;
            return View();
        }
        //public ActionResult backend() {
        //    return View();
        //}
        public ActionResult admin() {
            
         
            if (!string.IsNullOrEmpty((string)Session["login"] as string))
            {
                if (Session["login"].ToString()=="true")
                {
                    return View();
                }
               
            }

            mensaje = "Debe estar logeado";
            return RedirectToAction("Index");
        }
        public ActionResult detailBackend() {

            return PartialView(dao.todoBackend());
        }
        public ActionResult backend()
        {
            return View();
        }
        public ActionResult addBackend() {
            return PartialView();
        }
        [HttpPost]
        public ActionResult addBackend(backendPro backend)
        {
            dao.agregarBackEnd(backend);
            return Redirect("/admin/backend");
        }
        [HttpGet]
        public ActionResult editBackend(int id)
        {
           backend registro = dao.GetBack(id);
           return PartialView(registro);
            
        }
        public ActionResult editBackend()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult editBackend(backendPro backend)
        {
            dao.EditBack(backend);
            return Redirect("/admin/backend");

        }
        [HttpPost]
        public ActionResult Index(loginModel login)
        {
            try
            {
               
                if (!ModelState.IsValid)
                {
                    Session["login"] = "false";
                    ViewBag.Errores = "Login Incorrecto";
                    return View();
                }
                bool loginOK = dao.login(login.usuario, login.password);
                if (loginOK)
                {
                    Session["login"] = "true";
                    return RedirectToAction("admin");
                }
                else
                {
                    ViewBag.Errores = "Login Incorrecto";
                    return View();
                }
            }
            catch (Exception)
            {

                throw;
            }
         
        }
        [HttpPost]
        public ActionResult deleteBackend(string id)
        {
            backendPro backend = new backendPro();
            backend.id = Convert.ToInt32(id);
            dao.deleteBackend(backend.id);
            return RedirectToAction("detailBackend");

        }
        public ActionResult create() {
            return View();
        }
        [HttpPost]
        public ActionResult create(backend registro)
        {
            //dao.agregarBackEnd(registro);
            return RedirectToAction("create");
           
        }
        [HttpPost]
        public ActionResult frontEnd(frontendPro registro) {
            dao.agregarFrontEnd(registro);
            return RedirectToAction("create");
        }
        [HttpPost]
        public ActionResult perfil(perfil registro)
        {
            dao.perfil(registro);
            return RedirectToAction("create");
        }
    }
}