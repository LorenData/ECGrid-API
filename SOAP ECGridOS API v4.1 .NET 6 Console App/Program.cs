/*
 * ECGridOS API Console App Example for .NET 6
 * Copyright: Loren Data Corp.
 * Last Updated: 09/28/2022
 * Author: Greg Kolinski
 * Description: Example Calls to provide users with a basic example of using the ECGridOS API Service with .NET 6 Projects
 * Examples are not production ready and you will need to impliment your own best practices.

 * Provided as Example only
 * 
 * Only Covers Connecting Via SOAP
 * https://learn.microsoft.com/en-us/dotnet/framework/wcf/feature-details/generating-a-wcf-client-from-service-metadata
 * 
 * Example uses 2 Nuget Packages
 * 
 * System.ServiceModel.Primitives
 * System.ServiceModel.Http
 * 
 */

using ECGridOSAPI_ConsoleApp_Example_DotNet6;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Use the SecretManager or keep/reference the APIKey somewhere secure, we do not recommend having the key in your source code. 
string MyAPIKey = "FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF";

// Set Your APIKey in the Client
ECGridOSAPIv4_1_SOAP_Client.APIKey = MyAPIKey;

// Check if the EGridOS API is running
string APIVersion = ECGridOSAPIv4_1_SOAP_Client.Version();
if(!string.IsNullOrEmpty(APIVersion))
{
    Console.WriteLine($"ECGridOS API is Running: {APIVersion}");
}

// Check that My API Key can access a persistant session.
SessionInfo sessionInfo = ECGridOSAPIv4_1_SOAP_Client.SessionInfoAsync().Result;
if(!string.IsNullOrEmpty(sessionInfo.SessionID))
{
    Console.WriteLine($"ECGridOS API has a persistant Session ID: {sessionInfo.SessionID}");
}

// Check if there are any Inbound Files to Download
ParcelIDInfoCollection parcelPending = ECGridOSAPIv4_1_SOAP_Client.ParcelInbox();

// Check for Pending Documents to Download
if(parcelPending != null && parcelPending.TotalRecords > 0)
{
    // Do For Each File
    foreach (ParcelIDInfo parcel2Download in parcelPending.ParcelIDInfoList)
    {
        long parcelID = parcel2Download.ParcelID;

        // Download the File
        FileInfo file2Save = ECGridOSAPIv4_1_SOAP_Client.ParcelDownload(parcelID);
        if(file2Save != null)
        {
            // Make the Filename
            string fileName = Path.Combine("c:/temp/download", file2Save.FileName);
            
            // Write to File however you want
            File.WriteAllBytes(fileName, file2Save.Content);

            // File was written
            if (File.Exists(fileName))
            {
                // Confirm that the File was Download and remove it from the Pending List on ECGridOS
                if (ECGridOSAPIv4_1_SOAP_Client.ParcelDownloadConfirm(parcelID))
                {
                    Console.WriteLine($"ECGridOS API File Downloaded and written to disk: {fileName}");
                }
            }
        }
    }
}

// Upload Files to ECGridOS API
string file2Upload = Path.Combine("c:/temp/upload", "Upload.edi");
string FilenameNoPath = Path.GetFileName(file2Upload);
byte[] contents2Upload = File.ReadAllBytes(file2Upload);

// Convert to Base64 String for ParcelUploadA
string contentsBase64 = Convert.ToBase64String(contents2Upload);

int returnedParcelID = ECGridOSAPIv4_1_SOAP_Client.ParcelUploadA(FilenameNoPath, contentsBase64);

// Check the File Was Uploaded
if(returnedParcelID > 0)
{
    Console.WriteLine($"ECGridOS API File Uploaded: {FilenameNoPath}");
}
