using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portafolio.Models
{
    public class loginModel
    {

        [Required(ErrorMessage = "Debe ingresar un usuario")]
        public string usuario
        {
            get;
            set; }

        [Required(ErrorMessage = "Debe ingresar la clave")]
        public string password {
            get;
            set; }

    }
}