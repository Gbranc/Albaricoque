using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Categorias_Controlador
    {
        Categorias objDatos = new Categorias();

        public Categorias_Controlador() { }

        //listar categorias
        public List<Categorias> ListarCategorias()
        {
            try
            {
                return objDatos.ListarCategorias();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //busqueda por nombre
        public List<Categorias> buscarCategoriaNombre(string Palabra_buscar)
        {
            try
            {


                return objDatos.ListarCategoriasNombre(Palabra_buscar);

            }
            catch (Exception)
            {
                throw;
               

            }


        }
        
        //registrar categoria
        public int RegistrarCategoria(Categorias entity)
        {
            int r = 0;
            try
            {
                r = objDatos.RegistrarCategoria(entity);
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
        //modificar categoria
        public int ModificarCategorias(Categorias entity)
        {
            int r = 0;
            try
            {
                r = objDatos.ModificarCategoria(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;


        }
        //Eliminar Categorias
        public int EliminarCategorias(Categorias entity)
        {
            int r = 0;
            try
            {
                r = objDatos.EliminarCategoria(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;
        }


    }
}
