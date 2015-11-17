using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class Usuarios_controlador
    {
        Usuarios objDatos = new Usuarios();

        public Usuarios_controlador() { }
        //Metodos a continuacion

        //listar usuarios
        public List<Usuarios> listarUsuario()
        {
            try
            {
                return objDatos.ListarUsuarios();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //listar usuario por nombre
        public List<Usuarios> listarUsuarioNombre(string nombreBuscar)
        {
            try
            {
                return objDatos.ListarUsuarioNombre(nombreBuscar);
           }
            catch (Exception)
            {
                throw;
            }
        }
        //registrar Usuario
        public int registrarUsuario(Usuarios entity)
        {
            int r = 0;
            try
            {
                r = objDatos.registrarUsuario(entity);
            }
            catch (Exception)
            {
             throw;
            }
            return 1;



        }
        //modificar usuario
        public int ModificarUsuario(Usuarios entity)
        {
            int r = 0;
            try
            {
                r = objDatos.ModificarUsuario(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return r;


        }
        //Eliminar usuario
        public int EliminarUsuario(Usuarios entity)
        {
            int r = 0;
            try
            {
                r = objDatos.EliminarUsuario(entity);
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
