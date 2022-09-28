/*
 * ECGridOS API Console App Example for .NET 6
 * Copyright: Loren Data Corp.
 * Last Updated: 09/28/2022
 * Author: Greg Kolinski
 * Description: Example Calls to provide users with a basic example of using the ECGridOS API Service with .NET 6 Projects
 * Examples are not production ready and you will need to impliment your own best practices.
 * Provided as Example only
 * 
 * Only Covers Connecting Via HTTP POST
 * 
 * Please Note WebClient is deprecated in .NET 6 and not recommended by Microsoft. This is an example for backwards compatability reference only.
 * https://learn.microsoft.com/en-us/dotnet/core/compatibility/networking/6.0/webrequest-deprecated
 * 
 */

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Initialize the Client
ECGridOSClient ecgridClient = new ECGridOSClient();

// Use the SecretManager or keep/reference the APIKey somewhere secure, we do not recommend having the key in your source code. 
string MyAPIKey = "FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF";

// Check if the EGridOS API is running
string ecgridos_version = ecgridClient.Version();
if (!string.IsNullOrEmpty(ecgridos_version))
{
    Console.WriteLine($"ECGridOS API is Running: {ecgridos_version}");
}

// Check that My API Key can access a persistant session.
SessionInfo sessionInfo = ecgridClient.WhoAmI(MyAPIKey);
if (!string.IsNullOrEmpty(sessionInfo.SessionID))
{
    Console.WriteLine($"ECGridOS API has a persistant Session ID: {sessionInfo.SessionID}");
}

// Check if there are any Inbound Files to Download
ParcelIDInfoCollection parcelPending = ecgridClient.ParcelInBox(MyAPIKey);

// Check for Pending Documents to Download
if (parcelPending != null && parcelPending.TotalRecords > 0)
{
    // Do For Each File
    foreach (ParcelIDInfo parcel2Download in parcelPending.ParcelIDInfoList)
    {
        long parcelID = parcel2Download.ParcelID;

        // Download the File
        FileInfo file2Save = ecgridClient.ParcelDownload(MyAPIKey, parcelID);
        if (file2Save != null)
        {
            // Save Base64 String
            string FileAsBase64 = file2Save.ContentBase64String;

            // Make the Filename
            string fileName = Path.Combine("c:/temp/download", file2Save.FileName);

            // Write to File however you want
            File.WriteAllBytes(fileName, file2Save.Content);

            // File was written
            if (File.Exists(fileName))
            {
                // Confirm that the File was Download and remove it from the Pending List on ECGridOS
                if (ecgridClient.ParcelDownloadConfirm(MyAPIKey, parcelID))
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

// Upload A File
int returnedParcelID = ecgridClient.ParcelUploadA(MyAPIKey, FilenameNoPath, contentsBase64);

// Check the File Was Uploaded
if (returnedParcelID > 0)
{
    Console.WriteLine($"ECGridOS API File Uploaded: {FilenameNoPath}");
}