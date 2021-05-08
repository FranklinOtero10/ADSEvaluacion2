using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SegundaEvaluacion.Models;
using SegundaEvaluacion.DAL;

namespace SegundaEvaluacion.Services
{
    public class ServiceCustomer
    {
        //Para acceder a los miembros de carrera dal
        public CustomerDAL customerDal = new CustomerDAL();

        // Para insertar carrera
        public int insertar(Customer cust)
        {
            try
            {
                return customerDal.insertCustomer(cust);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificar(int id, Customer cust)
        {
            try
            {
                return customerDal.modifiCustomer(id, cust);
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
                return customerDal.eliminarCustomer(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para obtener todos las carreras.
        public List<Customer> obtenerTodos()
        {
            return customerDal.obtenerTodos();
        }

        // Para obtener por ID.
        public Customer obtenerPorID(int id)
        {
            try
            {
                return customerDal.obtenerPorID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}