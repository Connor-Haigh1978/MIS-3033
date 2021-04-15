using Begginer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Begginer.Controllers
{
    public class ChuckController : Controller
    {
        // GET: Chuck
        public ActionResult Index()
        {

            RandomJokeAPI joke;

            using (var client = new HttpClient())
            {
                var JsonData = client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;

                joke = JsonConvert.DeserializeObject<RandomJokeAPI>(JsonData);


            }
            return View(joke);
        }
    }
}