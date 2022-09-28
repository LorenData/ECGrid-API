using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml.Linq;

namespace ECGridOSAPI_ConsoleApp_Example_DotNet6;

/*
 * ECGridOS_Client
 * Copyright: Loren Data Corp.
 * Last Updated: 09/28/2022
 * Author: Greg Kolinski
 * Description: Example ECGridOS API SOAP Client to make calls to the ECGridOS API using the ECGridOSAPIv4_1_SOAP_Service
 *
 * This is starter template to use along with the ECGridOSAPIv4_1_SOAP_Service.cs interface for your reference.
 * Provided as Example only, is not Production Code.
 * 
 * System.ServiceModel.Http
 */


internal class ECGridOSAPIv4_1_SOAP_Client
{
    #region Class Properties

    /// The following steps are normally configured for you when you add a web reference in the .NET framework
    /// At the time of writting this .NET Core does not currently allow for "SOAP Web References/WCF" only currently supporting REST services

    /// <summary>
    /// Binding Type for the ECgridOS API Service
    /// </summary>
    private static Binding binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);

    /// <summary>
    /// Channel Creation to the ECGridOS API Endpoint using binding 
    /// </summary>
    private static ChannelFactory<IECGridOSAPIv4Soap> factory = new ChannelFactory<IECGridOSAPIv4Soap>(binding, new EndpointAddress("https://os.ecgrid.io/v4.1/prod/ECGridOS.asmx"));

    /// <summary>
    /// Service Client to the ECGridOS API fromthe binded channel
    /// </summary>
    private static IECGridOSAPIv4Soap client = factory.CreateChannel();

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

    #endregion

    #region SessionInfo (WhoAmI)

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

    #endregion

    #region UserInfo

    public static UserIDInfo UserInfo(int userID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(_apiKey))
            {
                // Make the call and return the results
                return client.UserInfo(_apiKey, userID);
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

    public static UserIDInfo UserInfo(string APIKey, int userID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                // Make the call and return the results
                return client.UserInfo(APIKey, userID);
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

    public static async Task<UserIDInfo> UserInfoAsync(int userID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(_apiKey))
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginUserInfo(_apiKey, userID, callback, stateObject), client.EndUserInfo, null);
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

    public static async Task<UserIDInfo> UserInfoAsync(string APIKey, int userID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginUserInfo(APIKey, userID, callback, stateObject), client.EndUserInfo, null);
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

    #endregion

    #region ParcelInbox

    public static ParcelIDInfoCollection ParcelInbox()
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(_apiKey))
            {
                // Make the call and return the results
                return client.ParcelInBox(_apiKey);
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

    public static ParcelIDInfoCollection ParcelInbox(string APIKey)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                // Make the call and return the results
                return client.ParcelInBox(APIKey);
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

    public static async Task<ParcelIDInfoCollection> ParcelInboxAsync()
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(_apiKey))
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginParcelInBox(_apiKey, callback, stateObject), client.EndParcelInBox, null);
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

    public static async Task<ParcelIDInfoCollection> ParcelInboxAsync(string APIKey)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginParcelInBox(APIKey, callback, stateObject), client.EndParcelInBox, null);
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

    #endregion

    #region ParcelDownload

    public static FileInfo ParcelDownload(long parcelID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(_apiKey))
            {
                // Make the call and return the results
                return client.ParcelDownload(_apiKey, parcelID);
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

    public static FileInfo ParcelDownload(string APIKey, long parcelID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                // Make the call and return the results
                return client.ParcelDownload(APIKey, parcelID);
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

    public static async Task<FileInfo> ParcelDownloadAsync(long parcelID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(_apiKey))
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginParcelDownload(_apiKey, parcelID, callback, stateObject), client.EndParcelDownload, null);
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

    public static async Task<FileInfo> ParcelDownloadAsync(string APIKey, long parcelID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginParcelDownload(APIKey, parcelID, callback, stateObject), client.EndParcelDownload, null);
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

    #endregion

    #region ParcelDownloadConfirm

    public static bool ParcelDownloadConfirm(long parcelID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(_apiKey))
            {
                // Make the call and return the results
                return client.ParcelDownloadConfirm(_apiKey, parcelID);
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
            return false;
        }
        catch (Exception Ex)
        {
            // Catch Everything Else
            Console.WriteLine($"{Ex.Message}");
            return false;
        }
    } // END METHOD

    public static bool ParcelDownloadConfirm(string APIKey, long parcelID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                // Make the call and return the results
                return client.ParcelDownloadConfirm(APIKey, parcelID);
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
            return false;
        }
        catch (Exception Ex)
        {
            // Catch Everything Else
            Console.WriteLine($"{Ex.Message}");
            return false;
        }
    } // END METHOD

    public static async Task<bool> ParcelDownloadConfirmAsync(long parcelID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(_apiKey))
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginParcelDownloadConfirm(_apiKey, parcelID, callback, stateObject), client.EndParcelDownloadConfirm, null);
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
            return false;
        }
        catch (Exception Ex)
        {
            // Catch Everything Else
            Console.WriteLine($"{Ex.Message}");
            return false;
        }
    } // END METHOD

    public static async Task<bool> ParcelDownloadConfirmAsync(string APIKey, long parcelID)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginParcelDownloadConfirm(APIKey, parcelID, callback, stateObject), client.EndParcelDownloadConfirm, null);
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
            return false;
        }
        catch (Exception Ex)
        {
            // Catch Everything Else
            Console.WriteLine($"{Ex.Message}");
            return false;
        }
    } // END METHOD

    #endregion

    #region ParcelUploadA

    public static int ParcelUploadA(string fileName, string contentsBase64)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(_apiKey))
            {
                // Make the call and return the results
                return client.ParcelUploadA(_apiKey, fileName, contentsBase64);
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
            return -1;
        }
        catch (Exception Ex)
        {
            // Catch Everything Else
            Console.WriteLine($"{Ex.Message}");
            return -1;
        }
    } // END METHOD

    public static int ParcelUploadA(string APIKey, string fileName, string contentsBase64)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                // Make the call and return the results
                return client.ParcelUploadA(APIKey, fileName, contentsBase64);
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
            return -1;
        }
        catch (Exception Ex)
        {
            // Catch Everything Else
            Console.WriteLine($"{Ex.Message}");
            return -1;
        }
    } // END METHOD

    public static async Task<int> ParcelUploadAAsync(string fileName, string contentsBase64)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(_apiKey))
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginParcelUploadA(_apiKey, fileName, contentsBase64, callback, stateObject), client.EndParcelUploadA, null);
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
            return -1;
        }
        catch (Exception Ex)
        {
            // Catch Everything Else
            Console.WriteLine($"{Ex.Message}");
            return -1;
        }
    } // END METHOD

    public static async Task<int> ParcelUploadAAsync(string APIKey, string fileName, string contentsBase64)
    {
        try
        {
            // Check to make sure it is in valid Guid Format
            if (IsValidGUID(APIKey))
            {
                // Make the call and await the results to return
                var asyncResult = await Task.Factory.FromAsync((callback, stateObject) => client.BeginParcelUploadA(APIKey, fileName, contentsBase64, callback, stateObject), client.EndParcelUploadA, null);
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
            return -1;
        }
        catch (Exception Ex)
        {
            // Catch Everything Else
            Console.WriteLine($"{Ex.Message}");
            return -1;
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

}
