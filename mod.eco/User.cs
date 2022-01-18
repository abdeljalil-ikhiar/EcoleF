using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod.eco
{
    public class User
    {
        public User()
        {
        }

        //public User(int id, string fName, string lName, string email, string Password, string statut, Role Role)
        //{
        //    this.id = id;
        //    FName = fName;
        //    LName = lName;
        //    this.email = email;
        //    this.Password = Password;
        //    this.statut = statut;
        //    this.Role = Role;
        //}

        public int id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string statut { get; set; }
        public Role Role { get; set; }

    }
}

namespace mod.eco
{
    public class IAccountServices
    {
    }
}