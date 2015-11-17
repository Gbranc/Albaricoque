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
    public class MateriaPrima
    {
        public string id_mp { get; set; }

        public string nombre { get; set; }

        public string cantidad { get; set; }

        public string unidad { get; set; }

        public string descripcion { get; set; }

        public string Contador { get; set; }

        

        public MateriaPrima() { }
        string conexion = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        //metodos

        //listar materia prima
        public List<MateriaPrima> listarMateriaPrima()
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ListarMateriaPrima", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<MateriaPrima> entities = new List<MateriaPrima>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            MateriaPrima entity = new MateriaPrima();
                            entity.id_mp = dr["id_mp"].ToString();
                            entity.nombre = dr["nombre"].ToString();
                            entity.cantidad = dr["cantidad"].ToString();
                            entity.unidad = dr["unidad"].ToString();
                            entity.descripcion = dr["descripcion"].ToString();
                            
                            entities.Add(entity);
                        }
                    }
                    return entities;
                }

            }

        }

        public List<MateriaPrima> listarContador()
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("Contador", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    List<MateriaPrima> entities = new List<MateriaPrima>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        { 
                            MateriaPrima entity = new MateriaPrima();
                            entity.Contador = dr["Contador"].ToString();
                            

                            entities.Add(entity);
                           
                        }
                    }
                    return entities;
                }

            }

        }

        // metodo listar materia prima por nombbre
        public List<MateriaPrima> listarMPnombre(string nombreBuscar)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("listarMPnombre", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombreBuscar", nombreBuscar);
                    cnn.Open();
                    List<MateriaPrima> entities = new List<MateriaPrima>();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            MateriaPrima entity = new MateriaPrima();
                            entity.id_mp = dr["id_mp"].ToString();
                            entity.nombre = dr["nombre"].ToString();
                            entity.cantidad = dr["cantidad"].ToString();
                            entity.unidad = dr["unidad"].ToString();
                            entity.descripcion = dr["descripcion"].ToString();
                            
                            entities.Add(entity);
                        }
                    }
                    return entities;
                }
            }
        }
        //Metdo de actualizar o acumular cantidad de materia prima nueva
        public int calcularCantidad(MateriaPrima entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("calcularCantidad2", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_mp", entity.id_mp);
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad);
                    

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }

            }

        }
       
        //
        //registrar materia prima
        public int registrarMateriaPrima(MateriaPrima entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("registrarMateriaPrima", cnn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_mp", entity.id_mp);
                    cmd.Parameters.AddWithValue("@nombre", entity.nombre);
                    cmd.Parameters.AddWithValue("@unidad", entity.unidad);
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad);
                   
                    cmd.Parameters.AddWithValue("@descripcion", entity.descripcion);
                   
                    

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }


            }


        }
        //registrar merma
        public int calcularMerma(MateriaPrima entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("registrarMerma", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_mp", entity.id_mp);
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad);


                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }

            }

        }

        //fin de registro de merma
        // modificar materia prima
        public int modificarMateriaPrima(MateriaPrima entity)
        {
            using (SqlConnection cnn = new SqlConnection(conexion))
            {
                using (SqlCommand cmd = new SqlCommand("ModificarMateriaPrima", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_mp", entity.id_mp);
                    cmd.Parameters.AddWithValue("@nombre", entity.nombre);
                    cmd.Parameters.AddWithValue("@cantidad", entity.cantidad);
                    cmd.Parameters.AddWithValue("@unidad", entity.unidad);
                    cmd.Parameters.AddWithValue("@descripcion", entity.descripcion);
                    
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;
                }

            }

        }
        //eliminar materia prima
        public int eliminarMateriaPrima(MateriaPrima entity)
        {

            using (SqlConnection cnn = new SqlConnection(conexion))
            {


                using (SqlCommand cmd = new SqlCommand("eliminarMateriaPrima", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_mp", entity.id_mp);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    return 1;


                }


            }


        }
        //


    }
}
