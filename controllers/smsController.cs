using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;  // for class Encoding
using System.IO;



namespace V2_API_CSHARP.controllers
{
    [Route("sms")]
    public class smsController : Controller
    {

        [HttpPost]
      
        public IActionResult Auth(string action_cmd, string api_key)
        {
            string cmd = action_cmd;

            if (cmd == "auth")
            {

                var request = (HttpWebRequest)WebRequest.Create("https://api.smsmasivos.com.mx/auth");
                var postData = $"apikey={api_key}";
                var data = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                try
                {
                    var response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    return Content(responseString);

                }
                catch (WebException ex)
                {
                    return Content("Error, usuario no autorizado "+ex);
                }

            }


            return Content("fhdrsewu trdtr");

        }

    }

}


