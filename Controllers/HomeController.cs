using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Message"] = "Selamat datang di aplikasi web .NET 8 Anda!";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ProductDetail()
    {
    var product = new Product
    {
    Id = 1,
    Name = "Laptop Gaming",
    Price = 15000000.00m
    };
    return View(product);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
