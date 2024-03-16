using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Security.Cryptography.X509Certificates;

namespace negocio
{
    public class articuloNegocio
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
                comando.CommandText = "Select Id, Codigo, Descripcion, Proveedor, Stock, UrlImagen from articulos";
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
                    if (!(lector["UrlImagen"] is DBNull))      
                        aux.UrlImagen = (string)lector["UrlImagen"];

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

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();  

            try
            {
                //datos.setearConsulta("insert into articulos(Codigo,Descripcion,Proveedor,Stock) values(" + nuevo.codigo + ",'" + nuevo.descripcion + ",'" + nuevo.proveedor + ",'" + nuevo.stock)";
                datos.setearConsulta($"insert into articulos(Codigo,Descripcion,Proveedor,Stock, UrlImagen) values('{nuevo.codigo}', '{nuevo.descripcion}', '{nuevo.proveedor}',{nuevo.stock}, '{nuevo.UrlImagen}')");
                datos.ejecutarAccion();      
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion(); 
            }

        }
    }
}
