using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Menu_Controlador
    {
        Menuu objDatos = new Menuu();
        public Menu_Controlador() { }


        //
        public List<Menuu> listarContador()
        {
            try
            {
                return objDatos.listarContador();
            }
            catch (Exception)
            {

                throw;
            }


        }
        //
        public List<Menuu> ListarMenu()
        {
            try
            {
                return objDatos.ListarMenu();
            }
            catch (Exception)
            {

                throw;
            }


        }
        //
        public List<Menuu> ListarMenuNombre(string nombreBuscar)
        {
            try
            {
                return objDatos.ListarMenuNombre(nombreBuscar);

            }
            catch (Exception)
            {
                throw;

            }


        }
        public List<Menuu> ListarIdMenu(string nombreBuscar)
        {
            try
            {
                return objDatos.ListarIdMenu(nombreBuscar);

            }
            catch (Exception)
            {
                throw;

            }


        }
       
        public int RegistrarMenu(Menuu entity)
        {
            int r = 0;
            try
            {
                r = objDatos.RegistrarMenu(entity);



            }
            catch (Exception)
            {
                throw;

            }
            return 1;



        }

        public int ModificarMenu(Menuu entity)
        {
            int r = 0;
            try
            {
                r = objDatos.ModificarMenu(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;


        }

        public int EliminarMenu(Menuu entity)
        {
            int r = 0;
            try
            {


                r = objDatos.EliminarMenu(entity);
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
