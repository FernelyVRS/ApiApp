using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ApiApp.Models;
using Newtonsoft.Json;

namespace ApiApp.Request
{
    public class Solicitud
    {
        public object Respuesta()
        {
            string url = "https://pokeapi.co/api/v2/pokemon?limit=100&offset=0";
            string respuesta = GetHTTP(url);
            Rootobject oRootobject = JsonConvert.DeserializeObject<Rootobject>(respuesta);
            return respuesta;
        }

        public static string GetHTTP(string url)
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }
    }
}
