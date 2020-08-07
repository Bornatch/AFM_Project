using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFM_Project.Models
{
    //selon https://www.codemag.com/Article/1809031/Security-in-Angular-Part-2
    public class JwtSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int MinutesToExpiration { get; set; }
    }
}
