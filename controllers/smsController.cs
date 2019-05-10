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

                HttpWebResponse response = null;

                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    return Content(responseString);

                }
                catch (WebException ex)
                {
                    return Content("{\"success\":false,\"message\":\"Usuario no autorizado\",\"status\":401,\"code\":\"auth_01\"}");
                }

            }

            return Content("Server Error 500");

        }


        [HttpPost]
        [Route("Send")]
        public IActionResult Send(string action_cmd, string token, string c, string dest, string texto, string sand, string nombre)
        {
            if (action_cmd == "send")
                if (token != "" && token != null)
                {
                    c = c.Replace(" ", "");
                    int country = int.Parse(c);
                    int sandbox = 0;
                    if (sand == "1") sandbox = int.Parse(sand);

                    var request = (HttpWebRequest)WebRequest.Create("https://api.smsmasivos.com.mx/sms/send");
                    var postData = $"message={texto}&";
                    postData += $"numbers={dest}&";
                    postData += $"country_code={country}&";
                    postData += $"sandbox={sandbox}&";
                    postData += $"name={nombre}&";
                    var data = Encoding.ASCII.GetBytes(postData);
                    Console.WriteLine(postData.ToString());
                    request.Method = "POST";
                    request.Headers["token"] = token;
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = data.Length;

                    using (Stream stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }

                    HttpWebResponse response = null;

                    try
                    {
                        response = (HttpWebResponse)request.GetResponse();
                        var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                        return Content(responseString);

                    }
                    catch (WebException ex)
                    {
                        return Content("{\"success\":false,\"message\":\"Error al enviar el mensaje\",\"status\":501,\"code\":\"auth_01\"}");
                    }

                }

            return Content("Server Error 500");

        }

        [HttpPost]
        [Route("Credits")]
        public IActionResult Credits(string action_cmd,string token)
        {
            if (action_cmd == "credits" )
                if (token != "" && token != null)
                {
                    var request = (HttpWebRequest)WebRequest.Create("https://api.smsmasivos.com.mx/credits/consult");
                    var postData = "";
                    var data = Encoding.ASCII.GetBytes(postData);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = data.Length;

                    using (Stream stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }

                    HttpWebResponse response = null;

                    try
                    {
                        response = (HttpWebResponse)request.GetResponse();
                        var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                        return Content(responseString);

                    }
                    catch (WebException ex)
                    {
                        return Content("{\"success\":false,\"message\":\"Usuario no autorizado\",\"status\":401,\"code\":\"auth_01\"}");
                    }

                }

            return Content("Server Error 500");

        }

    }

}