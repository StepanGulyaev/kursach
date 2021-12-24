using ClassLib;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ServerASPCORE.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class RegController : ControllerBase
        {
        [HttpPost]
        public string Post(LoginClass reciveData)
            {
            string token = Program.storedLogins.RegUser(reciveData.login, reciveData.password);
            Console.WriteLine(Program.storedLogins);
            return token;
            }
        }
    }
