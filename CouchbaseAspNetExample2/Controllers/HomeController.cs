using System.Collections.Generic;
using System.Web.Mvc;
using CouchbaseAspNetExample2.Models;

namespace CouchbaseAspNetExample2.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonRepository _personRepo;

        public HomeController(PersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public ActionResult Index()
        {
            var list = _personRepo.GetAll();
//            var list = new List<Person> { _personRepo.GetPersonByKey("foo::123") };

            return View(list);
//            return Content("Name: " + person.Name + ", Address: " + person.Address);
        }
    }
}