using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SegundaEvaluacion.Models;

namespace SegundaEvaluacion.DAL
{
    public class StoreDAL
    {
        //Declaramos una lista de la clase carrera para guardar en memoria
        public static List<Store> lstStore = new List<Store>();

        //Constructor de la clase
        public StoreDAL() { }

        public int insertStore(Store st)
        {
            try
            {
                // Si el listado tiene elementos entonces se genera el ID.
                if (lstStore.Count > 0)
                {
                    st.idStore = lstStore.Last().idStore + 1;
                }
                else
                {
                    // Si el listado esta vacio entonces el id será por default 1
                    st.idStore = 1;
                }
                lstStore.Add(st);

                return st.idStore;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int modifiStore(int id, Store st)
        {
            try
            {
                // Buscando el indice en la lista
                lstStore[lstStore.FindIndex(temp => temp.idStore == id)] = st;
                return st.idStore;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool eliminarStore(int id)
        {
            try
            {
                lstStore.RemoveAt(lstStore.FindIndex(aux => aux.idStore == id));
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Store> obtenerTodos()
        {
            return lstStore;
        }

        // para encontrar una carrera por ID
        public Store obtenerPorID(int id)
        {
            try
            {
                var elementos = lstStore.Find(temp => temp.idStore == id);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}