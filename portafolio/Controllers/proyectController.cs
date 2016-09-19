using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using portafolio.Models;
using System.IO;
namespace portafolio.Controllers
{
    public class proyectController : Controller
    {
        UsuarioDao dao = new UsuarioDao();
        public static string mensaje;
        public static string val;
        private portafolioEntities2 ctx = new portafolioEntities2();
        // GET: proyect
        public ActionResult Index()
        {
            if (!string.IsNullOrEmpty((string)Session["login"] as string))
            {
                ViewBag.Message = mensaje;
                ViewBag.val = val;
                return View();
            }
            else
            {
                return RedirectToAction("../admin/Index");
            }
        }
        public ActionResult detail() {
            return PartialView(dao.todoProyect());
        }
        public ActionResult add()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult add(HttpPostedFileBase file,proyectPro pro)
        {

            string extencion = Path.GetExtension(file.FileName);
            
            if (extencion == ".png" || extencion == ".jpeg" || extencion == ".jpg" || extencion == "")
            {
                pro.img = file.FileName.Trim();
                dao.agregarProyect(pro);
                var fileName = Path.GetFileName(file.FileName.Trim());
                var path = Path.Combine(Server.MapPath("~/img-pro/"), fileName);
                if (extencion !="")
                {
                    file.SaveAs(path);
                }
                mensaje = "Registro guardado";
                val = "1";
            }
            else
            {
                mensaje = "El formato para la imagen es de tipo: jpg,jpeg o png";
                val = "0";
            }

            return Redirect("/proyect/Index");
        }

        [HttpGet]
        public ActionResult editProyect(int id) {
            portafolio.Models.portafolio registro = dao.GetPor(id);
            return PartialView(registro);
        }
        [HttpPost]
        public ActionResult editProyect(HttpPostedFileBase file, proyectPro registro)
        {
            string extencion = "";
            if (file !=null)
            {
               extencion = Path.GetExtension(file.FileName);
         
                if (extencion == ".png" || extencion == ".jpeg" || extencion == ".jpg" || extencion == "")
                {
                    registro.img = file.FileName.Trim();
                    dao.EdiPro(registro);
                    var fileName = Path.GetFileName(file.FileName.Trim());
                    var path = Path.Combine(Server.MapPath("~/img-pro/"), fileName);
                    if (extencion != "")
                    {
                        file.SaveAs(path);
                    }
                    mensaje = "Registro modificado";
                    val = "1";
                }
                else
                {
                    mensaje = "El formato para la imagen es de tipo: jpg,jpeg o png";
                    val = "0";
                }
            }
            else
            {
                dao.EdiPro(registro);
                mensaje = "Registro guardado";
                val = "1";
            }

            return Redirect("/proyect/Index");
        }
        [HttpPost]
        public ActionResult delete(string id)
        {
            proyectPro proyect = new proyectPro();
            proyect.id = Convert.ToInt32(id);
            dao.deleteProyect(proyect.id);
            return RedirectToAction("Index");

        }
    }
}