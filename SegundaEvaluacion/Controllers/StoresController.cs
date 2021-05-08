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
    public class StoresController : Controller
    {
        public ServiceStore servicioStore = new ServiceStore();

        public StoresController() { }

        [HttpGet]
        public ActionResult Index()
        {
            var store = servicioStore.obtenerTodos();
            return View(store);
        }

        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var store = new Store();

            if (id.HasValue)
            {
                store = servicioStore.obtenerPorID(id.Value);
            }
            ViewData["Operacion"] = operacion;

            return View(store);
        }

        //
        [HttpPost]
        public ActionResult Form(Store store)
        {
            try
            {
                // Validamos que el modelo carrera sea valido
                // segun las validaciones que le agregamos anteriormente
                if (ModelState.IsValid)
                {
                    //Esta variable nos sirve para sabaer si una carrera ha sido insertada correctamente
                    int id = 0;
                    if (store.idStore == 0)
                    {
                        id = servicioStore.insertar(store);
                    }
                    else
                    {
                        id = servicioStore.modificar(store.idStore, store);
                    }

                    //Si el id es mayor que 0 la operación es correcta
                    if (id > 0)
                    {
                        //Si la operación fue exitosa entonces devolvemos el codigo 200(success)
                        return new JsonHttpStatusResult(store, HttpStatusCode.OK);
                    }
                    else
                    {
                        //Si la operación no fue exitosa entonces devolvemos un codigo 202(accepted)
                        return new JsonHttpStatusResult(store, HttpStatusCode.Accepted);
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
                return new JsonHttpStatusResult(store, HttpStatusCode.InternalServerError);
                //throw;
            }
        }

        ///

        [HttpPost]
        public JsonResult Delete(int id, string operacion)
        {
            try
            {
                //variable que permite controlar si fue eliminado correctamente
                bool correcto = false;
                //Eliminar una carrera
                correcto = servicioStore.eliminar(id);

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