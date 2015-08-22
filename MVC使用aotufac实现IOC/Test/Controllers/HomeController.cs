using Endity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        IBLL.IPersonBLL personbll = null;
        public HomeController(IBLL.IPersonBLL personBLL)
        {
            personbll = personBLL;
        }

        public ActionResult Index()
        {
           List<Person> persons=personbll.GetPerson();
           ViewData["Persons"] = persons;
            return View();
        }

    }
}
