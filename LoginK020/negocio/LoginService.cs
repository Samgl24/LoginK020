using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginK020.negocio
{
    internal class LoginService
    {
        string usernameValido = "admin";
        string passwordValido = "nimda";

        public bool check(string username, string password)
        {
            if (usernameValido == username && passwordValido == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
