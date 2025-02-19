using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            return View();
        }
    }
}
