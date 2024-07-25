using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class CD_Clientes
    {
        private Conexion Conexion = new Conexion();

        SqlDataReader leerregistro;
        DataTable tablaregistro = new DataTable();
        SqlCommand Ejecutar = new SqlCommand();

        public DataTable Resultado()
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "SELECT * FROM CLIENTES";
            leerregistro = Ejecutar.ExecuteReader();
            tablaregistro.Load(leerregistro);
            Conexion.CerrarConexion();
            return tablaregistro;
        }

        //Metodo para el ingreso de datos en la tabla Marca
        public void InsertCliente(string IDCLIENTE, string NIT, string DIRECCION, string NOMBRE, string TELEFONO)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();//Abre nuestra conexion

            Ejecutar.CommandText = "INSERT INTO CLIENTES VALUES('" + IDCLIENTE + "','" + NIT + "', '"+DIRECCION+"', '"+NOMBRE+"','"+TELEFONO+"')";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();//Cierra conexion
        }
        //Fin de Metodo

        //Inicio de metodo para editar datos
        public void EditarCliente(string IDCLIENTE, string NIT, string DIRECCION, string NOMBRE, string TELEFONO)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "UPDATE CLIENTES SET NIT='" + NIT + "', DIRECCION='"+DIRECCION+"', NOMBRE='"+NOMBRE+"', TELEFONO='"+TELEFONO+"' WHERE ID_CLIENTE= '"+ IDCLIENTE+"'";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();
        }
        //Fin de Metodo

        //Inicio metodo eliminar registro
        public void EliminarCliente(string IDCLIENTE)
        {
            Ejecutar.Connection = Conexion.AbrirConexion();

            Ejecutar.CommandText = "DELETE FROM CLIENTES WHERE ID_CLIENTE= '"+ IDCLIENTE+"'";
            Ejecutar.ExecuteNonQuery();
            Ejecutar.CommandType = CommandType.Text;

            Conexion.CerrarConexion();
        }
        //Fin metodo

        
    }

}
