using Microsoft.AspNetCore.Mvc;

namespace MusicOrganizer.Controllers
{
  public class Homecontroller : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    
  }
}