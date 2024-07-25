using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class CD_TipoC
    {
        private Conexion Conexion = new Conexion();

        SqlDataReader leerregistro;
        DataTable tablaregistro = new DataTable();
        SqlCommand Ejecutar = new SqlCommand();

        public DataTable Resultado()
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "SELECT * FROM TIPOCOMBUSTIBLE";
            leerregistro = Ejecutar.ExecuteReader();
            tablaregistro.Load(leerregistro);
            Conexion.CerrarConexion();
            return tablaregistro;
        }

        //Metodo para el ingreso de datos en la tabla Marca
        public void InsertTipo(string IDTIPOC, string DESCRIPCION)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();//Abre nuestra conexion

            Ejecutar.CommandText = "INSERT INTO TIPOCOMBUSTIBLE VALUES('" + IDTIPOC + "','" + DESCRIPCION + "')";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();//Cierra conexion
        }
        //Fin de Metodo

        //Inicio de metodo para editar datos
        public void EditarTipo(string IDTIPOC, string DESCRIPCION)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "UPDATE TIPOCOMBUSTIBLE SET DESCRIPCION='" + DESCRIPCION + "' WHERE ID_TIPOCOMBUSTIBLE= '" + IDTIPOC + "'";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();
        }
        //Fin de Metodo

        //Inicio metodo eliminar registro
        public void EliminarTipo(string IDTIPOC)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "DELETE FROM TIPOCOMBUSTIBLE WHERE ID_TIPOCOMBUSTIBLE= '" + IDTIPOC + "'";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();
        }
        //Fin metodo
    }
}
