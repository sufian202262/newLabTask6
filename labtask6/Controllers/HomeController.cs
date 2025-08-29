using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using labtask6.Models;

namespace labtask6.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Profile()
    {
        ViewBag.Name = "Abu Sufian";
        ViewBag.Age = 25;
        ViewBag.Country = "Bangladesh";
        return View();
    }
}
