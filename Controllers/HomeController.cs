using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Everest.Models;

namespace Everest.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context; // Initialize it here
    }
    public IActionResult Index()
    {
        // CompanyProfile profile;
        //var profiles = _context.CompanyProfiles.ToList();
        var profile = _context.CompanyProfiles.FirstOrDefault();
        return View(profile);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    //Services
    [HttpGet]
    public IActionResult Services()
    {
        return View();
    }
    public IActionResult CompanyProfile()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
