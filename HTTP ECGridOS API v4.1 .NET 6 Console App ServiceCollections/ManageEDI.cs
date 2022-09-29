using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTP_ECGridOS_API_v4._1_.NET_6_Console_App_ServiceCollections;

internal interface IManageEDI
{
    Task<string> CheckECGridOSIsRunning();

    Task<string> CheckECGridOSSession(string APIKey);

    Task<int> DownloadFiles(string APIKey);

    Task<int> UploadloadFile(string APIKey);
}

internal class ManageEDI : IManageEDI
{
    #region Class Variables

    private readonly IECGridOSClient _ECGridOSClient;

    #endregion

    #region Constructor

    public ManageEDI(IECGridOSClient ECGridOSClient)
    {
        _ECGridOSClient = ECGridOSClient;
    }

    #endregion

    public async Task<string> CheckECGridOSIsRunning()
    {
        // Check if the EGridOS API is running
        string ecgridos_version = await _ECGridOSClient.Version();
        if (!string.IsNullOrEmpty(ecgridos_version))
        {
            return $"ECGridOS API is Running: {ecgridos_version}";
        }

        return String.Empty;
    }

    public async Task<string> CheckECGridOSSession(string APIKey)
    {
        // Check that My API Key can access a persistant session.
        SessionInfo sessionInfo = await _ECGridOSClient.WhoAmI(APIKey);
        if (!string.IsNullOrEmpty(sessionInfo.SessionID))
        {
            Console.WriteLine($"ECGridOS API has a persistant Session ID: {sessionInfo.SessionID}");
        }

        return String.Empty;
    }

    public async Task<int> DownloadFiles(string APIKey)
    {
        int downloadedFiles = 0;

        // Check if there are any Inbound Files to Download
        ParcelIDInfoCollection parcelPending = await _ECGridOSClient.ParcelInBox(APIKey);

        // Check for Pending Documents to Download
        if (parcelPending != null && parcelPending.TotalRecords > 0)
        {
            // Do For Each File
            foreach (ParcelIDInfo parcel2Download in parcelPending.ParcelIDInfoList)
            {
                long parcelID = parcel2Download.ParcelID;

                // Download the File
                FileInfo file2Save = await _ECGridOSClient.ParcelDownload(APIKey, parcelID);
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
                        if (await _ECGridOSClient.ParcelDownloadConfirm(APIKey, parcelID))
                        {
                            Console.WriteLine($"ECGridOS API File Downloaded and written to disk: {fileName}");
                            downloadedFiles++;
                        }
                    }
                }
            }
        }

        return downloadedFiles;
    }

    public async Task<int> UploadloadFile(string APIKey)
    {
        // Upload File to ECGridOS API
        string file2Upload = Path.Combine("c:/temp/upload", "Upload.edi");
        string FilenameNoPath = Path.GetFileName(file2Upload);
        byte[] contents2Upload = File.ReadAllBytes(file2Upload);

        // Upload A File
        int returnedParcelID = await _ECGridOSClient.ParcelUpload(APIKey, FilenameNoPath, contents2Upload.Length, contents2Upload);

        // Check the File Was Uploaded
        if (returnedParcelID > 0)
        {
            Console.WriteLine($"ECGridOS API File Uploaded: {FilenameNoPath}");
            return returnedParcelID;
        }

        return -1;
    }
}
