using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class CD_Marcas
    {
        private Conexion Conexion = new Conexion();

        SqlDataReader leerregistro;
        DataTable tablaregistro = new DataTable();
        SqlCommand Ejecutar = new SqlCommand();

        public DataTable Resultado()
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "SELECT * FROM MARCA";
            leerregistro = Ejecutar.ExecuteReader();
            tablaregistro.Load(leerregistro);
            Conexion.CerrarConexion();
            return tablaregistro;
        }

        //Metodo para el ingreso de datos en la tabla Marca
        public void InsertMarca(string IDMARCA, string DESCRIPCION)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();//Abre nuestra conexion

            Ejecutar.CommandText = "INSERT INTO MARCA VALUES('" + IDMARCA + "','" + DESCRIPCION + "')";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();//Cierra conexion
        }
        //Fin de Metodo

        //Inicio de metodo para editar datos
        public void EditarMarca (string IDMARCA, string DESCRIPCION)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "UPDATE MARCA SET DESCRIPCION='" + DESCRIPCION + "' WHERE ID_MARCA= '" + IDMARCA + "'";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();
        }
        //Fin de Metodo

        //Inicio metodo eliminar registro
        public void EliminarMarca(string IDMARCA)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "DELETE FROM MARCA WHERE ID_MARCA= '" + IDMARCA + "'";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();
        }
        //Fin metodo
    }
}
