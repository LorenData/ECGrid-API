/*
 * ECGridOS_Soap_Service Class
 * Copyright: Loren Data Corp.
 * Last Updated: 11/30/2017
 * Author: Greg Kolinski
 * Description: This class is indended to provide you the same functionality in .NET CORE as you get eith regular .Net Projects using Web References.
 * Included are both Synchronous and Asyncronous(AMP) Methods versions.  All call as are SOAP Calls with the HTTP GET/POST removed.
 * 
 * This code was created in part by using the microsoft svcutil tool version 4.6.1055.0 from the current WSDL at https://ecgridos.net/v3.2/prod/ecgridos.asmx.
 * Visual Studio Command Line Tool Calls
 * Async Only = svcutil https://ecgridos.net/v3.2/prod/ecgridos.asmx?WSDL /o:c:\temp\ECGridOS_Soap_Service.cs /sc /a /tcv:Version35
 * Sync Only = svcutil https://ecgridos.net/v3.2/prod/ecgridos.asmx?WSDL /o:c:\temp\ECGridOS_Soap_Service.cs /sc
 * 
 * To get a combined version like this one, you will need to combine the two interface sections. The object classes structures, etc. are the same in both versions.
 */

 /// <summary>
 /// ECGridOS API Soap Service Interface Class
 /// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Name="ECGridOS API v3Soap", Namespace="http://ecgridos.net/", ConfigurationName="ECGridOSAPIv3Soap")]
public interface IECGridOSAPIv3SoapService
{
    #region Synchronous Method Service Contracts

    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ContractAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    Contract ContractAdd(string SessionID, int OwnerUserID, string ContractNumber, string CompanyName, string BillingAddress, System.DateTime ContractDate, System.DateTime EffectiveDate, System.DateTime Expires, short RenewalDays, short OptionTerms, bool AggregateNetworks, int AdministratorUserID, int AccountingUserID, int AccountingCCUserID, string PONumber);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ContractList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    Contract[] ContractList(string SessionID, System.DateTime ActiveDate, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ContractInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    Contract ContractInfo(string SessionID, int ContractID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ContractSetEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ContractSetEx(string SessionID, int NetworkID, int MailboxID, int ContractID, int PricelistID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InvoiceInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    Invoice InvoiceInfo(string SessionID, int InvoiceID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InvoiceCalculate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    Invoice InvoiceCalculate(string SessionID, int ContractID, System.DateTime ReportingMonth, InvoiceInclude Include, System.DateTime InvoiceDate, string InvoiceNumber, int NetworkID, int MailboxID, string Notice, string SpecialNotice, string Message, bool Save);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InvoiceCalculateLineItem")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    LineItem InvoiceCalculateLineItem(string SessionID, int NetworkID, int MailboxID, System.DateTime ReportingMonth, PricelistAccountReports AccountReport, PricelistMeasureField MeasureField);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InvoiceSetStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool InvoiceSetStatus(string SessionID, int InvoiceID, InvoiceStatus Status);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InvoiceList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    Invoice[] InvoiceList(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ContractID, InvoiceStatus Status);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ReportMonthly")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Data.DataSet ReportMonthly(string SessionID, short Report, System.DateTime Month);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ReportMonthlyEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Data.DataSet ReportMonthlyEx(string SessionID, int NetworkID, int MailboxID, short Report, System.DateTime Month);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ReportTrafficStats")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Data.DataSet ReportTrafficStats(string SessionID, System.DateTime TargetTime, short NumPeriods, StatisticsPeriod Period);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ReportTrafficStatsEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Data.DataSet ReportTrafficStatsEx(string SessionID, int NetworkID, int MailboxID, System.DateTime TargetTime, short NumPeriods, StatisticsPeriod Period);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ReportTrafficStatsPublic")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Data.DataSet ReportTrafficStatsPublic();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ReportInstantStats")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Data.DataSet ReportInstantStats(string SessionID, short Minutes1, short Minutes2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ReportInstantStatsEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Data.DataSet ReportInstantStatsEx(string SessionID, int NetworkID, int MailboxID, int ECGridID, short Minutes1, short Minutes2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2Add")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    as2CommInfo AS2Add(
                string SessionID, 
                int NetworkID, 
                int MailboxID, 
                int OwnerUserID, 
                bool ECGridHosted, 
                string AS2Identifier, 
                string URL, 
                bool SignData, 
                bool EncryptData, 
                bool CompressData, 
                ReceiptType ReceiptType, 
                HTTPAuthType HTTPAuthentication, 
                string HTTPUser, 
                string HTTPPassword, 
                UseType UseType, 
                System.DateTime BeginUsage, 
                System.DateTime EndUsage, 
                Status Status);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CommAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CommIDInfo CommAdd(
                string SessionID, 
                int NetworkID, 
                int MailboxID, 
                NetworkGatewayCommChannel CommType, 
                int OwnerUserID, 
                bool ECGridHosted, 
                string Identifier, 
                string URL, 
                bool SignData, 
                bool EncryptData, 
                bool CompressData, 
                ReceiptType ReceiptType, 
                HTTPAuthType HTTPAuthentication, 
                string HTTPUser, 
                string HTTPPassword, 
                UseType UseType, 
                System.DateTime BeginUsage, 
                System.DateTime EndUsage, 
                Status Status);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2SetPair")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    as2CommInfo[] AS2SetPair(string SessionID, int ECGridIDFrom, int ECGridIDTo, string AS2ID1, string AS2ID2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2Pair")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    as2CommInfo[] AS2Pair(string SessionID, int ECGridIDFrom, int ECGridIDTo, string DefaultAS2ID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2Update")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    as2CommInfo AS2Update(string SessionID, int CommID, int OwnerUserID, string AS2Identifier, string URL, bool SignData, bool EncryptData, bool CompressData, ReceiptType ReceiptType, HTTPAuthType HTTPAuthentication, string HTTPUser, string HTTPPassword, UseType UseType, System.DateTime BeginUsage, System.DateTime EndUsage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2List")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    as2CommInfo[] AS2List(string SessionID, bool PrivateKeyRequired, UseType UseType, bool ShowInactive, bool WithCerts);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2ListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    as2CommInfo[] AS2ListEx(string SessionID, int NetworkID, int MailboxID, bool PrivateKeyRequired, UseType UseType, bool ShowInactive, bool WithCerts);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2Find")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    as2CommInfo[] AS2Find(string SessionID, string Identifier, bool PrivateKeyRequired, UseType UseType, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CommList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CommIDInfo[] CommList(string SessionID, NetworkGatewayCommChannel CommType, bool PrivateKeyRequired, UseType UseType, bool ShowInactive, bool WithCerts);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CommListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CommIDInfo[] CommListEx(string SessionID, int NetworkID, int MailboxID, NetworkGatewayCommChannel CommType, bool PrivateKeyRequired, UseType UseType, bool ShowInactive, bool WithCerts);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CommFind")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CommIDInfo[] CommFind(string SessionID, string Identifier, NetworkGatewayCommChannel CommType, bool PrivateKeyRequired, UseType UseType, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2Info")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    as2CommInfo AS2Info(string SessionID, int CommID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CommInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CommIDInfo CommInfo(string SessionID, int CommID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2SetStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool AS2SetStatus(string SessionID, int CommID, Status Status);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2Terminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool AS2Terminate(string SessionID, int CommID);
    
    // CODEGEN: Parameter 'Cert' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2CertAddPublic")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    AS2CertAddPublicResponse AS2CertAddPublic(AS2CertAddPublicRequest request);
    
    // CODEGEN: Parameter 'Cert' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CertificateAddPublic")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CertificateAddPublicResponse CertificateAddPublic(CertificateAddPublicRequest request);
    
    // CODEGEN: Parameter 'Cert' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2CertAddPrivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    AS2CertAddPrivateResponse AS2CertAddPrivate(AS2CertAddPrivateRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2CertCreatePrivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    as2CommInfo AS2CertCreatePrivate(string SessionID, int CommID, System.DateTime BeginUsage, CertificateUsage Usage, CertificateSecureHashAlgorithm SecureHashAlgorithm, string PartnerAS2ID, System.DateTime Expires);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2CertRenewPrivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    as2CommInfo AS2CertRenewPrivate(string SessionID, int CommID, int CertKeyID, short OverlapDays, short Years, CertificateSecureHashAlgorithm SecureHashAlgorithm);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2CertTerminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool AS2CertTerminate(string SessionID, int CommID, int CertKeyID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/AS2DefaultMailbox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool AS2DefaultMailbox(string SessionID, int CommID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/GISBList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    GISBCommInfo[] GISBList(string SessionID, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/GISBListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    GISBCommInfo[] GISBListEx(string SessionID, int NetworkID, int MailboxID, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/GISBFind")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    GISBCommInfo[] GISBFind(string SessionID, string Identifier, UseType UseType, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/GISBInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    GISBCommInfo GISBInfo(string SessionID, int CommID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NowUTC")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.DateTime NowUTC();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeDate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.DateTime InterchangeDate(string InterchangeHeader);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/Version")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    string Version();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/X400Format")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    string X400Format(
                string Country, 
                string ADMD, 
                string PRMD, 
                string Organization, 
                string OrganizationalUnit1, 
                string OrganizationalUnit2, 
                string OrganizationalUnit3, 
                string OrganizationalUnit4, 
                string Surname, 
                string GivenName, 
                string Initials, 
                string Generation, 
                string CommonName, 
                string DDA, 
                string X_121, 
                string N_ID, 
                string T_TY, 
                string T_ID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/PricelistInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    Pricelist PricelistInfo(string SessionID, int PricelistID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelInterchangeManifest")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ManifestInfo[] ParcelInterchangeManifest(string SessionID, long InterchangeID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeManifest")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ManifestInfo[] InterchangeManifest(string SessionID, long InterchangeID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelNoteList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelNote[] ParcelNoteList(string SessionID, long ParcelID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelInBoxArchive")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelInBoxArchive(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelInBoxArchiveEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelInBoxArchiveEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelInBoxArchiveDescEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelInBoxArchiveDescEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelOutBoxArchive")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelOutBoxArchive(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelOutBoxArchiveEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelOutBoxArchiveEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelOutBoxArchiveDescEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelOutBoxArchiveDescEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelOutBoxError")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelOutBoxError(string SessionID, System.DateTime BeginDate, System.DateTime EndDate);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelOutBoxErrorEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelOutBoxErrorEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelOutBoxInProcess")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelOutBoxInProcess(string SessionID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelOutBoxInProcessEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelOutBoxInProcessEx(string SessionID, int NetworkID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo InterchangeInfo(string SessionID, long InterchangeID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeInBox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo[] InterchangeInBox(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeInBoxArchive")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfoCollection InterchangeInBoxArchive(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, short PageNo, short RecordsPerPage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeInBoxEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo[] InterchangeInBoxEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeInBoxArchiveEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfoCollection InterchangeInBoxArchiveEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, short PageNo, short RecordsPerPage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeOutBox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo[] InterchangeOutBox(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeOutBoxArchive")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfoCollection InterchangeOutBoxArchive(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, short PageNo, short RecordsPerPage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeOutBoxEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo[] InterchangeOutBoxEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeOutBoxArchiveEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfoCollection InterchangeOutBoxArchiveEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, short PageNo, short RecordsPerPage);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeOutBoxPending")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo[] InterchangeOutBoxPending(string SessionID, int ECGridIDFrom, int ECGridIDTo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeOutBoxPendingEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo[] InterchangeOutBoxPendingEx(string SessionID, int NetworkID, int MailboxID, int ECGridIDFrom, int ECGridIDTo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeInBoxPending")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo[] InterchangeInBoxPending(string SessionID, int ECGridIDFrom, int ECGridIDTo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeInBoxPendingEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo[] InterchangeInBoxPendingEx(string SessionID, int NetworkID, int MailboxID, int ECGridIDFrom, int ECGridIDTo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeHeaderInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo InterchangeHeaderInfo(string SessionID, string InterchangeHeader);
    
    // CODEGEN: Parameter 'InterchangeHeader' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeHeaderInfoB")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeHeaderInfoBResponse InterchangeHeaderInfoB(InterchangeHeaderInfoBRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeOutBoxNoRoute")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo[] InterchangeOutBoxNoRoute(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeOutBoxNoRouteEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterchangeIDInfo[] InterchangeOutBoxNoRouteEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeResend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool InterchangeResend(string SessionID, long InterchangeID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterchangeCancel")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool InterchangeCancel(string SessionID, int InterchangeID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackEventInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CallBackEventIDInfo CallBackEventInfo(string SessionID, int CallBackEventID, short QueueCount);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackEventListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CallBackEventIDInfo[] CallBackEventListEx(string SessionID, int NetworkID, int MailboxID, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackAddEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CallBackEventIDInfo CallBackAddEx(string SessionID, int NetworkID, int MailboxID, int UserID, Objects SystemObject, short ObjectStatus, Direction Direction, short Frequency, short MaxRetries, string URL, HTTPAuthType HTTPAuthentication, string HTTPUser, string HTTPPassword, Status Status);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackEventSetStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool CallBackEventSetStatus(string SessionID, int CallBackEventID, Status Status);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackQueueInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CallBackQueueIDInfo CallBackQueueInfo(string SessionID, int CallBackQueueID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackTest")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CallBackQueueIDInfo CallBackTest(string SessionID, int CallBackEventID, int ParcelID, int InterchangeID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackInvoke")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CallBackQueueIDInfo CallBackInvoke(string SessionID, int CallBackQueueID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackPendingList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CallBackQueueIDInfo[] CallBackPendingList(string SessionID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackPendingListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CallBackQueueIDInfo[] CallBackPendingListEx(string SessionID, int NetworkID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackFailedList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CallBackQueueIDInfo[] CallBackFailedList(string SessionID, short MaxDays);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CallBackFailedListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CallBackQueueIDInfo[] CallBackFailedListEx(string SessionID, int NetworkID, int MailboxID, short MaxDays);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterconnectIDInfo InterconnectInfo(string SessionID, int InterconnectID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectInfoGUID")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterconnectIDInfo InterconnectInfoGUID(string SessionID, string UniqueID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectNoteList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterconnectNote[] InterconnectNoteList(string SessionID, int InterconnectID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectListByECGridID")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterconnectIDInfo[] InterconnectListByECGridID(string SessionID, int ECGridID1, int ECGridID2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectListByStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterconnectIDInfo[] InterconnectListByStatus(string SessionID, StatusInterconnect Status, int ECGridID, short MaxDays);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectListByStatusEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterconnectIDInfo[] InterconnectListByStatusEx(string SessionID, int NetworkID, int MailboxID, StatusInterconnect IntStatus, int ECGridID, short MaxDays);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectAssignNetOps")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool InterconnectAssignNetOps(string SessionID, int InterconnectID, int UserID, eMailTo eMailTo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectCount")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Data.DataSet InterconnectCount(string SessionID, short MaxDays);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectCountEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Data.DataSet InterconnectCountEx(string SessionID, int NetworkID, int MailboxID, int ECGridID, short MaxDays);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MigrationList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    MigrationIDInfo[] MigrationList(string SessionID, MigrationStatus Status, bool ShowCanceled);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MigrationListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    MigrationIDInfo[] MigrationListEx(string SessionID, int NetworkID, int MailboxID, MigrationStatus Status, bool ShowCanceled);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MigrationInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    MigrationIDInfo MigrationInfo(string SessionID, int MigrationID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MigrationAddTP")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MigrationAddTP(string SessionID, int MigrationID, int ECGridID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CarbonCopyAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int CarbonCopyAdd(string SessionID, int ECGridIDFrom, int ECGridIDTo, int ECGridIDCCFrom, int ECGridIDCCTo, string TransactionSet);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CarbonCopyAddEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int CarbonCopyAddEx(string SessionID, int NetworkID, int MailboxID, int ECGridIDFrom, int ECGridIDTo, int ECGridIDCCFrom, int ECGridIDCCTo, string TransactionSet);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CarbonCopyActivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool CarbonCopyActivate(string SessionID, int CarbonCopyID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CarbonCopySuspend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool CarbonCopySuspend(string SessionID, int CarbonCopyID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CarbonCopyTerminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool CarbonCopyTerminate(string SessionID, int CarbonCopyID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CarbonCopyInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CarbonCopyIDInfo CarbonCopyInfo(string SessionID, int CarbonCopyID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CarbonCopyList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CarbonCopyIDInfo[] CarbonCopyList(string SessionID, int ECGridIDFrom, int ECGridIDTo, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/CarbonCopyListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    CarbonCopyIDInfo[] CarbonCopyListEx(string SessionID, int NetworkID, int MailboxID, int ECGridIDFrom, int ECGridIDTo, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelInBox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelInBox(string SessionID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelInBoxEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfoCollection ParcelInBoxEx(string SessionID, int NetworkID, int MailboxID, int ECGridIDFrom, int ECGridIDTo);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelIDInfo ParcelInfo(string SessionID, long ParcelID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelDownload")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    FileInfo ParcelDownload(string SessionID, long ParcelID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelDownloadNoUpdate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    FileInfo ParcelDownloadNoUpdate(string SessionID, long ParcelID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelDownloadGZip")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    FileInfo ParcelDownloadGZip(string SessionID, long ParcelID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelDownloadInner")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    FileInfo ParcelDownloadInner(string SessionID, long ParcelID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelDownloadConfirm")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ParcelDownloadConfirm(string SessionID, long ParcelID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelAcknowledgmentNote")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ParcelAcknowledgmentNote(string SessionID, long ParcelID, string Subject, string Note);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelDownloadCancel")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ParcelDownloadCancel(string SessionID, long ParcelID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelDownloadConfirmPendingAck")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ParcelDownloadConfirmPendingAck(string SessionID, long ParcelID, ParcelStatus Status);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelDownloadReset")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ParcelDownloadReset(string SessionID, long ParcelID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelResend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ParcelResend(string SessionID, long ParcelID);
    
    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelUpload")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelUploadResponse ParcelUpload(ParcelUploadRequest request);
    
    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelUploadExA")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelUploadExAResponse ParcelUploadExA(ParcelUploadExARequest request);
    
    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelUploadGZip")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelUploadGZipResponse ParcelUploadGZip(ParcelUploadGZipRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelUpdateStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ParcelUpdateStatus(string SessionID, long ParcelID, ParcelStatus Status, bool TransLogOnly);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelUpdateLocalStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ParcelUpdateLocalStatus(string SessionID, long ParcelID, short Status);
    
    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelUploadEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelUploadExResponse ParcelUploadEx(ParcelUploadExRequest request);
    
    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelUploadDirected")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelUploadDirectedResponse ParcelUploadDirected(ParcelUploadDirectedRequest request);
    
    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelUploadGZipEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelUploadGZipExResponse ParcelUploadGZipEx(ParcelUploadGZipExRequest request);
    
    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelUploadDirectedGZip")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ParcelUploadDirectedGZipResponse ParcelUploadDirectedGZip(ParcelUploadDirectedGZipRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelTest")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int ParcelTest(string SessionID, int ECGridIDFrom, int ECGridIDTo, EDIStandard DocumentType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelSetMailbagControlID")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ParcelSetMailbagControlID(string SessionID, int ParcelID, string MailbagControlID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ParcelManifest")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ManifestInfo[] ParcelManifest(string SessionID, long ParcelID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkReportsContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkReportsContact(string SessionID, int NetworkID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkSetWebsite")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkSetWebsite(string SessionID, int NetworkID, string URL, NetworkWebsiteType WebsiteType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkBackupAllConfigs")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    string NetworkBackupAllConfigs(string SessionID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkX12Delimiters")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkX12Delimiters(string SessionID, int NetworkID, byte SegTerm, byte ElmSep, byte SubElmSep);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int MailboxAdd(string SessionID, string Name, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxAddEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int MailboxAddEx(string SessionID, int NetworkID, string Name, string UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxActivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxActivate(string SessionID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxSuspend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxSuspend(string SessionID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxTerminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxTerminate(string SessionID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxManaged")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxManaged(string SessionID, int MailboxID, bool Managed);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxDeleteOnDownload")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxDeleteOnDownload(string SessionID, int MailboxID, bool DeleteOnDownload);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    MailboxIDInfo MailboxInfo(string SessionID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxName")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxName(string SessionID, int MailboxID, string Name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxSetContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxSetContact(string SessionID, int MailboxID, int UserID, NetworkContactType ContactType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxOwnerContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxOwnerContact(string SessionID, int MailboxID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxErrorsContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxErrorsContact(string SessionID, int MailboxID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxInterconnectsContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxInterconnectsContact(string SessionID, int MailboxID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxNoticesContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxNoticesContact(string SessionID, int MailboxID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxX12Delimiters")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxX12Delimiters(string SessionID, int MailboxID, byte SegTerm, byte ElmSep, byte SubElmSep);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxInBoxTimeout")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxInBoxTimeout(string SessionID, int MailboxID, short Minutes);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxDescription")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxDescription(string SessionID, int MailboxID, string Description);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxUse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool MailboxUse(string SessionID, int MailboxID, UseType UseType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    MailboxIDInfo[] MailboxList(string SessionID, string Name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/MailboxListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    MailboxIDInfo[] MailboxListEx(string SessionID, int NetworkID, string Name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int TPAdd(string SessionID, string Qualifier, string ID, string Description);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPAddVAN")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int TPAddVAN(string SessionID, int NetworkID, string Qualifier, string ID, string Description);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPAddEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int TPAddEx(string SessionID, int NetworkID, int MailboxID, string Qualifier, string ID, string Description, RoutingGroup RoutingGroup);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPMove")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int TPMove(string SessionID, int ECGridID, System.DateTime MoveDateTime);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPMoveMailbox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int TPMoveMailbox(string SessionID, int ECGridID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPMoveEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int TPMoveEx(string SessionID, int NetworkID, int MailboxID, int ECGridID, System.DateTime MoveDateTime);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPUpdateDescription")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool TPUpdateDescription(string SessionID, int ECGridID, string Description);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPUpdateDataEMail")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool TPUpdateDataEMail(string SessionID, int ECGridID, EMailSystem EMailSystem, string DataEMail, EMailPayload PayloadPosition);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPActivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool TPActivate(string SessionID, int ECGridID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPSuspend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool TPSuspend(string SessionID, int ECGridID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPTerminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool TPTerminate(string SessionID, int ECGridID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPSetRoutingGroup")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool TPSetRoutingGroup(string SessionID, int ECGridID, RoutingGroup RoutingGroup);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ECGridIDInfo TPInfo(string SessionID, int ECGridID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPSearch")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ECGridIDInfo[] TPSearch(string SessionID, string Qualifier, string ID, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPSearchEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ECGridIDInfo[] TPSearchEx(string SessionID, int NetworkID, int MailboxID, string Qualifier, string ID, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ECGridIDInfo[] TPList(string SessionID, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ECGridIDInfo[] TPListEx(string SessionID, int NetworkID, int MailboxID, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPListExPaged")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ECGridIDInfoCollection TPListExPaged(string SessionID, int NetworkID, int MailboxID, bool ShowInactive, short PageSize, short PageNumber);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPListByOwner")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ECGridIDInfoCollection TPListByOwner(string SessionID, int OwnerUserID, OrderBy OrderBy, bool ShowInactive, short PageSize, short PageNumber);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPFindEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ECGridIDInfo[] TPFindEx(string SessionID, int NetworkID, int MailboxID, string Description, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPGetMailboxDefault")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ECGridIDInfo TPGetMailboxDefault(string SessionID, int NetworkID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPSetMailboxDefault")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool TPSetMailboxDefault(string SessionID, int ECGridID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/TPSetOwner")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool TPSetOwner(string SessionID, int ECGridID, int OwnerUserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterconnectIDInfo InterconnectAdd(string SessionID, int ECGridID1, int ECGridID2, string Reference, string ContactName, string ContactEMail, bool NotifyContact, bool Preconfirm, string Note);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectUpdate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool InterconnectUpdate(string SessionID, int InterconnectID, StatusInterconnect Status, AuthLevel AuthLevel, string Note, eMailTo EMailTo, string OtherEMailAddress);
    
    // CODEGEN: Parameter 'AttachmentContent' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectNote")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    InterconnectNoteResponse InterconnectNote(InterconnectNoteRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/InterconnectCancel")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool InterconnectCancel(string SessionID, int InterconnectID, string Note, eMailTo EMailTo, string OtherEMailAddress);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/Login")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    string Login(string LoginName, string Password);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/GenerateAPIKey")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    string GenerateAPIKey(string SessionID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/GeneratePassword")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    string GeneratePassword(string SessionID, short Length);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/Logout")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int Logout(string SessionID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/ChangePassword")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool ChangePassword(string SessionID, string OldPassword, string NewPassword);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/WhoAmI")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    SessionInfo WhoAmI(string SessionID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int UserAdd(string SessionID, int MailboxID, string LoginName, string Password, string RecoveryQuestion, string RecoveryAnswer, string FirstName, string LastName, string Company, string EMail, string Phone, string CellPhone, CellCarrier CellCarrier, AuthLevel AuthLevel);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserAddEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int UserAddEx(string SessionID, int NetworkID, int MailboxID, string LoginName, string Password, string RecoveryQuestion, string RecoveryAnswer, string FirstName, string LastName, string Company, string EMail, string Phone, string CellPhone, CellCarrier CellCarrier, AuthLevel AuthLevel);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    UserIDInfo UserInfo(string SessionID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserUpdate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool UserUpdate(string SessionID, int UserID, string FirstName, string LastName, string Company, string EMail, string Phone, string CellPhone, CellCarrier CellCarrier, AuthLevel AuthLevel);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserPassword")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool UserPassword(string SessionID, int UserID, string CurrentRecoveryAnswer, string Password, string RecoveryQuestion, string RecoveryAnswer);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserActivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool UserActivate(string SessionID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserSuspend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool UserSuspend(string SessionID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserTerminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool UserTerminate(string SessionID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserSendSMS")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool UserSendSMS(string SessionID, int UserID, string Text);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserReset")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool UserReset(string SessionID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserResetAll")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    short UserResetAll(string SessionID, short TimeOutMinutes);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    UserIDInfo[] UserList(string SessionID, string Name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    UserIDInfo[] UserListEx(string SessionID, int NetworkID, int MailboxID, string Name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserListLockedOut")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    UserIDInfo[] UserListLockedOut(string SessionID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserListLockedOutEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    UserIDInfo[] UserListLockedOutEx(string SessionID, int NetworkID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserSetNetworkMailbox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool UserSetNetworkMailbox(string SessionID, int UserID, int NetworkID, int MailboxID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserSetAuthLevel")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool UserSetAuthLevel(string SessionID, int UserID, AuthLevel AuthLevel);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/UserGetAPIKey")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    string UserGetAPIKey(string SessionID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/SessionLogCurrent")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    SessionLogInfo SessionLogCurrent(string SessionID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/SessionLog")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    SessionLogInfo[] SessionLog(string SessionID, short MaxRecords);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/SessionLogEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    SessionLogInfo[] SessionLogEx(string SessionID, int UserID, System.DateTime StartTime, System.DateTime EndTime, short MaxRecords);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/KeyGet")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    KeyValue KeyGet(string SessionID, string Key, Objects SystemObject, int ObjectID, KeyVisibility Visibility);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/KeyList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    KeyValue[] KeyList(string SessionID, Objects SystemObject, int ObjectID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/KeySet")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool KeySet(string SessionID, string Key, Objects SystemObject, int ObjectID, KeyVisibility Visibility, string Value, string Meta, int DaysToLive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/KeyRemove")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool KeyRemove(string SessionID, string Key, Objects SystemObject, int ObjectID, KeyVisibility Visibility);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    NetworkIDInfo NetworkInfo(string SessionID, int NetworkID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkInfoWithLog")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    NetworkIDInfo NetworkInfoWithLog(string SessionID, int NetworkID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    NetworkIDInfo[] NetworkList(string SessionID, string Name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkStatusSummary")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Data.DataSet NetworkStatusSummary(string SessionID, bool ShowInactive);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkOutageList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    NetworkIDInfo[] NetworkOutageList(string SessionID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkStart")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkStart(string SessionID, int NetworkID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkStop")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkStop(string SessionID, int NetworkID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkRestart")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkRestart(string SessionID, int NetworkID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkCheckIn")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkCheckIn(string SessionID, bool OutOnly, string Version, string IP, NetworkLogType ActionType, NetworkLogStatus Status, string Description, int ID, string ComputerName, string UserName, string UserDomain);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkSetStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkSetStatus(string SessionID, int NetworkID, Status Status);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    int NetworkAdd(string SessionID, int NetworkID, string Name, string Location, NetworkServiceType Type, NetworkRoutingType RoutingType, string Password, short RunDir, string Server);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkSetContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkSetContact(string SessionID, int NetworkID, int UserID, NetworkContactType ContactType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkGetContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    UserIDInfo NetworkGetContact(string SessionID, int NetworkID, NetworkContactType ContactType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkOwnerContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkOwnerContact(string SessionID, int NetworkID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkErrorsContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkErrorsContact(string SessionID, int NetworkID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkInterconnectsContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkInterconnectsContact(string SessionID, int NetworkID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkNoticesContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkNoticesContact(string SessionID, int NetworkID, int UserID);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ecgridos.net/NetworkBillingContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    bool NetworkBillingContact(string SessionID, int NetworkID, int UserID);

    #endregion

    #region Asynchronous Method Service Contracts

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ContractAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginContractAdd(
                string SessionID,
                int OwnerUserID,
                string ContractNumber,
                string CompanyName,
                string BillingAddress,
                System.DateTime ContractDate,
                System.DateTime EffectiveDate,
                System.DateTime Expires,
                short RenewalDays,
                short OptionTerms,
                bool AggregateNetworks,
                int AdministratorUserID,
                int AccountingUserID,
                int AccountingCCUserID,
                string PONumber,
                System.AsyncCallback callback,
                object asyncState);

    Contract EndContractAdd(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ContractList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginContractList(string SessionID, System.DateTime ActiveDate, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    Contract[] EndContractList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ContractInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginContractInfo(string SessionID, int ContractID, System.AsyncCallback callback, object asyncState);

    Contract EndContractInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ContractSetEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginContractSetEx(string SessionID, int NetworkID, int MailboxID, int ContractID, int PricelistID, System.AsyncCallback callback, object asyncState);

    bool EndContractSetEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InvoiceInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInvoiceInfo(string SessionID, int InvoiceID, System.AsyncCallback callback, object asyncState);

    Invoice EndInvoiceInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InvoiceCalculate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInvoiceCalculate(string SessionID, int ContractID, System.DateTime ReportingMonth, InvoiceInclude Include, System.DateTime InvoiceDate, string InvoiceNumber, int NetworkID, int MailboxID, string Notice, string SpecialNotice, string Message, bool Save, System.AsyncCallback callback, object asyncState);

    Invoice EndInvoiceCalculate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InvoiceCalculateLineItem")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInvoiceCalculateLineItem(string SessionID, int NetworkID, int MailboxID, System.DateTime ReportingMonth, PricelistAccountReports AccountReport, PricelistMeasureField MeasureField, System.AsyncCallback callback, object asyncState);

    LineItem EndInvoiceCalculateLineItem(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InvoiceSetStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInvoiceSetStatus(string SessionID, int InvoiceID, InvoiceStatus Status, System.AsyncCallback callback, object asyncState);

    bool EndInvoiceSetStatus(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InvoiceList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInvoiceList(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ContractID, InvoiceStatus Status, System.AsyncCallback callback, object asyncState);

    Invoice[] EndInvoiceList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ReportMonthly")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginReportMonthly(string SessionID, short Report, System.DateTime Month, System.AsyncCallback callback, object asyncState);

    System.Data.DataSet EndReportMonthly(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ReportMonthlyEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginReportMonthlyEx(string SessionID, int NetworkID, int MailboxID, short Report, System.DateTime Month, System.AsyncCallback callback, object asyncState);

    System.Data.DataSet EndReportMonthlyEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ReportTrafficStats")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginReportTrafficStats(string SessionID, System.DateTime TargetTime, short NumPeriods, StatisticsPeriod Period, System.AsyncCallback callback, object asyncState);

    System.Data.DataSet EndReportTrafficStats(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ReportTrafficStatsEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginReportTrafficStatsEx(string SessionID, int NetworkID, int MailboxID, System.DateTime TargetTime, short NumPeriods, StatisticsPeriod Period, System.AsyncCallback callback, object asyncState);

    System.Data.DataSet EndReportTrafficStatsEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ReportTrafficStatsPublic")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginReportTrafficStatsPublic(System.AsyncCallback callback, object asyncState);

    System.Data.DataSet EndReportTrafficStatsPublic(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ReportInstantStats")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginReportInstantStats(string SessionID, short Minutes1, short Minutes2, System.AsyncCallback callback, object asyncState);

    System.Data.DataSet EndReportInstantStats(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ReportInstantStatsEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginReportInstantStatsEx(string SessionID, int NetworkID, int MailboxID, int ECGridID, short Minutes1, short Minutes2, System.AsyncCallback callback, object asyncState);

    System.Data.DataSet EndReportInstantStatsEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2Add")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2Add(
                string SessionID,
                int NetworkID,
                int MailboxID,
                int OwnerUserID,
                bool ECGridHosted,
                string AS2Identifier,
                string URL,
                bool SignData,
                bool EncryptData,
                bool CompressData,
                ReceiptType ReceiptType,
                HTTPAuthType HTTPAuthentication,
                string HTTPUser,
                string HTTPPassword,
                UseType UseType,
                System.DateTime BeginUsage,
                System.DateTime EndUsage,
                Status Status,
                System.AsyncCallback callback,
                object asyncState);

    as2CommInfo EndAS2Add(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CommAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCommAdd(
                string SessionID,
                int NetworkID,
                int MailboxID,
                NetworkGatewayCommChannel CommType,
                int OwnerUserID,
                bool ECGridHosted,
                string Identifier,
                string URL,
                bool SignData,
                bool EncryptData,
                bool CompressData,
                ReceiptType ReceiptType,
                HTTPAuthType HTTPAuthentication,
                string HTTPUser,
                string HTTPPassword,
                UseType UseType,
                System.DateTime BeginUsage,
                System.DateTime EndUsage,
                Status Status,
                System.AsyncCallback callback,
                object asyncState);

    CommIDInfo EndCommAdd(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2SetPair")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2SetPair(string SessionID, int ECGridIDFrom, int ECGridIDTo, string AS2ID1, string AS2ID2, System.AsyncCallback callback, object asyncState);

    as2CommInfo[] EndAS2SetPair(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2Pair")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2Pair(string SessionID, int ECGridIDFrom, int ECGridIDTo, string DefaultAS2ID, System.AsyncCallback callback, object asyncState);

    as2CommInfo[] EndAS2Pair(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2Update")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2Update(
                string SessionID,
                int CommID,
                int OwnerUserID,
                string AS2Identifier,
                string URL,
                bool SignData,
                bool EncryptData,
                bool CompressData,
                ReceiptType ReceiptType,
                HTTPAuthType HTTPAuthentication,
                string HTTPUser,
                string HTTPPassword,
                UseType UseType,
                System.DateTime BeginUsage,
                System.DateTime EndUsage,
                System.AsyncCallback callback,
                object asyncState);

    as2CommInfo EndAS2Update(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2List")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2List(string SessionID, bool PrivateKeyRequired, UseType UseType, bool ShowInactive, bool WithCerts, System.AsyncCallback callback, object asyncState);

    as2CommInfo[] EndAS2List(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2ListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2ListEx(string SessionID, int NetworkID, int MailboxID, bool PrivateKeyRequired, UseType UseType, bool ShowInactive, bool WithCerts, System.AsyncCallback callback, object asyncState);

    as2CommInfo[] EndAS2ListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2Find")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2Find(string SessionID, string Identifier, bool PrivateKeyRequired, UseType UseType, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    as2CommInfo[] EndAS2Find(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CommList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCommList(string SessionID, NetworkGatewayCommChannel CommType, bool PrivateKeyRequired, UseType UseType, bool ShowInactive, bool WithCerts, System.AsyncCallback callback, object asyncState);

    CommIDInfo[] EndCommList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CommListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCommListEx(string SessionID, int NetworkID, int MailboxID, NetworkGatewayCommChannel CommType, bool PrivateKeyRequired, UseType UseType, bool ShowInactive, bool WithCerts, System.AsyncCallback callback, object asyncState);

    CommIDInfo[] EndCommListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CommFind")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCommFind(string SessionID, string Identifier, NetworkGatewayCommChannel CommType, bool PrivateKeyRequired, UseType UseType, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    CommIDInfo[] EndCommFind(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2Info")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2Info(string SessionID, int CommID, System.AsyncCallback callback, object asyncState);

    as2CommInfo EndAS2Info(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CommInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCommInfo(string SessionID, int CommID, System.AsyncCallback callback, object asyncState);

    CommIDInfo EndCommInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2SetStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2SetStatus(string SessionID, int CommID, Status Status, System.AsyncCallback callback, object asyncState);

    bool EndAS2SetStatus(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2Terminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2Terminate(string SessionID, int CommID, System.AsyncCallback callback, object asyncState);

    bool EndAS2Terminate(System.IAsyncResult result);

    // CODEGEN: Parameter 'Cert' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2CertAddPublic")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2CertAddPublic(AS2CertAddPublicRequest request, System.AsyncCallback callback, object asyncState);

    AS2CertAddPublicResponse EndAS2CertAddPublic(System.IAsyncResult result);

    // CODEGEN: Parameter 'Cert' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CertificateAddPublic")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCertificateAddPublic(CertificateAddPublicRequest request, System.AsyncCallback callback, object asyncState);

    CertificateAddPublicResponse EndCertificateAddPublic(System.IAsyncResult result);

    // CODEGEN: Parameter 'Cert' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2CertAddPrivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2CertAddPrivate(AS2CertAddPrivateRequest request, System.AsyncCallback callback, object asyncState);

    AS2CertAddPrivateResponse EndAS2CertAddPrivate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2CertCreatePrivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2CertCreatePrivate(string SessionID, int CommID, System.DateTime BeginUsage, CertificateUsage Usage, CertificateSecureHashAlgorithm SecureHashAlgorithm, string PartnerAS2ID, System.DateTime Expires, System.AsyncCallback callback, object asyncState);

    as2CommInfo EndAS2CertCreatePrivate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2CertRenewPrivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2CertRenewPrivate(string SessionID, int CommID, int CertKeyID, short OverlapDays, short Years, CertificateSecureHashAlgorithm SecureHashAlgorithm, System.AsyncCallback callback, object asyncState);

    as2CommInfo EndAS2CertRenewPrivate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2CertTerminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2CertTerminate(string SessionID, int CommID, int CertKeyID, System.AsyncCallback callback, object asyncState);

    bool EndAS2CertTerminate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/AS2DefaultMailbox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginAS2DefaultMailbox(string SessionID, int CommID, int MailboxID, System.AsyncCallback callback, object asyncState);

    bool EndAS2DefaultMailbox(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/GISBList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginGISBList(string SessionID, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    GISBCommInfo[] EndGISBList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/GISBListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginGISBListEx(string SessionID, int NetworkID, int MailboxID, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    GISBCommInfo[] EndGISBListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/GISBFind")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginGISBFind(string SessionID, string Identifier, UseType UseType, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    GISBCommInfo[] EndGISBFind(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/GISBInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginGISBInfo(string SessionID, int CommID, System.AsyncCallback callback, object asyncState);

    GISBCommInfo EndGISBInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NowUTC")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNowUTC(System.AsyncCallback callback, object asyncState);

    System.DateTime EndNowUTC(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeDate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeDate(string InterchangeHeader, System.AsyncCallback callback, object asyncState);

    System.DateTime EndInterchangeDate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/Version")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginVersion(System.AsyncCallback callback, object asyncState);

    string EndVersion(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/X400Format")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginX400Format(
                string Country,
                string ADMD,
                string PRMD,
                string Organization,
                string OrganizationalUnit1,
                string OrganizationalUnit2,
                string OrganizationalUnit3,
                string OrganizationalUnit4,
                string Surname,
                string GivenName,
                string Initials,
                string Generation,
                string CommonName,
                string DDA,
                string X_121,
                string N_ID,
                string T_TY,
                string T_ID,
                System.AsyncCallback callback,
                object asyncState);

    string EndX400Format(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/PricelistInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginPricelistInfo(string SessionID, int PricelistID, System.AsyncCallback callback, object asyncState);

    Pricelist EndPricelistInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelInterchangeManifest")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelInterchangeManifest(string SessionID, long InterchangeID, System.AsyncCallback callback, object asyncState);

    ManifestInfo[] EndParcelInterchangeManifest(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeManifest")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeManifest(string SessionID, long InterchangeID, System.AsyncCallback callback, object asyncState);

    ManifestInfo[] EndInterchangeManifest(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelNoteList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelNoteList(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    ParcelNote[] EndParcelNoteList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelInBoxArchive")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelInBoxArchive(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelInBoxArchive(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelInBoxArchiveEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelInBoxArchiveEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelInBoxArchiveEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelInBoxArchiveDescEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelInBoxArchiveDescEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelInBoxArchiveDescEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelOutBoxArchive")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelOutBoxArchive(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelOutBoxArchive(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelOutBoxArchiveEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelOutBoxArchiveEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelOutBoxArchiveEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelOutBoxArchiveDescEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelOutBoxArchiveDescEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string MailbagControlID, short PageNo, short RecordsPerPage, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelOutBoxArchiveDescEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelOutBoxError")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelOutBoxError(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelOutBoxError(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelOutBoxErrorEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelOutBoxErrorEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelOutBoxErrorEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelOutBoxInProcess")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelOutBoxInProcess(string SessionID, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelOutBoxInProcess(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelOutBoxInProcessEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelOutBoxInProcessEx(string SessionID, int NetworkID, int MailboxID, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelOutBoxInProcessEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeInfo(string SessionID, long InterchangeID, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo EndInterchangeInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeInBox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeInBox(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo[] EndInterchangeInBox(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeInBoxArchive")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeInBoxArchive(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, short PageNo, short RecordsPerPage, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfoCollection EndInterchangeInBoxArchive(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeInBoxEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeInBoxEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo[] EndInterchangeInBoxEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeInBoxArchiveEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeInBoxArchiveEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, short PageNo, short RecordsPerPage, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfoCollection EndInterchangeInBoxArchiveEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeOutBox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeOutBox(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo[] EndInterchangeOutBox(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeOutBoxArchive")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeOutBoxArchive(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, short PageNo, short RecordsPerPage, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfoCollection EndInterchangeOutBoxArchive(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeOutBoxEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeOutBoxEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo[] EndInterchangeOutBoxEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeOutBoxArchiveEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeOutBoxArchiveEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, string InterchangeControlID, short PageNo, short RecordsPerPage, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfoCollection EndInterchangeOutBoxArchiveEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeOutBoxPending")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeOutBoxPending(string SessionID, int ECGridIDFrom, int ECGridIDTo, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo[] EndInterchangeOutBoxPending(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeOutBoxPendingEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeOutBoxPendingEx(string SessionID, int NetworkID, int MailboxID, int ECGridIDFrom, int ECGridIDTo, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo[] EndInterchangeOutBoxPendingEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeInBoxPending")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeInBoxPending(string SessionID, int ECGridIDFrom, int ECGridIDTo, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo[] EndInterchangeInBoxPending(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeInBoxPendingEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeInBoxPendingEx(string SessionID, int NetworkID, int MailboxID, int ECGridIDFrom, int ECGridIDTo, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo[] EndInterchangeInBoxPendingEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeHeaderInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeHeaderInfo(string SessionID, string InterchangeHeader, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo EndInterchangeHeaderInfo(System.IAsyncResult result);

    // CODEGEN: Parameter 'InterchangeHeader' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeHeaderInfoB")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeHeaderInfoB(InterchangeHeaderInfoBRequest request, System.AsyncCallback callback, object asyncState);

    InterchangeHeaderInfoBResponse EndInterchangeHeaderInfoB(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeOutBoxNoRoute")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeOutBoxNoRoute(string SessionID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo[] EndInterchangeOutBoxNoRoute(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeOutBoxNoRouteEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeOutBoxNoRouteEx(string SessionID, int NetworkID, int MailboxID, System.DateTime BeginDate, System.DateTime EndDate, int ECGridIDFrom, int ECGridIDTo, System.AsyncCallback callback, object asyncState);

    InterchangeIDInfo[] EndInterchangeOutBoxNoRouteEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeResend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeResend(string SessionID, long InterchangeID, System.AsyncCallback callback, object asyncState);

    bool EndInterchangeResend(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterchangeCancel")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterchangeCancel(string SessionID, int InterchangeID, System.AsyncCallback callback, object asyncState);

    bool EndInterchangeCancel(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackEventInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackEventInfo(string SessionID, int CallBackEventID, short QueueCount, System.AsyncCallback callback, object asyncState);

    CallBackEventIDInfo EndCallBackEventInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackEventListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackEventListEx(string SessionID, int NetworkID, int MailboxID, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    CallBackEventIDInfo[] EndCallBackEventListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackAddEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackAddEx(
                string SessionID,
                int NetworkID,
                int MailboxID,
                int UserID,
                Objects SystemObject,
                short ObjectStatus,
                Direction Direction,
                short Frequency,
                short MaxRetries,
                string URL,
                HTTPAuthType HTTPAuthentication,
                string HTTPUser,
                string HTTPPassword,
                Status Status,
                System.AsyncCallback callback,
                object asyncState);

    CallBackEventIDInfo EndCallBackAddEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackEventSetStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackEventSetStatus(string SessionID, int CallBackEventID, Status Status, System.AsyncCallback callback, object asyncState);

    bool EndCallBackEventSetStatus(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackQueueInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackQueueInfo(string SessionID, int CallBackQueueID, System.AsyncCallback callback, object asyncState);

    CallBackQueueIDInfo EndCallBackQueueInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackTest")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackTest(string SessionID, int CallBackEventID, int ParcelID, int InterchangeID, int UserID, System.AsyncCallback callback, object asyncState);

    CallBackQueueIDInfo EndCallBackTest(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackInvoke")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackInvoke(string SessionID, int CallBackQueueID, System.AsyncCallback callback, object asyncState);

    CallBackQueueIDInfo EndCallBackInvoke(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackPendingList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackPendingList(string SessionID, System.AsyncCallback callback, object asyncState);

    CallBackQueueIDInfo[] EndCallBackPendingList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackPendingListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackPendingListEx(string SessionID, int NetworkID, int MailboxID, System.AsyncCallback callback, object asyncState);

    CallBackQueueIDInfo[] EndCallBackPendingListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackFailedList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackFailedList(string SessionID, short MaxDays, System.AsyncCallback callback, object asyncState);

    CallBackQueueIDInfo[] EndCallBackFailedList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CallBackFailedListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCallBackFailedListEx(string SessionID, int NetworkID, int MailboxID, short MaxDays, System.AsyncCallback callback, object asyncState);

    CallBackQueueIDInfo[] EndCallBackFailedListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectInfo(string SessionID, int InterconnectID, System.AsyncCallback callback, object asyncState);

    InterconnectIDInfo EndInterconnectInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectInfoGUID")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectInfoGUID(string SessionID, string UniqueID, System.AsyncCallback callback, object asyncState);

    InterconnectIDInfo EndInterconnectInfoGUID(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectNoteList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectNoteList(string SessionID, int InterconnectID, System.AsyncCallback callback, object asyncState);

    InterconnectNote[] EndInterconnectNoteList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectListByECGridID")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectListByECGridID(string SessionID, int ECGridID1, int ECGridID2, System.AsyncCallback callback, object asyncState);

    InterconnectIDInfo[] EndInterconnectListByECGridID(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectListByStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectListByStatus(string SessionID, StatusInterconnect Status, int ECGridID, short MaxDays, System.AsyncCallback callback, object asyncState);

    InterconnectIDInfo[] EndInterconnectListByStatus(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectListByStatusEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectListByStatusEx(string SessionID, int NetworkID, int MailboxID, StatusInterconnect IntStatus, int ECGridID, short MaxDays, System.AsyncCallback callback, object asyncState);

    InterconnectIDInfo[] EndInterconnectListByStatusEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectAssignNetOps")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectAssignNetOps(string SessionID, int InterconnectID, int UserID, eMailTo eMailTo, System.AsyncCallback callback, object asyncState);

    bool EndInterconnectAssignNetOps(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectCount")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectCount(string SessionID, short MaxDays, System.AsyncCallback callback, object asyncState);

    System.Data.DataSet EndInterconnectCount(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectCountEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectCountEx(string SessionID, int NetworkID, int MailboxID, int ECGridID, short MaxDays, System.AsyncCallback callback, object asyncState);

    System.Data.DataSet EndInterconnectCountEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MigrationList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMigrationList(string SessionID, MigrationStatus Status, bool ShowCanceled, System.AsyncCallback callback, object asyncState);

    MigrationIDInfo[] EndMigrationList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MigrationListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMigrationListEx(string SessionID, int NetworkID, int MailboxID, MigrationStatus Status, bool ShowCanceled, System.AsyncCallback callback, object asyncState);

    MigrationIDInfo[] EndMigrationListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MigrationInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMigrationInfo(string SessionID, int MigrationID, System.AsyncCallback callback, object asyncState);

    MigrationIDInfo EndMigrationInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MigrationAddTP")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMigrationAddTP(string SessionID, int MigrationID, int ECGridID, System.AsyncCallback callback, object asyncState);

    bool EndMigrationAddTP(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CarbonCopyAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCarbonCopyAdd(string SessionID, int ECGridIDFrom, int ECGridIDTo, int ECGridIDCCFrom, int ECGridIDCCTo, string TransactionSet, System.AsyncCallback callback, object asyncState);

    int EndCarbonCopyAdd(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CarbonCopyAddEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCarbonCopyAddEx(string SessionID, int NetworkID, int MailboxID, int ECGridIDFrom, int ECGridIDTo, int ECGridIDCCFrom, int ECGridIDCCTo, string TransactionSet, System.AsyncCallback callback, object asyncState);

    int EndCarbonCopyAddEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CarbonCopyActivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCarbonCopyActivate(string SessionID, int CarbonCopyID, System.AsyncCallback callback, object asyncState);

    bool EndCarbonCopyActivate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CarbonCopySuspend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCarbonCopySuspend(string SessionID, int CarbonCopyID, System.AsyncCallback callback, object asyncState);

    bool EndCarbonCopySuspend(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CarbonCopyTerminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCarbonCopyTerminate(string SessionID, int CarbonCopyID, System.AsyncCallback callback, object asyncState);

    bool EndCarbonCopyTerminate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CarbonCopyInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCarbonCopyInfo(string SessionID, int CarbonCopyID, System.AsyncCallback callback, object asyncState);

    CarbonCopyIDInfo EndCarbonCopyInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CarbonCopyList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCarbonCopyList(string SessionID, int ECGridIDFrom, int ECGridIDTo, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    CarbonCopyIDInfo[] EndCarbonCopyList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/CarbonCopyListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginCarbonCopyListEx(string SessionID, int NetworkID, int MailboxID, int ECGridIDFrom, int ECGridIDTo, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    CarbonCopyIDInfo[] EndCarbonCopyListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelInBox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelInBox(string SessionID, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelInBox(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelInBoxEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelInBoxEx(string SessionID, int NetworkID, int MailboxID, int ECGridIDFrom, int ECGridIDTo, System.AsyncCallback callback, object asyncState);

    ParcelIDInfoCollection EndParcelInBoxEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelInfo(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    ParcelIDInfo EndParcelInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelDownload")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelDownload(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    FileInfo EndParcelDownload(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelDownloadNoUpdate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelDownloadNoUpdate(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    FileInfo EndParcelDownloadNoUpdate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelDownloadGZip")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelDownloadGZip(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    FileInfo EndParcelDownloadGZip(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelDownloadInner")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelDownloadInner(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    FileInfo EndParcelDownloadInner(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelDownloadConfirm")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelDownloadConfirm(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    bool EndParcelDownloadConfirm(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelAcknowledgmentNote")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelAcknowledgmentNote(string SessionID, long ParcelID, string Subject, string Note, System.AsyncCallback callback, object asyncState);

    bool EndParcelAcknowledgmentNote(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelDownloadCancel")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelDownloadCancel(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    bool EndParcelDownloadCancel(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelDownloadConfirmPendingAck")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelDownloadConfirmPendingAck(string SessionID, long ParcelID, ParcelStatus Status, System.AsyncCallback callback, object asyncState);

    bool EndParcelDownloadConfirmPendingAck(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelDownloadReset")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelDownloadReset(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    bool EndParcelDownloadReset(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelResend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelResend(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    bool EndParcelResend(System.IAsyncResult result);

    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelUpload")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelUpload(ParcelUploadRequest request, System.AsyncCallback callback, object asyncState);

    ParcelUploadResponse EndParcelUpload(System.IAsyncResult result);

    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelUploadExA")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelUploadExA(ParcelUploadExARequest request, System.AsyncCallback callback, object asyncState);

    ParcelUploadExAResponse EndParcelUploadExA(System.IAsyncResult result);

    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelUploadGZip")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelUploadGZip(ParcelUploadGZipRequest request, System.AsyncCallback callback, object asyncState);

    ParcelUploadGZipResponse EndParcelUploadGZip(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelUpdateStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelUpdateStatus(string SessionID, long ParcelID, ParcelStatus Status, bool TransLogOnly, System.AsyncCallback callback, object asyncState);

    bool EndParcelUpdateStatus(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelUpdateLocalStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelUpdateLocalStatus(string SessionID, long ParcelID, short Status, System.AsyncCallback callback, object asyncState);

    bool EndParcelUpdateLocalStatus(System.IAsyncResult result);

    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelUploadEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelUploadEx(ParcelUploadExRequest request, System.AsyncCallback callback, object asyncState);

    ParcelUploadExResponse EndParcelUploadEx(System.IAsyncResult result);

    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelUploadDirected")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelUploadDirected(ParcelUploadDirectedRequest request, System.AsyncCallback callback, object asyncState);

    ParcelUploadDirectedResponse EndParcelUploadDirected(System.IAsyncResult result);

    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelUploadGZipEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelUploadGZipEx(ParcelUploadGZipExRequest request, System.AsyncCallback callback, object asyncState);

    ParcelUploadGZipExResponse EndParcelUploadGZipEx(System.IAsyncResult result);

    // CODEGEN: Parameter 'Content' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelUploadDirectedGZip")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelUploadDirectedGZip(ParcelUploadDirectedGZipRequest request, System.AsyncCallback callback, object asyncState);

    ParcelUploadDirectedGZipResponse EndParcelUploadDirectedGZip(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelTest")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelTest(string SessionID, int ECGridIDFrom, int ECGridIDTo, EDIStandard DocumentType, System.AsyncCallback callback, object asyncState);

    int EndParcelTest(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelSetMailbagControlID")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelSetMailbagControlID(string SessionID, int ParcelID, string MailbagControlID, System.AsyncCallback callback, object asyncState);

    bool EndParcelSetMailbagControlID(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ParcelManifest")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginParcelManifest(string SessionID, long ParcelID, System.AsyncCallback callback, object asyncState);

    ManifestInfo[] EndParcelManifest(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkReportsContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkReportsContact(string SessionID, int NetworkID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndNetworkReportsContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkSetWebsite")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkSetWebsite(string SessionID, int NetworkID, string URL, NetworkWebsiteType WebsiteType, System.AsyncCallback callback, object asyncState);

    bool EndNetworkSetWebsite(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkBackupAllConfigs")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkBackupAllConfigs(string SessionID, System.AsyncCallback callback, object asyncState);

    string EndNetworkBackupAllConfigs(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkX12Delimiters")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkX12Delimiters(string SessionID, int NetworkID, byte SegTerm, byte ElmSep, byte SubElmSep, System.AsyncCallback callback, object asyncState);

    bool EndNetworkX12Delimiters(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxAdd(string SessionID, string Name, int UserID, System.AsyncCallback callback, object asyncState);

    int EndMailboxAdd(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxAddEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxAddEx(string SessionID, int NetworkID, string Name, string UserID, System.AsyncCallback callback, object asyncState);

    int EndMailboxAddEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxActivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxActivate(string SessionID, int MailboxID, System.AsyncCallback callback, object asyncState);

    bool EndMailboxActivate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxSuspend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxSuspend(string SessionID, int MailboxID, System.AsyncCallback callback, object asyncState);

    bool EndMailboxSuspend(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxTerminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxTerminate(string SessionID, int MailboxID, System.AsyncCallback callback, object asyncState);

    bool EndMailboxTerminate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxManaged")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxManaged(string SessionID, int MailboxID, bool Managed, System.AsyncCallback callback, object asyncState);

    bool EndMailboxManaged(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxDeleteOnDownload")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxDeleteOnDownload(string SessionID, int MailboxID, bool DeleteOnDownload, System.AsyncCallback callback, object asyncState);

    bool EndMailboxDeleteOnDownload(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxInfo(string SessionID, int MailboxID, System.AsyncCallback callback, object asyncState);

    MailboxIDInfo EndMailboxInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxName")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxName(string SessionID, int MailboxID, string Name, System.AsyncCallback callback, object asyncState);

    bool EndMailboxName(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxSetContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxSetContact(string SessionID, int MailboxID, int UserID, NetworkContactType ContactType, System.AsyncCallback callback, object asyncState);

    bool EndMailboxSetContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxOwnerContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxOwnerContact(string SessionID, int MailboxID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndMailboxOwnerContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxErrorsContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxErrorsContact(string SessionID, int MailboxID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndMailboxErrorsContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxInterconnectsContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxInterconnectsContact(string SessionID, int MailboxID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndMailboxInterconnectsContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxNoticesContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxNoticesContact(string SessionID, int MailboxID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndMailboxNoticesContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxX12Delimiters")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxX12Delimiters(string SessionID, int MailboxID, byte SegTerm, byte ElmSep, byte SubElmSep, System.AsyncCallback callback, object asyncState);

    bool EndMailboxX12Delimiters(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxInBoxTimeout")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxInBoxTimeout(string SessionID, int MailboxID, short Minutes, System.AsyncCallback callback, object asyncState);

    bool EndMailboxInBoxTimeout(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxDescription")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxDescription(string SessionID, int MailboxID, string Description, System.AsyncCallback callback, object asyncState);

    bool EndMailboxDescription(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxUse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxUse(string SessionID, int MailboxID, UseType UseType, System.AsyncCallback callback, object asyncState);

    bool EndMailboxUse(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxList(string SessionID, string Name, System.AsyncCallback callback, object asyncState);

    MailboxIDInfo[] EndMailboxList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/MailboxListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginMailboxListEx(string SessionID, int NetworkID, string Name, System.AsyncCallback callback, object asyncState);

    MailboxIDInfo[] EndMailboxListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPAdd(string SessionID, string Qualifier, string ID, string Description, System.AsyncCallback callback, object asyncState);

    int EndTPAdd(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPAddVAN")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPAddVAN(string SessionID, int NetworkID, string Qualifier, string ID, string Description, System.AsyncCallback callback, object asyncState);

    int EndTPAddVAN(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPAddEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPAddEx(string SessionID, int NetworkID, int MailboxID, string Qualifier, string ID, string Description, RoutingGroup RoutingGroup, System.AsyncCallback callback, object asyncState);

    int EndTPAddEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPMove")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPMove(string SessionID, int ECGridID, System.DateTime MoveDateTime, System.AsyncCallback callback, object asyncState);

    int EndTPMove(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPMoveMailbox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPMoveMailbox(string SessionID, int ECGridID, int MailboxID, System.AsyncCallback callback, object asyncState);

    int EndTPMoveMailbox(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPMoveEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPMoveEx(string SessionID, int NetworkID, int MailboxID, int ECGridID, System.DateTime MoveDateTime, System.AsyncCallback callback, object asyncState);

    int EndTPMoveEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPUpdateDescription")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPUpdateDescription(string SessionID, int ECGridID, string Description, System.AsyncCallback callback, object asyncState);

    bool EndTPUpdateDescription(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPUpdateDataEMail")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPUpdateDataEMail(string SessionID, int ECGridID, EMailSystem EMailSystem, string DataEMail, EMailPayload PayloadPosition, System.AsyncCallback callback, object asyncState);

    bool EndTPUpdateDataEMail(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPActivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPActivate(string SessionID, int ECGridID, System.AsyncCallback callback, object asyncState);

    bool EndTPActivate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPSuspend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPSuspend(string SessionID, int ECGridID, System.AsyncCallback callback, object asyncState);

    bool EndTPSuspend(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPTerminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPTerminate(string SessionID, int ECGridID, System.AsyncCallback callback, object asyncState);

    bool EndTPTerminate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPSetRoutingGroup")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPSetRoutingGroup(string SessionID, int ECGridID, RoutingGroup RoutingGroup, System.AsyncCallback callback, object asyncState);

    bool EndTPSetRoutingGroup(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPInfo(string SessionID, int ECGridID, System.AsyncCallback callback, object asyncState);

    ECGridIDInfo EndTPInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPSearch")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPSearch(string SessionID, string Qualifier, string ID, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    ECGridIDInfo[] EndTPSearch(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPSearchEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPSearchEx(string SessionID, int NetworkID, int MailboxID, string Qualifier, string ID, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    ECGridIDInfo[] EndTPSearchEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPList(string SessionID, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    ECGridIDInfo[] EndTPList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPListEx(string SessionID, int NetworkID, int MailboxID, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    ECGridIDInfo[] EndTPListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPListExPaged")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPListExPaged(string SessionID, int NetworkID, int MailboxID, bool ShowInactive, short PageSize, short PageNumber, System.AsyncCallback callback, object asyncState);

    ECGridIDInfoCollection EndTPListExPaged(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPListByOwner")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPListByOwner(string SessionID, int OwnerUserID, OrderBy OrderBy, bool ShowInactive, short PageSize, short PageNumber, System.AsyncCallback callback, object asyncState);

    ECGridIDInfoCollection EndTPListByOwner(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPFindEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPFindEx(string SessionID, int NetworkID, int MailboxID, string Description, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    ECGridIDInfo[] EndTPFindEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPGetMailboxDefault")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPGetMailboxDefault(string SessionID, int NetworkID, int MailboxID, System.AsyncCallback callback, object asyncState);

    ECGridIDInfo EndTPGetMailboxDefault(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPSetMailboxDefault")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPSetMailboxDefault(string SessionID, int ECGridID, System.AsyncCallback callback, object asyncState);

    bool EndTPSetMailboxDefault(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/TPSetOwner")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginTPSetOwner(string SessionID, int ECGridID, int OwnerUserID, System.AsyncCallback callback, object asyncState);

    bool EndTPSetOwner(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectAdd(string SessionID, int ECGridID1, int ECGridID2, string Reference, string ContactName, string ContactEMail, bool NotifyContact, bool Preconfirm, string Note, System.AsyncCallback callback, object asyncState);

    InterconnectIDInfo EndInterconnectAdd(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectUpdate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectUpdate(string SessionID, int InterconnectID, StatusInterconnect Status, AuthLevel AuthLevel, string Note, eMailTo EMailTo, string OtherEMailAddress, System.AsyncCallback callback, object asyncState);

    bool EndInterconnectUpdate(System.IAsyncResult result);

    // CODEGEN: Parameter 'AttachmentContent' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectNote")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectNote(InterconnectNoteRequest request, System.AsyncCallback callback, object asyncState);

    InterconnectNoteResponse EndInterconnectNote(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/InterconnectCancel")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginInterconnectCancel(string SessionID, int InterconnectID, string Note, eMailTo EMailTo, string OtherEMailAddress, System.AsyncCallback callback, object asyncState);

    bool EndInterconnectCancel(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/Login")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginLogin(string LoginName, string Password, System.AsyncCallback callback, object asyncState);

    string EndLogin(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/GenerateAPIKey")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginGenerateAPIKey(string SessionID, int UserID, System.AsyncCallback callback, object asyncState);

    string EndGenerateAPIKey(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/GeneratePassword")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginGeneratePassword(string SessionID, short Length, System.AsyncCallback callback, object asyncState);

    string EndGeneratePassword(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/Logout")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginLogout(string SessionID, System.AsyncCallback callback, object asyncState);

    int EndLogout(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/ChangePassword")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginChangePassword(string SessionID, string OldPassword, string NewPassword, System.AsyncCallback callback, object asyncState);

    bool EndChangePassword(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/WhoAmI")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginWhoAmI(string SessionID, System.AsyncCallback callback, object asyncState);

    SessionInfo EndWhoAmI(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserAdd(
                string SessionID,
                int MailboxID,
                string LoginName,
                string Password,
                string RecoveryQuestion,
                string RecoveryAnswer,
                string FirstName,
                string LastName,
                string Company,
                string EMail,
                string Phone,
                string CellPhone,
                CellCarrier CellCarrier,
                AuthLevel AuthLevel,
                System.AsyncCallback callback,
                object asyncState);

    int EndUserAdd(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserAddEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserAddEx(
                string SessionID,
                int NetworkID,
                int MailboxID,
                string LoginName,
                string Password,
                string RecoveryQuestion,
                string RecoveryAnswer,
                string FirstName,
                string LastName,
                string Company,
                string EMail,
                string Phone,
                string CellPhone,
                CellCarrier CellCarrier,
                AuthLevel AuthLevel,
                System.AsyncCallback callback,
                object asyncState);

    int EndUserAddEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserInfo(string SessionID, int UserID, System.AsyncCallback callback, object asyncState);

    UserIDInfo EndUserInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserUpdate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserUpdate(string SessionID, int UserID, string FirstName, string LastName, string Company, string EMail, string Phone, string CellPhone, CellCarrier CellCarrier, AuthLevel AuthLevel, System.AsyncCallback callback, object asyncState);

    bool EndUserUpdate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserPassword")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserPassword(string SessionID, int UserID, string CurrentRecoveryAnswer, string Password, string RecoveryQuestion, string RecoveryAnswer, System.AsyncCallback callback, object asyncState);

    bool EndUserPassword(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserActivate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserActivate(string SessionID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndUserActivate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserSuspend")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserSuspend(string SessionID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndUserSuspend(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserTerminate")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserTerminate(string SessionID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndUserTerminate(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserSendSMS")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserSendSMS(string SessionID, int UserID, string Text, System.AsyncCallback callback, object asyncState);

    bool EndUserSendSMS(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserReset")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserReset(string SessionID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndUserReset(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserResetAll")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserResetAll(string SessionID, short TimeOutMinutes, System.AsyncCallback callback, object asyncState);

    short EndUserResetAll(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserList(string SessionID, string Name, System.AsyncCallback callback, object asyncState);

    UserIDInfo[] EndUserList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserListEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserListEx(string SessionID, int NetworkID, int MailboxID, string Name, System.AsyncCallback callback, object asyncState);

    UserIDInfo[] EndUserListEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserListLockedOut")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserListLockedOut(string SessionID, System.AsyncCallback callback, object asyncState);

    UserIDInfo[] EndUserListLockedOut(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserListLockedOutEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserListLockedOutEx(string SessionID, int NetworkID, int MailboxID, System.AsyncCallback callback, object asyncState);

    UserIDInfo[] EndUserListLockedOutEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserSetNetworkMailbox")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserSetNetworkMailbox(string SessionID, int UserID, int NetworkID, int MailboxID, System.AsyncCallback callback, object asyncState);

    bool EndUserSetNetworkMailbox(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserSetAuthLevel")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserSetAuthLevel(string SessionID, int UserID, AuthLevel AuthLevel, System.AsyncCallback callback, object asyncState);

    bool EndUserSetAuthLevel(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/UserGetAPIKey")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginUserGetAPIKey(string SessionID, int UserID, System.AsyncCallback callback, object asyncState);

    string EndUserGetAPIKey(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/SessionLogCurrent")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginSessionLogCurrent(string SessionID, System.AsyncCallback callback, object asyncState);

    SessionLogInfo EndSessionLogCurrent(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/SessionLog")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginSessionLog(string SessionID, short MaxRecords, System.AsyncCallback callback, object asyncState);

    SessionLogInfo[] EndSessionLog(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/SessionLogEx")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginSessionLogEx(string SessionID, int UserID, System.DateTime StartTime, System.DateTime EndTime, short MaxRecords, System.AsyncCallback callback, object asyncState);

    SessionLogInfo[] EndSessionLogEx(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/KeyGet")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginKeyGet(string SessionID, string Key, Objects SystemObject, int ObjectID, KeyVisibility Visibility, System.AsyncCallback callback, object asyncState);

    KeyValue EndKeyGet(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/KeyList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginKeyList(string SessionID, Objects SystemObject, int ObjectID, System.AsyncCallback callback, object asyncState);

    KeyValue[] EndKeyList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/KeySet")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginKeySet(string SessionID, string Key, Objects SystemObject, int ObjectID, KeyVisibility Visibility, string Value, string Meta, int DaysToLive, System.AsyncCallback callback, object asyncState);

    bool EndKeySet(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/KeyRemove")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginKeyRemove(string SessionID, string Key, Objects SystemObject, int ObjectID, KeyVisibility Visibility, System.AsyncCallback callback, object asyncState);

    bool EndKeyRemove(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkInfo")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkInfo(string SessionID, int NetworkID, System.AsyncCallback callback, object asyncState);

    NetworkIDInfo EndNetworkInfo(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkInfoWithLog")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkInfoWithLog(string SessionID, int NetworkID, System.AsyncCallback callback, object asyncState);

    NetworkIDInfo EndNetworkInfoWithLog(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkList(string SessionID, string Name, System.AsyncCallback callback, object asyncState);

    NetworkIDInfo[] EndNetworkList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkStatusSummary")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkStatusSummary(string SessionID, bool ShowInactive, System.AsyncCallback callback, object asyncState);

    System.Data.DataSet EndNetworkStatusSummary(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkOutageList")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkOutageList(string SessionID, System.AsyncCallback callback, object asyncState);

    NetworkIDInfo[] EndNetworkOutageList(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkStart")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkStart(string SessionID, int NetworkID, System.AsyncCallback callback, object asyncState);

    bool EndNetworkStart(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkStop")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkStop(string SessionID, int NetworkID, System.AsyncCallback callback, object asyncState);

    bool EndNetworkStop(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkRestart")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkRestart(string SessionID, int NetworkID, System.AsyncCallback callback, object asyncState);

    bool EndNetworkRestart(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkCheckIn")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkCheckIn(string SessionID, bool OutOnly, string Version, string IP, NetworkLogType ActionType, NetworkLogStatus Status, string Description, int ID, string ComputerName, string UserName, string UserDomain, System.AsyncCallback callback, object asyncState);

    bool EndNetworkCheckIn(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkSetStatus")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkSetStatus(string SessionID, int NetworkID, Status Status, System.AsyncCallback callback, object asyncState);

    bool EndNetworkSetStatus(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkAdd")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkAdd(string SessionID, int NetworkID, string Name, string Location, NetworkServiceType Type, NetworkRoutingType RoutingType, string Password, short RunDir, string Server, System.AsyncCallback callback, object asyncState);

    int EndNetworkAdd(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkSetContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkSetContact(string SessionID, int NetworkID, int UserID, NetworkContactType ContactType, System.AsyncCallback callback, object asyncState);

    bool EndNetworkSetContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkGetContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkGetContact(string SessionID, int NetworkID, NetworkContactType ContactType, System.AsyncCallback callback, object asyncState);

    UserIDInfo EndNetworkGetContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkOwnerContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkOwnerContact(string SessionID, int NetworkID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndNetworkOwnerContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkErrorsContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkErrorsContact(string SessionID, int NetworkID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndNetworkErrorsContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkInterconnectsContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkInterconnectsContact(string SessionID, int NetworkID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndNetworkInterconnectsContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkNoticesContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkNoticesContact(string SessionID, int NetworkID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndNetworkNoticesContact(System.IAsyncResult result);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://ecgridos.net/NetworkBillingContact")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.IAsyncResult BeginNetworkBillingContact(string SessionID, int NetworkID, int UserID, System.AsyncCallback callback, object asyncState);

    bool EndNetworkBillingContact(System.IAsyncResult result);

    #endregion
}

#region Classes, Objects, Enums

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class Contract
{
    
    private int contractIDField;
    
    private string descriptionField;
    
    private string contractNumberField;
    
    private short currentModField;
    
    private System.DateTime dateField;
    
    private System.DateTime effectiveField;
    
    private System.DateTime expiresField;
    
    private short termField;
    
    private short renewalDaysField;
    
    private short optionTermsField;
    
    private Status statusField;
    
    private string pONumberField;
    
    private bool aggregateNetworkTrafficField;
    
    private string addressField;
    
    private UserIDInfo ownerField;
    
    private UserIDInfo administratorUserField;
    
    private UserIDInfo accountingUserField;
    
    private UserIDInfo accountingCCUserField;
    
    private int x12InvoiceECGridIDField;
    
    private NetworkIDInfo[] networksField;
    
    private MailboxIDInfo[] mailboxesField;
    
    private string lastInvoiceNumberField;
    
    private System.DateTime lastInvoiceDateField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int ContractID
    {
        get
        {
            return this.contractIDField;
        }
        set
        {
            this.contractIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string ContractNumber
    {
        get
        {
            return this.contractNumberField;
        }
        set
        {
            this.contractNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public short CurrentMod
    {
        get
        {
            return this.currentModField;
        }
        set
        {
            this.currentModField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime Date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public System.DateTime Effective
    {
        get
        {
            return this.effectiveField;
        }
        set
        {
            this.effectiveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public System.DateTime Expires
    {
        get
        {
            return this.expiresField;
        }
        set
        {
            this.expiresField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public short Term
    {
        get
        {
            return this.termField;
        }
        set
        {
            this.termField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public short RenewalDays
    {
        get
        {
            return this.renewalDaysField;
        }
        set
        {
            this.renewalDaysField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public short OptionTerms
    {
        get
        {
            return this.optionTermsField;
        }
        set
        {
            this.optionTermsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public string PONumber
    {
        get
        {
            return this.pONumberField;
        }
        set
        {
            this.pONumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public bool AggregateNetworkTraffic
    {
        get
        {
            return this.aggregateNetworkTrafficField;
        }
        set
        {
            this.aggregateNetworkTrafficField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public string Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public UserIDInfo Owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public UserIDInfo AdministratorUser
    {
        get
        {
            return this.administratorUserField;
        }
        set
        {
            this.administratorUserField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public UserIDInfo AccountingUser
    {
        get
        {
            return this.accountingUserField;
        }
        set
        {
            this.accountingUserField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public UserIDInfo AccountingCCUser
    {
        get
        {
            return this.accountingCCUserField;
        }
        set
        {
            this.accountingCCUserField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public int X12InvoiceECGridID
    {
        get
        {
            return this.x12InvoiceECGridIDField;
        }
        set
        {
            this.x12InvoiceECGridIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=19)]
    public NetworkIDInfo[] Networks
    {
        get
        {
            return this.networksField;
        }
        set
        {
            this.networksField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=20)]
    public MailboxIDInfo[] Mailboxes
    {
        get
        {
            return this.mailboxesField;
        }
        set
        {
            this.mailboxesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=21)]
    public string LastInvoiceNumber
    {
        get
        {
            return this.lastInvoiceNumberField;
        }
        set
        {
            this.lastInvoiceNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=22)]
    public System.DateTime LastInvoiceDate
    {
        get
        {
            return this.lastInvoiceDateField;
        }
        set
        {
            this.lastInvoiceDateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum Status
{
    
    /// <remarks/>
    Development,
    
    /// <remarks/>
    Active,
    
    /// <remarks/>
    Preproduction,
    
    /// <remarks/>
    Suspended,
    
    /// <remarks/>
    Terminated,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class UserIDInfo
{
    
    private int userIDField;
    
    private string loginNameField;
    
    private string recoveryQuestionField;
    
    private string firstNameField;
    
    private string lastNameField;
    
    private string companyField;
    
    private string eMailField;
    
    private string phoneField;
    
    private string cellPhoneField;
    
    private CellCarrier cellCarrierField;
    
    private short timeZoneOffsetField;
    
    private int networkIDField;
    
    private int mailboxIDField;
    
    private AuthLevel authLevelField;
    
    private System.DateTime createdField;
    
    private System.DateTime modifiedField;
    
    private System.DateTime lastLoginField;
    
    private Status statusField;
    
    private bool lockedOutField;
    
    private short openSessionsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string LoginName
    {
        get
        {
            return this.loginNameField;
        }
        set
        {
            this.loginNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string RecoveryQuestion
    {
        get
        {
            return this.recoveryQuestionField;
        }
        set
        {
            this.recoveryQuestionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string FirstName
    {
        get
        {
            return this.firstNameField;
        }
        set
        {
            this.firstNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string LastName
    {
        get
        {
            return this.lastNameField;
        }
        set
        {
            this.lastNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string Company
    {
        get
        {
            return this.companyField;
        }
        set
        {
            this.companyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string EMail
    {
        get
        {
            return this.eMailField;
        }
        set
        {
            this.eMailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string Phone
    {
        get
        {
            return this.phoneField;
        }
        set
        {
            this.phoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string CellPhone
    {
        get
        {
            return this.cellPhoneField;
        }
        set
        {
            this.cellPhoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public CellCarrier CellCarrier
    {
        get
        {
            return this.cellCarrierField;
        }
        set
        {
            this.cellCarrierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public short TimeZoneOffset
    {
        get
        {
            return this.timeZoneOffsetField;
        }
        set
        {
            this.timeZoneOffsetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public AuthLevel AuthLevel
    {
        get
        {
            return this.authLevelField;
        }
        set
        {
            this.authLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public System.DateTime LastLogin
    {
        get
        {
            return this.lastLoginField;
        }
        set
        {
            this.lastLoginField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public bool LockedOut
    {
        get
        {
            return this.lockedOutField;
        }
        set
        {
            this.lockedOutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=19)]
    public short OpenSessions
    {
        get
        {
            return this.openSessionsField;
        }
        set
        {
            this.openSessionsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum CellCarrier
{
    
    /// <remarks/>
    NoChange,
    
    /// <remarks/>
    Undefined,
    
    /// <remarks/>
    ATTCingular,
    
    /// <remarks/>
    Verizon,
    
    /// <remarks/>
    TMobile,
    
    /// <remarks/>
    SprintPCS,
    
    /// <remarks/>
    Nextel,
    
    /// <remarks/>
    Alltel,
    
    /// <remarks/>
    VirginMobile,
    
    /// <remarks/>
    ATTPreCingular,
    
    /// <remarks/>
    ATT,
    
    /// <remarks/>
    BoostMobile,
    
    /// <remarks/>
    USCellular,
    
    /// <remarks/>
    MetroPCS,
    
    /// <remarks/>
    Powertel,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum AuthLevel
{
    
    /// <remarks/>
    NoChange,
    
    /// <remarks/>
    Root,
    
    /// <remarks/>
    TechOps,
    
    /// <remarks/>
    NetOps,
    
    /// <remarks/>
    NetworkAdmin,
    
    /// <remarks/>
    NetworkUser,
    
    /// <remarks/>
    MailboxAdmin,
    
    /// <remarks/>
    MailboxUser,
    
    /// <remarks/>
    TPUser,
    
    /// <remarks/>
    General,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class KeyValue
{
    
    private string keyField;
    
    private string valueField;
    
    private string metaField;
    
    private System.DateTime createdField;
    
    private System.DateTime expiresField;
    
    private KeyVisibility visibilityField;
    
    private int networkIDField;
    
    private int mailboxIDField;
    
    private int userIDField;
    
    private string sessionIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Key
    {
        get
        {
            return this.keyField;
        }
        set
        {
            this.keyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string Meta
    {
        get
        {
            return this.metaField;
        }
        set
        {
            this.metaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime Expires
    {
        get
        {
            return this.expiresField;
        }
        set
        {
            this.expiresField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public KeyVisibility Visibility
    {
        get
        {
            return this.visibilityField;
        }
        set
        {
            this.visibilityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public string SessionID
    {
        get
        {
            return this.sessionIDField;
        }
        set
        {
            this.sessionIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum KeyVisibility
{
    
    /// <remarks/>
    Private,
    
    /// <remarks/>
    Shared,
    
    /// <remarks/>
    Public,
    
    /// <remarks/>
    Session,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class SessionEvents
{
    
    private APICall aPICallField;
    
    private System.DateTime dateField;
    
    private int millisecondsField;
    
    private string ipField;
    
    private RetCode returnCodeField;
    
    private string commentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public APICall APICall
    {
        get
        {
            return this.aPICallField;
        }
        set
        {
            this.aPICallField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime Date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int Milliseconds
    {
        get
        {
            return this.millisecondsField;
        }
        set
        {
            this.millisecondsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string ip
    {
        get
        {
            return this.ipField;
        }
        set
        {
            this.ipField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public RetCode ReturnCode
    {
        get
        {
            return this.returnCodeField;
        }
        set
        {
            this.returnCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string Comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum APICall
{
    
    /// <remarks/>
    GenerateAPIKey,
    
    /// <remarks/>
    Login,
    
    /// <remarks/>
    Logout,
    
    /// <remarks/>
    ChangePassword,
    
    /// <remarks/>
    WhoAmI,
    
    /// <remarks/>
    UserAdd,
    
    /// <remarks/>
    UserAddEx,
    
    /// <remarks/>
    UserInfo,
    
    /// <remarks/>
    UserUpdate,
    
    /// <remarks/>
    UserActivate,
    
    /// <remarks/>
    UserSuspend,
    
    /// <remarks/>
    UserTerminate,
    
    /// <remarks/>
    UserReset,
    
    /// <remarks/>
    UserList,
    
    /// <remarks/>
    UserListEx,
    
    /// <remarks/>
    UserPassword,
    
    /// <remarks/>
    SessionLog,
    
    /// <remarks/>
    SessionLogEx,
    
    /// <remarks/>
    SessionLogCurrent,
    
    /// <remarks/>
    KeySave,
    
    /// <remarks/>
    KeyGet,
    
    /// <remarks/>
    KeyList,
    
    /// <remarks/>
    KeyRemove,
    
    /// <remarks/>
    UserSetNetworkMailbox,
    
    /// <remarks/>
    UserSetAuthLevel,
    
    /// <remarks/>
    UserListLockedOut,
    
    /// <remarks/>
    UserListLockedOutEx,
    
    /// <remarks/>
    UserResetAll,
    
    /// <remarks/>
    SetLocalTime,
    
    /// <remarks/>
    TerminateAPIKey,
    
    /// <remarks/>
    GeneratePassword,
    
    /// <remarks/>
    UserSendSMS,
    
    /// <remarks/>
    UserGetAPIKey,
    
    /// <remarks/>
    NetworkInfo,
    
    /// <remarks/>
    NetworkList,
    
    /// <remarks/>
    NetworkStatusSummary,
    
    /// <remarks/>
    NetworkOutageList,
    
    /// <remarks/>
    NetworkStart,
    
    /// <remarks/>
    NetworkStop,
    
    /// <remarks/>
    NetworkRestart,
    
    /// <remarks/>
    NetworkAdd,
    
    /// <remarks/>
    NetworkOwnerContact,
    
    /// <remarks/>
    NetworkErrorsContact,
    
    /// <remarks/>
    NetworkInterconnectsContact,
    
    /// <remarks/>
    NetworkNoticesContact,
    
    /// <remarks/>
    NetworkBillingContact,
    
    /// <remarks/>
    NetworkReportsContact,
    
    /// <remarks/>
    NetworkSetContact,
    
    /// <remarks/>
    NetworkGetContact,
    
    /// <remarks/>
    NetworkSetWebsite,
    
    /// <remarks/>
    NetworkSetStatus,
    
    /// <remarks/>
    NetworkInfoWithLog,
    
    /// <remarks/>
    NetworkBackupAllConfigs,
    
    /// <remarks/>
    NetworkX12Delimiters,
    
    /// <remarks/>
    NetworkCheckIn,
    
    /// <remarks/>
    MailboxAdd,
    
    /// <remarks/>
    MailboxAddEx,
    
    /// <remarks/>
    MailboxActivate,
    
    /// <remarks/>
    MailboxSuspend,
    
    /// <remarks/>
    MailboxTerminate,
    
    /// <remarks/>
    MailboxInfo,
    
    /// <remarks/>
    MailboxName,
    
    /// <remarks/>
    MailboxErrorsContact,
    
    /// <remarks/>
    MailboxInterconnectsContact,
    
    /// <remarks/>
    MailboxNoticesContact,
    
    /// <remarks/>
    MailboxX12Delimiters,
    
    /// <remarks/>
    MailboxInBoxTimeout,
    
    /// <remarks/>
    MailboxList,
    
    /// <remarks/>
    MailboxListEx,
    
    /// <remarks/>
    MailboxOwnerContact,
    
    /// <remarks/>
    MailboxManaged,
    
    /// <remarks/>
    MailboxDescription,
    
    /// <remarks/>
    MailboxUse,
    
    /// <remarks/>
    MailboxSetContact,
    
    /// <remarks/>
    MailboxDeleteOnDownload,
    
    /// <remarks/>
    TPAdd,
    
    /// <remarks/>
    TPAddVAN,
    
    /// <remarks/>
    TPAddEx,
    
    /// <remarks/>
    TPMove,
    
    /// <remarks/>
    TPMoveEx,
    
    /// <remarks/>
    TPUpdateDescription,
    
    /// <remarks/>
    TPActivate,
    
    /// <remarks/>
    TPSuspend,
    
    /// <remarks/>
    TPTerminate,
    
    /// <remarks/>
    TPInfo,
    
    /// <remarks/>
    TPSearch,
    
    /// <remarks/>
    TPSearchEx,
    
    /// <remarks/>
    TPList,
    
    /// <remarks/>
    TPListEx,
    
    /// <remarks/>
    TPFind,
    
    /// <remarks/>
    TPFindEx,
    
    /// <remarks/>
    TPDataEMail,
    
    /// <remarks/>
    TPSetMailboxDefault,
    
    /// <remarks/>
    TPGetMailboxDefault,
    
    /// <remarks/>
    TPEMailX400Format,
    
    /// <remarks/>
    TPMoveMailbox,
    
    /// <remarks/>
    TPSetRoutingGroup,
    
    /// <remarks/>
    TPListExPaged,
    
    /// <remarks/>
    TPListByOwner,
    
    /// <remarks/>
    TPSetOwner,
    
    /// <remarks/>
    InterconnectAdd,
    
    /// <remarks/>
    InterconnectUpdate,
    
    /// <remarks/>
    InterconnectNote,
    
    /// <remarks/>
    InterconnectCancel,
    
    /// <remarks/>
    InterconnectInfo,
    
    /// <remarks/>
    InterconnectNoteList,
    
    /// <remarks/>
    InterconnectListByECGridID,
    
    /// <remarks/>
    InterconnectListByStatus,
    
    /// <remarks/>
    InterconnectListByStatusEx,
    
    /// <remarks/>
    InterconnectAssignNetOps,
    
    /// <remarks/>
    InterconnectCount,
    
    /// <remarks/>
    InterconnectCountEx,
    
    /// <remarks/>
    InterconnectInfoGUID,
    
    /// <remarks/>
    MigrationAdd,
    
    /// <remarks/>
    MigrationAddAuthorization,
    
    /// <remarks/>
    MigrationSendRequest,
    
    /// <remarks/>
    MigrationUpdate,
    
    /// <remarks/>
    MigrationStatus,
    
    /// <remarks/>
    MigrationInfo,
    
    /// <remarks/>
    MigrationList,
    
    /// <remarks/>
    MigrationListEx,
    
    /// <remarks/>
    MigrationECGridIDAdd,
    
    /// <remarks/>
    MigrationECGridIDRemove,
    
    /// <remarks/>
    MigrationECGridIDStatus,
    
    /// <remarks/>
    MigrationECGridIDNote,
    
    /// <remarks/>
    CarbonCopyAdd,
    
    /// <remarks/>
    CarbonCopyAddEx,
    
    /// <remarks/>
    CarbonCopyActivate,
    
    /// <remarks/>
    CarbonCopySuspend,
    
    /// <remarks/>
    CarbonCopyTerminate,
    
    /// <remarks/>
    CarbonCopyInfo,
    
    /// <remarks/>
    CarbonCopyList,
    
    /// <remarks/>
    CarbonCopyListEx,
    
    /// <remarks/>
    ParcelInBox,
    
    /// <remarks/>
    ParcelInBoxEx,
    
    /// <remarks/>
    ParcelDownload,
    
    /// <remarks/>
    ParcelDownloadInner,
    
    /// <remarks/>
    ParcelDownloadConfirm,
    
    /// <remarks/>
    ParcelUpload,
    
    /// <remarks/>
    ParcelUploadEx,
    
    /// <remarks/>
    ParcelInfo,
    
    /// <remarks/>
    ParcelMainfest,
    
    /// <remarks/>
    ParcelInterchangeManifest,
    
    /// <remarks/>
    ParcelNoteList,
    
    /// <remarks/>
    ParcelInBoxArchive,
    
    /// <remarks/>
    ParcelInBoxArchiveEx,
    
    /// <remarks/>
    ParcelOutBoxArchive,
    
    /// <remarks/>
    ParcelOutBoxArchiveEx,
    
    /// <remarks/>
    ParcelOutBoxError,
    
    /// <remarks/>
    ParcelOutBoxErrorEx,
    
    /// <remarks/>
    InterchangeInBox,
    
    /// <remarks/>
    InterchangeInBoxEx,
    
    /// <remarks/>
    InterchangeOutBox,
    
    /// <remarks/>
    InterchangeOutBoxEx,
    
    /// <remarks/>
    InterchangeHeaderInfo,
    
    /// <remarks/>
    ParcelDownloadReset,
    
    /// <remarks/>
    InterchangeOutBoxNoRoute,
    
    /// <remarks/>
    InterchangeOutBoxNoRouteEx,
    
    /// <remarks/>
    ParcelUploadGZip,
    
    /// <remarks/>
    InterchangeInfo,
    
    /// <remarks/>
    InterchangeResend,
    
    /// <remarks/>
    ParcelUploadGZipEx,
    
    /// <remarks/>
    ParcelUploadExA,
    
    /// <remarks/>
    ParcelSetMailbagControlID,
    
    /// <remarks/>
    ParcelUpdateStatus,
    
    /// <remarks/>
    ParcelUpdateLocalStatus,
    
    /// <remarks/>
    ParcelUploadDirected,
    
    /// <remarks/>
    ParcelUploadDirectedGZip,
    
    /// <remarks/>
    ParcelDownloadConfirmPendingAck,
    
    /// <remarks/>
    InterchangeHeaderInfoB,
    
    /// <remarks/>
    ParcelDownloadGZip,
    
    /// <remarks/>
    ParcelDownloadCancel,
    
    /// <remarks/>
    ParcelTest,
    
    /// <remarks/>
    InterchangeManifest,
    
    /// <remarks/>
    ParcelOutBoxInProcess,
    
    /// <remarks/>
    ParcelOutBoxInProcessEx,
    
    /// <remarks/>
    ParcelResend,
    
    /// <remarks/>
    InterchangeCancel,
    
    /// <remarks/>
    ParcelAcknowledgmentNote,
    
    /// <remarks/>
    InterchangeOutBoxPending,
    
    /// <remarks/>
    InterchangeOutBoxPendingEx,
    
    /// <remarks/>
    InterchangeInBoxPending,
    
    /// <remarks/>
    InterchangeInBoxPendingEx,
    
    /// <remarks/>
    InterchangeInBoxArchive,
    
    /// <remarks/>
    InterchangeInBoxArchiveEx,
    
    /// <remarks/>
    InterchangeOutBoxArchive,
    
    /// <remarks/>
    InterchangeOutBoxArchiveEx,
    
    /// <remarks/>
    ParcelInBoxArchiveDescEx,
    
    /// <remarks/>
    ParcelOutBoxArchiveDescEx,
    
    /// <remarks/>
    CallBackAdd,
    
    /// <remarks/>
    CallBackActivate,
    
    /// <remarks/>
    CallBackSuspend,
    
    /// <remarks/>
    CallBackTerminate,
    
    /// <remarks/>
    CallBackList,
    
    /// <remarks/>
    CallBackListEx,
    
    /// <remarks/>
    CallBackEventList,
    
    /// <remarks/>
    CallBackEventListEx,
    
    /// <remarks/>
    CallBackInvoke,
    
    /// <remarks/>
    CallBackTest,
    
    /// <remarks/>
    CallBackPendingList,
    
    /// <remarks/>
    CallBackPendingListEx,
    
    /// <remarks/>
    CallBackQueueInfo,
    
    /// <remarks/>
    CallBackEventInfo,
    
    /// <remarks/>
    CallBackAddEx,
    
    /// <remarks/>
    CallBackFailedList,
    
    /// <remarks/>
    CallBackFailedListEx,
    
    /// <remarks/>
    CallBackEventSetStatus,
    
    /// <remarks/>
    ReportMonthly,
    
    /// <remarks/>
    ReportMonthlyEx,
    
    /// <remarks/>
    ReportTrafficStats,
    
    /// <remarks/>
    ReportTrafficStatsEx,
    
    /// <remarks/>
    ReportInstantStats,
    
    /// <remarks/>
    ReportInstantStatsEx,
    
    /// <remarks/>
    AS2Add,
    
    /// <remarks/>
    AS2Update,
    
    /// <remarks/>
    AS2Activate,
    
    /// <remarks/>
    AS2Suspend,
    
    /// <remarks/>
    AS2Terminate,
    
    /// <remarks/>
    AS2CertAddPublic,
    
    /// <remarks/>
    AS2CertAddPrivate,
    
    /// <remarks/>
    AS2CertTerminate,
    
    /// <remarks/>
    AS2Find,
    
    /// <remarks/>
    AS2List,
    
    /// <remarks/>
    AS2ListEx,
    
    /// <remarks/>
    AS2Info,
    
    /// <remarks/>
    AS2CertCreatePrivate,
    
    /// <remarks/>
    AS2Pair,
    
    /// <remarks/>
    AS2DefaultMailbox,
    
    /// <remarks/>
    AS2SetPair,
    
    /// <remarks/>
    AS2SetStatus,
    
    /// <remarks/>
    AS2CertRenewPrivate,
    
    /// <remarks/>
    GISBAdd,
    
    /// <remarks/>
    GISBUpdate,
    
    /// <remarks/>
    GISBActivate,
    
    /// <remarks/>
    GISBSuspend,
    
    /// <remarks/>
    GISBTerminate,
    
    /// <remarks/>
    GISBKeyAdd,
    
    /// <remarks/>
    GISBKeyTerminate,
    
    /// <remarks/>
    GISBFind,
    
    /// <remarks/>
    GISBList,
    
    /// <remarks/>
    GISBListEx,
    
    /// <remarks/>
    GISBInfo,
    
    /// <remarks/>
    CertificateAddPublic,
    
    /// <remarks/>
    CertificateAddPrivate,
    
    /// <remarks/>
    CertificateCreatePrivate,
    
    /// <remarks/>
    CertificateSetUsageDates,
    
    /// <remarks/>
    CertificateTerminate,
    
    /// <remarks/>
    CommAdd,
    
    /// <remarks/>
    CommUpdate,
    
    /// <remarks/>
    CommSetStatus,
    
    /// <remarks/>
    CommFind,
    
    /// <remarks/>
    CommList,
    
    /// <remarks/>
    CommListEx,
    
    /// <remarks/>
    CommInfo,
    
    /// <remarks/>
    CommPair,
    
    /// <remarks/>
    CommSetPair,
    
    /// <remarks/>
    ContractInfo,
    
    /// <remarks/>
    ContractList,
    
    /// <remarks/>
    ContractListEx,
    
    /// <remarks/>
    ContractAdd,
    
    /// <remarks/>
    ContractActivate,
    
    /// <remarks/>
    ContractSuspend,
    
    /// <remarks/>
    ContractTerminate,
    
    /// <remarks/>
    ContractExpiring,
    
    /// <remarks/>
    ContractSet,
    
    /// <remarks/>
    ContractSetEx,
    
    /// <remarks/>
    PricelistInfo,
    
    /// <remarks/>
    PricelistAdd,
    
    /// <remarks/>
    PricelistLineAdd,
    
    /// <remarks/>
    PricelistLineDelete,
    
    /// <remarks/>
    InvoiceCreate,
    
    /// <remarks/>
    InvoiceInfo,
    
    /// <remarks/>
    InvoiceList,
    
    /// <remarks/>
    InvoiceSetStatus,
    
    /// <remarks/>
    InvoiceCalculateLineItem,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum RetCode
{
    
    /// <remarks/>
    Unknown,
    
    /// <remarks/>
    Success,
    
    /// <remarks/>
    SesssionTimeout,
    
    /// <remarks/>
    AccessDenied,
    
    /// <remarks/>
    NotFound,
    
    /// <remarks/>
    InvalidID,
    
    /// <remarks/>
    Duplicate,
    
    /// <remarks/>
    IDExistsOnNetwork,
    
    /// <remarks/>
    InvalidDataType,
    
    /// <remarks/>
    InvalidDataLength,
    
    /// <remarks/>
    DataError,
    
    /// <remarks/>
    SQLError,
    
    /// <remarks/>
    InternalError,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class SessionLogInfo
{
    
    private string sessionIDField;
    
    private System.DateTime startTimeField;
    
    private System.DateTime endTimeField;
    
    private System.DateTime expiresField;
    
    private int networkIDField;
    
    private int mailboxIDField;
    
    private int userIDField;
    
    private SessionStatus statusField;
    
    private string versionField;
    
    private SessionEvents[] eventsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string SessionID
    {
        get
        {
            return this.sessionIDField;
        }
        set
        {
            this.sessionIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime StartTime
    {
        get
        {
            return this.startTimeField;
        }
        set
        {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime EndTime
    {
        get
        {
            return this.endTimeField;
        }
        set
        {
            this.endTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime Expires
    {
        get
        {
            return this.expiresField;
        }
        set
        {
            this.expiresField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public SessionStatus Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string Version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=9)]
    public SessionEvents[] Events
    {
        get
        {
            return this.eventsField;
        }
        set
        {
            this.eventsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum SessionStatus
{
    
    /// <remarks/>
    Open,
    
    /// <remarks/>
    Closed,
    
    /// <remarks/>
    Expired,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class SessionInfo
{
    
    private string eCGridOSVersionField;
    
    private string sessionIDField;
    
    private int sessionEventIDField;
    
    private int userIDField;
    
    private string loginNameField;
    
    private string firstNameField;
    
    private string lastNameField;
    
    private string companyField;
    
    private string eMailField;
    
    private string phoneField;
    
    private float timeZoneOffsetField;
    
    private AuthLevel authLevelField;
    
    private System.DateTime lastLoginField;
    
    private short openSessionsField;
    
    private short timeOutField;
    
    private int networkIDField;
    
    private int mailboxIDField;
    
    private string ipField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string ECGridOSVersion
    {
        get
        {
            return this.eCGridOSVersionField;
        }
        set
        {
            this.eCGridOSVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string SessionID
    {
        get
        {
            return this.sessionIDField;
        }
        set
        {
            this.sessionIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int SessionEventID
    {
        get
        {
            return this.sessionEventIDField;
        }
        set
        {
            this.sessionEventIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string LoginName
    {
        get
        {
            return this.loginNameField;
        }
        set
        {
            this.loginNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string FirstName
    {
        get
        {
            return this.firstNameField;
        }
        set
        {
            this.firstNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string LastName
    {
        get
        {
            return this.lastNameField;
        }
        set
        {
            this.lastNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string Company
    {
        get
        {
            return this.companyField;
        }
        set
        {
            this.companyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string EMail
    {
        get
        {
            return this.eMailField;
        }
        set
        {
            this.eMailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public string Phone
    {
        get
        {
            return this.phoneField;
        }
        set
        {
            this.phoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public float TimeZoneOffset
    {
        get
        {
            return this.timeZoneOffsetField;
        }
        set
        {
            this.timeZoneOffsetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public AuthLevel AuthLevel
    {
        get
        {
            return this.authLevelField;
        }
        set
        {
            this.authLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public System.DateTime LastLogin
    {
        get
        {
            return this.lastLoginField;
        }
        set
        {
            this.lastLoginField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public short OpenSessions
    {
        get
        {
            return this.openSessionsField;
        }
        set
        {
            this.openSessionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public short TimeOut
    {
        get
        {
            return this.timeOutField;
        }
        set
        {
            this.timeOutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public string ip
    {
        get
        {
            return this.ipField;
        }
        set
        {
            this.ipField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class ECGridIDInfoCollection
{
    
    private short pageSizeField;
    
    private short pageNumberField;
    
    private short countField;
    
    private int totalRecordsField;
    
    private short totalPagesField;
    
    private ECGridIDInfo[] eCGridIDInfoListField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public short PageSize
    {
        get
        {
            return this.pageSizeField;
        }
        set
        {
            this.pageSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public short PageNumber
    {
        get
        {
            return this.pageNumberField;
        }
        set
        {
            this.pageNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public short Count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int TotalRecords
    {
        get
        {
            return this.totalRecordsField;
        }
        set
        {
            this.totalRecordsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public short TotalPages
    {
        get
        {
            return this.totalPagesField;
        }
        set
        {
            this.totalPagesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
    public ECGridIDInfo[] ECGridIDInfoList
    {
        get
        {
            return this.eCGridIDInfoListField;
        }
        set
        {
            this.eCGridIDInfoListField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class ECGridIDInfo
{
    
    private int eCGridIDField;
    
    private int networkIDField;
    
    private string networkNameField;
    
    private int mailboxIDField;
    
    private string mailboxNameField;
    
    private string qualifierField;
    
    private string idField;
    
    private string descriptionField;
    
    private string dataEMailField;
    
    private bool mailboxDefaultField;
    
    private StatusECGridID statusField;
    
    private UseType useTypeField;
    
    private UserIDInfo ownerField;
    
    private ECGridOwnerInfo ownerInfoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int ECGridID
    {
        get
        {
            return this.eCGridIDField;
        }
        set
        {
            this.eCGridIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string NetworkName
    {
        get
        {
            return this.networkNameField;
        }
        set
        {
            this.networkNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string MailboxName
    {
        get
        {
            return this.mailboxNameField;
        }
        set
        {
            this.mailboxNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string Qualifier
    {
        get
        {
            return this.qualifierField;
        }
        set
        {
            this.qualifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string DataEMail
    {
        get
        {
            return this.dataEMailField;
        }
        set
        {
            this.dataEMailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public bool MailboxDefault
    {
        get
        {
            return this.mailboxDefaultField;
        }
        set
        {
            this.mailboxDefaultField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public StatusECGridID Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public UseType UseType
    {
        get
        {
            return this.useTypeField;
        }
        set
        {
            this.useTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public UserIDInfo Owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public ECGridOwnerInfo OwnerInfo
    {
        get
        {
            return this.ownerInfoField;
        }
        set
        {
            this.ownerInfoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum StatusECGridID
{
    
    /// <remarks/>
    Active,
    
    /// <remarks/>
    AutoRoute,
    
    /// <remarks/>
    Pending,
    
    /// <remarks/>
    Suspended,
    
    /// <remarks/>
    Terminated,
    
    /// <remarks/>
    Duplicate,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum UseType
{
    
    /// <remarks/>
    Undefined,
    
    /// <remarks/>
    Test,
    
    /// <remarks/>
    Production,
    
    /// <remarks/>
    TestAndProduction,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class ECGridOwnerInfo
{
    
    private int networkIDField;
    
    private string networkNameField;
    
    private int mailboxIDField;
    
    private string mailboxNameField;
    
    private System.DateTime createdField;
    
    private System.DateTime modifiedField;
    
    private System.DateTime effectiveField;
    
    private System.DateTime expiresField;
    
    private System.DateTime lastTrafficField;
    
    private RoutingGroup routingGroupField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string NetworkName
    {
        get
        {
            return this.networkNameField;
        }
        set
        {
            this.networkNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string MailboxName
    {
        get
        {
            return this.mailboxNameField;
        }
        set
        {
            this.mailboxNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public System.DateTime Effective
    {
        get
        {
            return this.effectiveField;
        }
        set
        {
            this.effectiveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public System.DateTime Expires
    {
        get
        {
            return this.expiresField;
        }
        set
        {
            this.expiresField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public System.DateTime LastTraffic
    {
        get
        {
            return this.lastTrafficField;
        }
        set
        {
            this.lastTrafficField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public RoutingGroup RoutingGroup
    {
        get
        {
            return this.routingGroupField;
        }
        set
        {
            this.routingGroupField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum RoutingGroup
{
    
    /// <remarks/>
    ProductionA,
    
    /// <remarks/>
    ProductionB,
    
    /// <remarks/>
    Migration1,
    
    /// <remarks/>
    Migration2,
    
    /// <remarks/>
    NetOpsOnly1,
    
    /// <remarks/>
    NetOpsOnly2,
    
    /// <remarks/>
    ManagedFileTransfer,
    
    /// <remarks/>
    SuperHub,
    
    /// <remarks/>
    Test,
    
    /// <remarks/>
    Suspense1,
    
    /// <remarks/>
    Suspense2,
    
    /// <remarks/>
    Suspense3,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class FileInfo
{
    
    private long parcelIDField;
    
    private string fileNameField;
    
    private System.DateTime fileDateField;
    
    private int bytesField;
    
    private EDIStandard standardField;
    
    private byte[] contentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public long ParcelID
    {
        get
        {
            return this.parcelIDField;
        }
        set
        {
            this.parcelIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string FileName
    {
        get
        {
            return this.fileNameField;
        }
        set
        {
            this.fileNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime FileDate
    {
        get
        {
            return this.fileDateField;
        }
        set
        {
            this.fileDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int Bytes
    {
        get
        {
            return this.bytesField;
        }
        set
        {
            this.bytesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public EDIStandard Standard
    {
        get
        {
            return this.standardField;
        }
        set
        {
            this.standardField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=5)]
    public byte[] Content
    {
        get
        {
            return this.contentField;
        }
        set
        {
            this.contentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum EDIStandard
{
    
    /// <remarks/>
    X12,
    
    /// <remarks/>
    EDIFACT,
    
    /// <remarks/>
    TRADACOMS,
    
    /// <remarks/>
    VDA,
    
    /// <remarks/>
    XML,
    
    /// <remarks/>
    TXT,
    
    /// <remarks/>
    PDF,
    
    /// <remarks/>
    Binary,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class CarbonCopyIDInfo
{
    
    private int carbonCopyIDField;
    
    private int networkIDField;
    
    private int mailboxIDField;
    
    private System.DateTime createdField;
    
    private System.DateTime modifiedField;
    
    private Status statusField;
    
    private ECGridIDInfo originalFromField;
    
    private ECGridIDInfo originalToField;
    
    private ECGridIDInfo cCFromField;
    
    private ECGridIDInfo cCToField;
    
    private string transactionSetField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int CarbonCopyID
    {
        get
        {
            return this.carbonCopyIDField;
        }
        set
        {
            this.carbonCopyIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public ECGridIDInfo OriginalFrom
    {
        get
        {
            return this.originalFromField;
        }
        set
        {
            this.originalFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public ECGridIDInfo OriginalTo
    {
        get
        {
            return this.originalToField;
        }
        set
        {
            this.originalToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public ECGridIDInfo CCFrom
    {
        get
        {
            return this.cCFromField;
        }
        set
        {
            this.cCFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public ECGridIDInfo CCTo
    {
        get
        {
            return this.cCToField;
        }
        set
        {
            this.cCToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public string TransactionSet
    {
        get
        {
            return this.transactionSetField;
        }
        set
        {
            this.transactionSetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class MigrationNote
{
    
    private int migrationNoteIDField;
    
    private System.DateTime noteDateField;
    
    private StatusInterconnect statusField;
    
    private int userIDField;
    
    private string mailToField;
    
    private string noteField;
    
    private NoteAttachment attachmentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int MigrationNoteID
    {
        get
        {
            return this.migrationNoteIDField;
        }
        set
        {
            this.migrationNoteIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime NoteDate
    {
        get
        {
            return this.noteDateField;
        }
        set
        {
            this.noteDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public StatusInterconnect Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string MailTo
    {
        get
        {
            return this.mailToField;
        }
        set
        {
            this.mailToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public NoteAttachment Attachment
    {
        get
        {
            return this.attachmentField;
        }
        set
        {
            this.attachmentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum StatusInterconnect
{
    
    /// <remarks/>
    Pending,
    
    /// <remarks/>
    Completed,
    
    /// <remarks/>
    Canceled,
    
    /// <remarks/>
    Delayed,
    
    /// <remarks/>
    Problem,
    
    /// <remarks/>
    AuthorizationRequired,
    
    /// <remarks/>
    NoStatusChange,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class NoteAttachment
{
    
    private string fileNameField;
    
    private byte[] contentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string FileName
    {
        get
        {
            return this.fileNameField;
        }
        set
        {
            this.fileNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=1)]
    public byte[] Content
    {
        get
        {
            return this.contentField;
        }
        set
        {
            this.contentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class MigrationTP
{
    
    private ECGridIDInfo eCGridIDField;
    
    private MigrationType typeField;
    
    private MigrationTPStatus statusField;
    
    private InterconnectIDInfo[] interconnectField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ECGridIDInfo ECGridID
    {
        get
        {
            return this.eCGridIDField;
        }
        set
        {
            this.eCGridIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public MigrationType Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public MigrationTPStatus Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
    public InterconnectIDInfo[] Interconnect
    {
        get
        {
            return this.interconnectField;
        }
        set
        {
            this.interconnectField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum MigrationType
{
    
    /// <remarks/>
    Expected,
    
    /// <remarks/>
    Unexpected,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum MigrationTPStatus
{
    
    /// <remarks/>
    Pending,
    
    /// <remarks/>
    Inbound,
    
    /// <remarks/>
    Outbound,
    
    /// <remarks/>
    Complete,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class InterconnectIDInfo
{
    
    private int interconnectIDField;
    
    private string uniqueIDField;
    
    private System.DateTime createdField;
    
    private System.DateTime modifiedField;
    
    private System.DateTime completedField;
    
    private System.DateTime lastTrafficField;
    
    private System.DateTime lastTrafficInboundField;
    
    private System.DateTime lastTrafficOutboundField;
    
    private UserIDInfo requestorUserField;
    
    private UserIDInfo contactUserField;
    
    private string contactNameField;
    
    private string contactEMailField;
    
    private StatusInterconnect statusField;
    
    private bool suspendPendingInterchangesField;
    
    private ECGridIDInfo tP1Field;
    
    private string aS2ID1Field;
    
    private string reference1Field;
    
    private ECGridIDInfo tP2Field;
    
    private string aS2ID2Field;
    
    private string reference2Field;
    
    private UserIDInfo netOpsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int InterconnectID
    {
        get
        {
            return this.interconnectIDField;
        }
        set
        {
            this.interconnectIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string UniqueID
    {
        get
        {
            return this.uniqueIDField;
        }
        set
        {
            this.uniqueIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime Completed
    {
        get
        {
            return this.completedField;
        }
        set
        {
            this.completedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public System.DateTime LastTraffic
    {
        get
        {
            return this.lastTrafficField;
        }
        set
        {
            this.lastTrafficField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public System.DateTime LastTrafficInbound
    {
        get
        {
            return this.lastTrafficInboundField;
        }
        set
        {
            this.lastTrafficInboundField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public System.DateTime LastTrafficOutbound
    {
        get
        {
            return this.lastTrafficOutboundField;
        }
        set
        {
            this.lastTrafficOutboundField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public UserIDInfo RequestorUser
    {
        get
        {
            return this.requestorUserField;
        }
        set
        {
            this.requestorUserField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public UserIDInfo ContactUser
    {
        get
        {
            return this.contactUserField;
        }
        set
        {
            this.contactUserField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public string ContactName
    {
        get
        {
            return this.contactNameField;
        }
        set
        {
            this.contactNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public string ContactEMail
    {
        get
        {
            return this.contactEMailField;
        }
        set
        {
            this.contactEMailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public StatusInterconnect Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public bool SuspendPendingInterchanges
    {
        get
        {
            return this.suspendPendingInterchangesField;
        }
        set
        {
            this.suspendPendingInterchangesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public ECGridIDInfo TP1
    {
        get
        {
            return this.tP1Field;
        }
        set
        {
            this.tP1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public string AS2ID1
    {
        get
        {
            return this.aS2ID1Field;
        }
        set
        {
            this.aS2ID1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public string Reference1
    {
        get
        {
            return this.reference1Field;
        }
        set
        {
            this.reference1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public ECGridIDInfo TP2
    {
        get
        {
            return this.tP2Field;
        }
        set
        {
            this.tP2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public string AS2ID2
    {
        get
        {
            return this.aS2ID2Field;
        }
        set
        {
            this.aS2ID2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=19)]
    public string Reference2
    {
        get
        {
            return this.reference2Field;
        }
        set
        {
            this.reference2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=20)]
    public UserIDInfo NetOps
    {
        get
        {
            return this.netOpsField;
        }
        set
        {
            this.netOpsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class MigrationIDInfo
{
    
    private int migrationIDField;
    
    private NetworkIDInfo networkField;
    
    private MailboxIDInfo mailboxField;
    
    private NetworkIDInfo eCSPNetworkField;
    
    private MailboxIDInfo eCSPMailboxField;
    
    private System.DateTime scheduledField;
    
    private System.DateTime createdField;
    
    private System.DateTime modifiedField;
    
    private System.DateTime contactedField;
    
    private System.DateTime respondedField;
    
    private System.DateTime confirmedField;
    
    private MigrationStatus statusField;
    
    private UserIDInfo ownerField;
    
    private string helpTicketField;
    
    private MigrationTP[] tPsField;
    
    private MigrationNote[] notesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int MigrationID
    {
        get
        {
            return this.migrationIDField;
        }
        set
        {
            this.migrationIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public NetworkIDInfo Network
    {
        get
        {
            return this.networkField;
        }
        set
        {
            this.networkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public MailboxIDInfo Mailbox
    {
        get
        {
            return this.mailboxField;
        }
        set
        {
            this.mailboxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public NetworkIDInfo ECSPNetwork
    {
        get
        {
            return this.eCSPNetworkField;
        }
        set
        {
            this.eCSPNetworkField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public MailboxIDInfo ECSPMailbox
    {
        get
        {
            return this.eCSPMailboxField;
        }
        set
        {
            this.eCSPMailboxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public System.DateTime Scheduled
    {
        get
        {
            return this.scheduledField;
        }
        set
        {
            this.scheduledField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public System.DateTime Contacted
    {
        get
        {
            return this.contactedField;
        }
        set
        {
            this.contactedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public System.DateTime Responded
    {
        get
        {
            return this.respondedField;
        }
        set
        {
            this.respondedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public System.DateTime Confirmed
    {
        get
        {
            return this.confirmedField;
        }
        set
        {
            this.confirmedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public MigrationStatus Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public UserIDInfo Owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public string HelpTicket
    {
        get
        {
            return this.helpTicketField;
        }
        set
        {
            this.helpTicketField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=14)]
    public MigrationTP[] TPs
    {
        get
        {
            return this.tPsField;
        }
        set
        {
            this.tPsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=15)]
    public MigrationNote[] Notes
    {
        get
        {
            return this.notesField;
        }
        set
        {
            this.notesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class NetworkIDInfo
{
    
    private int networkIDField;
    
    private string nameField;
    
    private string locationField;
    
    private string adminContactField;
    
    private string adminPhoneField;
    
    private string adminEMailField;
    
    private System.DateTime lastContactField;
    
    private NetworkType typeField;
    
    private Status statusField;
    
    private NetworkRunStatus runStatusField;
    
    private NetworkStatus networkStatusField;
    
    private bool eCGridAccountField;
    
    private int ownerUserIDField;
    
    private int routingUserIDField;
    
    private int errorsUserIDField;
    
    private int interconnectsUserIDField;
    
    private int noticesUserIDField;
    
    private int reportsUserIDField;
    
    private int accountingUserIDField;
    
    private int customerServiceUserIDField;
    
    private string homeWebsiteField;
    
    private string supportWebsiteField;
    
    private string loginWebsiteField;
    
    private System.DateTime createdField;
    
    private System.DateTime modifiedField;
    
    private NetworkLog lastLogField;
    
    private NetworkOwnerInfo ownerInfoField;
    
    private NetworkNetOpsInfo netOpsInfoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string Location
    {
        get
        {
            return this.locationField;
        }
        set
        {
            this.locationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string AdminContact
    {
        get
        {
            return this.adminContactField;
        }
        set
        {
            this.adminContactField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string AdminPhone
    {
        get
        {
            return this.adminPhoneField;
        }
        set
        {
            this.adminPhoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string AdminEMail
    {
        get
        {
            return this.adminEMailField;
        }
        set
        {
            this.adminEMailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public System.DateTime LastContact
    {
        get
        {
            return this.lastContactField;
        }
        set
        {
            this.lastContactField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public NetworkType Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public NetworkRunStatus RunStatus
    {
        get
        {
            return this.runStatusField;
        }
        set
        {
            this.runStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public NetworkStatus NetworkStatus
    {
        get
        {
            return this.networkStatusField;
        }
        set
        {
            this.networkStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public bool ECGridAccount
    {
        get
        {
            return this.eCGridAccountField;
        }
        set
        {
            this.eCGridAccountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public int OwnerUserID
    {
        get
        {
            return this.ownerUserIDField;
        }
        set
        {
            this.ownerUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public int RoutingUserID
    {
        get
        {
            return this.routingUserIDField;
        }
        set
        {
            this.routingUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public int ErrorsUserID
    {
        get
        {
            return this.errorsUserIDField;
        }
        set
        {
            this.errorsUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public int InterconnectsUserID
    {
        get
        {
            return this.interconnectsUserIDField;
        }
        set
        {
            this.interconnectsUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public int NoticesUserID
    {
        get
        {
            return this.noticesUserIDField;
        }
        set
        {
            this.noticesUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public int ReportsUserID
    {
        get
        {
            return this.reportsUserIDField;
        }
        set
        {
            this.reportsUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public int AccountingUserID
    {
        get
        {
            return this.accountingUserIDField;
        }
        set
        {
            this.accountingUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=19)]
    public int CustomerServiceUserID
    {
        get
        {
            return this.customerServiceUserIDField;
        }
        set
        {
            this.customerServiceUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=20)]
    public string HomeWebsite
    {
        get
        {
            return this.homeWebsiteField;
        }
        set
        {
            this.homeWebsiteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=21)]
    public string SupportWebsite
    {
        get
        {
            return this.supportWebsiteField;
        }
        set
        {
            this.supportWebsiteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=22)]
    public string LoginWebsite
    {
        get
        {
            return this.loginWebsiteField;
        }
        set
        {
            this.loginWebsiteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=23)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=24)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=25)]
    public NetworkLog LastLog
    {
        get
        {
            return this.lastLogField;
        }
        set
        {
            this.lastLogField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=26)]
    public NetworkOwnerInfo OwnerInfo
    {
        get
        {
            return this.ownerInfoField;
        }
        set
        {
            this.ownerInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=27)]
    public NetworkNetOpsInfo NetOpsInfo
    {
        get
        {
            return this.netOpsInfoField;
        }
        set
        {
            this.netOpsInfoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkType
{
    
    /// <remarks/>
    Network,
    
    /// <remarks/>
    Router,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkRunStatus
{
    
    /// <remarks/>
    Restart,
    
    /// <remarks/>
    OffLine,
    
    /// <remarks/>
    Active,
    
    /// <remarks/>
    Sleeping,
    
    /// <remarks/>
    Alert,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkStatus
{
    
    /// <remarks/>
    Redirected,
    
    /// <remarks/>
    NormalOperation,
    
    /// <remarks/>
    ECGridScheduledOutage,
    
    /// <remarks/>
    ECGridUnscheduledOutage,
    
    /// <remarks/>
    NetworkScheduledOutage,
    
    /// <remarks/>
    NetworkUnscheduledOutage,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class NetworkLog
{
    
    private int logIDField;
    
    private System.DateTime logDateField;
    
    private int userIDField;
    
    private NetworkLogType typeField;
    
    private NetworkLogStatus statusField;
    
    private AuthLevel authLevelField;
    
    private string descriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int LogID
    {
        get
        {
            return this.logIDField;
        }
        set
        {
            this.logIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime LogDate
    {
        get
        {
            return this.logDateField;
        }
        set
        {
            this.logDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public NetworkLogType Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public NetworkLogStatus Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public AuthLevel AuthLevel
    {
        get
        {
            return this.authLevelField;
        }
        set
        {
            this.authLevelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkLogType
{
    
    /// <remarks/>
    SystemResponse,
    
    /// <remarks/>
    SystemAutomated,
    
    /// <remarks/>
    User,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkLogStatus
{
    
    /// <remarks/>
    Start,
    
    /// <remarks/>
    CheckIn,
    
    /// <remarks/>
    Access,
    
    /// <remarks/>
    Pause,
    
    /// <remarks/>
    Restart,
    
    /// <remarks/>
    Shutdown,
    
    /// <remarks/>
    StatusChange,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class NetworkOwnerInfo
{
    
    private string typeField;
    
    private string routingTypeField;
    
    private NetworkRoutingType routingField;
    
    private string legacyPasswordField;
    
    private string interconnectContactField;
    
    private string interconnectEMailField;
    
    private string errorContactField;
    
    private string errorEMailField;
    
    private MailboxConfig configField;
    
    private int pricelistIDField;
    
    private int contractIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RoutingType
    {
        get
        {
            return this.routingTypeField;
        }
        set
        {
            this.routingTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public NetworkRoutingType Routing
    {
        get
        {
            return this.routingField;
        }
        set
        {
            this.routingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string LegacyPassword
    {
        get
        {
            return this.legacyPasswordField;
        }
        set
        {
            this.legacyPasswordField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string InterconnectContact
    {
        get
        {
            return this.interconnectContactField;
        }
        set
        {
            this.interconnectContactField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string InterconnectEMail
    {
        get
        {
            return this.interconnectEMailField;
        }
        set
        {
            this.interconnectEMailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string ErrorContact
    {
        get
        {
            return this.errorContactField;
        }
        set
        {
            this.errorContactField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string ErrorEMail
    {
        get
        {
            return this.errorEMailField;
        }
        set
        {
            this.errorEMailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public MailboxConfig Config
    {
        get
        {
            return this.configField;
        }
        set
        {
            this.configField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public int PricelistID
    {
        get
        {
            return this.pricelistIDField;
        }
        set
        {
            this.pricelistIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public int ContractID
    {
        get
        {
            return this.contractIDField;
        }
        set
        {
            this.contractIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkRoutingType
{
    
    /// <remarks/>
    Open,
    
    /// <remarks/>
    OpenWithSenderValidation,
    
    /// <remarks/>
    TradingPartnerPairs,
    
    /// <remarks/>
    MultiNetwork,
    
    /// <remarks/>
    ECGridOpen,
    
    /// <remarks/>
    ECGridTradingPartnerPairs,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class MailboxConfig
{
    
    private short inBoxTimeoutField;
    
    private byte segTermField;
    
    private byte elmSepField;
    
    private byte subElmSepField;
    
    private bool eBCDICFilterField;
    
    private bool fTPasciiFilterField;
    
    private bool lowPassFilterField;
    
    private bool mailbagPassThroughField;
    
    private bool deleteOnDownloadField;
    
    private bool stripDirectedEnvelopeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public short InBoxTimeout
    {
        get
        {
            return this.inBoxTimeoutField;
        }
        set
        {
            this.inBoxTimeoutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public byte SegTerm
    {
        get
        {
            return this.segTermField;
        }
        set
        {
            this.segTermField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public byte ElmSep
    {
        get
        {
            return this.elmSepField;
        }
        set
        {
            this.elmSepField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public byte SubElmSep
    {
        get
        {
            return this.subElmSepField;
        }
        set
        {
            this.subElmSepField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public bool EBCDICFilter
    {
        get
        {
            return this.eBCDICFilterField;
        }
        set
        {
            this.eBCDICFilterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public bool FTPasciiFilter
    {
        get
        {
            return this.fTPasciiFilterField;
        }
        set
        {
            this.fTPasciiFilterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public bool LowPassFilter
    {
        get
        {
            return this.lowPassFilterField;
        }
        set
        {
            this.lowPassFilterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public bool MailbagPassThrough
    {
        get
        {
            return this.mailbagPassThroughField;
        }
        set
        {
            this.mailbagPassThroughField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public bool DeleteOnDownload
    {
        get
        {
            return this.deleteOnDownloadField;
        }
        set
        {
            this.deleteOnDownloadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public bool StripDirectedEnvelope
    {
        get
        {
            return this.stripDirectedEnvelopeField;
        }
        set
        {
            this.stripDirectedEnvelopeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class NetworkNetOpsInfo
{
    
    private int billingUserIDField;
    
    private string billingContactField;
    
    private string billingEMailField;
    
    private short billingTypeField;
    
    private string invoiceContactField;
    
    private string invoiceEMailField;
    
    private string softwareVersionField;
    
    private System.DateTime createdField;
    
    private System.DateTime commissionedField;
    
    private System.DateTime decommissionedField;
    
    private System.DateTime modifiedField;
    
    private string runDirField;
    
    private string internalDirectoryField;
    
    private string externalDirectoryRootField;
    
    private string externalDirectoryInField;
    
    private string externalDirectoryOutField;
    
    private short archiveDaysField;
    
    private string supportURLField;
    
    private short blockSizeField;
    
    private short envPerMBField;
    
    private short outBoxTimeOutField;
    
    private string masterAccountField;
    
    private int processIDField;
    
    private string userNameField;
    
    private string userDomainField;
    
    private string serverField;
    
    private int aliasNetworkIDField;
    
    private int aliasMailboxIDField;
    
    private string inBoxPatternField;
    
    private string outBoxPatternField;
    
    private bool x1256Field;
    
    private short archiveDaysInternalField;
    
    private short archiveDaysExternalField;
    
    private short maxBatchField;
    
    private short dbOpenMaxCyclesField;
    
    private short dbOpenMaxSecondsField;
    
    private NetworkGateway gatewayField;
    
    private NetworkVPN vPNField;
    
    private NetworkFTPInfo fTPServerField;
    
    private NetworkFTPInfo fTPClientField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int BillingUserID
    {
        get
        {
            return this.billingUserIDField;
        }
        set
        {
            this.billingUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string BillingContact
    {
        get
        {
            return this.billingContactField;
        }
        set
        {
            this.billingContactField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string BillingEMail
    {
        get
        {
            return this.billingEMailField;
        }
        set
        {
            this.billingEMailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public short BillingType
    {
        get
        {
            return this.billingTypeField;
        }
        set
        {
            this.billingTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string InvoiceContact
    {
        get
        {
            return this.invoiceContactField;
        }
        set
        {
            this.invoiceContactField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string InvoiceEMail
    {
        get
        {
            return this.invoiceEMailField;
        }
        set
        {
            this.invoiceEMailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string SoftwareVersion
    {
        get
        {
            return this.softwareVersionField;
        }
        set
        {
            this.softwareVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public System.DateTime Commissioned
    {
        get
        {
            return this.commissionedField;
        }
        set
        {
            this.commissionedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public System.DateTime Decommissioned
    {
        get
        {
            return this.decommissionedField;
        }
        set
        {
            this.decommissionedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public string RunDir
    {
        get
        {
            return this.runDirField;
        }
        set
        {
            this.runDirField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public string InternalDirectory
    {
        get
        {
            return this.internalDirectoryField;
        }
        set
        {
            this.internalDirectoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public string ExternalDirectoryRoot
    {
        get
        {
            return this.externalDirectoryRootField;
        }
        set
        {
            this.externalDirectoryRootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public string ExternalDirectoryIn
    {
        get
        {
            return this.externalDirectoryInField;
        }
        set
        {
            this.externalDirectoryInField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public string ExternalDirectoryOut
    {
        get
        {
            return this.externalDirectoryOutField;
        }
        set
        {
            this.externalDirectoryOutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public short ArchiveDays
    {
        get
        {
            return this.archiveDaysField;
        }
        set
        {
            this.archiveDaysField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public string SupportURL
    {
        get
        {
            return this.supportURLField;
        }
        set
        {
            this.supportURLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public short BlockSize
    {
        get
        {
            return this.blockSizeField;
        }
        set
        {
            this.blockSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=19)]
    public short EnvPerMB
    {
        get
        {
            return this.envPerMBField;
        }
        set
        {
            this.envPerMBField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=20)]
    public short OutBoxTimeOut
    {
        get
        {
            return this.outBoxTimeOutField;
        }
        set
        {
            this.outBoxTimeOutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=21)]
    public string MasterAccount
    {
        get
        {
            return this.masterAccountField;
        }
        set
        {
            this.masterAccountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=22)]
    public int ProcessID
    {
        get
        {
            return this.processIDField;
        }
        set
        {
            this.processIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=23)]
    public string UserName
    {
        get
        {
            return this.userNameField;
        }
        set
        {
            this.userNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=24)]
    public string UserDomain
    {
        get
        {
            return this.userDomainField;
        }
        set
        {
            this.userDomainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=25)]
    public string Server
    {
        get
        {
            return this.serverField;
        }
        set
        {
            this.serverField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=26)]
    public int AliasNetworkID
    {
        get
        {
            return this.aliasNetworkIDField;
        }
        set
        {
            this.aliasNetworkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=27)]
    public int AliasMailboxID
    {
        get
        {
            return this.aliasMailboxIDField;
        }
        set
        {
            this.aliasMailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=28)]
    public string InBoxPattern
    {
        get
        {
            return this.inBoxPatternField;
        }
        set
        {
            this.inBoxPatternField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=29)]
    public string OutBoxPattern
    {
        get
        {
            return this.outBoxPatternField;
        }
        set
        {
            this.outBoxPatternField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=30)]
    public bool X1256
    {
        get
        {
            return this.x1256Field;
        }
        set
        {
            this.x1256Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=31)]
    public short ArchiveDaysInternal
    {
        get
        {
            return this.archiveDaysInternalField;
        }
        set
        {
            this.archiveDaysInternalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=32)]
    public short ArchiveDaysExternal
    {
        get
        {
            return this.archiveDaysExternalField;
        }
        set
        {
            this.archiveDaysExternalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=33)]
    public short MaxBatch
    {
        get
        {
            return this.maxBatchField;
        }
        set
        {
            this.maxBatchField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=34)]
    public short dbOpenMaxCycles
    {
        get
        {
            return this.dbOpenMaxCyclesField;
        }
        set
        {
            this.dbOpenMaxCyclesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=35)]
    public short dbOpenMaxSeconds
    {
        get
        {
            return this.dbOpenMaxSecondsField;
        }
        set
        {
            this.dbOpenMaxSecondsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=36)]
    public NetworkGateway Gateway
    {
        get
        {
            return this.gatewayField;
        }
        set
        {
            this.gatewayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=37)]
    public NetworkVPN VPN
    {
        get
        {
            return this.vPNField;
        }
        set
        {
            this.vPNField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=38)]
    public NetworkFTPInfo FTPServer
    {
        get
        {
            return this.fTPServerField;
        }
        set
        {
            this.fTPServerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=39)]
    public NetworkFTPInfo FTPClient
    {
        get
        {
            return this.fTPClientField;
        }
        set
        {
            this.fTPClientField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class NetworkGateway
{
    
    private string applicationField;
    
    private short applicationTimeOutField;
    
    private string applicationLogFileField;
    
    private short frequencyField;
    
    private short minimumPollingField;
    
    private NetworkGatewayHandshake handshakeField;
    
    private NetworkGatewayCommChannel commChannelField;
    
    private NetworkGatewayConnection connectionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Application
    {
        get
        {
            return this.applicationField;
        }
        set
        {
            this.applicationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public short ApplicationTimeOut
    {
        get
        {
            return this.applicationTimeOutField;
        }
        set
        {
            this.applicationTimeOutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string ApplicationLogFile
    {
        get
        {
            return this.applicationLogFileField;
        }
        set
        {
            this.applicationLogFileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public short Frequency
    {
        get
        {
            return this.frequencyField;
        }
        set
        {
            this.frequencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public short MinimumPolling
    {
        get
        {
            return this.minimumPollingField;
        }
        set
        {
            this.minimumPollingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public NetworkGatewayHandshake Handshake
    {
        get
        {
            return this.handshakeField;
        }
        set
        {
            this.handshakeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public NetworkGatewayCommChannel CommChannel
    {
        get
        {
            return this.commChannelField;
        }
        set
        {
            this.commChannelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public NetworkGatewayConnection Connection
    {
        get
        {
            return this.connectionField;
        }
        set
        {
            this.connectionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkGatewayHandshake
{
    
    /// <remarks/>
    Push,
    
    /// <remarks/>
    Pull,
    
    /// <remarks/>
    PushPull,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkGatewayCommChannel
{
    
    /// <remarks/>
    none,
    
    /// <remarks/>
    ftp,
    
    /// <remarks/>
    sftp,
    
    /// <remarks/>
    as2,
    
    /// <remarks/>
    http,
    
    /// <remarks/>
    oftp,
    
    /// <remarks/>
    x400,
    
    /// <remarks/>
    gisb,
    
    /// <remarks/>
    rnif,
    
    /// <remarks/>
    undefined,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkGatewayConnection
{
    
    /// <remarks/>
    Internet,
    
    /// <remarks/>
    VPN,
    
    /// <remarks/>
    Dial,
    
    /// <remarks/>
    Other,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class NetworkVPN
{
    
    private string localTunnelField;
    
    private string remoteTunnelField;
    
    private string[] encryptionDomainField;
    
    private string sharedSecretField;
    
    private NetworkVPNEncryptionMethod encryptionMethodField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string LocalTunnel
    {
        get
        {
            return this.localTunnelField;
        }
        set
        {
            this.localTunnelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string RemoteTunnel
    {
        get
        {
            return this.remoteTunnelField;
        }
        set
        {
            this.remoteTunnelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    public string[] EncryptionDomain
    {
        get
        {
            return this.encryptionDomainField;
        }
        set
        {
            this.encryptionDomainField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string SharedSecret
    {
        get
        {
            return this.sharedSecretField;
        }
        set
        {
            this.sharedSecretField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public NetworkVPNEncryptionMethod EncryptionMethod
    {
        get
        {
            return this.encryptionMethodField;
        }
        set
        {
            this.encryptionMethodField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkVPNEncryptionMethod
{
    
    /// <remarks/>
    _3DES_SHA1,
    
    /// <remarks/>
    _DES_SHA1,
    
    /// <remarks/>
    _3DES_MD5,
    
    /// <remarks/>
    _DES_MD5,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class NetworkFTPInfo
{
    
    private string[] ipField;
    
    private string userIDField;
    
    private string passwordField;
    
    private string accountField;
    
    private string virtualDirectoryInField;
    
    private string virtualDirectoryOutField;
    
    private string logicalDirectoryField;
    
    private short maxThreadsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    public string[] IP
    {
        get
        {
            return this.ipField;
        }
        set
        {
            this.ipField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string Password
    {
        get
        {
            return this.passwordField;
        }
        set
        {
            this.passwordField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string Account
    {
        get
        {
            return this.accountField;
        }
        set
        {
            this.accountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string VirtualDirectoryIn
    {
        get
        {
            return this.virtualDirectoryInField;
        }
        set
        {
            this.virtualDirectoryInField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string VirtualDirectoryOut
    {
        get
        {
            return this.virtualDirectoryOutField;
        }
        set
        {
            this.virtualDirectoryOutField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string LogicalDirectory
    {
        get
        {
            return this.logicalDirectoryField;
        }
        set
        {
            this.logicalDirectoryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public short MaxThreads
    {
        get
        {
            return this.maxThreadsField;
        }
        set
        {
            this.maxThreadsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class MailboxIDInfo
{
    
    private int mailboxIDField;
    
    private int networkIDField;
    
    private string nameField;
    
    private System.DateTime createdField;
    
    private System.DateTime modifiedField;
    
    private Status statusField;
    
    private string descriptionField;
    
    private UserIDInfo ownerUserIDField;
    
    private UserIDInfo errorsUserIDField;
    
    private UserIDInfo interconnectsUserIDField;
    
    private UserIDInfo noticesUserIDField;
    
    private UserIDInfo reportsUserIDField;
    
    private UserIDInfo customerServiceUserIDField;
    
    private UserIDInfo accountingUserIDField;
    
    private bool managedField;
    
    private UseType useTypeField;
    
    private MailboxConfig configField;
    
    private bool eCGridAccountField;
    
    private string defaultAS2IDField;
    
    private MailboxOwnerInfo ownerInfoField;
    
    private MailboxNetOpsInfo netOpsInfoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public UserIDInfo OwnerUserID
    {
        get
        {
            return this.ownerUserIDField;
        }
        set
        {
            this.ownerUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public UserIDInfo ErrorsUserID
    {
        get
        {
            return this.errorsUserIDField;
        }
        set
        {
            this.errorsUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public UserIDInfo InterconnectsUserID
    {
        get
        {
            return this.interconnectsUserIDField;
        }
        set
        {
            this.interconnectsUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public UserIDInfo NoticesUserID
    {
        get
        {
            return this.noticesUserIDField;
        }
        set
        {
            this.noticesUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public UserIDInfo ReportsUserID
    {
        get
        {
            return this.reportsUserIDField;
        }
        set
        {
            this.reportsUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public UserIDInfo CustomerServiceUserID
    {
        get
        {
            return this.customerServiceUserIDField;
        }
        set
        {
            this.customerServiceUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public UserIDInfo AccountingUserID
    {
        get
        {
            return this.accountingUserIDField;
        }
        set
        {
            this.accountingUserIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public bool Managed
    {
        get
        {
            return this.managedField;
        }
        set
        {
            this.managedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public UseType UseType
    {
        get
        {
            return this.useTypeField;
        }
        set
        {
            this.useTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public MailboxConfig Config
    {
        get
        {
            return this.configField;
        }
        set
        {
            this.configField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public bool ECGridAccount
    {
        get
        {
            return this.eCGridAccountField;
        }
        set
        {
            this.eCGridAccountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public string DefaultAS2ID
    {
        get
        {
            return this.defaultAS2IDField;
        }
        set
        {
            this.defaultAS2IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=19)]
    public MailboxOwnerInfo OwnerInfo
    {
        get
        {
            return this.ownerInfoField;
        }
        set
        {
            this.ownerInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=20)]
    public MailboxNetOpsInfo NetOpsInfo
    {
        get
        {
            return this.netOpsInfoField;
        }
        set
        {
            this.netOpsInfoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class MailboxOwnerInfo
{
    
    private int pricelistIDField;
    
    private int contractIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int PricelistID
    {
        get
        {
            return this.pricelistIDField;
        }
        set
        {
            this.pricelistIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int ContractID
    {
        get
        {
            return this.contractIDField;
        }
        set
        {
            this.contractIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class MailboxNetOpsInfo
{
    
    private int aliasNetworkIDField;
    
    private int aliasMailboxIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int AliasNetworkID
    {
        get
        {
            return this.aliasNetworkIDField;
        }
        set
        {
            this.aliasNetworkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int AliasMailboxID
    {
        get
        {
            return this.aliasMailboxIDField;
        }
        set
        {
            this.aliasMailboxIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum MigrationStatus
{
    
    /// <remarks/>
    All,
    
    /// <remarks/>
    Canceled,
    
    /// <remarks/>
    Planned,
    
    /// <remarks/>
    Requested,
    
    /// <remarks/>
    Confirmed,
    
    /// <remarks/>
    Active,
    
    /// <remarks/>
    Completed,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class InterconnectNote
{
    
    private int interconnectIDField;
    
    private int interconnectNoteIDField;
    
    private System.DateTime noteDateField;
    
    private StatusInterconnect statusField;
    
    private string postedByField;
    
    private int userIDField;
    
    private string mailToField;
    
    private string noteField;
    
    private NoteAttachment attachmentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int InterconnectID
    {
        get
        {
            return this.interconnectIDField;
        }
        set
        {
            this.interconnectIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int InterconnectNoteID
    {
        get
        {
            return this.interconnectNoteIDField;
        }
        set
        {
            this.interconnectNoteIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime NoteDate
    {
        get
        {
            return this.noteDateField;
        }
        set
        {
            this.noteDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public StatusInterconnect Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string PostedBy
    {
        get
        {
            return this.postedByField;
        }
        set
        {
            this.postedByField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string MailTo
    {
        get
        {
            return this.mailToField;
        }
        set
        {
            this.mailToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public NoteAttachment Attachment
    {
        get
        {
            return this.attachmentField;
        }
        set
        {
            this.attachmentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class CallBackLogInfo
{
    
    private int callBackLogIDField;
    
    private System.DateTime dateField;
    
    private short callNumberField;
    
    private int returnCodeField;
    
    private string messageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int CallBackLogID
    {
        get
        {
            return this.callBackLogIDField;
        }
        set
        {
            this.callBackLogIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime Date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public short CallNumber
    {
        get
        {
            return this.callNumberField;
        }
        set
        {
            this.callNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int ReturnCode
    {
        get
        {
            return this.returnCodeField;
        }
        set
        {
            this.returnCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class CallBackQueueIDInfo
{
    
    private int callBackQueueIDField;
    
    private System.DateTime dateField;
    
    private CallBackEventIDInfo callBackEventField;
    
    private short callsRemainingField;
    
    private System.DateTime nextCallField;
    
    private StatusCallBack statusField;
    
    private int objectIDField;
    
    private int userIDField;
    
    private bool testField;
    
    private CallBackLogInfo[] callBackLogField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int CallBackQueueID
    {
        get
        {
            return this.callBackQueueIDField;
        }
        set
        {
            this.callBackQueueIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime Date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public CallBackEventIDInfo CallBackEvent
    {
        get
        {
            return this.callBackEventField;
        }
        set
        {
            this.callBackEventField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public short CallsRemaining
    {
        get
        {
            return this.callsRemainingField;
        }
        set
        {
            this.callsRemainingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime NextCall
    {
        get
        {
            return this.nextCallField;
        }
        set
        {
            this.nextCallField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public StatusCallBack Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public int ObjectID
    {
        get
        {
            return this.objectIDField;
        }
        set
        {
            this.objectIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public bool Test
    {
        get
        {
            return this.testField;
        }
        set
        {
            this.testField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=9)]
    public CallBackLogInfo[] CallBackLog
    {
        get
        {
            return this.callBackLogField;
        }
        set
        {
            this.callBackLogField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class CallBackEventIDInfo
{
    
    private int callBackEventIDField;
    
    private int networkIDField;
    
    private int mailboxIDField;
    
    private int userIDField;
    
    private System.DateTime createdField;
    
    private System.DateTime modifiedField;
    
    private Objects systemObjectField;
    
    private short objectStatusField;
    
    private string statusCodeField;
    
    private Direction directionField;
    
    private short frequencyField;
    
    private short maxCallsField;
    
    private Status statusField;
    
    private string uRLField;
    
    private HTTPAuthInfo hTTPAuthenticationField;
    
    private CallBackQueueIDInfo[] callBackQueueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int CallBackEventID
    {
        get
        {
            return this.callBackEventIDField;
        }
        set
        {
            this.callBackEventIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public Objects SystemObject
    {
        get
        {
            return this.systemObjectField;
        }
        set
        {
            this.systemObjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public short ObjectStatus
    {
        get
        {
            return this.objectStatusField;
        }
        set
        {
            this.objectStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string StatusCode
    {
        get
        {
            return this.statusCodeField;
        }
        set
        {
            this.statusCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public Direction Direction
    {
        get
        {
            return this.directionField;
        }
        set
        {
            this.directionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public short Frequency
    {
        get
        {
            return this.frequencyField;
        }
        set
        {
            this.frequencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public short MaxCalls
    {
        get
        {
            return this.maxCallsField;
        }
        set
        {
            this.maxCallsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public string URL
    {
        get
        {
            return this.uRLField;
        }
        set
        {
            this.uRLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public HTTPAuthInfo HTTPAuthentication
    {
        get
        {
            return this.hTTPAuthenticationField;
        }
        set
        {
            this.hTTPAuthenticationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=15)]
    public CallBackQueueIDInfo[] CallBackQueue
    {
        get
        {
            return this.callBackQueueField;
        }
        set
        {
            this.callBackQueueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum Objects
{
    
    /// <remarks/>
    User,
    
    /// <remarks/>
    Network,
    
    /// <remarks/>
    Mailbox,
    
    /// <remarks/>
    ECGridID,
    
    /// <remarks/>
    Interconnect,
    
    /// <remarks/>
    Migration,
    
    /// <remarks/>
    Parcel,
    
    /// <remarks/>
    Interchange,
    
    /// <remarks/>
    CarbonCopy,
    
    /// <remarks/>
    CallBackEvent,
    
    /// <remarks/>
    AS2,
    
    /// <remarks/>
    GISB,
    
    /// <remarks/>
    ParcelNotes,
    
    /// <remarks/>
    InterconnectNote,
    
    /// <remarks/>
    PriceList,
    
    /// <remarks/>
    Contract,
    
    /// <remarks/>
    Invoice,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum Direction
{
    
    /// <remarks/>
    NoDir,
    
    /// <remarks/>
    OutBox,
    
    /// <remarks/>
    InBox,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class HTTPAuthInfo
{
    
    private HTTPAuthType typeField;
    
    private string userField;
    
    private string passwordField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public HTTPAuthType Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string User
    {
        get
        {
            return this.userField;
        }
        set
        {
            this.userField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string Password
    {
        get
        {
            return this.passwordField;
        }
        set
        {
            this.passwordField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum HTTPAuthType
{
    
    /// <remarks/>
    None,
    
    /// <remarks/>
    Basic,
    
    /// <remarks/>
    Digest,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum StatusCallBack
{
    
    /// <remarks/>
    Active,
    
    /// <remarks/>
    Pending,
    
    /// <remarks/>
    Completed,
    
    /// <remarks/>
    Error,
    
    /// <remarks/>
    Canceled,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class InterchangeIDInfoCollection
{
    
    private short pageSizeField;
    
    private short pageNumberField;
    
    private short countField;
    
    private int totalRecordsField;
    
    private short totalPagesField;
    
    private InterchangeIDInfo[] interchangeIDInfoListField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public short PageSize
    {
        get
        {
            return this.pageSizeField;
        }
        set
        {
            this.pageSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public short PageNumber
    {
        get
        {
            return this.pageNumberField;
        }
        set
        {
            this.pageNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public short Count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int TotalRecords
    {
        get
        {
            return this.totalRecordsField;
        }
        set
        {
            this.totalRecordsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public short TotalPages
    {
        get
        {
            return this.totalPagesField;
        }
        set
        {
            this.totalPagesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
    public InterchangeIDInfo[] InterchangeIDInfoList
    {
        get
        {
            return this.interchangeIDInfoListField;
        }
        set
        {
            this.interchangeIDInfoListField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class InterchangeIDInfo
{
    
    private long interchangeIDField;
    
    private System.DateTime interchangeProcessDateField;
    
    private int networkIDFromField;
    
    private string networkNameFromField;
    
    private int mailboxIDFromField;
    
    private int networkIDToField;
    
    private string networkNameToField;
    
    private int mailboxIDToField;
    
    private EDIStandard standardField;
    
    private int bytesField;
    
    private string interchangeControlIDField;
    
    private System.DateTime interchangeDateTimeField;
    
    private System.DateTime statusDateField;
    
    private string statusCodeField;
    
    private string statusMessageField;
    
    private string documentTypeField;
    
    private string headerField;
    
    private ECGridIDInfo tPFromField;
    
    private ECGridIDInfo tPToField;
    
    private ParcelIDInfo[] parcelsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public long InterchangeID
    {
        get
        {
            return this.interchangeIDField;
        }
        set
        {
            this.interchangeIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime InterchangeProcessDate
    {
        get
        {
            return this.interchangeProcessDateField;
        }
        set
        {
            this.interchangeProcessDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int NetworkIDFrom
    {
        get
        {
            return this.networkIDFromField;
        }
        set
        {
            this.networkIDFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string NetworkNameFrom
    {
        get
        {
            return this.networkNameFromField;
        }
        set
        {
            this.networkNameFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public int MailboxIDFrom
    {
        get
        {
            return this.mailboxIDFromField;
        }
        set
        {
            this.mailboxIDFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public int NetworkIDTo
    {
        get
        {
            return this.networkIDToField;
        }
        set
        {
            this.networkIDToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string NetworkNameTo
    {
        get
        {
            return this.networkNameToField;
        }
        set
        {
            this.networkNameToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public int MailboxIDTo
    {
        get
        {
            return this.mailboxIDToField;
        }
        set
        {
            this.mailboxIDToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public EDIStandard Standard
    {
        get
        {
            return this.standardField;
        }
        set
        {
            this.standardField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public int Bytes
    {
        get
        {
            return this.bytesField;
        }
        set
        {
            this.bytesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public string InterchangeControlID
    {
        get
        {
            return this.interchangeControlIDField;
        }
        set
        {
            this.interchangeControlIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public System.DateTime InterchangeDateTime
    {
        get
        {
            return this.interchangeDateTimeField;
        }
        set
        {
            this.interchangeDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public System.DateTime StatusDate
    {
        get
        {
            return this.statusDateField;
        }
        set
        {
            this.statusDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public string StatusCode
    {
        get
        {
            return this.statusCodeField;
        }
        set
        {
            this.statusCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public string StatusMessage
    {
        get
        {
            return this.statusMessageField;
        }
        set
        {
            this.statusMessageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public string DocumentType
    {
        get
        {
            return this.documentTypeField;
        }
        set
        {
            this.documentTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public string Header
    {
        get
        {
            return this.headerField;
        }
        set
        {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public ECGridIDInfo TPFrom
    {
        get
        {
            return this.tPFromField;
        }
        set
        {
            this.tPFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public ECGridIDInfo TPTo
    {
        get
        {
            return this.tPToField;
        }
        set
        {
            this.tPToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=19)]
    public ParcelIDInfo[] Parcels
    {
        get
        {
            return this.parcelsField;
        }
        set
        {
            this.parcelsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class ParcelIDInfo
{
    
    private long parcelIDField;
    
    private int parcelBytesField;
    
    private System.DateTime parcelDateField;
    
    private int actualBytesField;
    
    private int networkIDFromField;
    
    private string networkNameFromField;
    
    private int mailboxIDFromField;
    
    private string mailboxNameFromField;
    
    private int networkIDToField;
    
    private string networkNameToField;
    
    private int mailboxIDToField;
    
    private string mailboxNameToField;
    
    private string fileNameField;
    
    private string mailbagControlIDField;
    
    private System.DateTime statusDateField;
    
    private string statusCodeField;
    
    private string statusMessageField;
    
    private short localStatusField;
    
    private System.DateTime localStatusDateField;
    
    private ParcelValid validField;
    
    private string acknowledgmentField;
    
    private Direction directionField;
    
    private InterchangeIDInfo[] interchangesField;
    
    private ManifestInfo[] logField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public long ParcelID
    {
        get
        {
            return this.parcelIDField;
        }
        set
        {
            this.parcelIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int ParcelBytes
    {
        get
        {
            return this.parcelBytesField;
        }
        set
        {
            this.parcelBytesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime ParcelDate
    {
        get
        {
            return this.parcelDateField;
        }
        set
        {
            this.parcelDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int ActualBytes
    {
        get
        {
            return this.actualBytesField;
        }
        set
        {
            this.actualBytesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public int NetworkIDFrom
    {
        get
        {
            return this.networkIDFromField;
        }
        set
        {
            this.networkIDFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string NetworkNameFrom
    {
        get
        {
            return this.networkNameFromField;
        }
        set
        {
            this.networkNameFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public int MailboxIDFrom
    {
        get
        {
            return this.mailboxIDFromField;
        }
        set
        {
            this.mailboxIDFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string MailboxNameFrom
    {
        get
        {
            return this.mailboxNameFromField;
        }
        set
        {
            this.mailboxNameFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public int NetworkIDTo
    {
        get
        {
            return this.networkIDToField;
        }
        set
        {
            this.networkIDToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public string NetworkNameTo
    {
        get
        {
            return this.networkNameToField;
        }
        set
        {
            this.networkNameToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public int MailboxIDTo
    {
        get
        {
            return this.mailboxIDToField;
        }
        set
        {
            this.mailboxIDToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public string MailboxNameTo
    {
        get
        {
            return this.mailboxNameToField;
        }
        set
        {
            this.mailboxNameToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public string FileName
    {
        get
        {
            return this.fileNameField;
        }
        set
        {
            this.fileNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public string MailbagControlID
    {
        get
        {
            return this.mailbagControlIDField;
        }
        set
        {
            this.mailbagControlIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public System.DateTime StatusDate
    {
        get
        {
            return this.statusDateField;
        }
        set
        {
            this.statusDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public string StatusCode
    {
        get
        {
            return this.statusCodeField;
        }
        set
        {
            this.statusCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public string StatusMessage
    {
        get
        {
            return this.statusMessageField;
        }
        set
        {
            this.statusMessageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public short LocalStatus
    {
        get
        {
            return this.localStatusField;
        }
        set
        {
            this.localStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public System.DateTime LocalStatusDate
    {
        get
        {
            return this.localStatusDateField;
        }
        set
        {
            this.localStatusDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=19)]
    public ParcelValid Valid
    {
        get
        {
            return this.validField;
        }
        set
        {
            this.validField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=20)]
    public string Acknowledgment
    {
        get
        {
            return this.acknowledgmentField;
        }
        set
        {
            this.acknowledgmentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=21)]
    public Direction Direction
    {
        get
        {
            return this.directionField;
        }
        set
        {
            this.directionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=22)]
    public InterchangeIDInfo[] Interchanges
    {
        get
        {
            return this.interchangesField;
        }
        set
        {
            this.interchangesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=23)]
    public ManifestInfo[] Log
    {
        get
        {
            return this.logField;
        }
        set
        {
            this.logField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum ParcelValid
{
    
    /// <remarks/>
    Pending,
    
    /// <remarks/>
    Invalid,
    
    /// <remarks/>
    Valid,
    
    /// <remarks/>
    ValidPartialRouted,
    
    /// <remarks/>
    ValidNoneRouted,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class ManifestInfo
{
    
    private System.DateTime manifestDateField;
    
    private int networkIDField;
    
    private string networkNameField;
    
    private ManifestType typeField;
    
    private long parcelIDField;
    
    private long interchangeIDField;
    
    private string statusCodeField;
    
    private string statusMessageField;
    
    private string statusColorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public System.DateTime ManifestDate
    {
        get
        {
            return this.manifestDateField;
        }
        set
        {
            this.manifestDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string NetworkName
    {
        get
        {
            return this.networkNameField;
        }
        set
        {
            this.networkNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public ManifestType Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public long ParcelID
    {
        get
        {
            return this.parcelIDField;
        }
        set
        {
            this.parcelIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public long InterchangeID
    {
        get
        {
            return this.interchangeIDField;
        }
        set
        {
            this.interchangeIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string StatusCode
    {
        get
        {
            return this.statusCodeField;
        }
        set
        {
            this.statusCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string StatusMessage
    {
        get
        {
            return this.statusMessageField;
        }
        set
        {
            this.statusMessageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string StatusColor
    {
        get
        {
            return this.statusColorField;
        }
        set
        {
            this.statusColorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum ManifestType
{
    
    /// <remarks/>
    System,
    
    /// <remarks/>
    Error,
    
    /// <remarks/>
    Manual,
    
    /// <remarks/>
    ECGridOS,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class ParcelIDInfoCollection
{
    
    private short pageSizeField;
    
    private short pageNumberField;
    
    private short countField;
    
    private int totalRecordsField;
    
    private short totalPagesField;
    
    private ParcelIDInfo[] parcelIDInfoListField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public short PageSize
    {
        get
        {
            return this.pageSizeField;
        }
        set
        {
            this.pageSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public short PageNumber
    {
        get
        {
            return this.pageNumberField;
        }
        set
        {
            this.pageNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public short Count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int TotalRecords
    {
        get
        {
            return this.totalRecordsField;
        }
        set
        {
            this.totalRecordsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public short TotalPages
    {
        get
        {
            return this.totalPagesField;
        }
        set
        {
            this.totalPagesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
    public ParcelIDInfo[] ParcelIDInfoList
    {
        get
        {
            return this.parcelIDInfoListField;
        }
        set
        {
            this.parcelIDInfoListField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class ParcelNote
{
    
    private long parcelIDField;
    
    private int parcelNoteIDField;
    
    private long interchangeIDField;
    
    private System.DateTime noteDateField;
    
    private string statusCodeField;
    
    private string postedByField;
    
    private int userIDField;
    
    private string noteField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public long ParcelID
    {
        get
        {
            return this.parcelIDField;
        }
        set
        {
            this.parcelIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int ParcelNoteID
    {
        get
        {
            return this.parcelNoteIDField;
        }
        set
        {
            this.parcelNoteIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public long InterchangeID
    {
        get
        {
            return this.interchangeIDField;
        }
        set
        {
            this.interchangeIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime NoteDate
    {
        get
        {
            return this.noteDateField;
        }
        set
        {
            this.noteDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string StatusCode
    {
        get
        {
            return this.statusCodeField;
        }
        set
        {
            this.statusCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string PostedBy
    {
        get
        {
            return this.postedByField;
        }
        set
        {
            this.postedByField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class Level
{
    
    private PricelistItemLevel level1Field;
    
    private string nameField;
    
    private short limitedMonthsField;
    
    private Schedule[] schedulesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Level", Order=0)]
    public PricelistItemLevel Level1
    {
        get
        {
            return this.level1Field;
        }
        set
        {
            this.level1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public short LimitedMonths
    {
        get
        {
            return this.limitedMonthsField;
        }
        set
        {
            this.limitedMonthsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
    public Schedule[] Schedules
    {
        get
        {
            return this.schedulesField;
        }
        set
        {
            this.schedulesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum PricelistItemLevel
{
    
    /// <remarks/>
    Additional,
    
    /// <remarks/>
    OneTime,
    
    /// <remarks/>
    General,
    
    /// <remarks/>
    Developement,
    
    /// <remarks/>
    Level1,
    
    /// <remarks/>
    Level2,
    
    /// <remarks/>
    Level3,
    
    /// <remarks/>
    Level4,
    
    /// <remarks/>
    Level5,
    
    /// <remarks/>
    Level6,
    
    /// <remarks/>
    Level7,
    
    /// <remarks/>
    Level8,
    
    /// <remarks/>
    Level9,
    
    /// <remarks/>
    Tier1,
    
    /// <remarks/>
    Tier2,
    
    /// <remarks/>
    Tier3,
    
    /// <remarks/>
    Tier4,
    
    /// <remarks/>
    Tier5,
    
    /// <remarks/>
    Tier6,
    
    /// <remarks/>
    Tier7,
    
    /// <remarks/>
    Tier8,
    
    /// <remarks/>
    Tier9,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class Schedule
{
    
    private int scheduleIDField;
    
    private decimal allowanceField;
    
    private int maximumField;
    
    private decimal blockField;
    
    private decimal rateField;
    
    private int catalogIDField;
    
    private string descriptionField;
    
    private PricelistAccountReports accountReportField;
    
    private PricelistMeasureField measureField;
    
    private int specifiedNetworkIDField;
    
    private bool includeRootMailboxField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int ScheduleID
    {
        get
        {
            return this.scheduleIDField;
        }
        set
        {
            this.scheduleIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public decimal Allowance
    {
        get
        {
            return this.allowanceField;
        }
        set
        {
            this.allowanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int Maximum
    {
        get
        {
            return this.maximumField;
        }
        set
        {
            this.maximumField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public decimal Block
    {
        get
        {
            return this.blockField;
        }
        set
        {
            this.blockField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public decimal Rate
    {
        get
        {
            return this.rateField;
        }
        set
        {
            this.rateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public int CatalogID
    {
        get
        {
            return this.catalogIDField;
        }
        set
        {
            this.catalogIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public PricelistAccountReports AccountReport
    {
        get
        {
            return this.accountReportField;
        }
        set
        {
            this.accountReportField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public PricelistMeasureField Measure
    {
        get
        {
            return this.measureField;
        }
        set
        {
            this.measureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public int SpecifiedNetworkID
    {
        get
        {
            return this.specifiedNetworkIDField;
        }
        set
        {
            this.specifiedNetworkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public bool IncludeRootMailbox
    {
        get
        {
            return this.includeRootMailboxField;
        }
        set
        {
            this.includeRootMailboxField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum PricelistAccountReports
{
    
    /// <remarks/>
    FixedRate,
    
    /// <remarks/>
    Statistics,
    
    /// <remarks/>
    TrafficAll,
    
    /// <remarks/>
    TrafficIntraNetwork,
    
    /// <remarks/>
    TrafficInterECGrid,
    
    /// <remarks/>
    TrafficOffNetwork,
    
    /// <remarks/>
    TrafficSpecial,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum PricelistMeasureField
{
    
    /// <remarks/>
    Each,
    
    /// <remarks/>
    FixedRate,
    
    /// <remarks/>
    NewInterconnects,
    
    /// <remarks/>
    CurrentMailboxes,
    
    /// <remarks/>
    ActiveQIDs,
    
    /// <remarks/>
    ActiveTPs,
    
    /// <remarks/>
    TotalTrans,
    
    /// <remarks/>
    ToTrans,
    
    /// <remarks/>
    FromTrans,
    
    /// <remarks/>
    TotalKCs,
    
    /// <remarks/>
    ToKCs,
    
    /// <remarks/>
    FromKCs,
    
    /// <remarks/>
    RegisteredQIDs,
    
    /// <remarks/>
    RegisteredTPs,
    
    /// <remarks/>
    MigratedTPs,
    
    /// <remarks/>
    CreditPercentage,
    
    /// <remarks/>
    DebitPercentage,
    
    /// <remarks/>
    Subtotal,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class Pricelist
{
    
    private int pricelistIDField;
    
    private UserIDInfo ownerField;
    
    private System.DateTime dateField;
    
    private string descriptionField;
    
    private PricelistModel modelField;
    
    private Status statusField;
    
    private Level[] levelsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int PricelistID
    {
        get
        {
            return this.pricelistIDField;
        }
        set
        {
            this.pricelistIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public UserIDInfo Owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime Date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public PricelistModel Model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=6)]
    public Level[] Levels
    {
        get
        {
            return this.levelsField;
        }
        set
        {
            this.levelsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum PricelistModel
{
    
    /// <remarks/>
    Simple,
    
    /// <remarks/>
    Tiered,
    
    /// <remarks/>
    Stacked,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class PGPKeyInfo
{
    
    private int certKeyIDField;
    
    private string keyIDField;
    
    private string userIDField;
    
    private CertificateType typeField;
    
    private System.DateTime beginUsageField;
    
    private System.DateTime endUsageField;
    
    private System.DateTime expiresField;
    
    private Status statusField;
    
    private bool privateField;
    
    private string passwordField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int CertKeyID
    {
        get
        {
            return this.certKeyIDField;
        }
        set
        {
            this.certKeyIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string KeyID
    {
        get
        {
            return this.keyIDField;
        }
        set
        {
            this.keyIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public CertificateType Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.DateTime BeginUsage
    {
        get
        {
            return this.beginUsageField;
        }
        set
        {
            this.beginUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public System.DateTime EndUsage
    {
        get
        {
            return this.endUsageField;
        }
        set
        {
            this.endUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public System.DateTime Expires
    {
        get
        {
            return this.expiresField;
        }
        set
        {
            this.expiresField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public bool Private
    {
        get
        {
            return this.privateField;
        }
        set
        {
            this.privateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public string Password
    {
        get
        {
            return this.passwordField;
        }
        set
        {
            this.passwordField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum CertificateType
{
    
    /// <remarks/>
    X509,
    
    /// <remarks/>
    PGP,
    
    /// <remarks/>
    SSH,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class GISBCommInfo
{
    
    private int commIDField;
    
    private string identifierField;
    
    private int userIDField;
    
    private int networkIDField;
    
    private int mailboxIDField;
    
    private UseType useTypeField;
    
    private string uRLField;
    
    private bool signDataField;
    
    private bool encryptDataField;
    
    private string versionField;
    
    private Status statusField;
    
    private ReceiptType receiptField;
    
    private HTTPAuthInfo hTTPAuthenticationField;
    
    private PGPKeyInfo[] pGPKeysField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int CommID
    {
        get
        {
            return this.commIDField;
        }
        set
        {
            this.commIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Identifier
    {
        get
        {
            return this.identifierField;
        }
        set
        {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int UserID
    {
        get
        {
            return this.userIDField;
        }
        set
        {
            this.userIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public UseType UseType
    {
        get
        {
            return this.useTypeField;
        }
        set
        {
            this.useTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string URL
    {
        get
        {
            return this.uRLField;
        }
        set
        {
            this.uRLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public bool SignData
    {
        get
        {
            return this.signDataField;
        }
        set
        {
            this.signDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public bool EncryptData
    {
        get
        {
            return this.encryptDataField;
        }
        set
        {
            this.encryptDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public string Version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public ReceiptType Receipt
    {
        get
        {
            return this.receiptField;
        }
        set
        {
            this.receiptField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public HTTPAuthInfo HTTPAuthentication
    {
        get
        {
            return this.hTTPAuthenticationField;
        }
        set
        {
            this.hTTPAuthenticationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=13)]
    public PGPKeyInfo[] PGPKeys
    {
        get
        {
            return this.pGPKeysField;
        }
        set
        {
            this.pGPKeysField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum ReceiptType
{
    
    /// <remarks/>
    None,
    
    /// <remarks/>
    SynchronousUnsigned,
    
    /// <remarks/>
    SynchronousSigned,
    
    /// <remarks/>
    AsynchronousUnsigned,
    
    /// <remarks/>
    AsynchronousSigned,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class CertificateRoot
{
    
    private string passwordField;
    
    private byte[] privatePFXField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Password
    {
        get
        {
            return this.passwordField;
        }
        set
        {
            this.passwordField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=1)]
    public byte[] PrivatePFX
    {
        get
        {
            return this.privatePFXField;
        }
        set
        {
            this.privatePFXField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class Certificate
{
    
    private int certKeyIDField;
    
    private string partnerIDField;
    
    private string partnerURLField;
    
    private CertificateType typeField;
    
    private CertificateUsage usageField;
    
    private string secureHashAlgorithmField;
    
    private string subjectField;
    
    private string issuerField;
    
    private bool hasPrivateKeyField;
    
    private byte[] publicCertificateField;
    
    private System.DateTime beginUsageField;
    
    private System.DateTime endUsageField;
    
    private System.DateTime notBeforeField;
    
    private System.DateTime notAfterField;
    
    private string serialNumberField;
    
    private string thumbprintField;
    
    private Status statusField;
    
    private CertificateRoot rootInfoField;
    
    private CertStoreTypes certTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int CertKeyID
    {
        get
        {
            return this.certKeyIDField;
        }
        set
        {
            this.certKeyIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string PartnerID
    {
        get
        {
            return this.partnerIDField;
        }
        set
        {
            this.partnerIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string PartnerURL
    {
        get
        {
            return this.partnerURLField;
        }
        set
        {
            this.partnerURLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public CertificateType Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public CertificateUsage Usage
    {
        get
        {
            return this.usageField;
        }
        set
        {
            this.usageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string SecureHashAlgorithm
    {
        get
        {
            return this.secureHashAlgorithmField;
        }
        set
        {
            this.secureHashAlgorithmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string Subject
    {
        get
        {
            return this.subjectField;
        }
        set
        {
            this.subjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string Issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public bool HasPrivateKey
    {
        get
        {
            return this.hasPrivateKeyField;
        }
        set
        {
            this.hasPrivateKeyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=9)]
    public byte[] PublicCertificate
    {
        get
        {
            return this.publicCertificateField;
        }
        set
        {
            this.publicCertificateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public System.DateTime BeginUsage
    {
        get
        {
            return this.beginUsageField;
        }
        set
        {
            this.beginUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public System.DateTime EndUsage
    {
        get
        {
            return this.endUsageField;
        }
        set
        {
            this.endUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public System.DateTime NotBefore
    {
        get
        {
            return this.notBeforeField;
        }
        set
        {
            this.notBeforeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public System.DateTime NotAfter
    {
        get
        {
            return this.notAfterField;
        }
        set
        {
            this.notAfterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public string SerialNumber
    {
        get
        {
            return this.serialNumberField;
        }
        set
        {
            this.serialNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public string Thumbprint
    {
        get
        {
            return this.thumbprintField;
        }
        set
        {
            this.thumbprintField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public CertificateRoot RootInfo
    {
        get
        {
            return this.rootInfoField;
        }
        set
        {
            this.rootInfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public CertStoreTypes CertType
    {
        get
        {
            return this.certTypeField;
        }
        set
        {
            this.certTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum CertificateUsage
{
    
    /// <remarks/>
    SSL,
    
    /// <remarks/>
    Encryption,
    
    /// <remarks/>
    Signature,
    
    /// <remarks/>
    EncryptionAndSignature,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum CertStoreTypes
{
    
    /// <remarks/>
    cstUser,
    
    /// <remarks/>
    cstMachine,
    
    /// <remarks/>
    cstPFXFile,
    
    /// <remarks/>
    cstPFXBlob,
    
    /// <remarks/>
    cstJKSFile,
    
    /// <remarks/>
    cstJKSBlob,
    
    /// <remarks/>
    cstPEMKeyFile,
    
    /// <remarks/>
    cstPEMKeyBlob,
    
    /// <remarks/>
    cstPublicKeyFile,
    
    /// <remarks/>
    cstPublicKeyBlob,
    
    /// <remarks/>
    cstSSHPublicKeyBlob,
    
    /// <remarks/>
    cstP7BFile,
    
    /// <remarks/>
    cstP7BBlob,
    
    /// <remarks/>
    cstSSHPublicKeyFile,
    
    /// <remarks/>
    cstPPKFile,
    
    /// <remarks/>
    cstPPKBlob,
    
    /// <remarks/>
    cstXMLFile,
    
    /// <remarks/>
    cstXMLBlob,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class CommIDInfo
{
    
    private int commIDField;
    
    private NetworkGatewayCommChannel typeField;
    
    private System.DateTime createdField;
    
    private System.DateTime modifiedField;
    
    private bool hostedField;
    
    private string identifierField;
    
    private UserIDInfo ownerField;
    
    private int networkIDField;
    
    private int mailboxIDField;
    
    private UseType useTypeField;
    
    private string uRLField;
    
    private string mimeTypeOverrideField;
    
    private bool signDataField;
    
    private bool encryptDataField;
    
    private bool compressDataField;
    
    private System.DateTime beginUsageField;
    
    private System.DateTime endUsageField;
    
    private Status statusField;
    
    private ReceiptType receiptField;
    
    private bool sSLClientAuthenticationField;
    
    private HTTPAuthInfo hTTPAuthenticationField;
    
    private Certificate[] certificatesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int CommID
    {
        get
        {
            return this.commIDField;
        }
        set
        {
            this.commIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public NetworkGatewayCommChannel Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public bool Hosted
    {
        get
        {
            return this.hostedField;
        }
        set
        {
            this.hostedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string Identifier
    {
        get
        {
            return this.identifierField;
        }
        set
        {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public UserIDInfo Owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public UseType UseType
    {
        get
        {
            return this.useTypeField;
        }
        set
        {
            this.useTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public string URL
    {
        get
        {
            return this.uRLField;
        }
        set
        {
            this.uRLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public string MimeTypeOverride
    {
        get
        {
            return this.mimeTypeOverrideField;
        }
        set
        {
            this.mimeTypeOverrideField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public bool SignData
    {
        get
        {
            return this.signDataField;
        }
        set
        {
            this.signDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public bool EncryptData
    {
        get
        {
            return this.encryptDataField;
        }
        set
        {
            this.encryptDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public bool CompressData
    {
        get
        {
            return this.compressDataField;
        }
        set
        {
            this.compressDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public System.DateTime BeginUsage
    {
        get
        {
            return this.beginUsageField;
        }
        set
        {
            this.beginUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public System.DateTime EndUsage
    {
        get
        {
            return this.endUsageField;
        }
        set
        {
            this.endUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public ReceiptType Receipt
    {
        get
        {
            return this.receiptField;
        }
        set
        {
            this.receiptField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=19)]
    public bool SSLClientAuthentication
    {
        get
        {
            return this.sSLClientAuthenticationField;
        }
        set
        {
            this.sSLClientAuthenticationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=20)]
    public HTTPAuthInfo HTTPAuthentication
    {
        get
        {
            return this.hTTPAuthenticationField;
        }
        set
        {
            this.hTTPAuthenticationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=21)]
    public Certificate[] Certificates
    {
        get
        {
            return this.certificatesField;
        }
        set
        {
            this.certificatesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class CertificateRootInfo
{
    
    private string passwordField;
    
    private byte[] privatePFXField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Password
    {
        get
        {
            return this.passwordField;
        }
        set
        {
            this.passwordField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=1)]
    public byte[] PrivatePFX
    {
        get
        {
            return this.privatePFXField;
        }
        set
        {
            this.privatePFXField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class CertificateInfo
{
    
    private int certKeyIDField;
    
    private string partnerAS2IDField;
    
    private string partnerURLField;
    
    private CertificateType typeField;
    
    private CertificateUsage usageField;
    
    private string secureHashAlgorithmField;
    
    private string subjectField;
    
    private string issuerField;
    
    private bool hasPrivateKeyField;
    
    private byte[] publicCertificateField;
    
    private System.DateTime beginUsageField;
    
    private System.DateTime endUsageField;
    
    private System.DateTime notBeforeField;
    
    private System.DateTime notAfterField;
    
    private string serialNumberField;
    
    private string thumbprintField;
    
    private Status statusField;
    
    private CertificateRootInfo rootInfoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int CertKeyID
    {
        get
        {
            return this.certKeyIDField;
        }
        set
        {
            this.certKeyIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string PartnerAS2ID
    {
        get
        {
            return this.partnerAS2IDField;
        }
        set
        {
            this.partnerAS2IDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string PartnerURL
    {
        get
        {
            return this.partnerURLField;
        }
        set
        {
            this.partnerURLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public CertificateType Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public CertificateUsage Usage
    {
        get
        {
            return this.usageField;
        }
        set
        {
            this.usageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string SecureHashAlgorithm
    {
        get
        {
            return this.secureHashAlgorithmField;
        }
        set
        {
            this.secureHashAlgorithmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string Subject
    {
        get
        {
            return this.subjectField;
        }
        set
        {
            this.subjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string Issuer
    {
        get
        {
            return this.issuerField;
        }
        set
        {
            this.issuerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public bool HasPrivateKey
    {
        get
        {
            return this.hasPrivateKeyField;
        }
        set
        {
            this.hasPrivateKeyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=9)]
    public byte[] PublicCertificate
    {
        get
        {
            return this.publicCertificateField;
        }
        set
        {
            this.publicCertificateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public System.DateTime BeginUsage
    {
        get
        {
            return this.beginUsageField;
        }
        set
        {
            this.beginUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public System.DateTime EndUsage
    {
        get
        {
            return this.endUsageField;
        }
        set
        {
            this.endUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public System.DateTime NotBefore
    {
        get
        {
            return this.notBeforeField;
        }
        set
        {
            this.notBeforeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public System.DateTime NotAfter
    {
        get
        {
            return this.notAfterField;
        }
        set
        {
            this.notAfterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public string SerialNumber
    {
        get
        {
            return this.serialNumberField;
        }
        set
        {
            this.serialNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public string Thumbprint
    {
        get
        {
            return this.thumbprintField;
        }
        set
        {
            this.thumbprintField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public CertificateRootInfo RootInfo
    {
        get
        {
            return this.rootInfoField;
        }
        set
        {
            this.rootInfoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class as2CommInfo
{
    
    private int commIDField;
    
    private System.DateTime createdField;
    
    private System.DateTime modifiedField;
    
    private bool hostedField;
    
    private string identifierField;
    
    private UserIDInfo ownerField;
    
    private int networkIDField;
    
    private int mailboxIDField;
    
    private UseType useTypeField;
    
    private string uRLField;
    
    private string mimeTypeOverrideField;
    
    private bool signDataField;
    
    private bool encryptDataField;
    
    private bool compressDataField;
    
    private System.DateTime beginUsageField;
    
    private System.DateTime endUsageField;
    
    private Status statusField;
    
    private ReceiptType receiptField;
    
    private bool sSLClientAuthenticationField;
    
    private HTTPAuthInfo hTTPAuthenticationField;
    
    private CertificateInfo[] certificatesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int CommID
    {
        get
        {
            return this.commIDField;
        }
        set
        {
            this.commIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime Created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime Modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public bool Hosted
    {
        get
        {
            return this.hostedField;
        }
        set
        {
            this.hostedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string Identifier
    {
        get
        {
            return this.identifierField;
        }
        set
        {
            this.identifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public UserIDInfo Owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public int NetworkID
    {
        get
        {
            return this.networkIDField;
        }
        set
        {
            this.networkIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public int MailboxID
    {
        get
        {
            return this.mailboxIDField;
        }
        set
        {
            this.mailboxIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public UseType UseType
    {
        get
        {
            return this.useTypeField;
        }
        set
        {
            this.useTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public string URL
    {
        get
        {
            return this.uRLField;
        }
        set
        {
            this.uRLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public string MimeTypeOverride
    {
        get
        {
            return this.mimeTypeOverrideField;
        }
        set
        {
            this.mimeTypeOverrideField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public bool SignData
    {
        get
        {
            return this.signDataField;
        }
        set
        {
            this.signDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public bool EncryptData
    {
        get
        {
            return this.encryptDataField;
        }
        set
        {
            this.encryptDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public bool CompressData
    {
        get
        {
            return this.compressDataField;
        }
        set
        {
            this.compressDataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public System.DateTime BeginUsage
    {
        get
        {
            return this.beginUsageField;
        }
        set
        {
            this.beginUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public System.DateTime EndUsage
    {
        get
        {
            return this.endUsageField;
        }
        set
        {
            this.endUsageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public Status Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public ReceiptType Receipt
    {
        get
        {
            return this.receiptField;
        }
        set
        {
            this.receiptField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public bool SSLClientAuthentication
    {
        get
        {
            return this.sSLClientAuthenticationField;
        }
        set
        {
            this.sSLClientAuthenticationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=19)]
    public HTTPAuthInfo HTTPAuthentication
    {
        get
        {
            return this.hTTPAuthenticationField;
        }
        set
        {
            this.hTTPAuthenticationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=20)]
    public CertificateInfo[] Certificates
    {
        get
        {
            return this.certificatesField;
        }
        set
        {
            this.certificatesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class LineItem
{
    
    private short lineItemNumberField;
    
    private System.DateTime lineDateField;
    
    private int priceListIDField;
    
    private string priceListDescriptionField;
    
    private Objects systemObjectField;
    
    private int systemIDField;
    
    private string systemNameField;
    
    private PricelistItemLevel levelField;
    
    private string levelNameField;
    
    private PricelistModel modelField;
    
    private Schedule scheduleField;
    
    private decimal actualField;
    
    private decimal quantityBilledField;
    
    private bool taxableField;
    
    private decimal amountField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public short LineItemNumber
    {
        get
        {
            return this.lineItemNumberField;
        }
        set
        {
            this.lineItemNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime LineDate
    {
        get
        {
            return this.lineDateField;
        }
        set
        {
            this.lineDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int PriceListID
    {
        get
        {
            return this.priceListIDField;
        }
        set
        {
            this.priceListIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string PriceListDescription
    {
        get
        {
            return this.priceListDescriptionField;
        }
        set
        {
            this.priceListDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public Objects SystemObject
    {
        get
        {
            return this.systemObjectField;
        }
        set
        {
            this.systemObjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public int SystemID
    {
        get
        {
            return this.systemIDField;
        }
        set
        {
            this.systemIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string SystemName
    {
        get
        {
            return this.systemNameField;
        }
        set
        {
            this.systemNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public PricelistItemLevel Level
    {
        get
        {
            return this.levelField;
        }
        set
        {
            this.levelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string LevelName
    {
        get
        {
            return this.levelNameField;
        }
        set
        {
            this.levelNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public PricelistModel Model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public Schedule Schedule
    {
        get
        {
            return this.scheduleField;
        }
        set
        {
            this.scheduleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public decimal Actual
    {
        get
        {
            return this.actualField;
        }
        set
        {
            this.actualField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public decimal QuantityBilled
    {
        get
        {
            return this.quantityBilledField;
        }
        set
        {
            this.quantityBilledField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public bool Taxable
    {
        get
        {
            return this.taxableField;
        }
        set
        {
            this.taxableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public decimal Amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public partial class Invoice
{
    
    private int invoiceIDField;
    
    private string invoiceNumberField;
    
    private System.DateTime dateField;
    
    private int contractIDField;
    
    private decimal totalAmountField;
    
    private string pONumberField;
    
    private string noticeField;
    
    private string specialNoticeField;
    
    private string messageField;
    
    private InvoiceStatus statusField;
    
    private System.DateTime statusDateField;
    
    private System.DateTime dateDueField;
    
    private string pricelistDescriptionField;
    
    private string termsField;
    
    private string billToField;
    
    private string billToAddressField;
    
    private UserIDInfo sendToField;
    
    private UserIDInfo copiesToField;
    
    private UserIDInfo senderField;
    
    private LineItem[] lineItemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int InvoiceID
    {
        get
        {
            return this.invoiceIDField;
        }
        set
        {
            this.invoiceIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string InvoiceNumber
    {
        get
        {
            return this.invoiceNumberField;
        }
        set
        {
            this.invoiceNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime Date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public int ContractID
    {
        get
        {
            return this.contractIDField;
        }
        set
        {
            this.contractIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public decimal TotalAmount
    {
        get
        {
            return this.totalAmountField;
        }
        set
        {
            this.totalAmountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string PONumber
    {
        get
        {
            return this.pONumberField;
        }
        set
        {
            this.pONumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string Notice
    {
        get
        {
            return this.noticeField;
        }
        set
        {
            this.noticeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string SpecialNotice
    {
        get
        {
            return this.specialNoticeField;
        }
        set
        {
            this.specialNoticeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public InvoiceStatus Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public System.DateTime StatusDate
    {
        get
        {
            return this.statusDateField;
        }
        set
        {
            this.statusDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public System.DateTime DateDue
    {
        get
        {
            return this.dateDueField;
        }
        set
        {
            this.dateDueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    public string PricelistDescription
    {
        get
        {
            return this.pricelistDescriptionField;
        }
        set
        {
            this.pricelistDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public string Terms
    {
        get
        {
            return this.termsField;
        }
        set
        {
            this.termsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    public string BillTo
    {
        get
        {
            return this.billToField;
        }
        set
        {
            this.billToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=15)]
    public string BillToAddress
    {
        get
        {
            return this.billToAddressField;
        }
        set
        {
            this.billToAddressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public UserIDInfo SendTo
    {
        get
        {
            return this.sendToField;
        }
        set
        {
            this.sendToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public UserIDInfo CopiesTo
    {
        get
        {
            return this.copiesToField;
        }
        set
        {
            this.copiesToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=18)]
    public UserIDInfo Sender
    {
        get
        {
            return this.senderField;
        }
        set
        {
            this.senderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=19)]
    public LineItem[] LineItems
    {
        get
        {
            return this.lineItemsField;
        }
        set
        {
            this.lineItemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum InvoiceStatus
{
    
    /// <remarks/>
    Pending,
    
    /// <remarks/>
    Sent,
    
    /// <remarks/>
    Paid,
    
    /// <remarks/>
    Canceled,
    
    /// <remarks/>
    AllUnpaid,
    
    /// <remarks/>
    All,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum InvoiceInclude
{
    
    /// <remarks/>
    AllCurrentCharges,
    
    /// <remarks/>
    MonthlyItemsOnly,
    
    /// <remarks/>
    SpecialChargesOnly,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum StatisticsPeriod
{
    
    /// <remarks/>
    Hour,
    
    /// <remarks/>
    Day,
    
    /// <remarks/>
    Week,
    
    /// <remarks/>
    Month,
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="AS2CertAddPublic", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class AS2CertAddPublicRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public int CommID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public System.DateTime BeginUsage;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    public CertificateUsage Usage;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=4)]
    public string PartnerAS2ID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=5)]
    public string PartnerURL;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=6)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Cert;
    
    public AS2CertAddPublicRequest()
    {
    }
    
    public AS2CertAddPublicRequest(string SessionID, int CommID, System.DateTime BeginUsage, CertificateUsage Usage, string PartnerAS2ID, string PartnerURL, byte[] Cert)
    {
        this.SessionID = SessionID;
        this.CommID = CommID;
        this.BeginUsage = BeginUsage;
        this.Usage = Usage;
        this.PartnerAS2ID = PartnerAS2ID;
        this.PartnerURL = PartnerURL;
        this.Cert = Cert;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="AS2CertAddPublicResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class AS2CertAddPublicResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public as2CommInfo AS2CertAddPublicResult;
    
    public AS2CertAddPublicResponse()
    {
    }
    
    public AS2CertAddPublicResponse(as2CommInfo AS2CertAddPublicResult)
    {
        this.AS2CertAddPublicResult = AS2CertAddPublicResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="CertificateAddPublic", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class CertificateAddPublicRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public int CommID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public System.DateTime BeginUsage;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    public CertificateUsage Usage;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=4)]
    public string PartnerCommID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=5)]
    public string PartnerURL;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=6)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Cert;
    
    public CertificateAddPublicRequest()
    {
    }
    
    public CertificateAddPublicRequest(string SessionID, int CommID, System.DateTime BeginUsage, CertificateUsage Usage, string PartnerCommID, string PartnerURL, byte[] Cert)
    {
        this.SessionID = SessionID;
        this.CommID = CommID;
        this.BeginUsage = BeginUsage;
        this.Usage = Usage;
        this.PartnerCommID = PartnerCommID;
        this.PartnerURL = PartnerURL;
        this.Cert = Cert;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="CertificateAddPublicResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class CertificateAddPublicResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public CommIDInfo CertificateAddPublicResult;
    
    public CertificateAddPublicResponse()
    {
    }
    
    public CertificateAddPublicResponse(CommIDInfo CertificateAddPublicResult)
    {
        this.CertificateAddPublicResult = CertificateAddPublicResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="AS2CertAddPrivate", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class AS2CertAddPrivateRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public int CommID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public System.DateTime BeginUsage;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    public CertificateUsage Usage;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=4)]
    public string PartnerAS2ID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=5)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Cert;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=6)]
    public string Password;
    
    public AS2CertAddPrivateRequest()
    {
    }
    
    public AS2CertAddPrivateRequest(string SessionID, int CommID, System.DateTime BeginUsage, CertificateUsage Usage, string PartnerAS2ID, byte[] Cert, string Password)
    {
        this.SessionID = SessionID;
        this.CommID = CommID;
        this.BeginUsage = BeginUsage;
        this.Usage = Usage;
        this.PartnerAS2ID = PartnerAS2ID;
        this.Cert = Cert;
        this.Password = Password;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="AS2CertAddPrivateResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class AS2CertAddPrivateResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public as2CommInfo AS2CertAddPrivateResult;
    
    public AS2CertAddPrivateResponse()
    {
    }
    
    public AS2CertAddPrivateResponse(as2CommInfo AS2CertAddPrivateResult)
    {
        this.AS2CertAddPrivateResult = AS2CertAddPrivateResult;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum CertificateSecureHashAlgorithm
{
    
    /// <remarks/>
    sha1,
    
    /// <remarks/>
    sha2,
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="InterchangeHeaderInfoB", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class InterchangeHeaderInfoBRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] InterchangeHeader;
    
    public InterchangeHeaderInfoBRequest()
    {
    }
    
    public InterchangeHeaderInfoBRequest(string SessionID, byte[] InterchangeHeader)
    {
        this.SessionID = SessionID;
        this.InterchangeHeader = InterchangeHeader;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="InterchangeHeaderInfoBResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class InterchangeHeaderInfoBResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public InterchangeIDInfo InterchangeHeaderInfoBResult;
    
    public InterchangeHeaderInfoBResponse()
    {
    }
    
    public InterchangeHeaderInfoBResponse(InterchangeIDInfo InterchangeHeaderInfoBResult)
    {
        this.InterchangeHeaderInfoBResult = InterchangeHeaderInfoBResult;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum eMailTo
{
    
    /// <remarks/>
    NoEMail,
    
    /// <remarks/>
    Requestor,
    
    /// <remarks/>
    Network,
    
    /// <remarks/>
    RequestorAndNetwork,
    
    /// <remarks/>
    Other,
    
    /// <remarks/>
    RequestorAndOther,
    
    /// <remarks/>
    NetworkAndOther,
    
    /// <remarks/>
    EMailAll,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum ParcelStatus
{
    
    /// <remarks/>
    InBoxReady,
    
    /// <remarks/>
    InBoxTransferred,
    
    /// <remarks/>
    x1256Pending,
    
    /// <remarks/>
    as2Receive,
    
    /// <remarks/>
    as2MDNSent,
    
    /// <remarks/>
    as2MDNPending,
    
    /// <remarks/>
    as2MDNRejected,
    
    /// <remarks/>
    as2MDNConfirmed,
    
    /// <remarks/>
    as2Sent,
    
    /// <remarks/>
    as2SendFailed,
    
    /// <remarks/>
    gisbReceived,
    
    /// <remarks/>
    gisbSent,
    
    /// <remarks/>
    gisbSendFailed,
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUpload", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public string FileName;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public int Bytes;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Content;
    
    public ParcelUploadRequest()
    {
    }
    
    public ParcelUploadRequest(string SessionID, string FileName, int Bytes, byte[] Content)
    {
        this.SessionID = SessionID;
        this.FileName = FileName;
        this.Bytes = Bytes;
        this.Content = Content;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public int ParcelUploadResult;
    
    public ParcelUploadResponse()
    {
    }
    
    public ParcelUploadResponse(int ParcelUploadResult)
    {
        this.ParcelUploadResult = ParcelUploadResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadExA", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadExARequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public int NetworkID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public int MailboxID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    public string FileName;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=4)]
    public int Bytes;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=5)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Content;
    
    public ParcelUploadExARequest()
    {
    }
    
    public ParcelUploadExARequest(string SessionID, int NetworkID, int MailboxID, string FileName, int Bytes, byte[] Content)
    {
        this.SessionID = SessionID;
        this.NetworkID = NetworkID;
        this.MailboxID = MailboxID;
        this.FileName = FileName;
        this.Bytes = Bytes;
        this.Content = Content;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadExAResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadExAResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public int ParcelUploadExAResult;
    
    public ParcelUploadExAResponse()
    {
    }
    
    public ParcelUploadExAResponse(int ParcelUploadExAResult)
    {
        this.ParcelUploadExAResult = ParcelUploadExAResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadGZip", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadGZipRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public string FileName;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public int Bytes;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Content;
    
    public ParcelUploadGZipRequest()
    {
    }
    
    public ParcelUploadGZipRequest(string SessionID, string FileName, int Bytes, byte[] Content)
    {
        this.SessionID = SessionID;
        this.FileName = FileName;
        this.Bytes = Bytes;
        this.Content = Content;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadGZipResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadGZipResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public int ParcelUploadGZipResult;
    
    public ParcelUploadGZipResponse()
    {
    }
    
    public ParcelUploadGZipResponse(int ParcelUploadGZipResult)
    {
        this.ParcelUploadGZipResult = ParcelUploadGZipResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadEx", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadExRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public string FileName;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public int Bytes;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Content;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=4)]
    public int ECGridIDFrom;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=5)]
    public int ECGridIDTo;
    
    public ParcelUploadExRequest()
    {
    }
    
    public ParcelUploadExRequest(string SessionID, string FileName, int Bytes, byte[] Content, int ECGridIDFrom, int ECGridIDTo)
    {
        this.SessionID = SessionID;
        this.FileName = FileName;
        this.Bytes = Bytes;
        this.Content = Content;
        this.ECGridIDFrom = ECGridIDFrom;
        this.ECGridIDTo = ECGridIDTo;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadExResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadExResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public int ParcelUploadExResult;
    
    public ParcelUploadExResponse()
    {
    }
    
    public ParcelUploadExResponse(int ParcelUploadExResult)
    {
        this.ParcelUploadExResult = ParcelUploadExResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadDirected", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadDirectedRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public int NetworkID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public int MailboxID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    public string FileName;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=4)]
    public int Bytes;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=5)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Content;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=6)]
    public int ECGridIDFrom;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=7)]
    public int ECGridIDTo;
    
    public ParcelUploadDirectedRequest()
    {
    }
    
    public ParcelUploadDirectedRequest(string SessionID, int NetworkID, int MailboxID, string FileName, int Bytes, byte[] Content, int ECGridIDFrom, int ECGridIDTo)
    {
        this.SessionID = SessionID;
        this.NetworkID = NetworkID;
        this.MailboxID = MailboxID;
        this.FileName = FileName;
        this.Bytes = Bytes;
        this.Content = Content;
        this.ECGridIDFrom = ECGridIDFrom;
        this.ECGridIDTo = ECGridIDTo;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadDirectedResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadDirectedResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public int ParcelUploadDirectedResult;
    
    public ParcelUploadDirectedResponse()
    {
    }
    
    public ParcelUploadDirectedResponse(int ParcelUploadDirectedResult)
    {
        this.ParcelUploadDirectedResult = ParcelUploadDirectedResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadGZipEx", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadGZipExRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public string FileName;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public int Bytes;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Content;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=4)]
    public int ECGridIDFrom;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=5)]
    public int ECGridIDTo;
    
    public ParcelUploadGZipExRequest()
    {
    }
    
    public ParcelUploadGZipExRequest(string SessionID, string FileName, int Bytes, byte[] Content, int ECGridIDFrom, int ECGridIDTo)
    {
        this.SessionID = SessionID;
        this.FileName = FileName;
        this.Bytes = Bytes;
        this.Content = Content;
        this.ECGridIDFrom = ECGridIDFrom;
        this.ECGridIDTo = ECGridIDTo;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadGZipExResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadGZipExResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public int ParcelUploadGZipExResult;
    
    public ParcelUploadGZipExResponse()
    {
    }
    
    public ParcelUploadGZipExResponse(int ParcelUploadGZipExResult)
    {
        this.ParcelUploadGZipExResult = ParcelUploadGZipExResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadDirectedGZip", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadDirectedGZipRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public int NetworkID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public int MailboxID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    public string FileName;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=4)]
    public int Bytes;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=5)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] Content;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=6)]
    public int ECGridIDFrom;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=7)]
    public int ECGridIDTo;
    
    public ParcelUploadDirectedGZipRequest()
    {
    }
    
    public ParcelUploadDirectedGZipRequest(string SessionID, int NetworkID, int MailboxID, string FileName, int Bytes, byte[] Content, int ECGridIDFrom, int ECGridIDTo)
    {
        this.SessionID = SessionID;
        this.NetworkID = NetworkID;
        this.MailboxID = MailboxID;
        this.FileName = FileName;
        this.Bytes = Bytes;
        this.Content = Content;
        this.ECGridIDFrom = ECGridIDFrom;
        this.ECGridIDTo = ECGridIDTo;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ParcelUploadDirectedGZipResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class ParcelUploadDirectedGZipResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public int ParcelUploadDirectedGZipResult;
    
    public ParcelUploadDirectedGZipResponse()
    {
    }
    
    public ParcelUploadDirectedGZipResponse(int ParcelUploadDirectedGZipResult)
    {
        this.ParcelUploadDirectedGZipResult = ParcelUploadDirectedGZipResult;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkWebsiteType
{
    
    /// <remarks/>
    Home,
    
    /// <remarks/>
    Support,
    
    /// <remarks/>
    Login,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkContactType
{
    
    /// <remarks/>
    Owner,
    
    /// <remarks/>
    Errors,
    
    /// <remarks/>
    Interconnects,
    
    /// <remarks/>
    Notices,
    
    /// <remarks/>
    Reports,
    
    /// <remarks/>
    Accounting,
    
    /// <remarks/>
    CustomerService,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum EMailSystem
{
    
    /// <remarks/>
    smtp,
    
    /// <remarks/>
    x400,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum EMailPayload
{
    
    /// <remarks/>
    Body,
    
    /// <remarks/>
    Attachment,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum OrderBy
{
    
    /// <remarks/>
    Description,
    
    /// <remarks/>
    QID,
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="InterconnectNote", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class InterconnectNoteRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public string SessionID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=1)]
    public int InterconnectID;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=2)]
    public AuthLevel AuthLevel;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=3)]
    public string Note;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=4)]
    public string AttachmentName;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=5)]
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
    public byte[] AttachmentContent;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=6)]
    public eMailTo EMailTo;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=7)]
    public string OtherEMailAddress;
    
    public InterconnectNoteRequest()
    {
    }
    
    public InterconnectNoteRequest(string SessionID, int InterconnectID, AuthLevel AuthLevel, string Note, string AttachmentName, byte[] AttachmentContent, eMailTo EMailTo, string OtherEMailAddress)
    {
        this.SessionID = SessionID;
        this.InterconnectID = InterconnectID;
        this.AuthLevel = AuthLevel;
        this.Note = Note;
        this.AttachmentName = AttachmentName;
        this.AttachmentContent = AttachmentContent;
        this.EMailTo = EMailTo;
        this.OtherEMailAddress = OtherEMailAddress;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="InterconnectNoteResponse", WrapperNamespace="http://ecgridos.net/", IsWrapped=true)]
public partial class InterconnectNoteResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ecgridos.net/", Order=0)]
    public bool InterconnectNoteResult;
    
    public InterconnectNoteResponse()
    {
    }
    
    public InterconnectNoteResponse(bool InterconnectNoteResult)
    {
        this.InterconnectNoteResult = InterconnectNoteResult;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ecgridos.net/")]
public enum NetworkServiceType
{
    
    /// <remarks/>
    SVC,
    
    /// <remarks/>
    VAN,
    
    /// <remarks/>
    MBX,
    
    /// <remarks/>
    NET,
    
    /// <remarks/>
    APP,
    
    /// <remarks/>
    HUB,
}
#endregion