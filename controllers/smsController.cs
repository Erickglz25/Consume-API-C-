using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;  // for class Encoding
using System.IO;
using Newtonsoft.Json;
using System.Xml;



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

            return Content("Default Server Error 500");

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
                        return Content("{\"success\":false,\"message\":\"Informaci{on no disponible\",\"status\":401,\"code\":\"auth_01\"}");
                    }

                }

            return Content("Default Server Error 500");

        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(string action_cmd, string token, string nombre, string c, string dest, string digitos, string formato)
        {

            if (action_cmd == "2fa_register")
                if (token != "" && token != null)
                {
                    c = c.Replace(" ", "");
                    int country = int.Parse(c);
                    int dig = int.Parse(digitos);

                    string url = $"https://api.smsmasivos.com.mx/protected/"+formato+"/phones/verification/start";

                    var request = (HttpWebRequest)WebRequest.Create(url);

                    var postData = $"phone_number={dest}&";
                    postData += $"country_code={country}&";
                    postData += $"company={nombre}&";
                    postData += $"code_length={dig}";

                    var data = Encoding.ASCII.GetBytes(postData);

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
                        //Ejemplo de respuesta sin procesar, el manejo se realiza en el front-end
                        response = (HttpWebResponse)request.GetResponse();
                        var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                        if (formato == "json")
                        {
                            // Ejemplo de manejo de la respuesta en formato JSON
                            dynamic result = JsonConvert.DeserializeObject(responseString);
                            string message = result["message"];
                            message = message.Replace("{", "");           
                            message = message.Replace("}", "");
                            return Content(message);

                        }
                        else
                        {
                            // Ejemplo de manejo de la respuesta en formato XML
                            XmlDocument doc = new XmlDocument();
                            doc.LoadXml(responseString);
                            XmlNode node = doc.DocumentElement.SelectSingleNode("/hash/message");
                            string text = node.InnerText;
                            return Content(text);
                        }

                    }
                    catch (WebException ex)
                    {
                            return Content("Información no disponible");
                    }


                }

            return Content("Default Server Error 500");

        }

        [HttpPost]
        [Route("Validate")]
        public IActionResult Validate(string action_cmd, string token, string code, string dest, string formato)
        {
                                  
            if (action_cmd == "2fa_validate")
                if (token != "" && token != null)
                {

                    string url = $"https://api.smsmasivos.com.mx/protected/" + formato + "/phones/verification/check";

                    var request = (HttpWebRequest)WebRequest.Create(url);

                    var postData = $"phone_number={dest}&";
                    postData += $"verification_code={code}";
              

                    var data = Encoding.ASCII.GetBytes(postData);

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


                        if (formato == "json") {

                            // Ejemplo de manejo de la respuesta en formato JSON
                            dynamic result = JsonConvert.DeserializeObject(responseString);
                            string message = result["message"];
                            message = message.Replace("{", "");
                            message = message.Replace("}", "");
                            return Content(message);
                        }
                        else
                        {
                            // Ejemplo de manejo de la respuesta en formato XML
                            XmlDocument doc = new XmlDocument();
                            doc.LoadXml(responseString);
                            XmlNode node = doc.DocumentElement.SelectSingleNode("/hash/message");
                            string text = node.InnerText;
                            return Content(text);
                        }                  

                    }
                    catch (WebException ex)
                    {
                        return Content("The code could not be verified");
                    }

                }

            return Content("Default Server Error 500");

        }


    }

}