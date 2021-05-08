using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SegundaEvaluacion.Models;

namespace SegundaEvaluacion.DAL
{
    public class ProductDAL
    {
        //Declaramos una lista de la clase carrera para guardar en memoria
        public static List<Product> lstProduct = new List<Product>();

        //Constructor de la clase
        public ProductDAL() { }

        public int insertProduct(Product pr)
        {
            try
            {
                // Si el listado tiene elementos entonces se genera el ID.
                if (lstProduct.Count > 0)
                {
                    pr.idProduct = lstProduct.Last().idProduct + 1;
                }
                else
                {
                    // Si el listado esta vacio entonces el id será por default 1
                    pr.idProduct = 1;
                }
                lstProduct.Add(pr);
                return pr.idProduct;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modifiProduct(int id, Product pro)
        {
            try
            {
                // Buscando el indice en la lista
                lstProduct[lstProduct.FindIndex(temp => temp.idProduct == id)] = pro;
                return pro.idProduct;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminarProduct(int id)
        {
            try
            {
                lstProduct.RemoveAt(lstProduct.FindIndex(aux => aux.idProduct == id));
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Product> obtenerTodos()
        {
            return lstProduct;
        }

        // para encontrar una carrera por ID
        public Product obtenerPorID(int id)
        {
            try
            {
                var elementos = lstProduct.Find(temp => temp.idProduct == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}