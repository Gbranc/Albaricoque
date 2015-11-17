using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class MateriaPrima_Controlador
    {
        MateriaPrima objDatos = new MateriaPrima();
        public MateriaPrima_Controlador() { }

        public List<MateriaPrima> listarContador()
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

        public List<MateriaPrima> listarMateriaPrima()
        {
            try
            {
                return objDatos.listarMateriaPrima();
            }
            catch (Exception)
            {

                throw;
            }


        }
        //
        public List<MateriaPrima> listarMPnombre(string nombreBuscar)
        {
            try
            {
                return objDatos.listarMPnombre(nombreBuscar);

            }
            catch (Exception)
            {
                throw;

            }


        }

        public int registrarMateriaPrima(MateriaPrima entity)
        {
            int r = 0;
            try
            {
                r = objDatos.registrarMateriaPrima(entity);



            }
            catch (Exception)
            {
                throw;

            }
            return 1;



        }

        public int modificarMateriaPrima(MateriaPrima entity)
        {
            int r = 0;
            try
            {
                r = objDatos.modificarMateriaPrima(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;


        }
        //caluclar cantidad

        public int calcularCantidad(MateriaPrima entity)
        {
            int r = 0;
            try
            {
                r = objDatos.calcularCantidad(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;


        }
        //calcular merma
        public int calcularMerma(MateriaPrima entity)
        {
            int r = 0;
            try
            {
                r = objDatos.calcularMerma(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;


        }
        //fin calcular merma
       
        //
        public int eliminarMateriaPrima(MateriaPrima entity)
        {
            int r = 0;
            try
            {


                r = objDatos.eliminarMateriaPrima(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;

        }
    }
}
