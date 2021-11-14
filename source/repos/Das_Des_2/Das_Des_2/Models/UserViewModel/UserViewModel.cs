using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Das_Des_2.Models.UserViewModel
{
    public class UserViewModel
    {
        [Required]
        [Display(Name = "Nombre de Usuario")]
        public string NameUser { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name ="Correo Eléctronico")]
        public string MailUser { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string PasswordUser { get; set; }
        [Display(Name = "Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [Compare("PasswordUser", ErrorMessage ="Las contraseñas no son iguales")]
        public string ConfirmPasswordUser { get; set; }
    }

    public class EditUserViewModel
    {
        public int idUser { get; set; }
        [Display(Name = "Nombre de Usuario")]
        public string NameUser { get; set; }
        [EmailAddress]
        [Display(Name = "Correo Eléctronico")]
        public string MailUser { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string PasswordUser { get; set; }
        [Display(Name = "Confirmar Contraseña")]
        [DataType(DataType.Password)]
        [Compare("PasswordUser", ErrorMessage = "Las contraseñas no son iguales")]
        public string ConfirmPasswordUser { get; set; }
    }
}