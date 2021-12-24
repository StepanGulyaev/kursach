using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ServerASPCORE.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class contactsController : ControllerBase
        {
        [HttpGet()]
        public string Get(int id)
            {
            List<string> contacts = Program.storedLogins.GetContacts();
            string tmpStr = JsonConvert.SerializeObject(contacts);
            return tmpStr;
            }

        }
    }
