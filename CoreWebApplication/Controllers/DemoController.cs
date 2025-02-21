using CoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    public class DemoController : Controller
    {

        public static List<Customer> customers = new List<Customer>()
        {
            new Customer() {id =101, Name= "King", Amount=12000},
            new Customer() {id =102, Name= "Asha", Amount=6000},
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customers.Count();
            ViewBag.CustomerList = customers;
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Message"] = "Customer Management System";
            ViewData["CustomerCount"] = customers.Count();
            ViewData["CustomerList"]= customers;
            return View();
        }

        public IActionResult Method1()
        {
            TempData["Message"] = "Customer Management System";
            TempData["CustomerCount"] = customers.Count();
            TempData["CustomerList"] = customers;
            return View();
        }

        public IActionResult Method2()
        {
            if (TempData["Message"] == null)
                return RedirectToAction("Index");
            TempData["Message"] = TempData["Message"].ToString();
                return View();
            
        }

        public IActionResult Loggin() 
        {
            HttpContext.Session.SetString("username", "Bhawana"); // username is the key and Bhawana is the value
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();  
        }
        
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }


        //Request URL : http://localhost:5018/Demo/QueryTest
        //Request URL after adding query parameters : http://localhost:5018/Demo/QueryTest?name=Ashali%20Samaraweera
        public IActionResult QueryTest()
        {
            string name = "King Kochhar";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
                name = HttpContext.Request.Query["name"];
            ViewBag.Name = name;
            return View();
        }
    }
}
