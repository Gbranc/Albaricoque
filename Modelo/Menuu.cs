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
    [Serializable]
    public class Menuu
    {
        public string id_producto{ get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public string precio { get; set; }

        public string id_categoria { get; set; }

        public string Contador { get; set; }

        public Menuu() { }

        string conexion = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        //
        public List<Menuu> listarContador()
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ContadorMenu", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Menuu> entities = new List<Menuu>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Menuu entity = new Menuu();
                            entity.Contador = dr["Contador"].ToString();


                            entities.Add(entity);

                        }
                    }
                    return entities;
                }

            }

        }

        //
        public List<Menuu> ListarMenu()
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarMenu", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Menuu> entities = new List<Menuu>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Menuu entity = new Menuu();
                            entity.id_categoria = dr["id_producto"].ToString();
                            entity.nombre = dr["nombre"].ToString();
                            entity.descripcion = dr["descripcion"].ToString();
                            entity.descripcion = dr["precio"].ToString();
                            entity.descripcion = dr["id_categoria"].ToString();



                            entities.Add(entity);
                        }
                    }
                    return entities;
                }

            }


        }
        // fin metodo
        //metodo registrar menu
        public int RegistrarMenu(Menuu entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("registrarMenu", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_producto", entity.id_producto);
                    cmd.Parameters.AddWithValue("@nombre", entity.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", entity.descripcion);
                    cmd.Parameters.AddWithValue("@precio", entity.precio);

                    cmd.Parameters.AddWithValue("@id_categoria", entity.id_categoria);
                    
                    




                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }


            }


        }
        public List<Menuu> ListarMenuNombre(string nombreBuscar)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("listarMenuNombre", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreBuscar", nombreBuscar);
                    cnn.Open();
                    List<Menuu> entities = new List<Menuu>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Menuu entity = new Menuu();
                            entity.id_producto = dr["id_producto"].ToString();
                            entity.nombre = dr["nombre"].ToString();
                            entity.descripcion = dr["descripcion"].ToString();
                            entity.descripcion = dr["precio"].ToString();
                            entity.descripcion = dr["id_categoria"].ToString();

                            entities.Add(entity);
                        }
                    }
                    return entities;
                }
            }
        }
        //
        public int ModificarMenu(Menuu entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ModificarMenu", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_producto", entity.id_producto);
                    cmd.Parameters.AddWithValue("@nombre", entity.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", entity.descripcion);
                    cmd.Parameters.AddWithValue("@precio", entity.precio);

                    cmd.Parameters.AddWithValue("@id_categoria", entity.id_categoria);
                    
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }

            }

        }

        public int EliminarMenu(Menuu entity)
        {

            using (SqlConnection cnn = new SqlConnection(conexion))
            {


                using (SqlCommand cmd = new SqlCommand("eliminarMenu", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_producto", entity.id_producto);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;


                }


            }


        }
        public List<Menuu> ListarIdMenu(string nombreBuscar)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarIdMenu", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreBuscar", nombreBuscar);
                    cnn.Open();
                    List<Menuu> entities = new List<Menuu>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Menuu entity = new Menuu();
                            entity.id_producto = dr["id_producto"].ToString();
                            
                            entities.Add(entity);
                        }
                    }
                    return entities;
                }
            }
        }


        //fin

    }
}
