using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CatchApp.CatchReference;
using Newtonsoft.Json;


namespace CatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GET full list of Catches
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:4556/Service1.svc/");
            //// Add an Accept header for JSON format.  
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage response = client.GetAsync("GetCatch/List").Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    var catches = response.Content.ReadAsStringAsync().Result;
            //    Console.WriteLine(catches);
            //}
            //else
            //{
            //    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            //}

            ////GET Gets a single object
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:4556/Service1.svc/");
            //// Add an Accept header for JSON format.  
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage response = client.GetAsync("GetCatch/1").Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    var catches = response.Content.ReadAsStringAsync().Result;
            //    Console.WriteLine(catches);
            //}
            //else
            //{
            //    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            //}

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:4556/Service1.svc");
                var response = client.DeleteAsync("DeleteCatch/1").Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");
            }
        }

    }

}

