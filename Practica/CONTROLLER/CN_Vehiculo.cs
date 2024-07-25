using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace CONTROLLER
{
    public class CN_Vehiculo
    {
        public CD_Vehiculo MisVehiculos = new CD_Vehiculo();

        public DataTable MostrarVehiculo()
        {
            DataTable tabla = new DataTable();
            tabla = MisVehiculos.Resultado();
            return tabla;
        }
        //Metodo que comunica a la tabla Marcas(Ingresar registros)---------------------
        public void InsertarVehiculo(string PLACA, string IDMODELO, string IDMARCA, string COLOR, string LINEA, string IDTIPOC, string CMCUBICOS, string CILINDROS, string PRECIO)
        {
            MisVehiculos.InsertVehiculo(PLACA, IDMODELO, IDMARCA, COLOR, LINEA, IDTIPOC, CMCUBICOS, CILINDROS, PRECIO);
        }
        //Fin Metodo

        //Inicio de metodo para actualizar marcas
        public void ActualizarVehiculo(string PLACA, string IDMODELO, string IDMARCA, string COLOR, string LINEA, string IDTIPOC, string CMCUBICOS, string CILINDROS, string PRECIO)
        {
            MisVehiculos.EditarVehiculo(PLACA, IDMODELO, IDMARCA, COLOR, LINEA, IDTIPOC, CMCUBICOS, CILINDROS, PRECIO);
        }
        //Fin Metodo

        //Inicio metodo para eliminar marcas
        public void deletearVehiculo(string PLACA)
        {
            MisVehiculos.EliminarVehiculo(PLACA);
        }
        //Fin Metodo
    }

}
