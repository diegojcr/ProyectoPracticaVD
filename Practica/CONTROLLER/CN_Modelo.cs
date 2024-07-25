using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace CONTROLLER
{
    public class CN_Modelo
    {
        public CD_Modelo MisModelos = new CD_Modelo();

        public DataTable MostrarModelo()
        {
            DataTable tabla = new DataTable();
            tabla = MisModelos.Resultado();
            return tabla;
        }
        //Metodo que comunica a la tabla Marcas(Ingresar registros)---------------------
        public void InsertarModelos(string IDMODELO, string DESCRIPCION)
        {
            MisModelos.InsertModelo(IDMODELO, DESCRIPCION);
        }
        //Fin Metodo

        //Inicio de metodo para actualizar marcas
        public void ActualizarModelos(string IDMODELO, string DESCRIPCION)
        {
            MisModelos.EditarModelo(IDMODELO, DESCRIPCION);
        }
        //Fin Metodo

        //Inicio metodo para eliminar marcas
        public void deletearModelos(string IDMODELO)
        {
            MisModelos.EliminarModelo(IDMODELO);
        }
        //Fin Metodo
    }
}
