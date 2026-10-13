
using System.Web.Mvc;
using Practical_07_Feedback_Management_MVC.Models;

namespace Practical_07_Feedback_Management_MVC.Controllers
{
    public class FeedbackController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                return View("Result", feedback);
            }

            return View(feedback);
        }
    }
}
