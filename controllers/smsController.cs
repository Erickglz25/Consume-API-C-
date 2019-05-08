using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace V2_API_CSHARP.controllers
{
    [Route("sms")]
    public class smsController : Controller
    {   
        [HttpPost]
      
        public IActionResult Auth(string action_cmd, string api_key)
        {
            string cmd = action_cmd;
            string ApiKey = api_key;

            

            //generar los curl aqui en esta sección 

            System.Diagnostics.Debug.WriteLine(cmd);
            return Content("fhdrsewu trdtr");

        }

    }
}