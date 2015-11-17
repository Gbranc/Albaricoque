using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Ingredientes_Controlador
    {
         Ingredientes objDatos = new Ingredientes();
        public Ingredientes_Controlador() { }

        public List<Ingredientes> ListarIngrediente()
        {
            try
            {
                return objDatos.ListarIngredientes();
            }
            catch (Exception)
            {

                throw;
            }


        }
        //
        public List<Ingredientes> ListarIngredientesNombre(string id_producto)
        {
            try
            {
                return objDatos.ListarIngredientesNombre(id_producto);

            }
            catch (Exception)
            {
                throw;

            }


        }
        //
       

        public int RegistrarIngrediente(Ingredientes entity)
        {
            int r = 0;
            try
            {
                r = objDatos.RegistrarIngredientes(entity);



            }
            catch (Exception)
            {
                throw;

            }
            return 1;



        }

        public int ModificarIngrediente(Ingredientes entity)
        {
            int r = 0;
            try
            {
                r = objDatos.ModificarIngrediente(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;


        }

        public int EliminarIngrediente(Ingredientes entity)
        {
            int r = 0;
            try
            {


                r = objDatos.EliminarIngrediente(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;

        }
        //
    }
}
