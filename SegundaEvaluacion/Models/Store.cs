using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SegundaEvaluacion.Models
{
    public class Store
    {
        
        public int idStore { get; set; }        

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public String addressStore { get; set; }
        

        [Display(Name = "Tipo de tienda")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public Boolean typeStore { get; set; }
        

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MinLength(length: 5, ErrorMessage = "La longitud del campo no puede ser menor a 5 caracteres.")]
        public String description { get; set; }
       
    }
}