using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
   
    public class Proveedor
    {
        public string id_proveedor { get; set; }
        public string nombreProveedor { get; set; }

        public string direccion { get; set; }
        public string telefono { get; set; }
        public Proveedor() { }
        
        string conexion = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        public List<Proveedor> ListarProveedor()
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarProveedor", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Proveedor> entities = new List<Proveedor>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Proveedor entity = new Proveedor();
                            entity.id_proveedor = dr["id_proveedor"].ToString();
                            entity.nombreProveedor = dr["nombreProveedor"].ToString();
                            entity.direccion = dr["direccion"].ToString();
                            entity.telefono = dr["telefono"].ToString();

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
                using (SqlCommand cmd = new SqlCommand("ListarProveedor", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Proveedor> entities = new List<Proveedor>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // if (dr.HasRows)
                        //{
                        while (dr.Read())
                        {


                            if (Registro_buscar.Equals(dr["nombreProveedor"].ToString()))
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
        //
        public List<Proveedor> listarProveedorNombre(string Palabra_buscar)
        {
            Boolean bandera = false;
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarProveedor", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Proveedor> entities = new List<Proveedor>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // if (dr.HasRows)
                        //{
                        while (dr.Read())
                        {


                            if (dr["nombreProveedor"].ToString().Trim().StartsWith(Palabra_buscar.Trim()))
                            {
                                Proveedor entity = new Proveedor();
                                entity.id_proveedor = dr["id_proveedor"].ToString();
                                entity.nombreProveedor = dr["nombreProveedor"].ToString();
                                entity.direccion = dr["direccion"].ToString();
                                entity.telefono = dr["telefono"].ToString();
                                entities.Add(entity);
                                bandera = true;

                            }
                            else
                            {
                                bandera = false;
                            }
                            //   }
                        }
                        if (bandera == false)
                        {

                        }

                    }
                    return entities;
                }
            }
        }
        // registrar proveedor
        public int registrarProveedor(Proveedor entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("registrarProveedor", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_proveedor", entity.id_proveedor);
                    cmd.Parameters.AddWithValue("@nombreProveedor", entity.nombreProveedor);
                    cmd.Parameters.AddWithValue("@direccion", entity.direccion);
                    cmd.Parameters.AddWithValue("@telefono", entity.telefono);

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }


            }


        }
        //modificar proveedor
        public int ModificarProveedor(Proveedor entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ModificarProveedor", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_proveedor", entity.id_proveedor);
                    cmd.Parameters.AddWithValue("@nombreProveedor", entity.nombreProveedor);
                    cmd.Parameters.AddWithValue("@direccion", entity.direccion);
                    cmd.Parameters.AddWithValue("@telefono", entity.telefono);

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }

            }

        }

        //eliminar proveedor
        public int EliminarProveedor(Proveedor entity)
        {

            using (SqlConnection cnn = new SqlConnection(conexion))
            {

                //System.Data.dll
                using (SqlCommand cmd = new SqlCommand("eliminarProveedor", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_proveedor", entity.id_proveedor);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;


                }


            }


        }

    }
}
