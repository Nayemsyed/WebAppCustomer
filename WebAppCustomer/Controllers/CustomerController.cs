using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppCustomer.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            ViewBag.msg = "Customer Home Page";
            return View();
        }
        public ActionResult CustomerList()
        {
            List<string> list = new List<string>()
            {
             "sita",
             "Gita",
             "Riya",
             "Rithu"
            };
            ViewBag.CustomerList = list;
            return View();
        }
    }
}