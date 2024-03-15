using Microsoft.AspNetCore.Mvc;

namespace ParksLookup.Controllers
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
