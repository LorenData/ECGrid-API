/*
 * ECGridOS_CORE_Examples_Main
 * Copyright: Loren Data Corp.
 * Last Updated: 11/30/2017
 * Author: Greg Kolinski
 * Description: Example Call to provide users with a basic example of using the ECGridOS API Service with .NET Core Projects
 * Examples are not production ready and you will need to impliment your own best practices.
 * 
 * Provided as Example only
 */
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

namespace ECGridOS_CORE_Examples
{
    class ECGridOS_CORE_Examples_Main
    {
        static void Main(string[] args)
        {
            // Diagnostics
            Stopwatch stopW = new Stopwatch();
            
            /* 
             * Make Calls to The ECGridOS API Service using SOAP
             * The following steps are normally configured for you when you add a Web Reference in the .NET Framework
             * At the time of writting this .NET Core does not currently allow for "Web References/WCF" only currently supporting REST services
             * This is an example of how you can still use the ECGridOS API in .NET Core
             */

            // Create a HttpBinding for this Service Model
            Binding binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);

            // Creat a new channel with the binding for the ECGridOS API Endpoint
            ChannelFactory<IECGridOSAPIv3SoapService> factory = new ChannelFactory<IECGridOSAPIv3SoapService>(binding, new EndpointAddress("https://ecgridos.net/v3.2/prod/ecgridos.asmx"));

            // Create the Channel client for the ECGridOS API Service
            IECGridOSAPIv3SoapService ECGridOSClient = factory.CreateChannel();

            // Call the ECGridOS Synchronous API Methods direct in code
            stopW.Start();
            var result = ECGridOSClient.Version();
            stopW.Stop();
            Console.WriteLine($"ECGrid Version: {result}");
            Console.WriteLine($"Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

            Console.WriteLine($"{new String('-', 20)}{Environment.NewLine}");

            /* 
             * Example calls from a ECGridOS Client Class
             * Includes SOAP Calls with ServiceModel above as well as HTTPClient POST Async calls
             */

            // Use the SecretManager tool in .Net Core or keep/reference the APIKey somewhere secure, we do not recommend having the key in your source code. 
            string MyAPIKey = "FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF";

            // Set Your APIKey in the Client
            ECGridOS_Client.APIKey = MyAPIKey;

            // Synchronous SOAP Version Call
            stopW.Restart();
            var version = ECGridOS_Client.Version();
            stopW.Stop();
            Console.WriteLine($"ECGrid Version From SOAP Synchronous: {version}");
            Console.WriteLine($"Syncronous SOAP Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

            // Asynchronous SOAP Version Call
            stopW.Restart();
            var versionAsync = ECGridOS_Client.VersionAsync().Result;
            stopW.Stop();
            Console.WriteLine($"ECGrid Version From SOAP Asynchronous: {versionAsync}");
            Console.WriteLine($"Asyncronous SOAP Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

            // Asynchronous Http Post Version Call
            stopW.Restart();
            var versionAsyncPost = ECGridOS_Client.VersionHttpPostAsync().Result;
            stopW.Stop();
            Console.WriteLine($"ECGridOS Version From Http POST Async: {versionAsyncPost}");
            Console.WriteLine($"Asyncronous Http POST Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

            // Asynchronous Http Post to XML Version Call
            stopW.Restart();
            var versionAsyncPostXML = ECGridOS_Client.VersionHttpPostAsyncXML().Result;
            stopW.Stop();
            Console.WriteLine($"ECGridOS Version From Http POST Async: {versionAsyncPostXML.ToString()}");
            Console.WriteLine($"Asyncronous Http POST Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

            // Asynchronous Http Post to JSON Version Call
            stopW.Restart();
            var versionAsyncPostJson = ECGridOS_Client.VersionHttpPostAsyncJSON().Result;
            stopW.Stop();
            Console.WriteLine($"ECGridOS Version From POST HTTPClient Async to JSON: {versionAsyncPostJson.ToString()}");
            Console.WriteLine($"Asyncronous Http POST to JSON Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");


            Console.WriteLine($"{new String('-', 20)}{Environment.NewLine}");


            // Synchronous SOAP WhoAmI/SessionInfo Call
            stopW.Restart();
            var sessionInfo = ECGridOS_Client.SessionInfo();
            stopW.Stop();
            Console.WriteLine($"ECGrid SessionInfo UserID From SOAP Synchronous: {sessionInfo?.UserID}");
            Console.WriteLine($"Syncronous Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

            // Asynchronous SOAP WhoAmI/SessionInfo Call
            stopW.Restart();
            var sessionInfoAsync = ECGridOS_Client.SessionInfoAsync().Result;
            stopW.Stop();
            Console.WriteLine($"ECGrid SessionInfo UserID From SOAP Asynchronous: {sessionInfoAsync?.UserID}");
            Console.WriteLine($"Asyncronous Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

            // Asynchronous Http Post WhoAmI/SessionInfo Call
            stopW.Restart();
            var sessionInfoAsyncPost = ECGridOS_Client.SessionInfoHttpPostAsync().Result;
            stopW.Stop();
            Console.WriteLine($"ECGridOS SessionInfo From Http POST Async to Sessioninfo Object: {sessionInfoAsyncPost?.UserID}");
            Console.WriteLine($"Asyncronous Http POST to Object Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

            // Asynchronous Http Post to XML WhoAmI/SessionInfo Call
            stopW.Restart();
            XElement sessionInfoAsyncPostXML = ECGridOS_Client.SessionInfoHttpPostAsyncXML().Result;
            stopW.Stop();
            Console.WriteLine($"ECGridOS SessionInfo From Http POST Async to XML: {sessionInfoAsyncPostXML?.ToString()}");
            Console.WriteLine($"Asyncronous Http POST Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

            // Asynchronous Http Post to JSON WhoAmI/SessionInfo Call
            stopW.Restart();
            JArray sessionInfoAsyncPostJson = ECGridOS_Client.SessionInfoHttpPostAsyncJSON().Result;
            stopW.Stop();
            Console.WriteLine($"ECGridOS SessionInfo From Http POST Async to JSON: {sessionInfoAsyncPostJson?.ToString()}");
            Console.WriteLine($"Asyncronous Http POST to JSON Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

            Console.WriteLine($"{new String('-', 20)}{Environment.NewLine}");

            // End Examples
            Console.WriteLine("Press any Key to quit...");
            Console.ReadKey();
        }
    }
}
