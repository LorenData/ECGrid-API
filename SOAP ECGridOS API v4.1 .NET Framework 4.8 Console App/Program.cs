using SOAP_ECGridOS_API_v4._1.NET_4._8_Console_App.io.ecgrid.os;

using System;
using System.IO;

/*
 * ECGridOS_Examples_Main
 * Copyright: Loren Data Corp.
 * Last Updated: 09/28/2022
 * Author: Greg Kolinski
 * Description: Example Calls to provide users with a basic example of using the ECGridOS API Service with .NET Framework Projects
 * Examples are not production ready and you will need to impliment your own best practices.
 * 
 * Please make note it uses the Service Reference for ECGridOS - Use Advanced with a Web Reference
 *  net.ecgridos
 *  
 * Provided as Example only
 */
namespace SOAP_ECGridOS_API_v4._1.NET_4._8_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Use the SecretManager or keep/reference the APIKey somewhere secure, we do not recommend having the key in your source code. 
            string MyAPIKey = "FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF";

            // Set Your APIKey in the Client
            // Instantiate ECGridOSAPI Class & Set Your APIKey in the Client
            ECGridOSAPIv4 ECGridClient = new ECGridOSAPIv4();

            // Check if the EGridOS API is running
            string APIVersion = ECGridClient.Version();
            if (!string.IsNullOrEmpty(APIVersion))
            {
                Console.WriteLine($"ECGridOS API is Running: {APIVersion}");
            }

            // Check that My API Key can access a persistant session.
            SessionInfo sessionInfo = ECGridClient.WhoAmI(MyAPIKey);
            if (!string.IsNullOrEmpty(sessionInfo.SessionID))
            {
                Console.WriteLine($"ECGridOS API has a persistant Session ID: {sessionInfo.SessionID}");
            }

            // Check if there are any Inbound Files to Download
            ParcelIDInfoCollection parcelPending = ECGridClient.ParcelInBox(MyAPIKey);

            // Check for Pending Documents to Download
            if (parcelPending != null && parcelPending.TotalRecords > 0)
            {
                // Do For Each File
                foreach (ParcelIDInfo parcel2Download in parcelPending.ParcelIDInfoList)
                {
                    long parcelID = parcel2Download.ParcelID;

                    // Download the File
                    io.ecgrid.os.FileInfo file2Save = ECGridClient.ParcelDownload(MyAPIKey, parcelID);
                    if (file2Save != null)
                    {
                        // Make the Filename
                        string fileName = Path.Combine("c:/temp/download", file2Save.FileName);

                        // Write to File however you want
                        File.WriteAllBytes(fileName, file2Save.Content);

                        // File was written
                        if (File.Exists(fileName))
                        {
                            // Confirm that the File was Download and remove it from the Pending List on ECGridOS
                            if (ECGridClient.ParcelDownloadConfirm(MyAPIKey, parcelID))
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

            int returnedParcelID = ECGridClient.ParcelUploadA(MyAPIKey,FilenameNoPath, contentsBase64);

            // Check the File Was Uploaded
            if (returnedParcelID > 0)
            {
                Console.WriteLine($"ECGridOS API File Uploaded: {FilenameNoPath}");
            }

        }
    }
}
