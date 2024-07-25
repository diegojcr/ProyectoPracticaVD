using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Conexion
    {
        //Hacemos publica la clase conexion


        //Creamos la conexion...
        private SqlConnection conexion = new SqlConnection("Server=(local)\\SQLEXPRESS; DataBase=proyecto; Integrated Security = true");

        //Metodos que abriran y cerraran la BD...
        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
