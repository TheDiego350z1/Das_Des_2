using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Das_Des_2.Models.PeliculaViewModel
{
    public class PeliculaViewModel
    {
        [Required]
        [Display(Name = "Nombre de Película")]
        public string NameMovie { get; set; }
        [Required]
        [Display(Name = "Descipción de Película")]
        public string DescriptionMovie { get; set; }
        
        [Required]
        [Display(Name = "Director de Película")]
        public string DirectorMovie { get; set; }
        [Required]
        [Display(Name = "Imagen de Película")]
        public HttpPostedFileBase File {get; set; }
        public List<SelectListItem> GenderMovie { get; set; }
    }
}