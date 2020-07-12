using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFM_Project.Models
{
    public class SecurityManager
    {
        //code from https://www.codemag.com/Article/1809031/Security-in-Angular-Part-2
        public AppUserAuth
          AuthenticateUser(Customer user)
        {
            AppUserAuth ret = new AppUserAuth();
            Customer authUser = null;

            using (var db = new SeilernContext())
            {
                // Attempt to validate user
                authUser = db.Customer.Where(
                  u => u.UserName.ToLower()
                       == user.UserName.ToLower()
                    && u.Password
                       == user.Password).FirstOrDefault();
            }

            if (authUser != null)
            {
                // Build User Security Object
                ret = BuildUserAuthObject(authUser);
            }

            return ret;
        }

        protected List<ClaimUser>
          GetUserClaims(Customer authUser)
        {
            List<ClaimUser> list =
              new List<ClaimUser>();

            using (var db = new SeilernContext())
            {
                list = db.ClaimUser.Where(
                       u => u.IdCustomer == authUser.IdCustomer)
                       .ToList();
            }

            return list;
        }

        protected AppUserAuth
          BuildUserAuthObject(Customer authUser)
        {
            AppUserAuth ret = new AppUserAuth();
            List<ClaimUser> claims =
              new List<ClaimUser>();

            // Set User Properties
            ret.UserName = authUser.UserName;
            ret.IsAuthenticated = true;
            ret.BearerToken = new Guid().ToString();

            ret.IsAdmin = true;

            // Get all claims for this user
            claims = GetUserClaims(authUser);

            /*
            // Loop through all claims and 
            // set properties of user object
            foreach (ClaimUser claim in claims)
            {
                //problème de valeur null
                try
                {                   
                    typeof(AppUserAuth)
                      .GetProperty(claim.ClaimType)
                        .SetValue(ret, Convert.ToBoolean(
                          //claim.ClaimValue), null);
                          claim.ClaimValue));
                }
                catch
                {
                    
                }
            }

            */
            return ret;
        }
    }
}