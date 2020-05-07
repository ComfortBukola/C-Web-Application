using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRoot.Controllers
{
 public class squarerootController : Controller
 {
  [HttpGet]
  public ActionResult SquareRoot()
  {
   return View();
  }

  [HttpPost]
  public ActionResult SquareRoot(string firstNumber, string secondNumber)
  {
   try
   {
    int numberOne = int.Parse(firstNumber);
    int numberTwo = int.Parse(secondNumber);
    double x1 = Math.Sqrt(numberOne);
    double x2 = Math.Sqrt(numberTwo);
    ViewBag.Result1 = x1;
    ViewBag.Result2 = x2;
    ViewBag.Result3 = numberOne;
    ViewBag.Result4 = numberTwo;
   }
   catch (System.Exception)
   {
    ViewBag.Error = "Whatever error statement of your choice";
   }
   return View();
  }
 }
}
