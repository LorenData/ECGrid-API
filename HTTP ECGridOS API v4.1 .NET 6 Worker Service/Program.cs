using HTTP_ECGridOS_API_v4._1_.NET_6_Worker_Service;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHttpClient<IECGridOSClient, ECGridOSClient>(client =>
        {
            client.BaseAddress = new Uri("https://os.ecgrid.io/v4.1/prod/ECGridOS.asmx/");
            client.Timeout = TimeSpan.FromMinutes(10);
        }).SetHandlerLifetime(TimeSpan.FromMinutes(720)); // Reuse connection pool for 12 hour before getting a new one

        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
