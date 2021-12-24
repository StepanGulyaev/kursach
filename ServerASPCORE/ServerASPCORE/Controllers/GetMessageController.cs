using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerASPCORE.Controllers
  {
  [Route("api/[controller]")]
  [ApiController]
  public class GetMessageController : ControllerBase
    {
    [HttpGet("{id}")]
    public string Get(int id)
      {
      if (id>=0 && id < Program.listOfMessages.Count)
        {
        return Program.listOfMessages[id].ToString();
        }
      else
        return "Not found";
      }

    }
  }
