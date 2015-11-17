using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Proveedor_Controlador
    {
         Proveedor objDatos = new Proveedor();
        public Proveedor_Controlador(){}

        public List<Proveedor> ListarProveedor()
        {
            try
            {
                return objDatos.ListarProveedor();
            }
            catch (Exception)
            {

                throw;
            }


        }
        //
        public List<Proveedor> buscarProveedorNombre(string Palabra_buscar)
        {
            try
            {
                return objDatos.listarProveedorNombre(Palabra_buscar);

            }
            catch (Exception)
            {
                throw;

            }


        }

        public int registrarProveedor(Proveedor entity)
        {
            int r = 0;
            try
            {
                r = objDatos.registrarProveedor(entity);



            }
            catch (Exception)
            {
                throw;

            }
            return 1;



        }
        public Boolean ValidarRegistro1(String Registro_buscar)
        {

            return objDatos.ValidarRegistro2(Registro_buscar);

        }
        public int ModificarProveedor(Proveedor entity)
        {
            int r = 0;
            try
            {
                r = objDatos.ModificarProveedor(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;


        }

        public int EliminarProveedor(Proveedor entity )
        {
            int r = 0;
            try
            {


                r = objDatos.EliminarProveedor(entity);
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
