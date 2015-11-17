using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuarios
    {
        public string id_usuario { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string edad { get; set; }
        public string tipo_usuario { get; set; }
        public string contraseña { get; set; }
        public string salario { get; set; }

        string conexion = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        public Usuarios() { }

        //Metodo listarUsuarios
        public List<Usuarios> ListarUsuarios()
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarUsuarios", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Usuarios> entities = new List<Usuarios>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            Usuarios entity = new Usuarios();
                            entity.id_usuario = dr["id_usuario"].ToString();
                            //entity.nombre = dr["nombre"].ToString();
                            //entity.direccion = dr["direccion"].ToString();
                           // entity.telefono = dr["telefono"].ToString();
                           // entity.edad = dr["edad"].ToString();                                                                                 
                            entity.tipo_usuario = dr["tipo_usuario"].ToString();                        
                            entity.contraseña = dr["contraseña"].ToString();
                         //   entity.salario = dr["salario"].ToString();
                            entities.Add(entity);
                        }
                    }
                    return entities;
                }

            }

        }

        //Metodo Listar Usuario por nombre
        public List<Usuarios> ListarUsuarioNombre(string nombreBuscar)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("listarUsuarionombre", cnn))
                
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreBuscar", nombreBuscar);
                    cnn.Open();
                    List<Usuarios> entities = new List<Usuarios>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Usuarios entity = new Usuarios();
                            entity.id_usuario = dr["id_usuario"].ToString();
                            entity.nombre = dr["nombre"].ToString();
                            entity.edad = dr["edad"].ToString();
                            entity.direccion = dr["direccion"].ToString();
                            entity.telefono = dr["telefono"].ToString();
                            entity.tipo_usuario = dr["tipo_usuario"].ToString();
                            entity.salario = dr["salario"].ToString();
                            entity.contraseña = dr["contraseña"].ToString();
                            entities.Add(entity);
                        }
                    }
                    return entities;
                }
            }
        }
        // registrar usuario
        public int registrarUsuario(Usuarios entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("registrarUsuario", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", entity.id_usuario);
                    //cmd.Parameters.AddWithValue("@nombre", entity.nombre);
                   // cmd.Parameters.AddWithValue("@direccion", entity.direccion);
                   // cmd.Parameters.AddWithValue("@telefono", entity.telefono); 
                    //cmd.Parameters.AddWithValue("@edad", entity.edad);                               
                    cmd.Parameters.AddWithValue("@tipo_usuario", entity.tipo_usuario);
                    cmd.Parameters.AddWithValue("@contraseña", entity.contraseña);
                    //cmd.Parameters.AddWithValue("@salario", entity.salario);
                    
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;



                }


            }


        }

        //Modificar usuario
        public int ModificarUsuario(Usuarios entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ModificarUsuario", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", entity.id_usuario);
                    cmd.Parameters.AddWithValue("@nombre", entity.nombre);
                    cmd.Parameters.AddWithValue("@edad", entity.edad);
                    cmd.Parameters.AddWithValue("@direccion", entity.direccion);
                    cmd.Parameters.AddWithValue("@telefono", entity.telefono);
                    cmd.Parameters.AddWithValue("@tipo_usuario", entity.tipo_usuario);
                    cmd.Parameters.AddWithValue("@salario", entity.salario);
                    cmd.Parameters.AddWithValue("@contraseña", entity.contraseña);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;



                }

            }

        }
        //Eliminar Usuario
        public int EliminarUsuario(Usuarios entity)
        {

            using (SqlConnection cnn = new SqlConnection(conexion))
            {


                using (SqlCommand cmd = new SqlCommand("eliminarUsuario", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", entity.id_usuario);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }
            }
        }

      


        //fin de metodos
    }
}
