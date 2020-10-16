using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Request
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://pokeapi.co/api/v2/pokemon?limit=10&offset=0";
            string respuesta = GetHTTP(url);
            Rootobject oRootobject = JsonConvert.DeserializeObject<Rootobject>(respuesta);
            Console.WriteLine(oRootobject);
        }

        public static string GetHTTP(string url)
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }
    }

    public class Result
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    public class Rootobject
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public Result[] results { get; set; }
    }

}
