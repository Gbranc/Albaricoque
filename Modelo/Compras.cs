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
    public class Compras
    {
        public string id_compra { get; set; }

        public string fechaCompra { get; set; }

        public string id_mp { get; set; }

        public string caducidad { get; set; }

        public string id_proveedor { get; set; }

        public string unidad { get; set; }
        public string cantidad { get; set; }

        public string costo { get; set; }

        public string claveCompra { get; set; }
       

        

        public Compras() { }

        string conexion = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        /*
        public void listarCompras()
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarCompras2", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<Compras> entities = new List<Compras>();
                    List<MateriaPrima> entities2 = new List<MateriaPrima>();
                    List<Proveedor> entities3 = new List<Proveedor>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Compras entity = new Compras();
                            MateriaPrima entity2 = new MateriaPrima();
                            Proveedor entity3 = new Proveedor();

                            //entity.id_compra = dr["id_compra"].ToString();
                            entity.fechaCompra = dr["fechaCompra"].ToString();
                            entity2.nombre = dr["nombre"].ToString();
                            entity.unidad = dr["unidad"].ToString();
                            entity.cantidad = dr["cantidad"].ToString();

                            //entity.id_mp = dr["id_mp"].ToString();
                            entity.caducidad = dr["caducidad"].ToString();
                            entity3.nombreProveedor = dr["nombreProveedor"].ToString();
                           
                            
                            entity.costo = dr["costo"].ToString();

                            entities.Add(entity);
                            entities2.Add(entity2);
                            entities3.Add(entity3);
                        }
                        
                    }
                    //return entities;
                    ///return entities2;
                    
                    //return entities2;
                    //return entities3;
                }
               

            }

        }
         * */

        
        public List<Compras> listarCompraClave(string claveBuscar)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("listarCompraClave", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@claveBuscar", claveBuscar);
                    cnn.Open();
                    List<Compras> entities = new List<Compras>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Compras entity = new Compras();
                            entity.id_compra = dr["id_compra"].ToString();
                            entity.fechaCompra = dr["fechaCompra"].ToString();
                            entity.id_mp = dr["id_mp"].ToString();
                            entity.caducidad = dr["caducidad"].ToString();
                            entity.id_proveedor = dr["id_proveedor"].ToString();
                            entity.unidad = dr["unidad"].ToString();
                            entity.cantidad = dr["cantidad"].ToString();

                            entity.costo = dr["costo"].ToString();
                            entity.claveCompra = dr["claveCompra"].ToString();

                            entities.Add(entity);
                        }
                    }
                    return entities;
                }
            }
        }

        public int registrarCompras(Compras entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("registrarCompra", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_compra", entity.id_compra);
                    cmd.Parameters.AddWithValue("@fechaCompra", entity.fechaCompra);
                    cmd.Parameters.AddWithValue("@id_mp", entity.id_mp);
                    cmd.Parameters.AddWithValue("@caducidad", entity.caducidad);
                    cmd.Parameters.AddWithValue("@id_proveedor", entity.id_proveedor);
                    cmd.Parameters.AddWithValue("@unidad", entity.unidad);
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad);
                  
                    cmd.Parameters.AddWithValue("@costo", entity.costo);
                    cmd.Parameters.AddWithValue("@claveCompra", entity.claveCompra);




                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }


            }


        }

        public int modificarCompra(Compras entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ModificarCompra", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_compra", entity.id_compra);
                    cmd.Parameters.AddWithValue("@fechaCompra", entity.fechaCompra);
                    cmd.Parameters.AddWithValue("@id_mp", entity.id_mp);
                    cmd.Parameters.AddWithValue("@caducidad", entity.caducidad);
                    cmd.Parameters.AddWithValue("@id_proveedor", entity.id_proveedor);
                    cmd.Parameters.AddWithValue("@unidad", entity.unidad);
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad);

                    cmd.Parameters.AddWithValue("@costo", entity.costo);
                    cmd.Parameters.AddWithValue("@claveCompra", entity.claveCompra);

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }

            }

        }

        public int eliminarCompra(Compras entity)
        {

            using (SqlConnection cnn = new SqlConnection(conexion))
            {


                using (SqlCommand cmd = new SqlCommand("eliminarCompra4", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaCompra", entity.fechaCompra);
                    cmd.Parameters.AddWithValue("@caducidad", entity.caducidad);
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;


                }


            }


        }

    }
}
