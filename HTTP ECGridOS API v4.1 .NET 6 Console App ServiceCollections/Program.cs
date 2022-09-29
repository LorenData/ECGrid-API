/*
 * ECGridOS API Console App Example for .NET 6 using Service Collections
 * Copyright: Loren Data Corp.
 * Last Updated: 09/28/2022
 * Author: Greg Kolinski
 * Description: Example Calls to provide users with a basic example of using the ECGridOS API Service with .NET 6 Projects
 * Examples are not production ready and you will need to impliment your own best practices.
 * Provided as Example only
 * 
 * Only Covers Connecting Via HTTP in a ServiceCollection
 * 
 * Example uses Nuget Packages
 * Microsoft.Extensions.DependencyInjection
 * Microsoft.Extensions.Http
 * 
 */

using HTTP_ECGridOS_API_v4._1_.NET_6_Console_App_ServiceCollections;

using Microsoft.Extensions.DependencyInjection;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Use the SecretManager or keep/reference the APIKey somewhere secure, we do not recommend having the key in your source code. 
string MyAPIKey = "FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF";

var services = new ServiceCollection();
services.AddScoped<IManageEDI, ManageEDI>();
services.AddHttpClient<IECGridOSClient, ECGridOSClient>(client =>
{
    client.BaseAddress = new Uri("https://os.ecgrid.io/v4.1/prod/ECGridOS.asmx/");
    client.Timeout = TimeSpan.FromMinutes(10);
}).SetHandlerLifetime(TimeSpan.FromMinutes(720)); // Reuse connection pool for 12 hour before getting a new one

using var servicesProvider = services.BuildServiceProvider();

var ediManager = servicesProvider.GetRequiredService<IManageEDI>();

// Check if the EGridOS API is running
Console.WriteLine(ediManager.CheckECGridOSIsRunning().Result);

// Check that My API Key can access a persistant session.
Console.WriteLine(ediManager.CheckECGridOSSession(MyAPIKey).Result);

int downloadedFileCount = ediManager.DownloadFiles(MyAPIKey).Result;

int uploadFileParcelID = ediManager.UploadloadFile(MyAPIKey).Result;

Console.ReadKey();
