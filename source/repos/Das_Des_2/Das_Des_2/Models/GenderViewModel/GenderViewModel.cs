using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Das_Des_2.Models.GenderViewModel
{
    public class GenderViewModel
    {
        [Required]
        [Display(Name ="Genero")]
        public string nameGender { get; set; }
    }
}