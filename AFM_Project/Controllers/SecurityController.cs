using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFM_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AFM_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        //code from https://www.codemag.com/Article/1809031/Security-in-Angular-Part-2
        [HttpPost("login")]
        public IActionResult
          Login([FromBody] Customer user)
        {
            IActionResult ret = null;
            AppUserAuth auth = new AppUserAuth();
            SecurityManager mgr = new SecurityManager();

            auth = mgr.AuthenticateUser(user);
            if (auth.IsAuthenticated)
            {
                ret = StatusCode(StatusCodes.Status200OK,
                                 auth);
            }
            else
            {
                ret = StatusCode(
                       StatusCodes.Status404NotFound,
                       "Invalid User Name/Password.");
            }

            return ret;
        }
    }
}