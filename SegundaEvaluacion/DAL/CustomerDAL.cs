using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SegundaEvaluacion.Models;

namespace SegundaEvaluacion.DAL
{
    public class CustomerDAL
    {
        //Declaramos una lista de la clase carrera para guardar en memoria
        public static List<Customer> lstCustomer = new List<Customer>();

        //Constructor de la clase
        public CustomerDAL() { }

        public int insertCustomer(Customer cust)
        {
            try
            {
                // Si el listado tiene elementos entonces se genera el ID.
                if (lstCustomer.Count > 0)
                {
                    cust.idCustomer = lstCustomer.Last().idCustomer + 1;
                }
                else
                {
                    // Si el listado esta vacio entonces el id será por default 1
                    cust.idCustomer = 1;
                }
                lstCustomer.Add(cust);
                return cust.idCustomer;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modifiCustomer(int id, Customer cust)
        {
            try
            {
                // Buscando el indice en la lista
                lstCustomer[lstCustomer.FindIndex(temp => temp.idCustomer == id)] = cust;
                return cust.idCustomer;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminarCustomer(int id)
        {
            try
            {
                lstCustomer.RemoveAt(lstCustomer.FindIndex(aux => aux.idCustomer == id));
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Customer> obtenerTodos()
        {
            return lstCustomer;
        }

        // para encontrar una carrera por ID
        public Customer obtenerPorID(int id)
        {
            try
            {
                var elementos = lstCustomer.Find(temp => temp.idCustomer == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}