/*
 * ECGridOS_Examples_Main
 * Copyright: Loren Data Corp.
 * Last Updated: 11/30/2017
 * Author: Greg Kolinski
 * Description: Example Calls to provide users with a basic example of using the ECGridOS API Service with .NET Framework Projects
 * Examples are not production ready and you will need to impliment your own best practices.
 * 
 * Please make note it uses the Web Reference for ECGridOS
 *  net.ecgridos
 * 
 * Please make note of the Packages Required - all can be installed via NuGet using these names.
 *  Newtonsoft.Json
 *  
 * Provided as Example only
 */

using System;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Web.Services.Protocols;
using Newtonsoft.Json;
using System.IO;
using ECGridOS_API = ECGridOS_Examples.net.ecgridos;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace ECGridOS_Examples
{
    /// <summary>
    /// Main Class to Call ECGridOS API
    /// </summary>
    class ECGridOS_Examples_Main
    {
        #region Console Pre-Setup

        /// Set Constant for Console window
        const int SWP_NOSIZE = 0x0001;

        /// <summary>
        /// Pointer to Console Window Internal Class
        /// </summary>
        private static IntPtr MyConsole = SafeNativeMethods.GetConsoleWindow();

        #endregion

        static void Main(string[] args)
        {
            try
            {
                #region Setup Console Window

                SafeNativeMethods.SetWindowPos(MyConsole, 0, 10, 10, 0, 0, SWP_NOSIZE);
                Console.Title = "ECGridOS .NET Framework 4.6 Examples";
                Console.WindowHeight = Console.WindowHeight = 50;
                Console.WindowWidth = Console.WindowWidth = 100;

                #endregion

                // Diagnostic Tools
                Stopwatch stopW = new Stopwatch();

                // Replace this with your API Key GUID in the App.config file or somewhere Secure.
                string MyAPIKey = ConfigurationManager.AppSettings["APIKey"].ToString();

                // Instantiate ECGridOSAPI Class & Set Your APIKey in the Client
                ECGridAPI ECGrid = new ECGridAPI(MyAPIKey);
                ECGridOS_API.ECGridOSAPIv3 ECGridClient = new ECGridOS_API.ECGridOSAPIv3();

                /* 
                 * Example calls from the ECGridAPI Class
                 * Includes SOAP Calls with Web Reference above as well as WebRequest GET Sync and Async calls
                 */

                // Synchronous SOAP Version Call
                stopW.Start();
                var version = ECGrid.APIVersion();
                stopW.Stop();
                Console.WriteLine($"ECGridOS Version From SOAP Synchronous: {version}");
                Console.WriteLine($"Synchronous SOAP Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                // Asynchronous SOAP Version Call
                stopW.Restart();
                var versionAsync = ECGrid.APIVersionAsync().Result;
                stopW.Stop();
                Console.WriteLine($"ECGridOS Version From SOAP Asynchronous: {versionAsync}");
                Console.WriteLine($"Asynchronous SOAP Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                // Synchronous Http GET Version Call
                stopW.Restart();
                var versionGet = ECGrid.APIVersionHttpGet();
                stopW.Stop();
                Console.WriteLine($"ECGridOS Version From Http GET Synchronous: {versionGet}");
                Console.WriteLine($"Syncronous Http GET Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                // Asynchronous Http GET Version Call
                stopW.Restart();
                var versionAsyncGet = ECGrid.APIVersionHttpGetAsync().Result;
                stopW.Stop();
                Console.WriteLine($"ECGridOS Version From Http GET Asynchronous: {versionAsyncGet}");
                Console.WriteLine($"Asyncronous Http GET Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                // Asynchronous Http GET to XML Version Call
                stopW.Restart();
                var versionAsyncGetXML = ECGrid.APIVersionHttpGetAsyncXML().Result;
                stopW.Stop();
                Console.WriteLine($"ECGridOS Version From Http GET To XML Asynchronous: {versionAsyncGetXML?.ToString()}");
                Console.WriteLine($"Asyncronous Http GET To XML Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                // Asynchronous Http GET to JSON Version Call
                stopW.Restart();
                var versionAsyncGetJSON = ECGrid.APIVersionHttpGetAsyncJSON().Result;
                stopW.Stop();
                Console.WriteLine($"ECGridOS Version From Http GET To JSON Asynchronous: {versionAsyncGetJSON?.ToString()}");
                Console.WriteLine($"Asyncronous Http GET To JSON Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");


                Console.WriteLine($"{new String('-', 20)}{Environment.NewLine}");


                // Synchronous SOAP WhoAmI/SessionInfo Call
                stopW.Restart();
                var sessionInfo = ECGrid.SessionInfo();
                stopW.Stop();
                Console.WriteLine($"ECGrid SessionInfo UserID From SOAP Synchronous: {sessionInfo?.UserID}");
                Console.WriteLine($"Synchronous Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                // Asynchronous SOAP WhoAmI/SessionInfo Call
                stopW.Restart();
                var sessionInfoAsync = ECGrid.SessionInfoAsync().Result;
                stopW.Stop();
                Console.WriteLine($"ECGrid SessionInfo UserID From SOAP Asynchronous: {sessionInfoAsync?.UserID}");
                Console.WriteLine($"Asynchronous Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                // Synchronous Http GET WhoAmI/SessionInfo Call
                stopW.Restart();
                var sessionInfoGet = ECGrid.SessionInfoHttpGet();
                stopW.Stop();
                Console.WriteLine($"ECGrid SessionInfo UserID From Http GET Sync to Sessioninfo Object: {sessionInfoGet?.UserID}");
                Console.WriteLine($"Synchronous Http GET to Object Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                // Asynchronous Http GET WhoAmI/SessionInfo Call
                stopW.Restart();
                var sessionInfoGetAsync = ECGrid.SessionInfoHttpGetAsync().Result;
                stopW.Stop();
                Console.WriteLine($"ECGrid SessionInfo UserID From Http GET Async to Sessioninfo Object: {sessionInfoGetAsync?.UserID}");
                Console.WriteLine($"Asyncronous Http GET to Object Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                // Asynchronous Http GET to XML WhoAmI/SessionInfo Call
                stopW.Restart();
                var sessionInfoGetAsyncXML = ECGrid.SessionInfoHttpGetAsyncXML().Result;
                stopW.Stop();
                Console.WriteLine($"ECGrid SessionInfo UserID From Http GET Async to XML: {sessionInfoGetAsyncXML?.ToString()}");
                Console.WriteLine($"Asyncronous Http GET to XML Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                // Asynchronous Http GET to JSON WhoAmI/SessionInfo Call
                stopW.Restart();
                var sessionInfoGetAsyncJSON = ECGrid.SessionInfoHttpGetAsyncJSON().Result;
                stopW.Stop();
                Console.WriteLine($"ECGrid SessionInfo UserID From Http GET Async to JSON: {sessionInfoGetAsyncJSON?.ToString()}");
                Console.WriteLine($"Asyncronous Http GET to JSON Time in Seconds: {stopW.Elapsed.TotalSeconds}{Environment.NewLine}");

                Console.WriteLine($"{new String('-', 20)}{Environment.NewLine}");

            }
            catch (Exception ex)
            {
                // Everything Else
                Console.WriteLine("Unhandled Exception: " + ex.ToString());
            }

            // End Examples
            Console.WriteLine("Press any Key to quit...");
            Console.ReadKey();

        } // END MAIN


    } // END CLASS

    #region Console Native Methods Class

    /// <summary>
    /// Console Window Internal Class
    /// </summary>
    internal static class SafeNativeMethods
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        internal static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
    } // END CLASS

    #endregion

} // END NAMESPACE