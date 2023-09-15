using Microsoft.AspNetCore.Mvc;

namespace thetechharvest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Contact()
        {

            return View();
        }


        public ActionResult OurCompany()
        {
            return View();
        }

        public ActionResult Partner()
        {
            return View();
        }

        public ActionResult Career()
        {
            return View();
        }

      
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult CareerDetails(string id)
        {
            ViewBag.JID = id;
            return View();
        }

    }
}
