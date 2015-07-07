using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DProductos
    {
        public int Id_Producto { get; set; }
        public String Nombre_Producto { get; set; }
        public String Nombre_Categoria { get; set; }
        public decimal Precio_Unitario { get; set; }
        public String Detalles { get; set; }
        public String Nombre_Buscado { get; set; }

        public DProductos()
        {

        }

        public DProductos(int parId_Producto, String parNombre_Producto, String parNombre_Categoria,
            decimal parPrecio_Unitario, String parDetalles)
        {
            this.Id_Producto = parId_Producto;
            this.Nombre_Producto = parNombre_Producto;
            this.Nombre_Categoria = parNombre_Categoria;
            this.Precio_Unitario = parPrecio_Unitario;
            this.Detalles = parDetalles;
        }

        public DataTable Mostrar(int parRegistrosPorPagina, int parNumeroPagina)
        {
            DataTable TablaDatos = new DataTable("Produccion.v_Productos_NombreCategoria");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.ProductosMostrar";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlParameter ParNumeroPagina = new SqlParameter();
                ParNumeroPagina.ParameterName = "@NumeroPagina";
                ParNumeroPagina.SqlDbType = SqlDbType.Int;
                ParNumeroPagina.Value = parNumeroPagina;
                SqlComando.Parameters.Add(ParNumeroPagina);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception ("Error al intentar ejecutar el procedimiento almacenado Produccion.ProductosMostrar. " + ex.Message);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public int Tamaño(int parRegistrosPorPagina)
        {
            int totalPaginas = 1;
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.ProductosTamaño";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlParameter ParTotalPaginas = new SqlParameter();
                ParTotalPaginas.ParameterName = "@TotalPaginas";
                ParTotalPaginas.Direction = ParameterDirection.Output;
                ParTotalPaginas.SqlDbType = SqlDbType.Int;
                SqlComando.Parameters.Add(ParTotalPaginas);

                SqlComando.ExecuteNonQuery();

                totalPaginas = (int)SqlComando.Parameters["@TotalPaginas"].Value;
            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.ProductosTamaño. " + ex.Message);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public DataTable Buscar(DProductos parProducto)
        {
            DataTable TablaDatos = new DataTable("Produccion.v_Productos_NombreCategoria");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.ProductosBuscar";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombreBuscado = new SqlParameter();
                ParNombreBuscado.ParameterName = "@NombreBuscado";
                ParNombreBuscado.SqlDbType = SqlDbType.VarChar;
                ParNombreBuscado.Size = parProducto.Nombre_Buscado.Length;
                ParNombreBuscado.Value = parProducto.Nombre_Buscado;
                SqlComando.Parameters.Add(ParNombreBuscado);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.ProductosBuscar. " + ex.Message);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }
    }
}
