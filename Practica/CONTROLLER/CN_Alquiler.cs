using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODEL;

namespace CONTROLLER
{
    public class CN_Alquiler
    {

        public CD_Alquiler MisAlquileres = new CD_Alquiler();

        public DataTable MostrarAlquileres()
        {
            DataTable tabla = new DataTable();
            tabla = MisAlquileres.Resultado();
            return tabla;
        }
        //Metodo que comunica a la tabla Marcas(Ingresar registros)---------------------
        public void InsertarAlquileres(string PLACA, string IDCLIENTE, string MONTOPAGAR, string DEPOSITODAÑOS)
        {
            MisAlquileres.InsertAlquiler(PLACA, IDCLIENTE, MONTOPAGAR, DEPOSITODAÑOS);
        }
        //Fin Metodo

        //Inicio de metodo para actualizar marcas
        public void ActualizarAlquiler(string PLACA, string IDCLIENTE, string MONTOPAGAR, string DEPOSITODAÑOS)
        {
            MisAlquileres.EditarAlquiler(PLACA, IDCLIENTE, MONTOPAGAR, DEPOSITODAÑOS);
        }
        //Fin Metodo

        //Inicio metodo para eliminar marcas
        public void deletearAlquiler(string IDCLIENTE)
        {
            MisAlquileres.EliminarAlquiler(IDCLIENTE);
        }
        //Fin Metodo

    }
}
