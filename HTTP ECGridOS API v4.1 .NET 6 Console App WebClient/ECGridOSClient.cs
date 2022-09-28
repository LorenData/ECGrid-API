using System.Net;
using System.Text;
using System.Xml.Serialization;

/*
 * ECGridOSClient
 * Copyright: Loren Data Corp.
 * Last Updated: 09/28/2022
 * Author: Greg Kolinski
 * Description: Example ECGridOS API HTTP WebClient to make calls to the ECGridOS API
 *
 * This is starter template to use along with the ECGridOS_Classes for your reference.
 * Provided as Example only, is not Production Code.
 * 
 * Only Covers Connecting Via HTTP POST
 * 
 * Please Note WebClient is deprecated in .NET 6 and not recommended. This is an example for backwards compatability reference only.
 * https://learn.microsoft.com/en-us/dotnet/core/compatibility/networking/6.0/webrequest-deprecated
 * 
 */

/// <summary>
/// ECGridOS Client Service
/// </summary>
public class ECGridOSClient
{
    #region Class Variables

    private readonly string domain_name = "https://os.ecgrid.io/";

    #endregion

    #region Parcel

    public FileInfo ParcelDownload(string sessionID, long parcelID)
    {
        try
        {
            // Define URL
            string URI = "https://os.ecgrid.io/v4.1/prod/ECGridOS.asmx/ParcelDownload";
            string responsebody = "";

#pragma warning disable SYSLIB0014 // Type or member is obsolete
            using (WebClient client = new WebClient())
            {
                // Set Headers
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

                var requestParm = new System.Collections.Specialized.NameValueCollection();
                requestParm.Add("SessionID", sessionID);
                requestParm.Add("ParcelID", parcelID.ToString());

                byte[] responsebytes = client.UploadValues(URI, "POST", requestParm);
                responsebody = Encoding.UTF8.GetString(responsebytes);
            }
#pragma warning restore SYSLIB0014 // Type or member is obsolete

            if (!string.IsNullOrEmpty(responsebody))
            {
                using (TextReader reader = new StringReader(responsebody))
                {
                    var serializer = new XmlSerializer(typeof(FileInfo), domain_name);
                    return (FileInfo)serializer.Deserialize(reader);
                }
            }
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public bool ParcelDownloadConfirm(string sessionID, long parcelID)
    {
        try
        {
            // Define URL
            string URI = "https://os.ecgrid.io/v4.1/prod/ECGridOS.asmx/ParcelDownloadConfirm";
            string responsebody = "";

#pragma warning disable SYSLIB0014 // Type or member is obsolete
            using (WebClient client = new WebClient())
            {
                // Set Headers
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

                var requestParm = new System.Collections.Specialized.NameValueCollection();
                requestParm.Add("SessionID", sessionID);
                requestParm.Add("ParcelID", parcelID.ToString());

                byte[] responsebytes = client.UploadValues(URI, "POST", requestParm);
                responsebody = Encoding.UTF8.GetString(responsebytes);
            }
#pragma warning restore SYSLIB0014 // Type or member is obsolete

            if (!string.IsNullOrEmpty(responsebody))
            {
                using (TextReader reader = new StringReader(responsebody))
                {
                    var serializer = new XmlSerializer(typeof(bool), domain_name);
                    return (bool)serializer.Deserialize(reader);
                }
            }
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public ParcelIDInfoCollection ParcelInBox(string sessionID)
    {
        try
        {
            // Define URL
            string URI = "https://os.ecgrid.io/v4.1/prod/ECGridOS.asmx/ParcelInBox";
            string responsebody = "";

#pragma warning disable SYSLIB0014 // Type or member is obsolete
            using (WebClient client = new WebClient())
            {
                // Set Headers
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

                var requestParm = new System.Collections.Specialized.NameValueCollection();
                requestParm.Add("SessionID", sessionID);

                byte[] responsebytes = client.UploadValues(URI, "POST", requestParm);
                responsebody = Encoding.UTF8.GetString(responsebytes);
            }
#pragma warning restore SYSLIB0014 // Type or member is obsolete

            if (!string.IsNullOrEmpty(responsebody))
            {
                using (TextReader reader = new StringReader(responsebody))
                {
                    var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                    return (ParcelIDInfoCollection)serializer.Deserialize(reader);
                }
            }
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public int ParcelUploadA(string sessionID, string fileName, string contentBase64)
    {
        try
        {
            // Define URL
            string URI = "https://os.ecgrid.io/v4.1/prod/ECGridOS.asmx/ParcelUploadA";
            string responsebody = "";

#pragma warning disable SYSLIB0014 // Type or member is obsolete
            using (WebClient client = new WebClient())
            {
                // Set Headers
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

                var requestParm = new System.Collections.Specialized.NameValueCollection();
                requestParm.Add("SessionID", sessionID);
                requestParm.Add("FileName", fileName);
                requestParm.Add("ContentBase64", contentBase64);

                byte[] responsebytes = client.UploadValues(URI, "POST", requestParm);
                responsebody = Encoding.UTF8.GetString(responsebytes);
            }
#pragma warning restore SYSLIB0014 // Type or member is obsolete

            if (!string.IsNullOrEmpty(responsebody))
            {
                using (TextReader reader = new StringReader(responsebody))
                {
                    var serializer = new XmlSerializer(typeof(int), domain_name);
                    return (int)serializer.Deserialize(reader);
                }
            }
            return -1;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    #endregion

    #region Version, WhoAmI, X400Format

    /// <summary>
    /// ECGridOS Version API Call
    /// </summary>
    /// <returns>string - ECGridOS Version Info</returns>
    public string Version()
    {
        try
        {
            // Define URL
            string URI = "https://os.ecgrid.io/v4.1/prod/ECGridOS.asmx/Version";
            string responsebody = "";

#pragma warning disable SYSLIB0014 // Type or member is obsolete
            using (WebClient client = new WebClient())
            {
                // Set Headers
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

                var requestParm = new System.Collections.Specialized.NameValueCollection();
                //requestParm.Add("param1", "<any> kinds & of = ? strings");
                //requestParm.Add("param2", "escaping is already handled");
                byte[] responsebytes = client.UploadValues(URI, "POST", requestParm);
                responsebody = Encoding.UTF8.GetString(responsebytes);
            }
#pragma warning restore SYSLIB0014 // Type or member is obsolete

            if(!string.IsNullOrEmpty(responsebody))
            {
                using (TextReader reader = new StringReader(responsebody))
                {
                    var serializer = new XmlSerializer(typeof(string), domain_name);
                    return (string)serializer.Deserialize(reader);
                }
            }

            return String.Empty;

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return String.Empty;
        }
    }

    /// <summary>
    /// ECGridOS WhoAmI API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <returns>SessionInfo</returns>
    public SessionInfo WhoAmI(string sessionID)
    {
        try
        {
            // Define URL
            string URI = "https://os.ecgrid.io/v4.1/prod/ECGridOS.asmx/WhoAmI";
            string responsebody = "";

#pragma warning disable SYSLIB0014 // Type or member is obsolete
            using (WebClient client = new WebClient())
            {
                // Set Headers
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

                var requestParm = new System.Collections.Specialized.NameValueCollection();
                requestParm.Add("SessionID", sessionID);

                byte[] responsebytes = client.UploadValues(URI, "POST", requestParm);
                responsebody = Encoding.UTF8.GetString(responsebytes);
            }
#pragma warning restore SYSLIB0014 // Type or member is obsolete

            if (!string.IsNullOrEmpty(responsebody))
            {
                using (TextReader reader = new StringReader(responsebody))
                {
                    var serializer = new XmlSerializer(typeof(SessionInfo), domain_name);
                    return (SessionInfo)serializer.Deserialize(reader);
                }
            }
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    #endregion
}