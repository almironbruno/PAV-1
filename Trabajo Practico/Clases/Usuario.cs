using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico.Clases
{
    //Usuario del Sistema 
    public class Usuario
    {
        private string NombreUsu;
        private string PassUsu;

        //Constructor
        public Usuario(string nombreUsuario, string password)
        {
            NombreUsu = nombreUsuario;
            PassUsu = password;
        }

        // Set y Get NombreUSU
        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;

        }

        // Set y Get PassUSU
        public string Password
        {
            get => PassUsu;
            set => PassUsu = value;

        }


    }


}
