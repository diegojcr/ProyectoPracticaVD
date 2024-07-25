using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class CD_Alquiler
    {
        private Conexion Conexion = new Conexion();

        SqlDataReader leerregistro;
        DataTable tablaregistro = new DataTable();
        SqlCommand Ejecutar = new SqlCommand();

        public DataTable Resultado()
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "SELECT * FROM ALQUILERAUTOMOVIL";
            leerregistro = Ejecutar.ExecuteReader();
            tablaregistro.Load(leerregistro);
            Conexion.CerrarConexion();
            return tablaregistro;
        }

        //Metodo para el ingreso de datos en la tabla Marca
        public void InsertAlquiler(string PLACA, string IDCLIENTE, string MONTOPAGAR, string DEPOSITODAÑOS)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();//Abre nuestra conexion

            Ejecutar.CommandText = "INSERT INTO ALQUILERAUTOMOVIL VALUES('" + PLACA + "','" + IDCLIENTE + "','"+MONTOPAGAR+"','"+DEPOSITODAÑOS+"')";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();//Cierra conexion
        }
        //Fin de Metodo

        //Inicio de metodo para editar datos
        public void EditarAlquiler(string PLACA, string IDCLIENTE, string MONTOPAGAR, string DEPOSITODAÑOS)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "UPDATE ALQUILERAUTOMOVIL SET ID_CLIENTE='" + IDCLIENTE + "', MONTOPAGAR='"+MONTOPAGAR+"', DEPOSITODAÑOS='"+DEPOSITODAÑOS+"' WHERE PLACA= '" + PLACA + "'";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();
        }
        //Fin de Metodo

        //Inicio metodo eliminar registro
        public void EliminarAlquiler(string PLACA)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "DELETE FROM ALQUILERAUTOMOVIL WHERE PLACA= '" + PLACA + "'";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();
        }
        //Fin metodo
    }
}
