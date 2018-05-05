using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.People = GetPeople();
            return View();
        }

        public List<Person> GetPeople()
        {
            List<Person> listPeople = new List<Person>();
            
            listPeople.Add(new Person("Hajan", "Selmani", "hajan@hajan.com", 070070070,DateTime.Now, 25));            
            listPeople.Add(new Person("Straight", "Dean", "email@address.com", 123456789, DateTime.Now.AddDays(-5), 35));
            listPeople.Add(new Person("Karsen", "Livia", "karsen@livia.com", 46874651, DateTime.Now.AddDays(-2), 31));
            listPeople.Add(new Person("Ringer", "Anne", "anne@ringer.org", null, DateTime.Now, null));
            listPeople.Add(new Person("O'Leary", "Michael", "23sssa@asssa.org", 32424344, DateTime.Now, 44));
            listPeople.Add(new Person("Gringlesby", "Anne", "email@yahoo.org", null, DateTime.Now.AddDays(-9), 18));
            listPeople.Add(new Person("Locksley", "Stearns", "my@email.org", 2135345, DateTime.Now, null));
            listPeople.Add(new Person("DeFrance", "Michel", "email@address.com", 235325352, DateTime.Now.AddDays(-18), null));
            listPeople.Add(new Person("White", "Johnson", null, null, DateTime.Now.AddDays(-22), 55));
            listPeople.Add(new Person("Panteley", "Sylvia", null, 23233223, DateTime.Now.AddDays(-1), 32));
            listPeople.Add(new Person("Blotchet-Halls", "Reginald", null, 323243423, DateTime.Now, 26));
            listPeople.Add(new Person("Merr", "South", "merr@hotmail.com", 3232442, DateTime.Now.AddDays(-5), 85));
            listPeople.Add(new Person("MacFeather", "Stearns", "mcstearns@live.com", null, DateTime.Now, null));

            return listPeople;
        }
    }

}
