using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class ItemsController : Controller
  {
    [Route("/addList")]
    public ActionResult AddList()
    {
     return View("AddList");
    }
  }
}
//   {
//
//     [HttpGet("/cars")]
//     public ActionResult Index()
//     {
//       Car newCar = new Car(Request.Query["new-item"]);
//       return View(newCar);
//     }
//
//     [HttpGet("cars/new")]
//     public ActionResult CreateForm()
//     {
//       return View();
//     }
//
//
//   }
// }
