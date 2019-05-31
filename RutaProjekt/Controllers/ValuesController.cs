using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace RutaProjekt.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            string key = "AIzaSyBgzPlQpifvoVGemxEajTymgl2ZMpd4p8Y";
            string url = "https://maps.googleapis.com/maps/api/directions/json?origin=Split&destination=Zagreb&waypoints=Zadar|Skradin&key=" + key;

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                string responseString = response.Content.ReadAsStringAsync().Result;
                return responseString; 
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "";
        }
            // POST api/values
            public void Post([FromBody]string value)
            {
            }

            // PUT api/values/5
            public void Put(int id, [FromBody]string value)
            {
            }

            // DELETE api/values/5
            public void Delete(int id)
            {
            }
        }
    }

