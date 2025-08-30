using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10.Models
{
    internal class AuthModel
    {
        const string ValidUsername = "admin";
        const string ValidPassword = "12345";

        public static bool Authenticate(string username, string password)
        {
            return username.Equals(ValidUsername) && password.Equals(ValidPassword);
        }
    }
}
