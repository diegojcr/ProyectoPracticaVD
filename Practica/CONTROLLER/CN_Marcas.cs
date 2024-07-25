using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODEL;

namespace CONTROLLER
{
    public class CN_Marcas
    {
        public CD_Marcas MisMarcas = new CD_Marcas();

        public DataTable MostrarMarca()
        {
            DataTable tabla = new DataTable();
            tabla = MisMarcas.Resultado();
            return tabla;
        }
        //Metodo que comunica a la tabla Marcas(Ingresar registros)---------------------
        public void InsertarMarcas(string IDMARCA, string DESCRIPCION)
        {
            MisMarcas.InsertMarca(IDMARCA, DESCRIPCION);
        }
        //Fin Metodo

        //Inicio de metodo para actualizar marcas
        public void ActualizarMarca(string IDMARCA, string DESCRIPCION)
        {
            MisMarcas.EditarMarca(IDMARCA, DESCRIPCION);
        }
        //Fin Metodo

        //Inicio metodo para eliminar marcas
        public void deletearMarca(string IDMARCA)
        {
            MisMarcas.EliminarMarca(IDMARCA);
        }
        //Fin Metodo
    }
}
