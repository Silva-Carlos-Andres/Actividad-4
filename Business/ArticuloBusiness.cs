using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dominio;



namespace Business
{
    public class ArticuloBusiness
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre from Articulos";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Articulo> Listar2()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select A.Id,A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.descripcion Categoria,ImagenUrl, Precio from Articulos A left join Marcas M ON A.IdMarca=M.Id left join Categorias C on A.IdCategoria=C.Id"); 
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca =  new Marca((string)datos.Lector["Marca"]);
                    aux.Categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    //lista.Add(new Articulo((int)datos.Lector["Id"]));
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
        public List<Articulo> buscarid(string txtsearch)
        {

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("select  Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.descripcion Categoria,ImagenUrl, Precio from Articulos A left join Marcas M ON A.IdMarca=M.Id left join Categorias C on A.IdCategoria=C.Id where Codigo LIKE '" + txtsearch + "%" + "'");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    //aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca((string)datos.Lector["Marca"]);
                    aux.Categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
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

        public List<Articulo> buscardesc(string txtsearch)
        {

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("select  Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.descripcion Categoria,ImagenUrl, Precio from Articulos A left join Marcas M ON A.IdMarca=M.Id left join Categorias C on A.IdCategoria=C.Id where A.Descripcion LIKE '" + "%" + txtsearch + "%" + "'");
                // datos.setearConsulta("select Codigo, Nombre, Descripcion, ImagenUrl, Precio from Articulos");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    //aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca((string)datos.Lector["Marca"]);
                    aux.Categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
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

        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values('" + articulo.Codigo + "', '" + articulo.Nombre + "','" + articulo.Descripcion + "', " + articulo.Marca.Id + ", " + articulo.Categoria.Id + ", '" + articulo.ImagenUrl + "', " + articulo.Precio + ")");
                datos.ejectutarAccion();
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
        public void editar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = '" + articulo.Codigo + "', Nombre = '" + articulo.Nombre + "' , Descripcion = '" + articulo.Descripcion + "', IdMarca = '" + articulo.Marca.Id + "', IdCategoria = '" + articulo.Categoria.Id + "' , ImagenUrl = '" + articulo.ImagenUrl + "' , Precio = '" + articulo.Precio + "' where Codigo = '" + articulo.Codigo + "'");
                datos.ejectutarAccion();
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
        public void eliminar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS where Codigo = '" + articulo.Codigo + "'");
                datos.ejectutarAccion();
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