using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa
{
    internal class clienteNegocio
    {
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=proyecto; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, RazonSocial, Telefono, Email, Domicilio from dbo.clientes";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.id = (int)lector["Id"];
                    aux.razonsocial = (string)lector["RazonSocial"];
                    aux.telefono = (string)lector["Telefono"];
                    aux.email = (string)lector["Email"];
                    aux.domicilio = (string)lector["Domicilio"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }
    }
}
