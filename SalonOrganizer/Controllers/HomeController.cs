using Microsoft.AspNetCore.Mvc;

namespace SalonOrganizer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}