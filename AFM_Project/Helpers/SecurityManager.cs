using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

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
        public AppUserAuth AuthenticateUser(MetaCustomer user)
        {
            AppUserAuth ret = new AppUserAuth();
            MetaCustomer authUser = null;

            using (var db = new SeilernContext())
            {
                // Attempt to validate user
                authUser = db.MetaCustomer.Where(
                  u => u. WebUserName.ToLower()
                       == user.WebUserName.ToLower()
                    && u.Password
                       == user.Password).FirstOrDefault();
            }

            if (authUser != null)
            {
                // Build User Security Object
                ret = BuildUserAuthObject(authUser);
                // attach user to context on successful jwt validation
                //context.Items["MetaCustomer"] = user;
            }

            return ret;
        }

        protected List<ClaimUser> GetUserClaims(MetaCustomer authUser)
        {
           
            List<ClaimUser> list =
              new List<ClaimUser>();

            using (var db = new SeilernContext())
            {
                list = db.ClaimUser.Where(
                       u => u.IdMetaCustomer == authUser.IdMetaCustomer)
                       .ToList();
            }

            return list;
        }
       
        protected AppUserAuth BuildUserAuthObject(MetaCustomer authUser)
        {
            AppUserAuth ret = new AppUserAuth();
            List<ClaimUser> claims = new List<ClaimUser>();

            // Set User Properties
            ret.UserName = authUser.WebUserName;
            ret.IsAuthenticated = true;           
            ret.IdMetaUser = authUser.IdMetaCustomer;
          
            // Get all claims for this user
            claims = GetUserClaims(authUser);

            // Loop through all claims and 
            // set properties of user object
            foreach (ClaimUser claim in claims)
            {                          
                //ajouter un case pour tous les options possibles si ajout 
                switch (claim.ClaimType)
                {
                    case nameof(ret.IsAdmin):
                            ret.IsAdmin = Convert.ToBoolean(claim.ClaimValue);
                        break;
                    case nameof(ret.IsUser):
                        ret.IsUser = Convert.ToBoolean(claim.ClaimValue);
                        break;
                }
                Console.WriteLine(claim);
            }

            ret.BearerToken = BuildJwtToken(ret);

            return ret;
        }

        protected string BuildJwtToken(AppUserAuth authUser)
        {
            SymmetricSecurityKey key =  new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(settings.Key));
            List<Claim> jwtClaims = new List<Claim>();

            // Create standard JWT claims
            jwtClaims.Add(new Claim(JwtRegisteredClaimNames.Sub,authUser.UserName));
            jwtClaims.Add(new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()));

            // Add custom claims
            jwtClaims.Add(new Claim("IsAuthenticated",
                authUser.IsAuthenticated.ToString()
                  .ToLower()));
            jwtClaims.Add(new Claim("IsAdmin",
                authUser.IsAdmin.ToString()
                  .ToLower()));
            jwtClaims.Add(new Claim("IsUser",
               authUser.IsUser.ToString()
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