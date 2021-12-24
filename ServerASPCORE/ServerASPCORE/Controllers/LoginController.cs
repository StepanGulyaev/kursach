using ClassLib;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ServerASPCORE.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
        {
        [HttpPost]
        public string Post(LoginClass reciveData)
            {
            string token = Program.storedLogins.CheckLoginPassword(reciveData);
            Console.WriteLine(Program.storedLogins);
            return token;
            }
        }
    }
