using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.SessionState;
using System.Web;
using System.IO;
using System.Data.Entity;

namespace portafolio.Models
{
    public class UsuarioDao
    {
        private portafolioEntities2 ctx = new portafolioEntities2();
        // Login al sistema.
        public bool login(string login, string password)
        {
            
            login usuario = ctx.login.FirstOrDefault(u => (u.login1 == login) && (u.password == password));
            if (usuario == null)
            {
                closeSession();
                return false;
            }
            initSession(usuario);
            return true;
        }
        public void agregarBackEnd(backendPro pro)
        {
            backend registro = new backend();
            registro.descripcion = pro.descripcion;
            registro.id = pro.id;
            registro.porcentaje = pro.porcentaje;
            ctx.backend.Add(registro);
            ctx.SaveChanges();
            
        }
        public backend GetBack(int id)
        {
            backend registro = ctx.backend.Single(r => r.id == id);
            return registro;
        }
        public frontend GetFront(int id) {
            frontend registro = ctx.frontend.Single(r => r.id == id);
            return registro;
        }
        public void deleteBackend(int id)
        {
            backend registro = ctx.backend.Single(r => r.id == id);
            ctx.backend.Remove(registro);
            ctx.SaveChanges();
        }
        public void deleteFrontend(int id)
        {
            frontend registro = ctx.frontend.Single(r => r.id == id);
            ctx.frontend.Remove(registro);
            ctx.SaveChanges();
        }
        public void EditBack(backendPro back)
        {
            backend registro = ctx.backend.Single(r => r.id == back.id);
            registro.id = back.id;
            registro.descripcion = back.descripcion;
            registro.porcentaje = back.porcentaje;
            ctx.SaveChanges();
        }
        public void EdiFront(frontendPro front) {
            frontend registro = ctx.frontend.Single(r => r.id == front.id);
            registro.id = front.id;
            registro.descripcion = front.descripcion;
            registro.porcentaje = front.porcentaje;
            ctx.SaveChanges();
        }
        public IEnumerable<backend> todoBackend()
        {
            List<backend> lista = ctx.backend.ToList();
            return lista;
        }
        public IEnumerable<frontend> todoFrontend()
        {
            List<frontend> lista = ctx.frontend.ToList();
            return lista;
        }
        public IEnumerable<portafolio> todoProyect()
        {
            List<portafolio> lista = ctx.portafolio.ToList();
            return lista;
        }
        public void agregarFrontEnd(frontendPro front)
        {
            frontend registro = new frontend();
            registro.descripcion = front.descripcion;
            registro.id = front.id;
            registro.porcentaje = front.porcentaje;
            ctx.frontend.Add(registro);
            ctx.SaveChanges();
        }
        public void agregarProyect(proyectPro por) {
            portafolio registro = new portafolio();
            registro.id = por.id;
            registro.descripcion = por.descripcion;
            registro.ruta = por.ruta;
            registro.img = por.img;
            ctx.portafolio.Add(registro);
            ctx.SaveChanges();
        }
        public portafolio GetPor(int id)
        {
            portafolio registro = ctx.portafolio.Single(r => r.id == id);
            return registro;
        }
        public void EdiPro(proyectPro pro)
        {
            portafolio registro = ctx.portafolio.Single(r => r.id == pro.id);
            registro.id = pro.id;
            registro.descripcion = pro.descripcion;
            registro.img = pro.img;
            ctx.SaveChanges();
        }
        public void deleteProyect(int id)
        {
            portafolio registro = ctx.portafolio.Single(r => r.id == id);
            ctx.portafolio.Remove(registro);
            ctx.SaveChanges();
        }
        public void perfil(perfil registro)
        {
            ctx.perfil.Add(registro);
            ctx.SaveChanges();
        }
        // Inicia la session con los datos del usuario logueado.
        public static void initSession(login usuario)
        {
            HttpSessionState session = HttpContext.Current.Session;
            session["usuarios_login"] = usuario.login1;
          
        }
        // Cierra la session, clareando las variables usadas en Session.
        public static void closeSession()
        {
            HttpSessionState session = HttpContext.Current.Session;
            session.Clear();
            session.Abandon();
        }
    }
}