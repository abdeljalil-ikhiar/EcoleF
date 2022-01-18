
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace pro.eco
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class AccountServices : IAccountServices
    {
        public User EtEtudiantinfo(User email)
        {
            throw new NotImplementedException();
        }

        public bool EtudiantIdAdmit(User user)
        {
            throw new NotImplementedException();
        }

        public bool Login(User user)
        {
            throw new NotImplementedException();
        }
    }
}
