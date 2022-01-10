using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Ecole.proxies.Users
{

    [ServiceContract]
    public interface IAccountServices
    { 
       
        [OperationContract]
        bool EtudiantIdAdmit(User user);
        [OperationContract]
        bool Login(User user);
        [OperationContract]
        User EtEtudiantinfo(User email);
    }
}

