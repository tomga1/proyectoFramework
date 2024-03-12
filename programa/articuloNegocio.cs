using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace programa
{
    internal class articuloNegocio
    {

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=proyecto; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Codigo, Descripcion, Proveedor, Stock from dbo.articulos";
                comando.Connection = conexion;  

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)lector["Id"];
                    aux.codigo = (string)lector["Codigo"];
                    aux.descripcion = (string)lector["Descripcion"];
                    aux.proveedor = (string)lector["Proveedor"];
                    aux.stock = (int)lector["Stock"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { 
                conexion.Close();   
            }

        }
    }
}
