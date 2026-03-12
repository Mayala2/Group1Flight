using Microsoft.AspNetCore.Mvc;

namespace Group1Flight.Areas.Airlines.Controllers
{

   [Area("Airlines")] 
public class FlightsController : Controller
{
   // public IActionResult Index()
   // {
        //return View(); 
   // }
    public IActionResult Index()
{
    ViewData["BodyClass"] = "airlines-bg";
    return View();
}

    }
}