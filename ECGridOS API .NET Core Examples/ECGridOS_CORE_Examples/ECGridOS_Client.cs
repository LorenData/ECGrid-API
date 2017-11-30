/*
 * ECGridOS_Client
 * Copyright: Loren Data Corp.
 * Last Updated: 11/30/2017
 * Author: Greg Kolinski
 * Description: Example ECGridOS Client to make calls to the ECGridOS API using the ECGridOS_Soap_Service Interface ServiceModel Interface
 * 
 * Take this starter template along with the ECGridOS_Soap_Service.cs interface and build your own .Net Standard/Core Library or use it directly in your code.
 * Please make note of the Packages Required - all can be installed via NuGet using these names.
 *  System.Private.ServiceModel
 *  System.ServiceModel.Duplex
 *  System.ServiceModel.Http
 *  System.ServiceModel.NetTcp
 *  System.ServiceModel.Primatives
 *  System.ServiceModel.Security
 *  Newtonsoft.Json
 * 
 *  Provided as Example only
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ECGridOS_CORE_Examples
{
    /// <summary>
    /// ECGridOS_Client - Example ECGridOS Client Class
    /// </summary>
    public static class ECGridOS_Client
    {
        #region Class Variables

        /// The following steps are normally configured for you when you add a web reference in the .NET framework
        /// At the time of writting this .NET Core does not currently allow for "SOAP Web References/WCF" only currently supporting REST services

        /// <summary>
        /// Binding Type for the ECgridOS API Service
        /// </summary>
        private static Binding binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);

        /// <summary>
        /// Channel Creation to the ECGridOS API Endpoint using binding 
        /// </summary>
        private static ChannelFactory<IECGridOSAPIv3SoapService> factory = new ChannelFactory<IECGridOSAPIv3SoapService>(binding, new EndpointAddress("https://ecgridos.net/v3.2/prod/ecgridos.asmx"));

        /// <summary>
        /// Service Client to the ECGridOS API fromthe binded channel
        /// </summary>
        private static IECGridOSAPIv3SoapService client = factory.CreateChannel();

        /// <summary>
        /// Internal Variable for Storeing the APIKey/SessionID
        /// </summary>
        private static string _apiKey;

        /// <summary>
        /// Public Variable for Getting/Setting APIKey/SessionID - with GUID validation on set
        /// </summary>
        public static string APIKey
        {
            get { return _apiKey; }
            set
            {
                // Check to make sure it is in valid Guid Format
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

        #region Public Methods

        #region Version

        /// <summary>
        /// Synchonous Soap Call to get the ECGridOS Version
        /// </summary>
        /// <returns>String: ECgridOS Version</returns>
        public static string Version()
        {
            try
            {
                // Make the call and return the results
                return client.Version();
            }
            catch (FaultException SoapEx)
            {
                // Handle Soap/Service and ECGridOS Errors
                var error = ShowSoapError(SoapEx);
                Console.WriteLine(error);
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
        /// Asynchonous Soap Call to get the ECGridOS Version
        /// Converts AMP pattern into TAP pattern to use async/await
        /// </summary>
        /// <returns>Task string: ECGridOS Version</returns>
        public static async Task<string> VersionAsync()
        {
            try
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginVersion(callback, stateObject), client.EndVersion, null);
                return asyncResult;
            }
            catch (FaultException SoapEx)
            {
                // Handle Soap/Service and ECGridOS Errors
                var error = ShowSoapError(SoapEx);
                Console.WriteLine(error);
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
        /// Asynchonous HTTP POST Call to get the ECGridOS Version
        /// </summary>
        /// <returns>Task string: ECGridOS Version</returns>
        public static async Task<string> VersionHttpPostAsync()
        {
            try
            {
                // Parameters to use for POST
                var parameters = new Dictionary<string, string> { { "", "" } };

                using (HttpResponseMessage response = await new HttpClient().PostAsync("https://ecgridos.net/v3.2/prod/ECGridOS.asmx/Version", new FormUrlEncodedContent(parameters)))
                using (HttpContent content = response.Content)
                {
                    // Read content into a string - can use ReadAsStreamAync() for streams.
                    string soapResult = await content.ReadAsStringAsync();

                    if (soapResult != null)
                    {
                        // Get the SOAP XML Response
                        XElement xmlElem = XElement.Parse(soapResult);

                        // Strip the NameSpace from Attributes and Element Names
                        xmlElem.DescendantsAndSelf().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                        foreach (XElement el in xmlElem.DescendantsAndSelf())
                        {
                            el.Name = el.Name.LocalName;
                        }
                        return xmlElem.Value;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP POST Call to get the ECGridOS Version
        /// </summary>
        /// <returns>Task XElement: ECGridOS Version</returns>
        public static async Task<XElement> VersionHttpPostAsyncXML()
        {
            try
            {
                // Parameters to use for POST
                var parameters = new Dictionary<string, string> { { "", "" } };

                using (HttpResponseMessage response = await new HttpClient().PostAsync("https://ecgridos.net/v3.2/prod/ECGridOS.asmx/Version", new FormUrlEncodedContent(parameters)))
                using (HttpContent content = response.Content)
                {
                    // Read content into a string - can use ReadAsStreamAync() for streams.
                    string soapResult = await content.ReadAsStringAsync();

                    if (soapResult != null)
                    {
                        // Get the SOAP XML Response
                        XElement xmlElem = XElement.Parse(soapResult);

                        // Strip the NameSpace from Attributes and Element Names
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
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP POST Cal to get the ECGridOS Version
        /// </summary>
        /// <returns>Task string: ECGridOS Version in JSON Format</returns>
        public static async Task<JArray> VersionHttpPostAsyncJSON()
        {
            try
            {
                // Parameters to use for POST
                var parameters = new Dictionary<string, string> { { "", "" } };

                //using (HttpResponseMessage response = await client.PostAsync(url, encodedContent).ConfigureAwait(false))
                using (HttpResponseMessage response = await new HttpClient().PostAsync("https://ecgridos.net/v3.2/prod/ECGridOS.asmx/Version", new FormUrlEncodedContent(parameters)))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (HttpContent content = response.Content)
                        {
                            // Read content into a string - can use ReadAsStreamAync() for streams.
                            string soapResult = await content.ReadAsStringAsync();

                            if (soapResult != null)
                            {
                                XElement xmlElem = XElement.Parse(soapResult);

                                // Remove the Namespace Attributes and from the element name
                                xmlElem.DescendantsAndSelf().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                                foreach (XElement el in xmlElem.DescendantsAndSelf())
                                {
                                    el.Name = el.Name.LocalName;
                                }
                                var jsonObj = new JArray(JsonConvert.SerializeXNode(xmlElem));
                                return jsonObj;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                    else
                    {
                        var errorMsg = await ShowHttpError(response);
                        Console.WriteLine(errorMsg);
                        return null;
                    }
                } // END USING (HttpResponseMessage)
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
        /// <returns>ECGridOS_Soap_Service Class SessionInfo: User Session information</returns>
        public static SessionInfo SessionInfo()
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(_apiKey))
                {
                    // Make the call and return the results
                    return client.WhoAmI(_apiKey);
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (FaultException SoapEx)
            {
                // Handle Soap/Service and ECGridOS Errors
                var error = ShowSoapError(SoapEx);
                Console.WriteLine(error);
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
        /// Synchonous Soap Call to get the ECGridOS SessionInfo
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>ECGridOS_Soap_Service Class SessionInfo: User Session information</returns>
        public static SessionInfo SessionInfo(string APIKey)
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(APIKey))
                {
                    // Make the call and return the results
                    return client.WhoAmI(APIKey);
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (FaultException SoapEx)
            {
                // Handle Soap/Service and ECGridOS Errors
                var error = ShowSoapError(SoapEx);
                Console.WriteLine(error);
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
        /// Asynchonous Soap Call to get the ECGridOS SessionInfo
        /// Uses private variable for APIKey - must be set prior to calling
        /// Converts AMP pattern into TAP pattern to use async/await
        /// </summary>
        /// <returns>ECGridOS_Soap_Service Class SessionInfo: User Session information</returns>
        public static async Task<SessionInfo> SessionInfoAsync()
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(_apiKey))
                {
                    // Make the call and await the results to return
                    var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginWhoAmI(_apiKey, callback, stateObject), client.EndWhoAmI, null);
                    return asyncResult;
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (FaultException SoapEx)
            {
                // Handle Soap/Service and ECGridOS Errors
                var error = ShowSoapError(SoapEx);
                Console.WriteLine(error);
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
        /// Asynchonous Soap Call to get the ECGridOS SessionInfo
        /// Converts AMP pattern into TAP pattern to use async/await
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>Task SessionInfo: ECGridOS_Soap_Service Class SessionInfo - User Session information</returns>
        public static async Task<SessionInfo> SessionInfoAsync(string APIKey)
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(APIKey))
                {
                    // Make the call and await the results to return
                    var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginWhoAmI(APIKey, callback, stateObject), client.EndWhoAmI, null);
                    return asyncResult;
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (FaultException SoapEx)
            {
                // Handle Soap/Service and ECGridOS Errors
                var error = ShowSoapError(SoapEx);
                Console.WriteLine(error);
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
        /// Asynchonous HTTP POST Call to get the ECGridOS SessionInfo
        /// Uses private variable for APIKey - must be set prior to calling
        /// </summary>
        /// <returns>Task SessionInfo: ECGridOS_Soap_Service Class SessionInfo - User Session information</returns>
        public static async Task<SessionInfo> SessionInfoHttpPostAsync()
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(_apiKey))
                {
                    // Parameters to use for POST
                    var parameters = new Dictionary<string, string> { { "SessionID", _apiKey } };

                    using (HttpResponseMessage response = await new HttpClient().PostAsync("https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI", new FormUrlEncodedContent(parameters)))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            using (HttpContent content = response.Content)
                            {
                                // Read content into a string - can use ReadAsStreamAync() for streams.
                                string soapResult = await content.ReadAsStringAsync();
                                if (soapResult != null)
                                {
                                    // Deserialize to ECGridOS_Soap_Service Class SessionInfo Object
                                    SessionInfo sessionResult;
                                    using (var stringreader = new StringReader(soapResult))
                                    {
                                        var serializer = new XmlSerializer(typeof(SessionInfo), "http://ecgridos.net/");
                                        sessionResult = (SessionInfo)serializer.Deserialize(stringreader);
                                    }
                                    return sessionResult;
                                }
                                else
                                {
                                    return null;
                                }
                            } // END USING (HttpContent)
                        }
                        else
                        {
                            var errorMsg = await ShowHttpError(response);
                            Console.WriteLine(errorMsg);
                            return null;
                        }
                    } // END USING (HttpResponseMessage)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP POST Call to get the ECGridOS SessionInfo
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>Task SessionInfo: ECGridOS_Soap_Service Class SessionInfo - User Session information</returns>
        public static async Task<SessionInfo> SessionInfoHttpPostAsync(string APIKey)
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(APIKey))
                {
                    // Parameters to use for POST
                    var parameters = new Dictionary<string, string> { { "SessionID", APIKey } };

                    using (HttpResponseMessage response = await new HttpClient().PostAsync("https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI", new FormUrlEncodedContent(parameters)))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            using (HttpContent content = response.Content)
                            {
                                // Read content into a string - can use ReadAsStreamAync() for streams.
                                string soapResult = await content.ReadAsStringAsync();
                                if (soapResult != null)
                                {
                                    // Deserialize to ECGridOS_Soap_Service Class SessionInfo Object
                                    SessionInfo sessionResult;
                                    using (var stringreader = new StringReader(soapResult))
                                    {
                                        var serializer = new XmlSerializer(typeof(SessionInfo), "http://ecgridos.net/");
                                        sessionResult = (SessionInfo)serializer.Deserialize(stringreader);
                                    }
                                    return sessionResult;
                                }
                                else
                                {
                                    return null;
                                }
                            } // END USING (HttpContent)
                        }
                        else
                        {
                            var errorMsg = await ShowHttpError(response);
                            Console.WriteLine(errorMsg);
                            return null;
                        }
                    } // END USING (HttpResponseMessage)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP POST Call to get the ECGridOS SessionInfo
        /// Uses private variable for APIKey - must be set prior to calling
        /// </summary>
        /// <returns>Task XElement: User Session information as XML</returns>
        public static async Task<XElement> SessionInfoHttpPostAsyncXML()
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(_apiKey))
                {
                    // Parameters to use for POST
                    var parameters = new Dictionary<string, string> { { "SessionID", _apiKey } };

                    using (HttpResponseMessage response = await new HttpClient().PostAsync("https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI", new FormUrlEncodedContent(parameters)))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            using (HttpContent content = response.Content)
                            {
                                // Read content into a string - can use ReadAsStreamAync() for streams.
                                string soapResult = await content.ReadAsStringAsync();

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
                            } // END USING (HttpContent)
                        }
                        else
                        {
                            var errorMsg = await ShowHttpError(response);
                            Console.WriteLine(errorMsg);
                            return null;
                        }
                    } // END USING (HttpResponseMessage)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP POST Call to get the ECGridOS SessionInfo
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>Task XElement: User Session information as XML</returns>
        public static async Task<XElement> SessionInfoHttpPostAsyncXML(string APIKey)
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(APIKey))
                {
                    // Parameters to use for POST
                    var parameters = new Dictionary<string, string> { { "SessionID", APIKey } };

                    using (HttpResponseMessage response = await new HttpClient().PostAsync("https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI", new FormUrlEncodedContent(parameters)))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            using (HttpContent content = response.Content)
                            {
                                // Read content into a string - can use ReadAsStreamAync() for streams.
                                string soapResult = await content.ReadAsStringAsync();
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
                            } // END USING (HttpContent)
                        }
                        else
                        {
                            var errorMsg = await ShowHttpError(response);
                            Console.WriteLine(errorMsg);
                            return null;
                        }
                    } // END USING (HttpResponseMessage)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP POST Call to get the ECGridOS SessionInfo
        /// Uses private variable for APIKey - must be set prior to calling
        /// </summary>
        /// <returns>Task JArray: User Session information as JSON</returns>
        public static async Task<JArray> SessionInfoHttpPostAsyncJSON()
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(_apiKey))
                {
                    // Parameters to use for POST
                    var parameters = new Dictionary<string, string> { { "SessionID", _apiKey } };

                    using (HttpResponseMessage response = await new HttpClient().PostAsync("https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI", new FormUrlEncodedContent(parameters)))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            using (HttpContent content = response.Content)
                            {
                                // Read content into a string - can use ReadAsStreamAync() for streams.
                                string soapResult = await content.ReadAsStringAsync();
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
                            } // END USING (HttpContent)
                        }
                        else
                        {
                            var errorMsg = await ShowHttpError(response);
                            Console.WriteLine(errorMsg);
                            return null;
                        }
                    } // END USING (HttpResponseMessage)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
            }
            catch (Exception Ex)
            {
                // Catch Everything Else
                Console.WriteLine($"{Ex.Message}");
                return null;
            }
        } // END METHOD

        /// <summary>
        /// Asynchonous HTTP POST Call to get the ECGridOS SessionInfo
        /// </summary>
        /// <param name="APIKey">String APIKey/SessionID in GUID Format for ECGridOS</param>
        /// <returns>Task JArray: User Session information as JSON</returns>
        public static async Task<JArray> SessionInfoHttpPostAsyncJSON(string APIKey)
        {
            try
            {
                // Check to make sure it is in valid Guid Format
                if (IsValidGUID(APIKey))
                {
                    // Parameters to use for POST
                    var parameters = new Dictionary<string, string> { { "SessionID", APIKey } };

                    using (HttpResponseMessage response = await new HttpClient().PostAsync("https://ecgridos.net/v3.2/prod/ECGridOS.asmx/WhoAmI", new FormUrlEncodedContent(parameters)))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            using (HttpContent content = response.Content)
                            {
                                // Read content into a string - can use ReadAsStreamAync() for streams.
                                string soapResult = await content.ReadAsStringAsync();
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
                            } // END USING (HttpContent)
                        }
                        else
                        {
                            var errorMsg = await ShowHttpError(response);
                            Console.WriteLine(errorMsg);
                            return null;
                        }
                    } // END USING (HttpResponseMessage)
                }
                else
                {
                    throw new Exception("Invalid GUID API Key");
                }
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

        #region Exception Handling

        /// <summary>
        /// Error handling to get the ECGridOS Error Result or system error
        /// </summary>
        /// <param name="ex">FaultException: Thrown from Service call in Catch Block</param>
        /// <returns>String: Error Message or ECGridOS Error Message</returns>
        public static string ShowSoapError(FaultException ex)
        {
            // Get the response/exception XML and parse if it is a ECGridOS API Error
            StringBuilder message = new StringBuilder(Environment.NewLine);
            var messageFault = ex.CreateMessageFault();
            if (messageFault.HasDetail)
            {
                // This picks up ECGridOS generated SOAP Exceptions
                XElement xElem = messageFault.GetDetail<XElement>();
                message.Append($"SOAP Exception: ({xElem.Element("ErrorCode").Value}) {xElem.Element("ErrorString").Value} {Environment.NewLine}");
                message.Append($"    Error Item: {xElem.Element("ErrorItem").Value}{Environment.NewLine}");
                message.Append($"           Msg: {xElem.Element("ErrorMessage").Value}{Environment.NewLine}");
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
        public async static Task<string> ShowHttpError(HttpResponseMessage responseEx)
        {
            // Get the response/exception XML and parse if it is a ECGridOS API Error
            StringBuilder message = new StringBuilder(Environment.NewLine);
            var content = await responseEx.Content.ReadAsStringAsync();
            message.Append($"Http Exception: ({Convert.ToInt32(responseEx.StatusCode).ToString()}) {responseEx.ReasonPhrase} {Environment.NewLine}");
            message.Append($"           Msg: {content}{Environment.NewLine}");

            return message.ToString();

        } // END METHOD

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

    } // END CLASS
} // END NAMESPACE
