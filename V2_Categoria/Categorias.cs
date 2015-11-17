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
    public class Categorias
    {
        public string id_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Categorias() { }

        string conexion = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        //listar categorias
        public List<Categorias> ListarCategorias()
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarCategorias", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Categorias> entities = new List<Categorias>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Categorias entity = new Categorias();
                            entity.id_categoria = dr["id_categoria"].ToString();
                            entity.nombre = dr["nombre"].ToString();
                            entity.descripcion = dr["descripcion"].ToString();

                            entities.Add(entity);
                        }
                    }
                    return entities;
                }

            }
            

        }
        public Boolean ValidarRegistro2(string Registro_buscar)
        {
            Boolean bandera = false;
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarCategorias", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Categorias> entities = new List<Categorias>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // if (dr.HasRows)
                        //{
                        while (dr.Read())
                        {


                            if (Registro_buscar.Equals(dr["nombre"].ToString()))
                            {
                                ////Console.Write("entre por fin\n");
                                ////Console.Write(Palabra_buscar +"\n");
                                //Categorias entity = new Categorias();
                                //entity.id_categoria = dr["id_categoria"].ToString();
                                //entity.nombre = dr["nombre"].ToString();
                                //entity.descripcion = dr["descripcion"].ToString();
                                //// entity.telefono = dr["telefono"].ToString();
                                ////Console.Write(entity.nombre);
                                //entities.Add(entity);
                                bandera = true;
                                break;
                            }
                            else
                            {
                                bandera = false;
                            }
                            //   }
                        }

                    }
                    return bandera;
                }
            }
        }
        public List<Categorias> ListarCategoriasNombre(string Palabra_buscar)
        {
            Boolean bandera = false;
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarCategorias", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Categorias> entities = new List<Categorias>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                       // if (dr.HasRows)
                        //{
                            while (dr.Read())
                            {


                                if (dr["nombre"].ToString().Trim().StartsWith(Palabra_buscar.Trim()))
                                {
                                    //Console.Write("entre por fin\n");
                                    //Console.Write(Palabra_buscar +"\n");
                                    Categorias entity = new Categorias();
                                    entity.id_categoria = dr["id_categoria"].ToString();
                                    entity.nombre = dr["nombre"].ToString();
                                    entity.descripcion = dr["descripcion"].ToString();
                                    // entity.telefono = dr["telefono"].ToString();
                                    //Console.Write(entity.nombre);
                                    entities.Add(entity);
                                    bandera = true;
                                }
                                else
                                {
                                    bandera = false;
                                }
                         //   }
                        }
                        if(bandera==false){
               
                        }
                            
                    }
                    return entities;
                }
            }
        }
        // fin metodo
        //metodo registrar categoria
        public int RegistrarCategoria(Categorias entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("registrarCategoria", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_categoria", entity.id_categoria);
                    cmd.Parameters.AddWithValue("@nombre", entity.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", entity.descripcion);
                    



                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }


            }


        }
        //

        //modificar categoria
        public int ModificarCategoria(Categorias entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ModificarCategoria", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_categoria", entity.id_categoria);
                    cmd.Parameters.AddWithValue("@nombre", entity.nombre);
             
                    cmd.Parameters.AddWithValue("@descripcion", entity.descripcion);

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }

            }

        }
        //
        //eliminar categoria
        public int EliminarCategoria(Categorias entity)
        {

            using (SqlConnection cnn = new SqlConnection(conexion))
            {


                using (SqlCommand cmd = new SqlCommand("eliminarCategoria", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_categoria", entity.id_categoria);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;


                }


            }


        }
    }
}
