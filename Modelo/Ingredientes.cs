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
    public class Ingredientes
    {
        public string id_producto{ get; set; }
        public string id_salida { get; set; }
        public string cantidad { get; set; }

        public string unidad { get; set; }

        public string id_mp { get; set; }

        public Ingredientes() { }

        string conexion = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        public List<Ingredientes> ListarIngredientes()
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarIngredientes", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Ingredientes> entities = new List<Ingredientes>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Ingredientes entity = new Ingredientes();
                            entity.id_salida = dr["id_salida"].ToString();
                            entity.id_producto = dr["id_producto"].ToString();
                            entity.id_mp = dr["id_mp"].ToString();
                            entity.cantidad = dr["cantidad"].ToString();
                            entity.unidad = dr["precio"].ToString();



                            entities.Add(entity);
                        }
                    }
                    return entities;
                }

            }


        }
        public List<Ingredientes> ListarIngredientesNombre(string id_producto)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarIngredientesNombre", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);
                    cnn.Open();
                    List<Ingredientes> entities = new List<Ingredientes>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Ingredientes entity = new Ingredientes();
                            entity.id_salida = dr["id_salida"].ToString();
                            entity.id_producto = dr["id_producto"].ToString();
                            entity.id_mp = dr["id_mp"].ToString();
                            entity.cantidad = dr["cantidad"].ToString();
                            entity.unidad = dr["unidad"].ToString();
                            
                           

                            entities.Add(entity);
                        }
                    }
                    return entities;
                }
            }
        }
        // fin metodo
        //metodo registrar 
        public int RegistrarIngredientes(Ingredientes entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("registrarIngrediente", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_salida", entity.id_salida);
                    cmd.Parameters.AddWithValue("@id_producto", entity.id_producto);
                    cmd.Parameters.AddWithValue("@id_mp", entity.id_mp);
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad);

                    cmd.Parameters.AddWithValue("@unidad", entity.unidad);






                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }


            }


        }

        public int ModificarIngrediente(Ingredientes entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ModificarIngrediente", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_salida", entity.id_salida);
                    cmd.Parameters.AddWithValue("@id_producto", entity.id_producto);
                    cmd.Parameters.AddWithValue("@id_mp", entity.id_mp);
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad);

                    cmd.Parameters.AddWithValue("@unidad", entity.unidad);

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }

            }

        }

        public int EliminarIngrediente(Ingredientes entity)
        {

            using (SqlConnection cnn = new SqlConnection(conexion))
            {


                using (SqlCommand cmd = new SqlCommand("eliminarIngrediente", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_salida", entity.id_salida);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;


                }


            }


        }
        //FIN
        
        



    }
}
