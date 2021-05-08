using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SegundaEvaluacion.Models
{
    public class Product
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser menor a 12 caracteres.")]
        public int idProduct { get; set; }
        
        [Display(Name = "Código de Tienda")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser menor a 12 caracteres.")]
        public int idStore { get; set; }
        

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public float price { get; set; }
        

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public String name { get; set; }
        

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public String description { get; set; }
        

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public int stock { get; set; }
        

    }
}