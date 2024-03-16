﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class clienteNegocio
    {
        public List<Cliente> listar()
        {
			List<Cliente> lista = new List<Cliente>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("SELECT c.Id, c.RazonSocial, c.Telefono, c.Email, c.Domicilio, v.Vendedor AS Vendedor FROM clientes c INNER JOIN Vendedor v ON c.IdVendedor = v.Id");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Cliente aux = new Cliente();
					aux.id = (int)datos.Lector["Id"];
                    aux.razonsocial = (string)datos.Lector["RazonSocial"];
                    aux.telefono = (string)datos.Lector["Telefono"];
                    aux.email = (string)datos.Lector["Email"];
                    aux.domicilio = (string)datos.Lector["Domicilio"];
                    Vendedor vendedor = new Vendedor();
                    vendedor.vendedor = (string)datos.Lector["Vendedor"];
                    vendedor.id = (int)datos.Lector["Id"];
                    aux.vendedor = vendedor;



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
				datos.cerrarConexion();	
			}

        }
        public void agregarCliente(Cliente nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.setearConsulta("insert into articulos(Codigo,Descripcion,Proveedor,Stock) values(" + nuevo.codigo + ",'" + nuevo.descripcion + ",'" + nuevo.proveedor + ",'" + nuevo.stock)";
                datos.setearConsulta($"insert into clientes(RazonSocial,Telefono, Email, Domicilio, IdVendedor) values('{nuevo.razonsocial}', '{nuevo.telefono}', '{nuevo.email}','{nuevo.domicilio}',{nuevo.vendedor.id})");
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

        public List<Vendedor> listarVendedor()
        {
            List<Vendedor> lista = new List<Vendedor>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select * from Vendedor");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Vendedor aux = new Vendedor();
                    aux.vendedor = (string)datos.Lector["Vendedor"];
                    aux.id = (int)datos.Lector["Id"];
                    

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
                datos.cerrarConexion();
            }

        }

    }
}
