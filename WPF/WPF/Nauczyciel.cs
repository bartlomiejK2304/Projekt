using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    internal class Nauczyciel: Person
    {
        private string login;
        private string password;

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
    }
}
