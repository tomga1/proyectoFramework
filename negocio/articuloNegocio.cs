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
        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update articulos set Codigo = @codigo, Descripcion = @descripcion, Proveedor = @proveedor, Stock = @stock, UrlImagen = @urlimagen where Id = @id");
                datos.setearParametro("@codigo", art.codigo);
                datos.setearParametro("@descripcion", art.descripcion);
                datos.setearParametro("@proveedor", art.proveedor);
                datos.setearParametro("@stock", art.stock);
                datos.setearParametro("@urlimagen", art.UrlImagen);
                datos.setearParametro("@id", art.id);

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
        public void eliminar(int id)
        {

            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from articulos where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
                
                
                
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select Id, Codigo, Descripcion, Proveedor, Stock, UrlImagen from articulos where ";


                if(campo == "Codigo")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Codigo like '" + filtro + "%'   ";
                            break;

                        case "Termina con":
                            consulta += "Codigo like  '%" + filtro + "'"  ;
                            break;
                        default:
                            consulta += "Codigo like '%" + filtro + "%'";
                            break;  
                    }
                }
                else if(campo == "Descripcion")
                {
                    switch (criterio)
                    {

                        case "Comienza con":
                            consulta += "Descripcion like '" + filtro + "%'   ";
                            break;

                        case "Termina con":
                            consulta += "Descripcion like  '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch(criterio)
                    {
                        case "Comienza con":
                            consulta += "Proveedor like '" + filtro + "%'   ";
                            break;

                        case "Termina con":
                            consulta += "Proveedor like  '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Proveedor like '%" + filtro + "%'";
                            break;
                    }

                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["Id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.proveedor = (string)datos.Lector["Proveedor"];
                    aux.stock = (int)datos.Lector["Stock"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }
    }
}
