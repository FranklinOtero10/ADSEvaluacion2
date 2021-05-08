using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SegundaEvaluacion.Models;
using SegundaEvaluacion.DAL;

namespace SegundaEvaluacion.Services
{
    public class ServiceStore
    {
        //Para acceder a los miembros de carrera dal
        public StoreDAL storeDal = new StoreDAL();

        // Para insertar carrera
        public int insertar(Store st)
        {
            try
            {
                return storeDal.insertStore(st);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modificar(int id, Store st)
        {
            try
            {
                return storeDal.modifiStore(id, st);
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
                return storeDal.eliminarStore(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // Para obtener todos las carreras.
        public List<Store> obtenerTodos()
        {
            return storeDal.obtenerTodos();
        }

        // Para obtener por ID.
        public Store obtenerPorID(int id)
        {
            try
            {
                return storeDal.obtenerPorID(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}