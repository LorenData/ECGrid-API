using HTTP_ECGridOS_API_v4._1_.NET_6_ASPNET_Core_MVC.Models;
using HTTP_ECGridOS_API_v4._1_.NET_6_ASPNET_Core_MVC.Services;

using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace HTTP_ECGridOS_API_v4._1_.NET_6_ASPNET_Core_MVC.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _Configuration;
    private readonly IECGridOSClient _ECGridOSClient;
    private readonly string APIKey = String.Empty;

    public HomeController(ILogger<HomeController> logger, IConfiguration Configuration, IECGridOSClient ECGridOSClient)
    {
        _logger = logger;
        _Configuration = Configuration;
        _ECGridOSClient = ECGridOSClient;
        APIKey = _Configuration["ECGridOS:APIKey"];
    }

    public async Task<IActionResult> Index()
    {
        string APIVersion = await  _ECGridOSClient.Version();
        if (!string.IsNullOrEmpty(APIVersion))
        {
            ViewData["EGridVersion"] = APIVersion;
        }
        else
        {
            ViewData["EGridVersion"] = "No result returned, ECGridOS might not be running.";
        }

        SessionInfo sessionInfo = await _ECGridOSClient.WhoAmI(APIKey);
       
        return View(sessionInfo);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
