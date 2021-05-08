using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SegundaEvaluacion.Models
{
    public class Product
    {
        
        public int idProduct { get; set; }
        
        [Display(Name = "Código de Tienda")]
        [Required(ErrorMessage = "Este campo no puede quedar vacio")]
        public int idStore { get; set; }
        

        [Display(Name = "Precio")]

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