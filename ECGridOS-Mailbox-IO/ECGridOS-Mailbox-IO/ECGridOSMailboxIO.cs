/*
 * ECGridOSMailboxIO
 * Copyright: 2017 Loren Data Corp. All rights reserved.
 * Last Updated: 12/01/2017
 * Description: Console Program to upload and download EDI files to/from a Loren Data Mailbox using ECGridOS API Calls
 * 
 * The following ECGridOS calls are used:
 * 
 *  WhoAmI()
 *  Version()
 *  
 *  ParcelUpload()
 *  ParcelUploadGZip()
 *  ParcelUploadDirected()
 *  ParcelUploadDirectedGZip()
 *  
 *  ParcelInBox()
 *  ParcelInBoxEx()
 *  ParcelDownloadGZip()
 *  ParcelDownloadConfirm()
 *  ParcelDownloadReset()
 * 
 * The following ecgrid:analystics calls are used:
 *  TransactionConfirmByInterchangeId()
 * 
 * 2016-10-12 - Added support for Target confirmations
 * 2017-10-06 - Added ECGridID options for downloads
 * 2017-12-01 - Added Deletion of 0 byte file on upload and automatic compression of file over 100KB
 *              Added GUID Format Validation
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using ECGridOS_API = ECGridOS_Mailbox_IO.net.ecgridos;
using System.Reflection;
using System.Web.Services.Protocols;
using System.Net.Mail;
using System.IO;
using System.IO.Compression;
using System.Xml.Linq;

namespace ECGridOS_Mailbox_IO
{
    /// <summary>
    /// Containing class for the ECGridOS Mailbox IO console program
    /// </summary>
    class ECGridOSMailboxIO
    {
        #region Properties

        // Define Properties
        private static string ErrorContact = "";
        private static int returnValue = 0;
        private static bool targetAnalytics = true;
        private static string assemblyCompany = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company;
        private static string assemblyProduct = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyProductAttribute>().Product;
        private static string assemblyCopyright = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
        private static string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        #endregion

        /// <summary>
        /// Main - Calling Method for the CommandLine to Execute
        /// </summary>
        /// <param name="args">string[]</param>
        /// <returns>integer</returns>
        static int Main(string[] args)
        {
            #region Setup Console Window

            Console.Title = "ECGridOS Mailbox IO";
            Console.WindowHeight = Console.WindowHeight = 60;
            Console.WindowWidth = Console.WindowWidth = 100;

            #endregion

            // Write to Console Window Product Name, Company, and Copyright
            Console.WriteLine("{0} {1:g}", assemblyProduct, DateTime.Now);
            Console.WriteLine("{0} {1}", assemblyCompany, assemblyCopyright);
            Console.WriteLine("");

            // Check for valid argument counts
            if (args.Count() < 3 || args.Count() > 4)
            {
                #region SMTP Arguments

                if(args.Count() == 1)
                {
                    if (args[0].ToLower().StartsWith("-smtpfromname"))
                    {
                        if (args[0].Contains(":"))
                        {
                            string smtpfromname = (args[0].Split(':'))[1];
                            SetAppSetting("SMTPFromName", smtpfromname);
                            Console.WriteLine("Set SMTP From Name: {0}", ConfigurationManager.AppSettings["SMTPFromName"].ToString());
                        }
                    }
                    else if (args[0].ToLower().StartsWith("-smtpfrom"))
                    {
                        if (args[0].Contains(":"))
                        {
                            string smtpfrom = (args[0].Split(':'))[1];
                            SetAppSetting("SMTPFrom", smtpfrom);
                            Console.WriteLine("Set SMTP From: {0}", ConfigurationManager.AppSettings["SMTPFrom"].ToString());
                        }
                    }
                    else if (args[0].ToLower().StartsWith("-smtphost"))
                    {
                        if (args[0].Contains(":"))
                        {
                            string smtphost = (args[0].Split(':'))[1];
                            SetAppSetting("SMTPHost", smtphost);
                            Console.WriteLine("Set SMTP Host: {0}", ConfigurationManager.AppSettings["SMTPHost"].ToString());
                        }
                    }
                    else if (args[0].ToLower().StartsWith("-smtpport"))
                    {
                        if (args[0].Contains(":"))
                        {
                            string smtpport = (args[0].Split(':'))[1];
                            SetAppSetting("SMTPPort", smtpport);
                            Console.WriteLine("Set SMTP Port: {0}", ConfigurationManager.AppSettings["SMTPPort"].ToString());
                        }
                    }
                    else if (args[0].ToLower().StartsWith("-smtpuser"))
                    {
                        if (args[0].Contains(":"))
                        {
                            string smtpuser = (args[0].Split(':'))[1];
                            SetAppSetting("SMTPUserName", smtpuser);
                            Console.WriteLine("Set SMTP User: {0}", ConfigurationManager.AppSettings["SMTPUserName"].ToString());
                        }
                    }
                    else if (args[0].ToLower().StartsWith("-smtppassword"))
                    {
                        if (args[0].Contains(":"))
                        {
                            string smtppassword = (args[0].Split(':'))[1];
                            SetAppSetting("SMTPPassword", smtppassword);
                            Console.WriteLine("Set SMTP Password: {0}", ConfigurationManager.AppSettings["SMTPPassword"].ToString());
                        }
                    }
                    else if (args[0].ToLower().StartsWith("-smtpssl"))
                    {
                        if (args[0].Contains(":"))
                        {
                            string smtppassword = (args[0].Split(':'))[1];
                            SetAppSetting("SMTPSSL", smtppassword);
                            Console.WriteLine("Set SMTP SSL: {0}", ConfigurationManager.AppSettings["SMTPSSL"].ToString());
                        }
                    }
                    else if (args[0].ToLower().StartsWith("-smtpauth"))
                    {
                        if (args[0].Contains(":"))
                        {
                            string smtpauth = (args[0].Split(':'))[1];
                            SetAppSetting("SMTPAuth", smtpauth);
                            Console.WriteLine("Set SMTP Auth: {0}", ConfigurationManager.AppSettings["SMTPAuth"].ToString());
                        }
                    }
                    else if (args[0].ToLower().StartsWith("-timeout"))
                    {
                        if (args[0].Contains(":"))
                        {
                            string smtpauth = (args[0].Split(':'))[1];
                            SetAppSetting("TimeOut", smtpauth);
                            Console.WriteLine("Set Time Out: {0}", ConfigurationManager.AppSettings["TimeOut"].ToString());
                        }
                    }
                    else if (args[0].ToLower().StartsWith("-smtpconfig"))
                    {
                        // Display the current -smtp configuration
                        SMTPConfig();
                        returnValue = 1;
                    }
                    else if (args[0].ToLower().StartsWith("-smtphelp"))
                    {
                        // Display the smtp syntax usage
                        SMTPSyntax();
                        returnValue = 1;
                    }
                }
                else
                {
                    // Invalid argument count displays argument definition and returns true/1
                    Syntax();
                    returnValue = 1;
                }

                #endregion
            }
            else
            {
                // Parse arguments into variables
                string APIKey = args[0];
                if (!IsValidGUID(APIKey)) { throw new Exception("Invalid GUID Format."); }

                string FileDir = args[1];
                bool Upload = false;
                int ECGridIDFrom = -1;
                int ECGridIDTo = -1;
                string errorMessage = "";

                #region Arguments

                // Check the Arguments for options
                for (int i = 2; i <= args.Count() - 1; i++)
                {
                    string argument = args[i];
                    argument = argument.Replace("–", "-"); // Replace em-dash

                    if (argument.ToLower().StartsWith("-upload"))
                    {
                        // Get the optional ECGridIDs for an upload
                        Upload = true;
                        if (argument.Contains(":"))
                        {
                            if (argument.Contains(","))
                            {
                                string ids = (argument.Split(':'))[1];
                                ECGridIDFrom = Convert.ToInt32((ids.Split(','))[0]);
                                ECGridIDTo = Convert.ToInt32((ids.Split(','))[1]);
                            }
                            else
                            {
                                // This is a fix for old code format - allows old : separator
                                ECGridIDFrom = Convert.ToInt32((argument.Split(':'))[1]);
                                ECGridIDTo = Convert.ToInt32((argument.Split(':'))[2]);
                            }
                        }
                    }
                    else if (argument.ToLower().StartsWith("-download"))
                    {
                        // Get the optional ECGridIDs for a download
                        if (argument.Contains(":"))
                        {
                            if (argument.Contains(","))
                            {
                                string ids = (argument.Split(':'))[1];
                                ECGridIDFrom = Convert.ToInt32((ids.Split(','))[0]);
                                ECGridIDTo = Convert.ToInt32((ids.Split(','))[1]);
                            }
                            else
                            {
                                // This is a fix for old code format - allows old : separator
                                ECGridIDFrom = Convert.ToInt32((argument.Split(':'))[1]);
                                ECGridIDTo = Convert.ToInt32((argument.Split(':'))[2]);
                            }
                        }
                    }
                    else if (argument.ToLower().StartsWith("-e:"))
                    {
                        // Get the Error Contact Email
                        ErrorContact = argument.Substring(3).Trim();
                    }

                } // END FOR

                #endregion

                // Try the API Calls and catch and exceptions
                try
                {
                    using (net.ecgridos.ECGridOSAPIv3 ecgridos = new net.ecgridos.ECGridOSAPIv3())
                    {
                        Console.WriteLine("ECGridOS {0}{1}", ecgridos.Version(), Environment.NewLine);
                    }

                    if (Upload)
                    {
                        ECGridOSUpload(APIKey, FileDir, ECGridIDFrom, ECGridIDTo);
                    }
                    else
                    {
                        ECGridOSDownload(APIKey, FileDir, ECGridIDFrom, ECGridIDTo);
                    }

                }
                catch (SoapException SoapEx)
                {
                    //There is good data in the InnerXML which can be parsed and used to processes specific exceptions
                    errorMessage = ShowSoapError(SoapEx);
                }
                catch (Exception ex)
                {
                    if (returnValue == 0) { returnValue = 2; }
                    errorMessage = String.Format("ERROR: {0} {1}{1} {2}", ex.Message, Environment.NewLine, ex.StackTrace);
                    Console.WriteLine(ex.Message);
                }

                // Send the Email to the Error contact if there are Errors and a Error Contact Set
                if (errorMessage.Length > 0 && !String.IsNullOrEmpty(ErrorContact)) { SendError(ErrorContact, errorMessage); }

            } // END IF/ELSE

            return returnValue;

        } // END MAIN

        #region Private Methods

        /// <summary>
        /// Syntax - Write to Console format for Command Line arguments
        /// </summary>
        private static void Syntax()
        {
            Console.WriteLine("Standard Usage");
            Console.WriteLine();
            Console.WriteLine("ECGridOSMailboxIO <APIKey> <LocalDirectory|LocalFile> <-upload|-download> [-e:ErrorContact]");
            Console.WriteLine("   WITH TARGET ANALYTICS - sends analytic information for Target Corporation.");
            Console.WriteLine();
            Console.WriteLine("   APIKey - must be previously registered on ECGridOS");
            Console.WriteLine("   LocalDirectory - the local directory - if upload, all files in the directory");
            Console.WriteLine("                    will be sent.");
            Console.WriteLine("                    Use \"...\" on the command line to allow spaces in the");
            Console.WriteLine("                    LocalDirectory");
            Console.WriteLine("   LocalFile      - a local file for upload only");
            Console.WriteLine("                    Use \"...\" on the command line to allow spaces in the");
            Console.WriteLine("                    LocalFile");
            Console.WriteLine("   -upload[:ECGridIDFrom,ECGridIDTo] - direction of file transfer");
            Console.WriteLine("   -download[:ECGridIDFrom,ECGridIDTo] - direction of file transfer");
            Console.WriteLine("                     Files 100KB or bigger forces compression");
            Console.WriteLine("   -e:ErrorContact - substitute a friendly error message with a contact message");
            Console.WriteLine("                     e.g. \"-e:test@example.com\" ");
            Console.WriteLine("                     Sends to Port 587 TLS on our mail server.");
            Console.WriteLine();
            Console.WriteLine("SMTP Configuration");
            Console.WriteLine();
            Console.WriteLine("ECGridOSMailboxIO <-smtphost:host | -smtpport:port | -smtpssl:true or false | ");
            Console.WriteLine("                  -smtpfrom:from email | -smtpfromname:from name | ");
            Console.WriteLine("                  -smtpauth:true or false | -smtpuser:auth username | -smtppassword:auth password |");
            Console.WriteLine("                  -smtpconfig | -smtphelp>");
            Console.WriteLine();
            Console.WriteLine("   -smtphost:host          - SMTP Host");
            Console.WriteLine("   -smtpport:port          - SMTP Port, default is 25");
            Console.WriteLine("   -smtpssl:boolean        - Use SSL (true or false), default is false");
            Console.WriteLine("   -smtpfrom:from email    - SMTP From Email Address");
            Console.WriteLine("   -smtpfromname:from name - SMTP From Name, default is ECGridOS Mailbox IO");
            Console.WriteLine("                             Use \"...\" on the command line to allow spaces in the");
            Console.WriteLine("   -smtpauth:boolean       - Use SMTP Auth (true or false), default is false");
            Console.WriteLine("   -smtphuser:username     - SMTP Username for AUTH");
            Console.WriteLine("   -smtppassword:password  - SMTP Password for AUTH");
            Console.WriteLine("   -timeout:milliseconds   - HTTP TimeOut Value in milliseconds, default 120000 = 2 min.");
            Console.WriteLine("   -smtphelp               - Shows SMTP options");
            Console.WriteLine("   -smtpconfig             - Show the current SMTP Configuration");
        }

        /// <summary>
        /// Shows the Required Syntax for setting the SMTP Config 
        /// </summary>
        private static void SMTPSyntax()
        {
            Console.WriteLine();
            Console.WriteLine("ECGridOSMailboxIO <-smtphost:host | -smtpport:port | -smtpssl:true or false | ");
            Console.WriteLine("                   -smtpfrom:from email | -smtpfromname:from name | ");
            Console.WriteLine("                   -smtpauth:true or false | -smtpuser:auth username | -smtppassword:auth password>");
            Console.WriteLine();
            Console.WriteLine("   -smtphost:host          - SMTP Host");
            Console.WriteLine("   -smtpport:port          - SMTP Port, default is 25");
            Console.WriteLine("   -smtpssl:boolean        - Use SSL (true or false), default is false");
            Console.WriteLine("   -smtpfrom:from email    - SMTP From Email Address");
            Console.WriteLine("   -smtpfromname:from name - SMTP From Name, default is ECGridOS Mailbox IO");
            Console.WriteLine("                             Use \"...\" on the command line to allow spaces in the");
            Console.WriteLine("   -smtpauth:boolean       - Use SMTP Auth (true or false), default is false");
            Console.WriteLine("   -smtphuser:username     - SMTP Username for AUTH");
            Console.WriteLine("   -smtppassword:password  - SMTP Password for AUTH");
            Console.WriteLine("   -timeout:milliseconds   - HTTP TimeOut Value in milliseconds, default 120000 = 2 min.");
            Console.WriteLine("   -smtphelp               - Shows SMTP options");
            Console.WriteLine("   -smtpconfig             - Show the current SMTP Configuration");
        }

        /// <summary>
        /// Shows the current SMTP Config from the .config file
        /// </summary>
        private static void SMTPConfig()
        {
            Console.WriteLine();
            Console.WriteLine("ECGridOSMailboxIO SMTP Configuration");
            Console.WriteLine("       SMTP Host: {0}", ConfigurationManager.AppSettings["SMTPHost"].ToString());
            Console.WriteLine("       SMTP Port: {0}", ConfigurationManager.AppSettings["SMTPPort"].ToString());
            Console.WriteLine("        SMTP SSL: {0}", ConfigurationManager.AppSettings["SMTPSSL"].ToString());
            Console.WriteLine("       SMTP From: {0}", ConfigurationManager.AppSettings["SMTPFrom"].ToString());
            Console.WriteLine("  SMTP From Name: {0}", ConfigurationManager.AppSettings["SMTPFromName"].ToString());
            Console.WriteLine("       SMTP Auth: {0}", ConfigurationManager.AppSettings["SMTPAuth"].ToString());
            Console.WriteLine("       SMTP User: {0}", ConfigurationManager.AppSettings["SMTPUsername"].ToString());
            Console.WriteLine("   SMTP Password: {0}", ConfigurationManager.AppSettings["SMTPPassword"].ToString());
            Console.WriteLine("        Time Out: {0}", ConfigurationManager.AppSettings["TimeOut"].ToString());
        }

        /// <summary>
        /// Sets new values into the .config file
        /// </summary>
        /// <param name="key">string</param>
        /// <param name="value">string</param>
        private static void SetAppSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// ECGridOSUpload - Uploads a File using ECGridOS ParcelUpload()/ParcelUploadGZip() or ParcelUploadDirected()/ParcelUploadDirectedGZip()
        /// </summary>
        /// <param name="APIKey">string GUID</param>
        /// <param name="FileDir">string</param>
        /// <param name="ECGridIDFrom">integer</param>
        /// <param name="ECGridIDTo">integer</param>
        private static void ECGridOSUpload(string APIKey, string FileDir, int ECGridIDFrom, int ECGridIDTo)
        {
            // Declare variables
            IReadOnlyCollection<string> files;
            int ParcelID;

            // Check if this File or Directory Exists
            if (File.Exists(FileDir) || Directory.Exists(FileDir))
            {
                // Find out if this is a file or directory
                FileAttributes attributes = File.GetAttributes(FileDir);
                if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    // This is a directory
                    files = Directory.GetFiles(FileDir, "*.*", SearchOption.TopDirectoryOnly);
                }
                else
                {
                    // This is a single file
                    files = Directory.GetFiles(Path.GetDirectoryName(FileDir), Path.GetFileName(FileDir), SearchOption.TopDirectoryOnly);
                }
            }
            else
            {
                returnValue = 2;
                throw new IOException("File/Path not found");
            }

            // Check if there are ECGridIDs and Get the SessionInfo if True
            bool isDirected = false;
            ECGridOS_API.SessionInfo whoami = new ECGridOS_API.SessionInfo();
            if (ECGridIDFrom > 0)
            {
                // ECGRIDOS: Set up an reference for the Web Service this requires a Web Reference to https://ecgridos.net/v3.2/prod/ecgridos.asmx
                using (net.ecgridos.ECGridOSAPIv3 ecgridos = new net.ecgridos.ECGridOSAPIv3())
                {
                    ecgridos.Timeout = Convert.ToInt32(ConfigurationManager.AppSettings["TimeOut"].ToString());

                    // ECGRIDOS: ParcelUploadDirected() posts a file to ECGrid wrapped with specified From and To IDs.
                    // The ParcelID can be used as a handle later to get more information about the specific files as it transits the system.
                    ECGridOSConsole("WhoAmI(\"{0}\")", APIKey);
                    whoami = ecgridos.WhoAmI(APIKey);
                    isDirected = true;
                }
            }

            // Upload File(s)
            foreach (string fileName in files)
            {
                //Load the entire file into a string buffer
                byte[] buffer = File.ReadAllBytes(fileName);

                // Check that the file is not empty
                if (buffer.Length <= 0)
                {
                    Console.WriteLine("Deleting Empty File: {0} ....", fileName);
                    File.Delete(fileName);
                    continue;
                }

                Console.WriteLine("Uploading: {0} ....", fileName);

                if (isDirected)
                {
                    // ECGRIDOS: Set up an reference for the Web Service this requires a Web Reference to https://ecgridos.net/v3.2/prod/ecgridos.asmx
                    using (net.ecgridos.ECGridOSAPIv3 ecgridos = new net.ecgridos.ECGridOSAPIv3())
                    {
                        ecgridos.Timeout = Convert.ToInt32(ConfigurationManager.AppSettings["TimeOut"].ToString());
                        ecgridos.EnableDecompression = true;

                        // Check the Size of this file and use GZip compression if it is 1 MB or over
                        /*
                        if (buffer.Length >= 100000)
                        {
                            buffer = GzipCompress(buffer);
                            Console.WriteLine("GZip Compressing File: {0} ....", fileName);

                            // ECGRIDOS: ParcelUploadDirectedGZip() posts a GZip file to ECGrid
                            // The ParcelID can be used as a handle later to get more information about the specific files as it transits the system.
                            ECGridOSConsole("ParcelUploadDirectedGZip(\"{0}\",{1},{2},\"{3}\",{4},{5},{6},{7})", APIKey, whoami.NetworkID, whoami.MailboxID, Path.GetFileName(fileName), buffer.Length, "byte[]", ECGridIDFrom, ECGridIDTo);
                            ParcelID = ecgridos.ParcelUploadDirectedGZip(APIKey, whoami.NetworkID, whoami.MailboxID, Path.GetFileName(fileName), buffer.Length, buffer, ECGridIDFrom, ECGridIDTo);
                        }
                        else
                        {
                        */
                            // ECGRIDOS: ParcelUploadDirected() posts a GZip file to ECGrid
                            // The ParcelID can be used as a handle later to get more information about the specific files as it transits the system.
                            ECGridOSConsole("ParcelUploadDirected(\"{0}\",{1},{2},\"{3}\",{4},{5},{6},{7})", APIKey, whoami.NetworkID, whoami.MailboxID, Path.GetFileName(fileName), buffer.Length, "byte[]", ECGridIDFrom, ECGridIDTo);
                            ParcelID = ecgridos.ParcelUploadDirected(APIKey, whoami.NetworkID, whoami.MailboxID, Path.GetFileName(fileName), buffer.Length, buffer, ECGridIDFrom, ECGridIDTo);
                        //}
                    }
                }
                else
                {
                    // ECGRIDOS: Set up an reference for the Web Service this requires a Web Reference to https://ecgridos.net/v3.2/prod/ecgridos.asmx
                    using (net.ecgridos.ECGridOSAPIv3 ecgridos = new net.ecgridos.ECGridOSAPIv3())
                    {
                        ecgridos.Timeout = Convert.ToInt32(ConfigurationManager.AppSettings["TimeOut"].ToString());
                        ecgridos.EnableDecompression = true;

                        // Check the Size of this file and use GZip compression if it is 1 MB or over
                        if (buffer.Length >= 1000000)
                        {
                            buffer = GzipCompress(buffer);
                            Console.WriteLine("GZip Compressing File: {0} ....", fileName);

                            // ECGRIDOS: ParcelUploadGZip() posts a GZip EDI file to ECGrid
                            // The ParcelID can be used as a handle later to get more information about the specific files as it transits the system.
                            ECGridOSConsole("ParcelUploadGZip(\"{0}\",\"{1}\",{2},{3})", APIKey, Path.GetFileName(fileName), buffer.Length, "byte[]");
                            ParcelID = ecgridos.ParcelUploadGZip(APIKey, Path.GetFileName(fileName), buffer.Length, buffer);
                        }
                        else
                        {
                            // ECGRIDOS: ParcelUpload() posts a EDI file to ECGrid
                            // The ParcelID can be used as a handle later to get more information about the specific files as it transits the system.
                            ECGridOSConsole("ParcelUpload(\"{0}\",\"{1}\",{2},{3})", APIKey, Path.GetFileName(fileName), buffer.Length, "byte[]");
                            ParcelID = ecgridos.ParcelUpload(APIKey, Path.GetFileName(fileName), buffer.Length, buffer);
                        }
                    }

                } // END IF/ELSE

                Console.WriteLine("ParcelID = {0}", ParcelID);

                // Delete the file after a successful upload.
                // Note that the Try/Catch from the calling routine will handle any errors and not delete the file if it doesn't upload
                File.Delete(fileName);

            } // END FOREACH(File)

        } // END METHOD

        /// <summary>
        /// ECGridOSDownload - Downloads Files using ECGridOS ParcelInBox() or ParcelInBoxEx()
        /// </summary>
        /// <param name="APIKey">string GUID</param>
        /// <param name="FileDir">string</param>
        /// <param name="ECGridIDFrom">integer</param>
        /// <param name="ECGridIDTo">integer</param>
        private static void ECGridOSDownload(string APIKey, string FileDir, int ECGridIDFrom, int ECGridIDTo)
        {
            // ECGRIDOS: Set up an reference for the Web Service this requires a Web Reference to https://ecgridos.net/v3.2/prod/ecgridos.asmx
            net.ecgridos.ECGridOSAPIv3 ecgridos = new net.ecgridos.ECGridOSAPIv3();
            ecgridos.EnableDecompression = true;
            long ParcelID;

            // The FileInfo object holds all the info and payload of the downloaded file
            ECGridOS_API.FileInfo FileInfo = new ECGridOS_API.FileInfo();
            ECGridOS_API.ParcelIDInfoCollection Parcels = new ECGridOS_API.ParcelIDInfoCollection();

            // Add trailing slash onto directory
            if (!FileDir.Right(1).Equals(@"\")) { FileDir += "\\"; }

            ECGridOSConsole("WhoAmI(\"{0}\")", APIKey);
            ECGridOS_API.SessionInfo whoami = ecgridos.WhoAmI(APIKey);

            if (ECGridIDFrom > 0)
            {
                ECGridOSConsole("ParcelInBoxEx(\"{0}\",{1},{2},{3},{4})", APIKey, whoami.NetworkID, whoami.MailboxID, ECGridIDFrom, ECGridIDTo);
                Parcels = ecgridos.ParcelInBoxEx(APIKey, whoami.NetworkID, whoami.MailboxID, ECGridIDFrom, ECGridIDTo);
            }
            else
            {
                ECGridOSConsole("ParcelInBox(\"{0}\")", APIKey);
                Parcels = ecgridos.ParcelInBox(APIKey);

            } // END IF/ELSE

            // Try to download each Parcel from the Inbox
            foreach (ECGridOS_API.ParcelIDInfo Parcel in Parcels.ParcelIDInfoList)
            {
                Console.WriteLine("Downloading: {0}  ParcelID: {1}  Bytes: {2}", Parcel.FileName, Parcel.ParcelID, Parcel.ParcelBytes);
                ParcelID = Parcel.ParcelID;

                // Check the Size of this file and use GZip decompression if it is 100 KB or over
                if (Parcel.ParcelBytes <= 100000)
                {
                    // ECGRIDOS: ParcelDownloadGZip() is used to download the File info & content, it returns the FileInfo object
                    ECGridOSConsole("ParcelDownload(\"{0}\",{1})", APIKey, ParcelID);
                    FileInfo = ecgridos.ParcelDownload(APIKey, ParcelID);
                }
                else
                {
                    // ECGRIDOS: ParcelDownloadGZip() is used to download the File info & content, it returns the FileInfo object
                    ECGridOSConsole("ParcelDownloadGZip(\"{0}\",{1})", APIKey, ParcelID);
                    FileInfo = ecgridos.ParcelDownloadGZip(APIKey, ParcelID);
                }

                string errorMessage = "";
                try
                {
                    if (IsGzipCompressed(FileInfo.Content))
                    {
                        byte[] decompressedContent = GzipDecompress(FileInfo.Content);

                        // Write to File to Drive
                        File.WriteAllBytes(Path.Combine(FileDir, FileInfo.FileName), decompressedContent);
                    }
                    else
                    {
                        // Write to File to Drive
                        File.WriteAllBytes(Path.Combine(FileDir, FileInfo.FileName), FileInfo.Content);
                    }

                    ECGridOSConsole("ParcelDownloadConfirm(\"{0}\",{1})", APIKey, ParcelID);
                    ecgridos.ParcelDownloadConfirm(APIKey, ParcelID);

                    Console.WriteLine("Complete.");
                    if (targetAnalytics && whoami.NetworkID == 506) { TargetConfirm(APIKey, Parcel); }
                }
                catch (SoapException SoapEx)
                {
                    // There is good data in the InnerXML which can be parsed and used to processes specific exceptions
                    errorMessage = ShowSoapError(SoapEx);
                    returnValue = 5;
                }
                catch (Exception ex)
                {
                    errorMessage = "ERROR: " + ex.ToString();
                    Console.WriteLine(errorMessage);
                    returnValue = 2;
                }

                // Chck if there are any error messsages
                if (errorMessage.Length > 0)
                {
                    SendError(ErrorContact, errorMessage);
                    ECGridOSConsole("ParcelDownloadReset(\"{0}\",{1})", APIKey, ParcelID);

                    try
                    {
                        // Reset the Download if error 
                        ecgridos.ParcelDownloadReset(APIKey, ParcelID);
                        Console.WriteLine("error: download reset.");
                    }
                    catch (SoapException SoapEx)
                    {
                        errorMessage = ShowSoapError(SoapEx);
                    }

                } // END IF

            } // END FOREACH

        } // END METHOD

        #region Target Analytics

        /// <summary>
        /// targetConfirm - Uses Traget Analytics to confirm if Parcel interchange is 850 or 860
        /// </summary>
        /// <param name="APIKey">string GUID</param>
        /// <param name="Parcel">ECGridOS_API.ParcelIDInfo</param>
        private static void TargetConfirm(string APIKey, ECGridOS_API.ParcelIDInfo Parcel)
        {
            // Check for each interchange in the parcel
            foreach (ECGridOS_API.InterchangeIDInfo interchange in Parcel.Interchanges)
            {
                string errorMessage = "";

                // See if it is from Target - NetworkID:=506 and if it is an 850 or 860
                try
                {
                    if (interchange.NetworkIDFrom == 506 && (("+" + interchange.DocumentType).Contains("+850:") || ("+" + interchange.DocumentType).Contains("+860:")))
                    {
                        using (com.ecgrid.analytics.ECGridAnalytics analytics = new com.ecgrid.analytics.ECGridAnalytics())
                        {
                            com.ecgrid.analytics.TransStatus response = analytics.TransactionConfirmByInterchangeId(APIKey, Convert.ToInt32(interchange.InterchangeID), com.ecgrid.analytics.ConfirmationEvent.MailboxPickedUp, com.ecgrid.analytics.DelayCode.Normal, "");
                            AnalyticsConsole("TransactionConfirmByInterchangeID(\"{0}\",{1},{2},{3},\"{4}\")", APIKey, interchange.InterchangeID, com.ecgrid.analytics.ConfirmationEvent.MailboxPickedUp, com.ecgrid.analytics.DelayCode.Normal, "");
                            Console.WriteLine("Target: {0}", response);
                        }
                    }
                }
                catch (Exception ex)
                {
                    errorMessage = "Target Confirm ERROR: " + ex.ToString();
                }
            } // END FOREACH

        } // END METHOD

        #endregion

        #region Console Messages

        /// <summary>
        /// ecgridosconsole
        /// </summary>
        /// <param name="str">string </param>
        /// <param name="a">Parameter Array of Objects</param>
        private static void ECGridOSConsole(string str, params object[] a)
        {
            ConsoleColor cColor = Console.ForegroundColor;
            string APICommand = String.Format(str, a);
            Console.Write("ecgridos.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(APICommand.Left(APICommand.IndexOf("(")));
            Console.ForegroundColor = cColor;
            Console.WriteLine(APICommand.Mid(APICommand.IndexOf("(")));
        } // END METHOD

        /// <summary>
        /// analyticsconsole
        /// </summary>
        /// <param name="str">string </param>
        /// <param name="a">Parameter Array of Objects</param>
        private static void AnalyticsConsole(string str, params object[] a)
        {
            ConsoleColor cColor = Console.ForegroundColor;
            string APICommand = String.Format(str, a);
            Console.Write("analytics.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(APICommand.Left(APICommand.IndexOf("(")));
            Console.ForegroundColor = cColor;
            Console.WriteLine(APICommand.Mid(APICommand.IndexOf("(")));
        } // END METHOD

        #endregion

        #region Error Handling

        /// <summary>
        ///Catch ECGridOS and Native Soap Exceptions
        /// Parses XML to get Error Detail Information
        /// </summary>
        /// <param name="ex">SoapException</param>
        /// <returns>String</returns>
        private static string ShowSoapError(SoapException ex)
        {
            // Get the response/exception XML and parse
            StringBuilder message = new StringBuilder(Environment.NewLine);
            XElement xmlElem = XElement.Parse(ex.Detail.OuterXml);

            if (xmlElem.HasElements && xmlElem != null)
            {
                XElement errorNode = xmlElem.Element("ErrorInfo");

                // This picks up ECGridOS generated SOAP Exceptions
                message.Append(String.Format("SOAP Exception: ({0}) {1} {2}", errorNode.Element("ErrorCode").Value, errorNode.Element("ErrorString").Value, Environment.NewLine));
                message.Append(String.Format("    Error Item: {0}{1}", errorNode.Element("ErrorItem").Value, Environment.NewLine));
                message.Append(String.Format("           Msg: {0}{1}", errorNode.Element("ErrorMessage").Value, Environment.NewLine));
            }
            else
            {
                // This picks up Framework generated SOAP Exceptions
                message.Append(String.Format("ERROR: {0} {1}{1} {2}", ex.Message, Environment.NewLine, ex.StackTrace));
            }

            Console.WriteLine(message.ToString());
            return message.ToString();

        } // END METHOD

        /// <summary>
        /// Emails the error message via SMTP to the contact email address in the command line arguments
        /// </summary>
        /// <param name="contact">string</param>
        /// <param name="errorMessage">string</param>
        private static void SendError(string contact, string errorMessage)
        {
            if (contact.Length == 0) { return; }

            try
            {
                StringBuilder config = new StringBuilder().Append(String.Format("Config: {0}{0}", Environment.NewLine));
                for (int i = 0; i < Environment.GetCommandLineArgs().Count() - 1; i++)
                {
                    config.Append(String.Format("args({0}): {1}{2}", i.ToString(), Environment.GetCommandLineArgs()[i], Environment.NewLine));
                }

                // Build the Email Body from the Error Message, Config, and AssemblyInfo
                StringBuilder errorToSend = new StringBuilder().Append(errorMessage);
                errorToSend.AppendLine(Environment.NewLine);
                errorToSend.Append(config.ToString());
                errorToSend.AppendLine(Environment.NewLine);
                errorToSend.Append(String.Format("{0} v{1}{2}", assemblyProduct, assemblyVersion, Environment.NewLine));
                errorToSend.Append(String.Format("{0}, {1}{2}", assemblyCopyright, assemblyCompany, Environment.NewLine));

                MailMessage emailMessage = new MailMessage();
                emailMessage.Subject = "ECGridOSMailboxIO: Error";
                emailMessage.From = new MailAddress(ConfigurationManager.AppSettings["SMTPFrom"].ToString(), ConfigurationManager.AppSettings["SMTPFromName"].ToString());
                emailMessage.To.Add(contact);
                emailMessage.Body = errorToSend.ToString();

                System.Net.ServicePointManager.ServerCertificateValidationCallback = ClsSSL.AcceptAllCertifications;
                SmtpClient smtp = new SmtpClient(ConfigurationManager.AppSettings["SMTPHost"].ToString(), Convert.ToInt32(ConfigurationManager.AppSettings["SMTPPort"]));

                if (ConfigurationManager.AppSettings["SMTPSSL"].ToString().Equals("true"))
                {
                    smtp.EnableSsl = true;
                }
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                if(ConfigurationManager.AppSettings["SMTPAuth"].Equals("true"))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["SMTPUserName"].ToString(), ConfigurationManager.AppSettings["SMTPPassword"].ToString());
                }
                else
                {
                    smtp.UseDefaultCredentials = true;
                }

                smtp.Send(emailMessage);
                Console.WriteLine("Error message sent to {0}", contact);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        } // END METHOD

        #endregion

        #region Compression Helper Methods

        /// <summary>
        /// Compress a Byte Array to a GZip Compressed Byte Array
        /// </summary>
        /// <param name="data">byte[]</param>
        /// <returns>byte[] compressed</returns>
        private static byte[] GzipCompress(byte[] data)
        {
            // Compress using GZIP
            // Compress using GZIP
            using (MemoryStream compressedStream = new MemoryStream())
            using (GZipStream gzipStream = new GZipStream(compressedStream, CompressionMode.Compress, true))
            {
                gzipStream.Write(data, 0, data.Length);
                gzipStream.Close();
                return compressedStream.ToArray();
            }

        } // END METHOD

        /// <summary>
        /// Decompress a GZip Compressed Byte Array
        /// </summary>
        /// <param name="data">byte[]</param>
        /// <returns>byte[] decompressed</returns>
        private static byte[] GzipDecompress(byte[] data)
        {
            using (var compressedStream = new MemoryStream(data))
            using (var GZipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
            using (var resultStream = new MemoryStream())
            {
                GZipStream.CopyTo(resultStream);
                return resultStream.ToArray();
            }

        } // END METHOD

        /// <summary>
        /// checks if a byte[] has the Gzip header signature (1F 8B 08)
        /// </summary>
        /// <param name="data">byte[]</param>
        /// <returns>true/false</returns>
        private static bool IsGzipCompressed(byte[] data) => (data.Length >= 2 && data[0] == 31 && data[1] == 139 && data[2] == 8);

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

        #endregion

    } // END CLASS

    #region SSL Certificate Class

    /// <summary>
    /// Internal Class for accepting all SSL Certificates when sending Emails
    /// </summary>
    internal static class ClsSSL
    {
        /// <summary>
        /// AcceptAllCertifications - accepts all ssl certificates reguardless of errors for sending emails
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="certification">System.Security.Cryptography.X509Certificates.X509Certificate</param>
        /// <param name="chain">System.Security.Cryptography.X509Certificates.X509Chain</param>
        /// <param name="sslPolicyErrors">System.Net.Security.SslPolicyErrors</param>
        /// <returns>true</returns>
        public static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;

        } // END MTHOD

    } // END CLASS

    #endregion

    #region Extentions to the String Class

    /// <summary>
    /// Extends the String Class for use of VB equivelent functions
    /// </summary>
    internal static class StringExtentions
    {
        /// <summary>
        /// Left - Extention Method to act as VB Left Function
        /// Gets a specific number of characters from the left side of a string
        /// </summary>
        /// <param name="value">string</param>
        /// <param name="characterCount">integer</param>
        /// <returns>string</returns>
        internal static string Left(this string value, int characterCount)
        {
            if (string.IsNullOrEmpty(value)) { return value; }
            characterCount = Math.Abs(characterCount);

            return (value.Length <= characterCount ? value : value.Substring(0, characterCount));

        } // END METHOD

        /// <summary>
        /// Right - Extention Method to act as VB Right Function
        /// Gets a specific number of characters from the right side of a string
        /// </summary>
        /// <param name="value">string</param>
        /// <param name="characterCount">integer</param>
        /// <returns>string</returns>
        internal static string Right(this string value, int characterCount)
        {
            if (string.IsNullOrEmpty(value)) { return value; }

            return (value.Length <= characterCount ? value : value.Substring(value.Length - characterCount));

        } // END METHOD

        /// <summary>
        /// Mid - Extention Method to act as VB Mid function
        /// Gets a specific number of characters from the middle side of a string
        /// </summary>
        /// <param name="value">string</param>
        /// <param name="startCharPosition">integer</param>
        /// <param name="Length">integer</param>
        /// <returns>string</returns>
        internal static string Mid(this string value, int startCharPosition, int Length = -1)
        {
            if (string.IsNullOrEmpty(value)) { return value; }

            if (Length > 0)
            {
                return (value.Length <= startCharPosition ? value : value.Substring(startCharPosition, Length));
            }
            else
            {
                return (value.Length <= startCharPosition ? value : value.Substring(startCharPosition));
            }
        } // END METHOD

    } // END EXTENTION CLASS

    #endregion

} // END NAMESPACE
