/*
 * ECGridAPI
 * Copyright: Loren Data Corp.
 * Last Updated: 11/30/2017
 * Author: Greg Kolinski
 * Description: ECGridOS internal Class for calling the ECGridOS Web Service and ASync versions converted to the TAP Pattern in the ECGridOSAsync class 
 * 
 * This is a starter template.
 * Please make note it uses the Web Reference for ECGridOS
 *  net.ecgridos
 * 
 * * Please make note of the Packages Required - all can be installed via NuGet using these names.
 *  Newtonsoft.Json
 *  
 *  Provided as Example only
 */

using System;
using System.Text;
using ECGridOS_API = ECGridOS_Examples.net.ecgridos;
using System.Web.Services.Protocols;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Xml.Serialization;

namespace ECGridOS_Examples
{
    /// <summary>
    /// Class for making ECGridOS API Calls
    /// </summary>
    public class ECGridAPI
    {
        #region Class Properties

        /// <summary>
        /// Internal Variable for Storeing the APIKey/SessionID
        /// </summary>
        private string _apiKey;

        /// <summary>
        /// Public Variable for Getting/Setting APIKey/SessionID - with GUID validation on set
        /// </summary>
        public string APIKey
        {
            get { return this._apiKey; }
            set
            {
                if (IsValidGUID(value))
                {
                    _apiKey = value;
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
        }

        #endregion  

        #region Constructors

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public ECGridAPI() { }

        /// <summary>
        /// Constructor to set the APIKey/SessionID at instantiation
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        public ECGridAPI(string APIKey)
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                _apiKey = APIKey;

                // Async API Key Assignment for ECGridOSAsync
                ECGridAPIAsync.APIKey = APIKey;
            }
            else
            {
                throw new Exception("Invalid GUID API Key");
            }
        }

        #endregion

        #region Public Methods

        #region Version

        /// <summary>
        /// Synchonous Soap Call to get the ECGridOS Version
        /// </summary>
        /// <returns>String: ECgridOS Version</returns>
        public string APIVersion()
        {
            try
            {
                using (ECGridOS_API.ECGridOSAPIv3 ECGridOS = new ECGridOS_API.ECGridOSAPIv3())
                {
                    // Make the call and return the results
                    return ECGridOS.Version();
                }
            }
            catch (SoapException SoapEx)
            {
                // SOAP Exceptions
                return ECGridAPI.ShowSoapError(SoapEx);
            }

        } // END METHOD

        /// <summary>
        /// Asynchonous Soap Call to get the ECGridOS Version
        /// Converts EAP pattern into TAP pattern to use async/await from ECGridAPIAsync Class
        /// </summary>
        /// <returns>Task string: ECGridOS Version</returns>
        public async Task<string> APIVersionAsync()
        {
            try
            {
                using (ECGridOS_API.ECGridOSAPIv3 ECGridOS = new ECGridOS_API.ECGridOSAPIv3())
                {
                    // Make the call and await the results to return
                    var AsyncTask = await ECGridAPIAsync.VersionAsync(ECGridOS);
                    return AsyncTask.Result;
                }
            }
            catch (SoapException SoapEx)
            {
                // SOAP Exceptions
                return ECGridAPI.ShowSoapError(SoapEx);
            }

        } // END METHOD

        /// <summary>
        /// Synchonous HTTP Get Call to get the ECGridOS Version
        /// </summary>
        /// <returns>string: ECGridOS Version</returns>
        public string APIVersionHttpGet()
        {
            try
            {
                // Create the request and get the response
                using (WebResponse response = WebRequest.Create(@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/Version").GetResponse())
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        // Read the response
                        string soapResult = sr.ReadToEnd();
                        if (soapResult != null)
                        {
                            // Get the SOAP XML Response
                            XElement xmlElem = XElement.Parse(soapResult);

                            // Remove the Namespace Attributes and from the element name
                            xmlElem.DescendantsAndSelf().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                            foreach (XElement el in xmlElem.DescendantsAndSelf())
                            {
                                el.Name = el.Name.LocalName;
                            }
                            return xmlElem.Value;
                        }
                        else
                        {
                            return string.Empty;
                        }
                    }
                } // END USING (WebResponse)
            }
            catch (WebException webEx)
            {
                var errorMsg = ShowHttpError(webEx).Result;
                Console.WriteLine(errorMsg);
                return string.Empty;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return string.Empty;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP Get Call to get the ECGridOS Version
        /// </summary>
        /// <returns>Task string: ECGridOS Version</returns>
        public async Task<string> APIVersionHttpGetAsync()
        {
            try
            {
                // Create the request and get the response
                using (WebResponse response = await WebRequest.Create(@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/Version").GetResponseAsync())
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        // Read the response
                        string soapResult = await sr.ReadToEndAsync();
                        if (soapResult != null)
                        {
                            // Get the SOAP XML Response
                            XElement xmlElem = XElement.Parse(soapResult);

                            // Remove the Namespace Attributes and from the element name
                            xmlElem.DescendantsAndSelf().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                            foreach (XElement el in xmlElem.DescendantsAndSelf())
                            {
                                el.Name = el.Name.LocalName;
                            }
                            return xmlElem.Value;
                        }
                        else
                        {
                            return string.Empty;
                        }
                    }
                } // END USING (WebResponse)
            }
            catch (WebException webEx)
            {
                var errorMsg = await ShowHttpError(webEx);
                Console.WriteLine(errorMsg);
                return string.Empty;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return string.Empty;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP Get Call to get the ECGridOS Version
        /// </summary>
        /// <returns>Task XElement: ECGridOS Version in XML Format</returns>
        public async Task<XElement> APIVersionHttpGetAsyncXML()
        {
            try
            {
                // Create the request and get the response
                using (WebResponse response = await WebRequest.Create(@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/Version").GetResponseAsync())
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        // Read the response
                        string soapResult = await sr.ReadToEndAsync();
                        if (soapResult != null)
                        {
                            // Get the SOAP XML Response
                            XElement xmlElem = XElement.Parse(soapResult);

                            // Remove the Namespace Attributes and from the element name
                            xmlElem.DescendantsAndSelf().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                            foreach (XElement el in xmlElem.DescendantsAndSelf())
                            {
                                el.Name = el.Name.LocalName;
                            }
                            return xmlElem;
                        }
                        else
                        {
                            return null;
                        }
                    }
                } // END USING (WebResponse)
            }
            catch (WebException webEx)
            {
                var errorMsg = await ShowHttpError(webEx);
                Console.WriteLine(errorMsg);
                return null;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP Get Call to get the ECGridOS Version
        /// </summary>
        /// <returns>Task XElement: ECGridOS Version in JSON Format</returns>
        public async Task<JArray> APIVersionHttpGetAsyncJSON()
        {
            try
            {
                // Create the request and get the response
                using (WebResponse response = await WebRequest.Create(@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/Version").GetResponseAsync())
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        // Read the response
                        string soapResult = await sr.ReadToEndAsync();
                        if (soapResult != null)
                        {
                            // Get the SOAP XML Response
                            XElement xmlElem = XElement.Parse(soapResult);

                            // Remove the Namespace Attributes and from the element name
                            xmlElem.DescendantsAndSelf().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                            foreach (XElement el in xmlElem.DescendantsAndSelf())
                            {
                                el.Name = el.Name.LocalName;
                            }
                            // Serialize XML to JSON
                            var jsonObj = new JArray(JsonConvert.SerializeXNode(xmlElem));
                            return jsonObj;
                        }
                        else
                        {
                            return null;
                        }
                    }
                } // END USING (WebResponse)
            }
            catch (WebException webEx)
            {
                var errorMsg = await ShowHttpError(webEx);
                Console.WriteLine(errorMsg);
                return null;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        #endregion

        #region SessionInfo (WhoAmI)

        /// <summary>
        /// Synchonous Soap Call to get the ECGridOS SessionInfo
        /// Uses private variable for APIKey - must be set prior to calling
        /// </summary>
        /// <returns>net.ecgridos.SessionInfo Class: User Session information</returns>
        public ECGridOS_API.SessionInfo SessionInfo()
        {
            try
            {
                using (ECGridOS_API.ECGridOSAPIv3 ECGridOS = new ECGridOS_API.ECGridOSAPIv3())
                {
                    // Check to make sure it is in valid Guid Format
                    if (IsValidGUID(_apiKey))
                    {
                        // Make the call and return the results
                        return ECGridOS.WhoAmI(_apiKey);
                    }
                    else
                    {
                        throw new Exception("Invalid GUID API Key");
                    }
                }
            }
            catch (SoapException SoapEx)
            {
                // SOAP Exceptions
                Console.WriteLine(ECGridAPI.ShowSoapError(SoapEx));
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Synchonous Soap Call to get the ECGridOS SessionInfo
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>net.ecgridos.SessionInfo Class: User Session information</returns>
        public ECGridOS_API.SessionInfo SessionInfo(string APIKey)
        {
            try
            {
                using (ECGridOS_API.ECGridOSAPIv3 ECGridOS = new ECGridOS_API.ECGridOSAPIv3())
                {
                    // Check to make sure it is in valid Guid Format
                    if (IsValidGUID(APIKey))
                    {
                        // Make the call and return the results
                        return ECGridOS.WhoAmI(APIKey);
                    }
                    else
                    {
                        throw new Exception("Invalid GUID API Key");
                    }
                }
            }
            catch (SoapException SoapEx)
            {
                // SOAP Exceptions
                Console.WriteLine(ECGridAPI.ShowSoapError(SoapEx));
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous Soap Call to get the ECGridOS SessionInfo
        /// Converts EAP pattern into TAP pattern to use async/await from ECGridAPIAsync Class
        /// </summary>
        /// <returns>net.ecgridos.SessionInfo Class: User Session information</returns>
        public async Task<ECGridOS_API.SessionInfo> SessionInfoAsync()
        {
            try
            {
                using (ECGridOS_API.ECGridOSAPIv3 ECGridOS = new ECGridOS_API.ECGridOSAPIv3())
                {
                    // Check to make sure it is in valid Guid Format
                    if (IsValidGUID(_apiKey))
                    {
                        // Make the call and return the results
                        var AsyncTask = await ECGridAPIAsync.SessionInfoAsync(ECGridOS);
                        return AsyncTask.Result;
                    }
                    else
                    {
                        throw new Exception("Invalid GUID API Key");
                    }
                }
            }
            catch (SoapException SoapEx)
            {
                // SOAP Exceptions
                Console.WriteLine(ECGridAPI.ShowSoapError(SoapEx));
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous Soap Call to get the ECGridOS SessionInfo
        /// Uses private variable for APIKey - must be set prior to calling
        /// Converts EAP pattern into TAP pattern to use async/await from ECGridAPIAsync Class
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>net.ecgridos.SessionInfo Class: User Session information</returns>
        public async Task<ECGridOS_API.SessionInfo> SessionInfoAsync(string APIKey)
        {
            try
            {
                using (ECGridOS_API.ECGridOSAPIv3 ECGridOS = new ECGridOS_API.ECGridOSAPIv3())
                {
                    // Check to make sure it is in valid Guid Format
                    if (IsValidGUID(_apiKey))
                    {
                        // Make the call and return the results
                        var AsyncTask = await ECGridAPIAsync.SessionInfoAsync(ECGridOS, APIKey);
                        return AsyncTask.Result;
                    }
                    else
                    {
                        throw new Exception("Invalid GUID API Key");
                    }
                }
            }
            catch (SoapException SoapEx)
            {
                // SOAP Exceptions
                Console.WriteLine(ECGridAPI.ShowSoapError(SoapEx));
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Synchonous HTTP GET Call to get the ECGridOS SessionInfo
        /// Uses private variable for APIKey - must be set prior to calling
        /// </summary>
        /// <returns>net.ecgridos.SessionInfo Class: User Session information</returns>
        public ECGridOS_API.SessionInfo SessionInfoHttpGet()
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(_apiKey))
                {
                    // Create the request and get the response
                    using (WebResponse response = WebRequest.Create($@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI?SessionID={_apiKey}").GetResponse())
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        {
                            string soapResult = sr.ReadToEnd();
                            if (soapResult != null)
                            {
                                // Deserialize to net.ecgridos.SessionInfo Object
                                ECGridOS_API.SessionInfo sessionResult;
                                using (var stringreader = new StringReader(soapResult))
                                {
                                    var serializer = new XmlSerializer(typeof(ECGridOS_API.SessionInfo), "http://ecgridos.net/");
                                    sessionResult = (ECGridOS_API.SessionInfo)serializer.Deserialize(stringreader);
                                }
                                return sessionResult;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    } // END USING (WebResponse)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (WebException webEx)
            {
                var errorMsg = ShowHttpError(webEx).Result;
                Console.WriteLine(errorMsg);
                return null;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Synchonous HTTP GET Call to get the ECGridOS SessionInfo
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>net.ecgridos.SessionInfo Class: User Session information</returns>
        public ECGridOS_API.SessionInfo SessionInfoHttpGet(string APIKey)
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(APIKey))
                {
                    // Create the request and get the response
                    using (WebResponse response = WebRequest.Create($@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI?SessionID={APIKey}").GetResponse())
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        {
                            string soapResult = sr.ReadToEnd();
                            if (soapResult != null)
                            {
                                // Deserialize to net.ecgridos.SessionInfo Object
                                ECGridOS_API.SessionInfo sessionResult;
                                using (var stringreader = new StringReader(soapResult))
                                {
                                    var serializer = new XmlSerializer(typeof(ECGridOS_API.SessionInfo), "http://ecgridos.net/");
                                    sessionResult = (ECGridOS_API.SessionInfo)serializer.Deserialize(stringreader);
                                }
                                return sessionResult;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    } // END USING (WebResponse)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (WebException webEx)
            {
                var errorMsg = ShowHttpError(webEx).Result;
                Console.WriteLine(errorMsg);
                return null;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP GET Call to get the ECGridOS SessionInfo
        /// Uses private variable for APIKey - must be set prior to calling
        /// </summary>
        /// <returns>Task net.ecgridos.SessionInfo Class: User Session information</returns>
        public async Task<ECGridOS_API.SessionInfo> SessionInfoHttpGetAsync()
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(_apiKey))
                {
                    // Create the request and get the response
                    using (WebResponse response = await WebRequest.Create($@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI?SessionID={_apiKey}").GetResponseAsync())
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        {
                            string soapResult = await sr.ReadToEndAsync();
                            if (soapResult != null)
                            {
                                // Deserialize to ECGridOS_Soap_Service Class SessionInfo Object
                                ECGridOS_API.SessionInfo sessionResult;
                                using (var stringreader = new StringReader(soapResult))
                                {
                                    var serializer = new XmlSerializer(typeof(ECGridOS_API.SessionInfo), "http://ecgridos.net/");
                                    sessionResult = (ECGridOS_API.SessionInfo)serializer.Deserialize(stringreader);
                                }
                                return sessionResult;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    } // END USING (WebResponse)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (WebException webEx)
            {
                var errorMsg = await ShowHttpError(webEx);
                Console.WriteLine(errorMsg);
                return null;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP GET Call to get the ECGridOS SessionInfo
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>Task net.ecgridos.SessionInfo Class: User Session information</returns>
        public async Task<ECGridOS_API.SessionInfo> SessionInfoHttpGetAsync(string APIKey)
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(APIKey))
                {
                    // Create the request and get the response
                    using (WebResponse response = await WebRequest.Create($@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI?SessionID={APIKey}").GetResponseAsync())
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        {
                            string soapResult = await sr.ReadToEndAsync();
                            if (soapResult != null)
                            {
                                // Deserialize to ECGridOS_Soap_Service Class SessionInfo Object
                                ECGridOS_API.SessionInfo sessionResult;
                                using (var stringreader = new StringReader(soapResult))
                                {
                                    var serializer = new XmlSerializer(typeof(ECGridOS_API.SessionInfo), "http://ecgridos.net/");
                                    sessionResult = (ECGridOS_API.SessionInfo)serializer.Deserialize(stringreader);
                                }
                                return sessionResult;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    } // END USING (WebResponse)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (WebException webEx)
            {
                var errorMsg = await ShowHttpError(webEx);
                Console.WriteLine(errorMsg);
                return null;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP GET Call to get the ECGridOS SessionInfo
        /// Uses private variable for APIKey - must be set prior to calling
        /// </summary>
        /// <returns>Task XElement: User Session information as XML</returns>
        public async Task<XElement> SessionInfoHttpGetAsyncXML()
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(_apiKey))
                {
                    // Create the request and get the response
                    using (WebResponse response = await WebRequest.Create($@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI?SessionID={_apiKey}").GetResponseAsync())
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        {
                            string soapResult = await sr.ReadToEndAsync();
                            if (soapResult != null)
                            {
                                XElement xmlElem = XElement.Parse(soapResult);

                                // Remove the Namespace Attributes and from the element name
                                xmlElem.DescendantsAndSelf().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                                foreach (XElement el in xmlElem.DescendantsAndSelf())
                                {
                                    el.Name = el.Name.LocalName;
                                }
                                return xmlElem;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    } // END USING (WebResponse)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (WebException webEx)
            {
                var errorMsg = await ShowHttpError(webEx);
                Console.WriteLine(errorMsg);
                return null;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP GET Call to get the ECGridOS SessionInfo
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>Task XElement: User Session information as XML</returns>
        public async Task<XElement> SessionInfoHttpGetAsyncXML(string APIKey)
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(APIKey))
                {
                    // Create the request and get the response
                    using (WebResponse response = await WebRequest.Create($@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI?SessionID={APIKey}").GetResponseAsync())
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        {
                            string soapResult = await sr.ReadToEndAsync();
                            if (soapResult != null)
                            {
                                XElement xmlElem = XElement.Parse(soapResult);

                                // Remove the Namespace Attributes and from the element name
                                xmlElem.DescendantsAndSelf().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                                foreach (XElement el in xmlElem.DescendantsAndSelf())
                                {
                                    el.Name = el.Name.LocalName;
                                }
                                return xmlElem;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    } // END USING (WebResponse)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (WebException webEx)
            {
                var errorMsg = await ShowHttpError(webEx);
                Console.WriteLine(errorMsg);
                return null;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP GET Call to get the ECGridOS SessionInfo
        /// Uses private variable for APIKey - must be set prior to calling
        /// </summary>
        /// <returns>Task JArray: User Session information as JSON</returns>
        public async Task<JArray> SessionInfoHttpGetAsyncJSON()
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(_apiKey))
                {
                    // Create the request and get the response
                    using (WebResponse response = await WebRequest.Create($@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI?SessionID={_apiKey}").GetResponseAsync())
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        {
                            string soapResult = await sr.ReadToEndAsync();
                            if (soapResult != null)
                            {
                                XElement xmlElem = XElement.Parse(soapResult);

                                // Remove the Namespace Attributes and from the element name
                                xmlElem.DescendantsAndSelf().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                                foreach (XElement el in xmlElem.DescendantsAndSelf())
                                {
                                    el.Name = el.Name.LocalName;
                                }
                                // Serialize XML to JSON
                                var jsonObj = new JArray(JsonConvert.SerializeXNode(xmlElem));
                                return jsonObj;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    } // END USING (WebResponse)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (WebException webEx)
            {
                var errorMsg = await ShowHttpError(webEx);
                Console.WriteLine(errorMsg);
                return null;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP GET Call to get the ECGridOS SessionInfo
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>Task JArray: User Session information as JSON</returns>
        public async Task<JArray> SessionInfoHttpGetAsyncJSON(string APIKey)
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(APIKey))
                {
                    // Create the request and get the response
                    using (WebResponse response = await WebRequest.Create($@"https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI?SessionID={APIKey}").GetResponseAsync())
                    {
                        using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                        {
                            string soapResult = await sr.ReadToEndAsync();
                            if (soapResult != null)
                            {
                                XElement xmlElem = XElement.Parse(soapResult);

                                // Remove the Namespace Attributes and from the element name
                                xmlElem.DescendantsAndSelf().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                                foreach (XElement el in xmlElem.DescendantsAndSelf())
                                {
                                    el.Name = el.Name.LocalName;
                                }
                                // Serialize XML to JSON
                                var jsonObj = new JArray(JsonConvert.SerializeXNode(xmlElem));
                                return jsonObj;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    } // END USING (WebResponse)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (WebException webEx)
            {
                var errorMsg = await ShowHttpError(webEx);
                Console.WriteLine(errorMsg);
                return null;
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        #endregion

        #endregion

        #region Validation Helper Methods

        /// <summary>
        /// Checks if a string is a valid GUID
        /// </summary>
        /// <param name="guid">String: ECGridOS APIKey/SessionID</param>
        /// <returns>Boolean: true/false</returns>
        public static bool IsValidGUID(string guid)
        {
            if (Guid.TryParse(guid, out Guid newTmpGuid) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        } // END METHOD

        #endregion

        #region Exception Handling

        /// <summary>
        /// showSoapError - Catch ECGridOS and Native Soap Exceptions
        /// Parses XML to get Error Detail Information
        /// </summary>
        /// <param name="ex">SoapException: Thrown from call in Catch Block</param>
        /// <returns>String: Error Message or ECGridOS Error Message</returns>
        public static string ShowSoapError(SoapException ex)
        {
            // Get the response/exception XML and parse
            StringBuilder message = new StringBuilder(Environment.NewLine);
            XElement xmlElem = XElement.Parse(ex.Detail.OuterXml);

            if (xmlElem.HasElements && xmlElem != null)
            {
                XElement errorNode = xmlElem.Element("ErrorInfo");
                // This picks up ECGridOS generated SOAP Exceptions
                message.Append($"SOAP Exception: ({errorNode.Element("ErrorCode").Value}) {errorNode.Element("ErrorString").Value} {Environment.NewLine}");
                message.Append($"    Error Item: {errorNode.Element("ErrorItem").Value}{Environment.NewLine}");
                message.Append($"           Msg: {errorNode.Element("ErrorMessage").Value}{Environment.NewLine}");
            }
            else
            {
                // This picks up Service/Channel Framework generated Exceptions
                message.Append($"ERROR: {ex.Message} {Environment.NewLine}{Environment.NewLine} {ex.StackTrace}");
            }
            return message.ToString();

        } // END METHOD

        /// <summary>
        /// Error handling to get the ECGridOS Error Result or system error
        /// </summary>
        /// <param name="responseEx">HttpRequestException: Thrown from Http Request call in Catch Block</param>
        /// <returns>String: Error Message or ECGridOS Error Message</returns>
        public async static Task<string> ShowHttpError(WebException responseEx)
        {
            // Get the response/exception XML and parse if it is a ECGridOS API Error
            StringBuilder message = new StringBuilder(Environment.NewLine);

            using (StreamReader sr = new StreamReader(responseEx.Response.GetResponseStream()))
            {
                string responseResult = await sr.ReadToEndAsync();

                message.Append($"Http Exception: ({Convert.ToInt32(responseEx.Status).ToString()}) {responseEx.Status} {Environment.NewLine}");
                message.Append($"           Msg: {responseResult}{Environment.NewLine}");
            }
            return message.ToString();

        } // END METHOD

        #endregion

    } // END CLASS

} // END NAMESPACE
