using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SegundaEvaluacion.Models;
using SegundaEvaluacion.DAL;

namespace SegundaEvaluacion.Services
{
    public class ServiceProduct
    {
        //Para acceder a los miembros de carrera dal
        public ProductDAL productDal = new ProductDAL();

        // Para insertar carrera
        public int insertar(Product pr)
        {
            try
            {
                return productDal.insertProduct(pr);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificar(int id, Product pr)
        {
            try
            {
                return productDal.modifiProduct(id, pr);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para eliminar
        public bool eliminar(int id)
        {
            try
            {
                return productDal.eliminarProduct(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para obtener todos las carreras.
        public List<Product> obtenerTodos()
        {
            return productDal.obtenerTodos();
        }

        // Para obtener por ID.
        public Product obtenerPorID(int id)
        {
            try
            {
                return productDal.obtenerPorID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}