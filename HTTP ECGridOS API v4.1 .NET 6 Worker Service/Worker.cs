namespace HTTP_ECGridOS_API_v4._1_.NET_6_Worker_Service;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IConfiguration _Configuration;
    private readonly IECGridOSClient _ECGridOSClient;
    private readonly string APIKey = String.Empty;

    public Worker(ILogger<Worker> logger, IConfiguration Configuration, IECGridOSClient ECGridOSClient)
    {
        _logger = logger;
        _Configuration = Configuration;
        _ECGridOSClient = ECGridOSClient;
        APIKey = _Configuration["ECGridOS:APIKey"];
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            string APIVersion = await _ECGridOSClient.Version();
            if (!string.IsNullOrEmpty(APIVersion))
            {
                _logger.LogInformation($"ECGridOS API is Running Version {APIVersion} at: {DateTimeOffset.Now}");
            }

            SessionInfo sessionInfo = await _ECGridOSClient.WhoAmI(APIKey);
            if (sessionInfo != null)
            {
                _logger.LogInformation($"ECGridOS Session ID: {sessionInfo.SessionID} at: {DateTimeOffset.Now}");
            }

            _logger.LogInformation(Environment.NewLine);

            await Task.Delay(10000, stoppingToken);
        }
    }
}
