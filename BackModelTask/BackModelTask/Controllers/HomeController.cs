using Microsoft.AspNetCore.Mvc;

namespace BackModelTask.Controllers
{
    public class HomeController : Controller
    {
      public ViewResult Index() 
        { 
            return View(); 
        }

        public ViewResult Contact()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
    }
}
