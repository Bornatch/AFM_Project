using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace AFM_Project.Models
{
    public class SecurityManager
    {
        private JwtSettings settings;

        public SecurityManager(JwtSettings settings)
        {
            this.settings = settings;
        }

        //code adapté de https://www.codemag.com/Article/1809031/Security-in-Angular-Part-2
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
            AppUserAuth ret = new AppUserAuth();
            List<ClaimUser> claims =
              new List<ClaimUser>();
            // Set User Properties
            ret.UserName = authUser.UserName;
            ret.IsAuthenticated = true;
            ret.BearerToken = BuildJwtToken(ret);
            List<ClaimUser> list =
              new List<ClaimUser>();

            using (var db = new SeilernContext())
            {
                list = db.ClaimUser.Where(
                       u => u.IdMetaCustomer == authUser.IdCustomer)
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
            ret.BearerToken = BuildJwtToken(ret);

            ret.IsAdmin = true;

            /*
             * // Get all claims for this user
            claims = GetUserClaims(authUser);           
            
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

        protected string BuildJwtToken(AppUserAuth authUser)
        {
            SymmetricSecurityKey key =
              new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(settings.Key));
            List<Claim> jwtClaims = new List<Claim>();

            // Create standard JWT claims
            jwtClaims.Add(new Claim(
                JwtRegisteredClaimNames.Sub,
                authUser.UserName));
            jwtClaims.Add(new Claim(
                JwtRegisteredClaimNames.Jti,
                Guid.NewGuid().ToString()));

            // Add custom claims
            jwtClaims.Add(new Claim("isAuthenticated",
                authUser.IsAuthenticated.ToString()
                  .ToLower()));
            jwtClaims.Add(new Claim("isAdmin",
                authUser.IsAdmin.ToString()
                  .ToLower()));
            

            // Create the JwtSecurityToken object
            var token = new JwtSecurityToken(
              issuer: settings.Issuer,
              audience: settings.Audience,
              claims: jwtClaims,
              notBefore: DateTime.UtcNow,
              expires: DateTime.UtcNow.AddMinutes(
                  settings.MinutesToExpiration),
              signingCredentials:
                new SigningCredentials(key,
                    SecurityAlgorithms.HmacSha256)
            );

            // Create string representation of Jwt token
            return new JwtSecurityTokenHandler()
                         .WriteToken(token);
        }
        
    }
}