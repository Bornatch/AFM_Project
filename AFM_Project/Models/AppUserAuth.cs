using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFM_Project.Models
{
    public class AppUserAuth
    {
        public AppUserAuth()
        {
            UserName = "Not authorized";
            BearerToken = string.Empty;
        }

        public string UserName { get; set; }
        public string BearerToken { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsUser { get; set; }

    }
}
