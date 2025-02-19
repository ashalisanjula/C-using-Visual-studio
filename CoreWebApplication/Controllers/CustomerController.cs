using CoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;


namespace CoreWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer() {id =101, Name= "King", Amount=12000},
            new Customer() {id =102, Name= "Asha", Amount=6000},
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount= customers.Count;
            ViewBag.CustomerList = customers;
            return View();
        }
    }
}
