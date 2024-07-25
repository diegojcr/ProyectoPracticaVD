using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class CD_Vehiculo
    {
        private Conexion Conexion = new Conexion();

        SqlDataReader leerregistro;
        DataTable tablaregistro = new DataTable();
        SqlCommand Ejecutar = new SqlCommand();

        public DataTable Resultado()
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "SELECT * FROM VEHICULO";
            leerregistro = Ejecutar.ExecuteReader();
            tablaregistro.Load(leerregistro);
            Conexion.CerrarConexion();
            return tablaregistro;
        }

        //Metodo para el ingreso de datos en la tabla Marca
        public void InsertVehiculo(string PLACA, string IDMODELO, string IDMARCA, string COLOR, string LINEA, string IDTIPOC, string CMCUBICOS, string CILINDROS, string PRECIO)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();//Abre nuestra conexion

            Ejecutar.CommandText = "INSERT INTO VEHICULO VALUES('" + PLACA + "','" + IDMODELO + "', '" + IDMARCA + "', '" + COLOR + "','" + LINEA + "','"+ IDTIPOC +"','"+ CMCUBICOS+ "','"+ CILINDROS+"','"+ PRECIO+"')";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();//Cierra conexion
        }
        //Fin de Metodo

        //Inicio de metodo para editar datos
        public void EditarVehiculo(string PLACA, string IDMODELO, string IDMARCA, string COLOR, string LINEA, string IDTIPOC, string CMCUBICOS, string CILINDROS, string PRECIO)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "UPDATE VEHICULO SET ID_MODELO='" + IDMODELO + "', ID_MARCA='" + IDMARCA + "', COLOR='" + COLOR + "', LINEA='" + LINEA + "', ID_TIPOCOMBUSTIBLE='"+IDTIPOC+"', CM_CUBICOS='"+CMCUBICOS+"', CILINDROS='"+CILINDROS+"', PRECIO='"+PRECIO+"' WHERE PLACA= '" + PLACA + "'";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();
        }
        //Fin de Metodo

        //Inicio metodo eliminar registro
        public void EliminarVehiculo(string PLACA)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "DELETE FROM VEHICULO WHERE PLACA= '" + PLACA + "'";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();
        }
        //Fin metodo
    }
}
