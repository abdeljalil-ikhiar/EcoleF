
using ecoleProxie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcoleF.Controllers
{
    public class AccountSController : Controller
    {
        // GET: AccountS
        private readonly IAccountServices Account;
        public AccountSController(IAccountServices Account)
        {
            this.Account = Account;
        }
        //GET: Account
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (this.Account.Login(user))
            {
                //get info user

                var resulte = this.Account.EtEtudiantinfo(user);
                //set idenit y info sigin

                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, resulte.Email));
                var ident = new ClaimsIdentity(claims, Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ApplicationCookie);

                //var ctx = HttpContext.GetOwinContext();
                //var authenticationManager = ctx.Authentication;
                //authenticationManager.SignIn(ident);
            }
            return Redirect("Index");
        }

    }
}