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
        private string ApellidoUsu;
        private string PassUsu;
        private string EmailUsu;

        //Constructor
        public Usuario(string nombreUsuario, string apellidoUsu ,string password, string email)
        {
            NombreUsu = nombreUsuario;
            ApellidoUsu = apellidoUsu;
            PassUsu = password;
            EmailUsu = email;
            
        }

        // Set y Get NombreUSU
        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;

        }

        public string ApellidoUsuario
        {
            get => ApellidoUsu;
            set => ApellidoUsu = value;     

        }
        // Set y Get PassUSU
        public string Password
        {
            get => PassUsu;
            set => PassUsu = value;

        }

        public string EmailUsuario
        {
            get => EmailUsu;
            set => EmailUsu = value;
        }

        


    }


}
