using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SegundaEvaluacion.Models;
using SegundaEvaluacion.Services;
using SegundaEvaluacion.Utilities;
using System.Net;

namespace SegundaEvaluacion.Controllers
{
    public class ProductsController : Controller
    {
        public ServiceProduct servicioProduct = new ServiceProduct();

        public ProductsController() { }

        [HttpGet]
        public ActionResult Index()
        {
            var Product = servicioProduct.obtenerTodos();
            return View(Product);
        }


        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var Product = new Product();

            if (id.HasValue)
            {
                Product = servicioProduct.obtenerPorID(id.Value);
            }
            ViewData["Operacion"] = operacion;

            return View(Product);
        }

        ////////
        [HttpPost]
        public ActionResult Form(Product product)
        {
            try
            {
                // Validamos que el modelo carrera sea valido
                // segun las validaciones que le agregamos anteriormente
                if (ModelState.IsValid)
                {
                    //Esta variable nos sirve para sabaer si una carrera ha sido insertada correctamente
                    int id = 0;
                    if (product.idProduct == 0)
                    {
                        id = servicioProduct.insertar(product);
                    }
                    else
                    {
                        id = servicioProduct.modificar(product.idProduct, product);
                    }

                    //Si el id es mayor que 0 la operación es correcta
                    if (id > 0)
                    {
                        //Si la operación fue exitosa entonces devolvemos el codigo 200(success)
                        return new JsonHttpStatusResult(product, HttpStatusCode.OK);
                    }
                    else
                    {
                        //Si la operación no fue exitosa entonces devolvemos un codigo 202(accepted)
                        return new JsonHttpStatusResult(product, HttpStatusCode.Accepted);
                    }
                }
                else
                {
                    //Si hubo error en la validación, entonces devolvemos todos los errores del modelo con un codigo 
                    // 400 (BadRequest)
                    IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(Temp => Temp.Errors);
                    return new JsonHttpStatusResult(allErrors, HttpStatusCode.BadRequest);
                }
                //return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return new JsonHttpStatusResult(product, HttpStatusCode.InternalServerError);
                //throw;
            }
        }

        //
        [HttpPost]
        public JsonResult Delete(int id, string operacion)
        {
            try
            {
                //variable que permite controlar si fue eliminado correctamente
                bool correcto = false;
                //Eliminar una carrera
                correcto = servicioProduct.eliminar(id);

                if (correcto)
                {
                    //Se devuelve el id del elemento eliminado y se retorna un código 200 (success)
                    return new JsonHttpStatusResult(new { id }, HttpStatusCode.OK);
                }
                else
                {
                    //si no se puede eliminar entonces se retorna un código 202 (Acceptes)
                    return new JsonHttpStatusResult(new { id }, HttpStatusCode.Accepted);
                }

                //return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return new JsonHttpStatusResult(new { id }, HttpStatusCode.InternalServerError);
                //throw;
            }
        }




    }
}