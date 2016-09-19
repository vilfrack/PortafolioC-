using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.WebPages.Html;

namespace portafolio.Models
{
    public partial class backendPro
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int porcentaje { get; set; }
       
    }
    public class backendGrid
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }
    public class backendGridPro
    {
        public backendPro backendPro { get; set; }
        public IList<backendGrid>backendGrid { get; set; }
    }
}