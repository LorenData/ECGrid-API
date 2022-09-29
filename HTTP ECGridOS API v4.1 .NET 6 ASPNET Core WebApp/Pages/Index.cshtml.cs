using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HTTP_ECGridOS_API_v4._1_.NET_6_ASPNET_Core_WebApp.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IConfiguration _Configuration;
    private readonly IECGridOSClient _ECGridOSClient;
    private readonly string APIKey = String.Empty;

    public IndexModel(ILogger<IndexModel> logger, IConfiguration Configuration, IECGridOSClient ECGridOSClient)
    {
        _logger = logger;
        _Configuration = Configuration;
        _ECGridOSClient = ECGridOSClient;
        APIKey = _Configuration["ECGridOS:APIKey"];
    }

    public void OnGet()
    {
        string APIVersion = _ECGridOSClient.Version().Result;
        if (!string.IsNullOrEmpty(APIVersion))
        {
            ViewData["EGridVersion"] = APIVersion;
        }
        else
        {
            ViewData["EGridVersion"] = "No result returned, ECGridOS might not be running.";
        }

        SessionInfo sessionInfo = _ECGridOSClient.WhoAmI(APIKey).Result;
        if (!string.IsNullOrEmpty(sessionInfo.SessionID))
        {
            ViewData["EGridSessionID"] = sessionInfo.SessionID;
        }
        else
        {
            ViewData["EGridSessionID"] = "No Sessions ID, I might ned to check my APIKey or call the Login API Endpoint";
        }
    }
}
