using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SegundaEvaluacion.Models
{
    public class Customer
    {
        [Display(Name = "Código Cliente")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser menor a 12 caracteres.")]
        public int idCustomer { get; set; }        

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser menor a 12 caracteres.")]
        public String nameCustomer { get; set; }
        

        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser menor a 12 caracteres.")]
        public String lastNameCustomer { get; set; }
        

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser menor a 12 caracteres.")]
        public String emailCustomer { get; set; }
        

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public String passwordCustomer { get; set; }
        

        [Display(Name = "Télefono")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public String phoneNumber { get; set; }
        
    }
}