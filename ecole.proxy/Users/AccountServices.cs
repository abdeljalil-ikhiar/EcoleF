using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voxel.Services.Helpers.WCF;

namespace ecole.proxy.Users
{
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
            bool tmpResult = false;
            SyncProxyHelper<AccountServices>.Use(
                Endpoint.Name.ecoleCommercialWebService_BasicHttpEndPoint.ToString(),
                serviceProxy =>
                {
                    tmpResult = serviceProxy.Login(user);
                }
            );
            return tmpResult;
        }
    }

    
}