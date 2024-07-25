using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODEL;

namespace CONTROLLER
{
    public class CN_Clientes
    {
        public CD_Clientes MisClientes = new CD_Clientes();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = MisClientes.Resultado();
            return tabla;
        }
        //Metodo que comunica a la tabla Marcas(Ingresar registros)---------------------
        public void InsertarClientes(string IDCLIENTE, string NIT, string DIRECCION, string NOMBRE, string TELEFONO)
        {
            MisClientes.InsertCliente(IDCLIENTE, NIT, DIRECCION, NOMBRE, TELEFONO);
        }
        //Fin Metodo

        //Inicio de metodo para actualizar marcas
        public void ActualizarCliente(string IDCLIENTE, string NIT, string DIRECCION, string NOMBRE, string TELEFONO)
        {
            MisClientes.EditarCliente(IDCLIENTE, NIT, DIRECCION, NOMBRE, TELEFONO);
        }
        //Fin Metodo

        //Inicio metodo para eliminar marcas
        public void deletearCliente(string IDCLIENTE)
        {
            MisClientes.EliminarCliente(IDCLIENTE);
        }
        //Fin Metodo


        
    }

    

}
