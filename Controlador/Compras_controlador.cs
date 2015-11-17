using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Compras_controlador
    {
        Compras objDatos = new Compras();
        public Compras_controlador() { }

       /* public void listarCompras()
        {
            MateriaPrima entity2 = new MateriaPrima();
            Proveedor entity3 = new Proveedor();
            try
            {
                  objDatos.listarCompras();
            }
            catch (Exception)
            {

                throw;
            }


        }
        * */
      
        //
        public List<Compras> listarCompraClave(string nombreBuscar)
        {
            try
            {
                return objDatos.listarCompraClave(nombreBuscar);

            }
            catch (Exception)
            {
                throw;

            }


        }

        public int registrarCompra(Compras entity)
        {
            int r = 0;
            try
            {
                r = objDatos.registrarCompras(entity);



            }
            catch (Exception)
            {
                throw;

            }
            return 1;



        }

        public int modificarCompra(Compras entity)
        {
            int r = 0;
            try
            {
                r = objDatos.modificarCompra(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;


        }

        public int eliminarCompra(Compras entity)
        {
            int r = 0;
            try
            {


                r = objDatos.eliminarCompra(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;

        }
    }
}
