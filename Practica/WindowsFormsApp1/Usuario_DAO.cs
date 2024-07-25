using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Usuario_DAO
    {
        public Usuario Ingresar_Usuario(Usuario DataUser)
        {
            if (DataUser.User1 == "Diego" && DataUser.Contra1 == "05")
            {
                DataUser.MensajeUsuario1 = "Bienvenido al portal de Usuarios";
            }
            else
            {
                DataUser.MensajeUsuario1 = "Error usuario o contraseña incorrecta";

            }
            return DataUser;
        }
    }
}
