using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace CONTROLLER
{
    public class CN_TipoC
    {
        public CD_TipoC MisTipos = new CD_TipoC();

        public DataTable MostrarTipo()
        {
            DataTable tabla = new DataTable();
            tabla = MisTipos.Resultado();
            return tabla;
        }
        //Metodo que comunica a la tabla Marcas(Ingresar registros)---------------------
        public void InsertarTipo(string IDTIPOC, string DESCRIPCION)
        {
            MisTipos.InsertTipo(IDTIPOC, DESCRIPCION);
        }
        //Fin Metodo

        //Inicio de metodo para actualizar marcas
        public void ActualizarTipo(string IDTIPOC, string DESCRIPCION)
        {
            MisTipos.EditarTipo(IDTIPOC, DESCRIPCION);
        }
        //Fin Metodo

        //Inicio metodo para eliminar marcas
        public void deletearTipo(string IDTIPOC)
        {
            MisTipos.EliminarTipo(IDTIPOC);
        }
        //Fin Metodo
    }
}
