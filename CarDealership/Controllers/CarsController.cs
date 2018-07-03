using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/addList")]
    public ActionResult AddList()
    {
      return View();
    }

    [HttpPost("/new-car")]
    public ActionResult Index()
    {
      Car newCar = new Car(Request.Query["makeModel"], Request.Query["year"], Request.Query["miles"], Request.Query["price"]);
      newCar.Save();
      return View(Car.GetAll());
    }

    [HttpGet("/inventory")]
    public ActionResult GetInventory()
    {
      List<Car> inventory = Car.GetAll();
      return View("Index", inventory);
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
