/*
 * ECGridOS_Classes
 * Copyright: Loren Data Corp.
 * Last Updated: 09/28/2022
 * Author: Greg Kolinski
 * Description: Example ECGridOS API Class Objects Returned From ECGridOS API Calls
 *
 * This is starter template to use for your reference.
 * Provided as Example only, is not Production Code.
 * 
 */

#region Object Classes

public class as2CommInfo
{
    public int CommID { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public bool Hosted { get; set; }
    public string Identifier { get; set; }
    public UserIDInfo Owner { get; set; }
    public int NetworkID { get; set; }
    public int MailboxID { get; set; }
    public UseType UseType { get; set; }
    public string URL { get; set; }
    public string MimeTypeOverride { get; set; }
    public bool SignData { get; set; }
    public bool EncryptData { get; set; }
    public bool CompressData { get; set; }
    public DateTime BeginUsage { get; set; }
    public DateTime EndUsage { get; set; }
    public Status Status { get; set; }
    public ReceiptType Receipt { get; set; }
    public bool SSLClientAuthentication { get; set; }
    public HTTPAuthInfo HTTPAuthentication { get; set; }
    public CertificateInfo[] Certificates { get; set; }
}

/// <summary>
/// CallBack Event ID Info Object
/// </summary>
public class CallBackEventIDInfo
{
    public int CallBackEventID { get; set; }
    public int CallBackEventIDField { get; set; }
    public int NetworkID { get; set; }
    public int MailboxID { get; set; }
    public int UserID { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public Objects SystemObject { get; set; }
    public short ObjectStatus { get; set; }
    public string StatusCode { get; set; }
    public Direction Direction { get; set; }
    public short Frequency { get; set; }
    public short MaxCalls { get; set; }
    public Status Status { get; set; }
    public string URL { get; set; }
    public HTTPAuthInfo HTTPAuthentication { get; set; }
    public CallBackQueueIDInfo[] CallBackQueue { get; set; }
}

public class CallBackLogInfo
{
    public int CallBackLogID { get; set; }
    public DateTime Date { get; set; }
    public short CallNumber { get; set; }
    public int ReturnCode { get; set; }
    public string Message { get; set; }
}

public class CallBackQueueIDInfo
{
    public int CallBackQueueID { get; set; }
    public DateTime Date { get; set; }
    public CallBackEventIDInfo CallBackEvent { get; set; }
    public short CallsRemaining { get; set; }
    public DateTime NextCall { get; set; }
    public StatusCallBack Status { get; set; }
    public int ObjectID { get; set; }
    public int UserID { get; set; }
    public bool Test { get; set; }
    public CallBackLogInfo[] CallBackLog { get; set; }
}

/// <summary>
/// Carbon Copy ID Info Object
/// </summary>
public class CarbonCopyIDInfo
{
    public int CarbonCopyID { get; set; }
    public int NetworkID { get; set; }
    public int MailboxID { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public Status Status { get; set; }
    public ECGridIDInfo OriginalFrom { get; set; }
    public ECGridIDInfo OriginalTo { get; set; }
    public ECGridIDInfo CCFrom { get; set; }
    public ECGridIDInfo CCTo { get; set; }
    public string GSFrom { get; set; }
    public string GSTo { get; set; }
    public string TransactionSet { get; set; }
}

public class Certificate
{
    public int CertKeyID { get; set; }
    public string PartnerID { get; set; }
    public string PartnerURL { get; set; }
    public CertificateType Type { get; set; }
    public CertificateUsage Usage { get; set; }
    public string SecureHashAlgorithm { get; set; }
    public string Subject { get; set; }
    public string Issuer { get; set; }
    public bool HasPrivateKey { get; set; }
    public byte[] PublicCertificate { get; set; }
    public DateTime BeginUsage { get; set; }
    public DateTime EndUsage { get; set; }
    public DateTime NotBefore { get; set; }
    public DateTime NotAfter { get; set; }
    public string SerialNumber { get; set; }
    public string Thumbprint { get; set; }
    public Status Status { get; set; }
    public CertificateRoot RootInfo { get; set; }
    public CertStoreTypes CertType { get; set; }
}

public class CertificateInfo
{
    public int CertKeyID { get; set; }
    public string PartnerAS2ID { get; set; }
    public string PartnerURL { get; set; }
    public CertificateType Type { get; set; }
    public CertificateUsage Usage { get; set; }
    public string SecureHashAlgorithm { get; set; }
    public string Subject { get; set; }
    public string Issuer { get; set; }
    public bool HasPrivateKey { get; set; }
    public byte[] PublicCertificate { get; set; }
    public DateTime BeginUsage { get; set; }
    public DateTime EndUsage { get; set; }
    public DateTime NotBefore { get; set; }
    public DateTime NotAfter { get; set; }
    public string SerialNumber { get; set; }
    public string Thumbprint { get; set; }
    public Status Status { get; set; }
    public CertificateRoot RootInfo { get; set; }
}

public class CertificateRoot
{
    public string Password { get; set; }
    public byte[] PrivatePFX { get; set; }
}

public class CertificateRootInfo
{
    public string Password { get; set; }
    public byte[] PrivatePFX { get; set; }
}

public class CommIDInfo
{
    public int CommID { get; set; }
    public NetworkGatewayCommChannel Type { get; set; }
    public string Version { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public bool Hosted { get; set; }
    public string Identifier { get; set; }
    public UserIDInfo Owner { get; set; }
    public int NetworkID { get; set; }
    public int MailboxID { get; set; }
    public UseType UseType { get; set; }
    public string URL { get; set; }
    public string MimeTypeOverride { get; set; }
    public bool SignData { get; set; }
    public bool EncryptData { get; set; }
    public bool CompressData { get; set; }
    public DateTime BeginUsage { get; set; }
    public DateTime EndUsage { get; set; }
    public Status Status { get; set; }
    public ReceiptType Receipt { get; set; }
    public bool SSLClientAuthentication { get; set; }
    public HTTPAuthInfo HTTPAuthentication { get; set; }
    public Certificate[] Certificates { get; set; }
}

public class cxmlStatus
{
    public bool sent { get; set; }
    public int parcelStatus { get; set; }
    public HttpStatusCode retCode { get; set; }
    public string retMessage { get; set; }
    public string retText { get; set; }
}

/// <summary>
/// ECGrid ID Info Object
/// </summary>
public class ECGridIDInfo
{
    public int ECGridID { get; set; }
    public int NetworkID { get; set; }
    public string NetworkName { get; set; }
    public int MailboxID { get; set; }
    public string MailboxName { get; set; }
    public string Qualifier { get; set; }
    public string ID { get; set; }
    public string Description { get; set; }
    public string DataEMail { get; set; }
    public bool MailboxDefault { get; set; }
    public StatusECGridID Status { get; set; }
    public UseType UseType { get; set; }
    public UserIDInfo Owner { get; set; }
    public ECGridOwnerInfo OwnerInfo { get; set; }
    public MailboxConfig Config { get; set; }
}

/// <summary>
/// ECGrid ID Info Collection Object
/// </summary>
public class ECGridIDInfoCollection
{
    public short PageSize { get; set; }
    public short PageNumber { get; set; }
    public short Count { get; set; }
    public int TotalRecords { get; set; }
    public short TotalPages { get; set; }
    public ECGridIDInfo[] ECGridIDInfoList { get; set; }
}

/// <summary>
/// ECGrid Owner Info Object
/// </summary>
public class ECGridOwnerInfo
{
    public int NetworkID { get; set; }
    public string NetworkName { get; set; }
    public int MailboxID { get; set; }
    public string MailboxName { get; set; }
    public System.DateTime Created { get; set; }
    public System.DateTime Modified { get; set; }
    public System.DateTime Effective { get; set; }
    public System.DateTime Expires { get; set; }
    public System.DateTime LastTraffic { get; set; }
    public RoutingGroup RoutingGroup { get; set; }
}

/// <summary>
/// File Info Object
/// </summary>
public class FileInfo
{
    public long ParcelID { get; set; }
    public string FileName { get; set; }
    public DateTime FileDate { get; set; }
    public int Bytes { get; set; }
    public EDIStandard Standard { get; set; }
    public byte[] Content { get; set; }
    public string ContentBase64String { get; set; }
    public bool routerArchive { get; set; }
}

public class GISBCommInfo
{
    public int CommID { get; set; }
    public string Identifier { get; set; }
    public int UserID { get; set; }
    public int NetworkID { get; set; }
    public int MailboxID { get; set; }
    public UseType UseType { get; set; }
    public string URL { get; set; }
    public bool SignData { get; set; }
    public bool EncryptData { get; set; }
    public string Version { get; set; }
    public Status Status { get; set; }
    public ReceiptType Receipt { get; set; }
    public HTTPAuthInfo HTTPAuthentication { get; set; }
    public PGPKeyInfo[] PGPKeys { get; set; }

}

public class HTTPAuthInfo
{
    public HTTPAuthType Type { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
}

/// <summary>
/// Interchange ID Info Object
/// </summary>
public class InterchangeIDInfo
{
    public long InterchangeID { get; set; }
    public DateTime InterchangeProcessDate { get; set; }
    public int NetworkIDFrom { get; set; }
    public string NetworkNameFrom { get; set; }
    public int MailboxIDFrom { get; set; }
    public int NetworkIDTo { get; set; }
    public string NetworkNameTo { get; set; }
    public int MailboxIDTo { get; set; }
    public EDIStandard Standard { get; set; }
    public int Bytes { get; set; }
    public string InterchangeControlID { get; set; }
    public DateTime InterchangeDateTime { get; set; }
    public DateTime StatusDate { get; set; }
    public string StatusCode { get; set; }
    public string StatusMessage { get; set; }
    public string DocumentType { get; set; }
    public DateTime ArchiveDate { get; set; }
    public string Header { get; set; }
    public ECGridIDInfo TPFrom { get; set; }
    public ECGridIDInfo TPTo { get; set; }
    public ParcelIDInfo[] Parcels { get; set; }
}

/// <summary>
/// Interchange ID Info Collection Object
/// </summary>
public class InterchangeIDInfoCollection
{
    public short PageSize { get; set; }
    public short PageNumber { get; set; }
    public short Count { get; set; }
    public int TotalRecords { get; set; }
    public short TotalPages { get; set; }
    public InterchangeIDInfo[] InterchangeIDInfoList { get; set; }
}

/// <summary>
/// Interchange ID Status Object
/// </summary>
public class InterchangeIDStatus
{
    public long Id { get; set; }
    public DateTime InterchangeProcessDate { get; set; }
    public int NetworkIDFrom { get; set; }
    public int MailboxIDFrom { get; set; }
    public int ECGridIDFrom { get; set; }
    public int NetworkIDTo { get; set; }
    public int MailboxIDTo { get; set; }
    public int ECGridIDTo { get; set; }
    public int RouterID { get; set; }
    public int Bytes { get; set; }
    public string StatusCode { get; set; }
    public DateTime StatusDate { get; set; }
    public string InterchangeHeader { get; set; }
    public EDIStandard standard { get; set; }
    public int ParcelIDInbox { get; set; }
}

/// <summary>
/// Interconnect ID Info Object
/// </summary>
public class InterconnectIDInfo
{
    public int InterconnectID { get; set; }
    public string UniqueID { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public DateTime Completed { get; set; }
    public DateTime LastTraffic { get; set; }
    public DateTime LastTrafficInbound { get; set; }
    public DateTime LastTrafficOutbound { get; set; }
    public UserIDInfo RequestorUser { get; set; }
    public UserIDInfo ContactUser { get; set; }
    public string ContactName { get; set; }
    public string ContactEMail { get; set; }
    public StatusInterconnect Status { get; set; }
    public bool SuspendPendingInterchanges { get; set; }
    public ECGridIDInfo TP1 { get; set; }
    public string AS2ID1 { get; set; }
    public string Reference1 { get; set; }
    public ECGridIDInfo TP2 { get; set; }
    public string AS2ID2 { get; set; }
    public string Reference2 { get; set; }
    public UserIDInfo NetOps { get; set; }
}

/// <summary>
/// Interconnect Note Object
/// </summary>
public class InterconnectNote
{
    public int InterconnectID { get; set; }
    public int InterconnectNoteID { get; set; }
    public DateTime NoteDate { get; set; }
    public StatusInterconnect Status { get; set; }
    public string PostedBy { get; set; }
    public int UserID { get; set; }
    public string MailTo { get; set; }
    public string Note { get; set; }
    public NoteAttachment Attachment { get; set; }
}

/// <summary>
/// Key Value Object
/// </summary>
public class KeyValue
{
    public string Key { get; set; }
    public string Value { get; set; }
    public string Meta { get; set; }
    public DateTime Created { get; set; }
    public DateTime Expires { get; set; }
    public KeyVisibility Visibility { get; set; }
    public int NetworkID { get; set; }
    public int MailboxID { get; set; }
    public int UserID { get; set; }
    public string SessionID { get; set; }
}

public class Level
{
    public PricelistItemLevel Level1 { get; set; }
    public string Name { get; set; }
    public short LimitedMonths { get; set; }
    public Schedule[] Schedules { get; set; }
}

/// <summary>
/// Mailbox Config Object
/// </summary>
public class MailboxConfig
{
    public short InBoxTimeout { get; set; }
    public byte SegTerm { get; set; }
    public byte ElmSep { get; set; }
    public byte SubElmSep { get; set; }
    public string EBCDICFilter { get; set; }
    public bool FTPasciiFilter { get; set; }
    public bool LowPassFilter { get; set; }
    public bool MailbagPassThrough { get; set; }
    public bool DeleteOnDownload { get; set; }
    public bool StripDirectedEnvelope { get; set; }
}

/// <summary>
/// Mailbox ID Info Object
/// </summary>
public class MailboxIDInfo
{
    public int MailboxID { get; set; }
    public int NetworkID { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public Status Status { get; set; }
    public string Description { get; set; }
    public UserIDInfo OwnerUserID { get; set; }
    public UserIDInfo ErrorsUserID { get; set; }
    public UserIDInfo InterconnectsUserID { get; set; }
    public UserIDInfo NoticesUserID { get; set; }
    public UserIDInfo ReportsUserID { get; set; }
    public UserIDInfo CustomerServiceUserID { get; set; }
    public UserIDInfo AccountingUserID { get; set; }
    public bool Managed { get; set; }
    public UseType UseType { get; set; }
    public MailboxConfig Config { get; set; }
    public bool ECGridAccount { get; set; }
    public string DefaultAS2ID { get; set; }
    public MailboxOwnerInfo OwnerInfo { get; set; }
    public MailboxNetOpsInfo NetOpsInfo { get; set; }
}

/// <summary>
/// Mailbox NetOps Info Object
/// </summary>
public class MailboxNetOpsInfo
{
    public int AliasNetworkID { get; set; }
    public int AliasMailboxID { get; set; }
}

/// <summary>
/// Mailbox Owner Info Object
/// </summary>
public class MailboxOwnerInfo
{
    public int PricelistID { get; set; }
    public int ContractID { get; set; }
}

/// <summary>
/// Manifest Info Object
/// </summary>
public class ManifestInfo
{
    public DateTime ManifestDate { get; set; }
    public int NetworkID { get; set; }
    public string NetworkName { get; set; }
    public ManifestType Type { get; set; }
    public long ParcelID { get; set; }
    public long InterchangeID { get; set; }
    public string StatusCode { get; set; }
    public string StatusMessage { get; set; }
    public string StatusColor { get; set; }
}

public class MigrationBatch
{
    public int MigrationBatchId { get; set; }
    public string Name { get; set; }
    public DateTime Scheduled { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public DateTime Contacted { get; set; }
    public DateTime Responded { get; set; }
    public DateTime Confirmed { get; set; }
    public int Total { get; set; }
    public int Complete { get; set; }
    public int Inbound { get; set; }
    public int Outbound { get; set; }
    public MigrationStatus Status { get; set; }
    public MigrationTP[] TPs { get; set; }
    public MigrationNote[] Notes { get; set; }
}

public class MigrationIDInfo
{
    public int MigrationID { get; set; }
    public string Name { get; set; }
    public NetworkIDInfo Network { get; set; }
    public MailboxIDInfo Mailbox { get; set; }
    public NetworkIDInfo ECSPNetwork { get; set; }
    public MailboxIDInfo ECSPMailbox { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public MigrationStatus Status { get; set; }
    public UserIDInfo Owner { get; set; }
    public string HelpTicket { get; set; }
    public MigrationBatch[] Batches { get; set; }
    public MigrationNote[] Notes { get; set; }
}

public class MigrationNote
{
    public int MigrationNoteID { get; set; }
    public DateTime NoteDate { get; set; }
    public StatusInterconnect Status { get; set; }
    public int UserID { get; set; }
    public string MailTo { get; set; }
    public string Note { get; set; }
    public NoteAttachment Attachment { get; set; }
}

public class MigrationTP
{
    public ECGridIDInfo ECGridID { get; set; }
    public MigrationType Type { get; set; }
    public MigrationTPStatus Status { get; set; }
    public ECGridIDInfo[] TPs { get; set; }
}

/// <summary>
/// Network FTP Info Object
/// </summary>
public class NetworkFTPInfo
{
    public string[] IP { get; set; }
    public string UserID { get; set; }
    public string Password { get; set; }
    public string Account { get; set; }
    public string VirtualDirectoryIn { get; set; }
    public string VirtualDirectoryOut { get; set; }
    public string LogicalDirectory { get; set; }
    public short MaxThreads { get; set; }
}

/// <summary>
/// Network Gateway Object
/// </summary>
public class NetworkGateway
{
    public string Application { get; set; }
    public short ApplicationTimeOut { get; set; }
    public string ApplicationLogFile { get; set; }
    public short Frequency { get; set; }
    public short MinimumPolling { get; set; }
    public NetworkGatewayHandshake Handshake { get; set; }
    public NetworkGatewayCommChannel CommChannel { get; set; }
    public NetworkGatewayConnection Connection { get; set; }
}

/// <summary>
/// Network ID Info Object
/// </summary>
public class NetworkIDInfo
{
    public int NetworkID { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string AdminContact { get; set; }
    public string AdminPhone { get; set; }
    public string AdminEMail { get; set; }
    public DateTime LastContact { get; set; }
    public NetworkType Type { get; set; }
    public Status Status { get; set; }
    public NetworkRunStatus RunStatus { get; set; }
    public NetworkStatus NetworkStatus { get; set; }
    public bool ECGridAccount { get; set; }
    public int OwnerUserID { get; set; }
    public int RoutingUserID { get; set; }
    public int ErrorsUserID { get; set; }
    public int InterconnectsUserID { get; set; }
    public int NoticesUserID { get; set; }
    public int ReportsUserID { get; set; }
    public int AccountingUserID { get; set; }
    public int CustomerServiceUserID { get; set; }
    public string HomeWebsite { get; set; }
    public string SupportWebsite { get; set; }
    public string LoginWebsite { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public NetworkLog LastLog { get; set; }
    public NetworkOwnerInfo OwnerInfo { get; set; }
    public NetworkNetOpsInfo NetOpsInfo { get; set; }
}

/// <summary>
/// Network Log Object
/// </summary>
public class NetworkLog
{
    public int LogID { get; set; }
    public DateTime LogDate { get; set; }
    public int UserID { get; set; }
    public NetworkLogType Type { get; set; }
    public NetworkLogStatus Status { get; set; }
    public AuthLevel AuthLevel { get; set; }
    public string Description { get; set; }
}

/// <summary>
/// Network NetOps Info Object
/// </summary>
public class NetworkNetOpsInfo
{
    public int BillingUserID { get; set; }
    public string BillingContact { get; set; }
    public string BillingEMail { get; set; }
    public short BillingType { get; set; }
    public string InvoiceContact { get; set; }
    public string InvoiceEMail { get; set; }
    public string SoftwareVersion { get; set; }
    public DateTime Created { get; set; }
    public DateTime Commissioned { get; set; }
    public DateTime Decommissioned { get; set; }
    public DateTime Modified { get; set; }
    public string RunDir { get; set; }
    public string InternalDirectory { get; set; }
    public string ExternalDirectoryRoot { get; set; }
    public string ExternalDirectoryIn { get; set; }
    public string ExternalDirectoryOut { get; set; }
    public short ArchiveDays { get; set; }
    public string SupportURL { get; set; }
    public short BlockSize { get; set; }
    public short EnvPerMB { get; set; }
    public short OutBoxTimeOut { get; set; }
    public string MasterAccount { get; set; }
    public int ProcessID { get; set; }
    public string UserName { get; set; }
    public string UserDomain { get; set; }
    public string Server { get; set; }
    public int AliasNetworkID { get; set; }
    public int AliasMailboxID { get; set; }
    public string InBoxPattern { get; set; }
    public string OutBoxPattern { get; set; }
    public X1256 X1256 { get; set; }
    public short ArchiveDaysInternal { get; set; }
    public short ArchiveDaysExternal { get; set; }
    public short MaxBatch { get; set; }
    public short dbOpenMaxCycles { get; set; }
    public short dbOpenMaxSeconds { get; set; }
    public NetworkGateway Gateway { get; set; }
    public NetworkVPN VPN { get; set; }
    public NetworkFTPInfo FTPServer { get; set; }
    public NetworkFTPInfo FTPClient { get; set; }
}

/// <summary>
/// Network Owner Info Object
/// </summary>
public class NetworkOwnerInfo
{
    public string Type { get; set; }
    public string RoutingType { get; set; }
    public NetworkRoutingType Routing { get; set; }
    public string LegacyPassword { get; set; }
    public string InterconnectContact { get; set; }
    public string InterconnectEMail { get; set; }
    public string ErrorContact { get; set; }
    public string ErrorEMail { get; set; }
    public MailboxConfig Config { get; set; }
    public int PricelistID { get; set; }
    public int ContractID { get; set; }
}

/// <summary>
/// Network VPN Object
/// </summary>
public class NetworkVPN
{
    public string LocalTunnel { get; set; }
    public string RemoteTunnel { get; set; }
    public string[] EncryptionDomain { get; set; }
    public string SharedSecret { get; set; }
    public NetworkVPNEncryptionMethod EncryptionMethod { get; set; }
}

/// <summary>
/// Note Attachment Object
/// </summary>
public class NoteAttachment
{
    public string FileName { get; set; }
    public byte[] Content { get; set; }
}

/// <summary>
/// Parcel ID Info Object
/// </summary>
public class ParcelIDInfo
{
    public long ParcelID { get; set; }
    public int ParcelBytes { get; set; }
    public DateTime ParcelDate { get; set; }
    public int ActualBytes { get; set; }
    public int NetworkIDFrom { get; set; }
    public string NetworkNameFrom { get; set; }
    public int MailboxIDFrom { get; set; }
    public string MailboxNameFrom { get; set; }
    public int NetworkIDTo { get; set; }
    public string NetworkNameTo { get; set; }
    public int MailboxIDTo { get; set; }
    public string MailboxNameTo { get; set; }
    public string FileName { get; set; }
    public string MailbagControlID { get; set; }
    public DateTime ArchiveDate { get; set; }
    public DateTime StatusDate { get; set; }
    public string StatusCode { get; set; }
    public string StatusMessage { get; set; }
    public short LocalStatus { get; set; }
    public DateTime LocalStatusDate { get; set; }
    public ParcelValid Valid { get; set; }
    public string Acknowledgment { get; set; }
    public Direction Direction { get; set; }
    public InterchangeIDInfo[] Interchanges { get; set; }
    public ManifestInfo[] Log { get; set; }
}

/// <summary>
/// Parcel ID Info Collection Object
/// </summary>
public class ParcelIDInfoCollection
{
    public short PageSize { get; set; }
    public short PageNumber { get; set; }
    public short Count { get; set; }
    public int TotalRecords { get; set; }
    public short TotalPages { get; set; }
    public ParcelIDInfo[] ParcelIDInfoList { get; set; }
}

public class ParcelIDStatus
{
    public long Id { get; set; }
    public int NetworkIDFrom { get; set; }
    public int NetworkIDTo { get; set; }
    public long Bytes { get; set; }
    public short Status { get; set; }
}

/// <summary>
/// Parcel Note Object
/// </summary>
public class ParcelNote
{
    public long ParcelID { get; set; }
    public int ParcelNoteID { get; set; }
    public long InterchangeID { get; set; }
    public DateTime NoteDate { get; set; }
    public string StatusCode { get; set; }
    public string PostedBy { get; set; }
    public int UserID { get; set; }
    public string Note { get; set; }
}

public class PGPKeyInfo
{
    public int CertKeyID { get; set; }
    public string KeyID { get; set; }
    public string UserID { get; set; }
    public CertificateType Type { get; set; }
    public DateTime BeginUsage { get; set; }
    public DateTime EndUsage { get; set; }
    public DateTime Expires { get; set; }
    public Status Status { get; set; }
    public bool Private { get; set; }
    public string Password { get; set; }
}

public class Pricelist
{
    public int PricelistID { get; set; }
    public UserIDInfo Owner { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public PricelistModel Model { get; set; }
    public Status Status { get; set; }
    public Level[] Levels { get; set; }
}

public class Schedule
{
    public int ScheduleID { get; set; }
    public decimal Allowance { get; set; }
    public int Minimum { get; set; }
    public int Maximum { get; set; }
    public decimal Block { get; set; }
    public decimal Rate { get; set; }
    public int CatalogID { get; set; }
    public string Description { get; set; }
    public PricelistAccountReports AccountReport { get; set; }
    public PricelistMeasureField Measure { get; set; }
    public int SpecifiedNetworkID { get; set; }
    public bool IncludeRootMailbox { get; set; }
}

/// <summary>
/// Session Events Object
/// </summary>
public class SessionEvents
{
    public APICall APICall { get; set; }
    public DateTime Date { get; set; }
    public int Milliseconds { get; set; }
    public string ip { get; set; }
    public RetCode ReturnCode { get; set; }
    public string Comment { get; set; }
}

/// <summary>
/// Session Info Object
/// </summary>
public class SessionInfo
{
    public string ECGridOSVersion { get; set; }
    public string SessionID { get; set; }
    public int SessionEventID { get; set; }
    public int UserID { get; set; }
    public string LoginName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
    public string EMail { get; set; }
    public string Phone { get; set; }
    public float TimeZoneOffset { get; set; }
    public AuthLevel AuthLevel { get; set; }
    public DateTime LastLogin { get; set; }
    public short OpenSessions { get; set; }
    public short TimeOut { get; set; }
    public int NetworkID { get; set; }
    public int MailboxID { get; set; }
    public string ip { get; set; }
}

/// <summary>
/// Session Log Info Object
/// </summary>
public class SessionLogInfo
{
    public string SessionID { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public DateTime Expires { get; set; }
    public int NetworkID { get; set; }
    public int MailboxID { get; set; }
    public int UserID { get; set; }
    public SessionStatus Status { get; set; }
    public string Version { get; set; }
    public SessionEvents[] Events { get; set; }
}

public class StatusInfo
{
    public short Code { get; set; }
    public string Qqualifier { get; set; }
    public string Message { get; set; }
    public string Level { get; set; }
}

/// <summary>
/// User ID Info Object
/// </summary>
public class UserIDInfo
{
    public int UserID { get; set; }
    public string LoginName { get; set; }
    public string RecoveryQuestion { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Company { get; set; }
    public string EMail { get; set; }
    public string Phone { get; set; }
    public string CellPhone { get; set; }
    public CellCarrier CellCarrier { get; set; }
    public short TimeZoneOffset { get; set; }
    public int NetworkID { get; set; }
    public int MailboxID { get; set; }
    public AuthLevel AuthLevel { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public DateTime LastLogin { get; set; }
    public Status Status { get; set; }
    public bool LockedOut { get; set; }
    public short OpenSessions { get; set; }
}

/// <summary>
/// X1256 Object
/// </summary>
public class X1256
{
    public string passwordFrom { get; set; }
    public string passwordTo { get; set; }
    public string qualifierFrom { get; set; }
    public string idFrom { get; set; }
    public string qualifierTo { get; set; }
    public string idTo { get; set; }
    public string version { get; set; }
    public bool production { get; set; }
}

#endregion

#region Enums

/// <summary>
/// API Call ENUM
/// </summary>
public enum APICall
{
    GenerateAPIKey,
    Login,
    Logout,
    ChangePassword,
    WhoAmI,
    UserAdd,
    UserAddEx,
    UserInfo,
    UserUpdate,
    UserActivate,
    UserSuspend,
    UserTerminate,
    UserReset,
    UserList,
    UserListEx,
    UserPassword,
    SessionLog,
    SessionLogEx,
    SessionLogCurrent,
    KeySave,
    KeyGet,
    KeyList,
    KeyRemove,
    UserSetNetworkMailbox,
    UserSetAuthLevel,
    UserListLockedOut,
    UserListLockedOutEx,
    UserResetAll,
    SetLocalTime,
    TerminateAPIKey,
    GeneratePassword,
    UserSendSMS,
    UserGetAPIKey,
    NetworkInfo,
    NetworkList,
    NetworkStatusSummary,
    NetworkOutageList,
    NetworkStart,
    NetworkStop,
    NetworkRestart,
    NetworkAdd,
    NetworkOwnerContact,
    NetworkErrorsContact,
    NetworkInterconnectsContact,
    NetworkNoticesContact,
    NetworkBillingContact,
    NetworkReportsContact,
    NetworkSetContact,
    NetworkGetContact,
    NetworkSetWebsite,
    NetworkSetStatus,
    NetworkInfoWithLog,
    NetworkBackupAllConfigs,
    NetworkX12Delimiters,
    MailboxAdd,
    MailboxAddEx,
    MailboxActivate,
    MailboxSuspend,
    MailboxTerminate,
    MailboxInfo,
    MailboxName,
    MailboxErrorsContact,
    MailboxInterconnectsContact,
    MailboxNoticesContact,
    MailboxX12Delimiters,
    MailboxInBoxTimeout,
    MailboxList,
    MailboxListEx,
    MailboxOwnerContact,
    MailboxManaged,
    MailboxDescription,
    MailboxUse,
    MailboxSetContact,
    TPAdd,
    TPAddVAN,
    TPAddEx,
    TPMove,
    TPMoveEx,
    TPUpdateDescription,
    TPActivate,
    TPSuspend,
    TPTerminate,
    TPInfo,
    TPSearch,
    TPSearchEx,
    TPList,
    TPListEx,
    TPFind,
    TPFindEx,
    TPDataEMail,
    TPSetMailboxDefault,
    TPGetMailboxDefault,
    TPEMailX400Format,
    TPMoveMailbox,
    TPSetRoutingGroup,
    TPListExPaged,
    TPListByOwner,
    TPSetOwner,
    InterconnectAdd,
    InterconnectUpdate,
    InterconnectNote,
    InterconnectCancel,
    InterconnectInfo,
    InterconnectNoteList,
    InterconnectListByECGridID,
    InterconnectListByStatus,
    InterconnectListByStatusEx,
    InterconnectAssignNetOps,
    InterconnectCount,
    InterconnectCountEx,
    InterconnectInfoGUID,
    MigrationAdd,
    MigrationAddAuthorization,
    MigrationSendRequest,
    MigrationUpdate,
    MigrationStatus,
    MigrationInfo,
    MigrationList,
    MigrationListEx,
    MigrationECGridIDAdd,
    MigrationECGridIDRemove,
    MigrationECGridIDStatus,
    MigrationECGridIDNote,
    CarbonCopyAdd,
    CarbonCopyAddEx,
    CarbonCopyActivate,
    CarbonCopySuspend,
    CarbonCopyTerminate,
    CarbonCopyInfo,
    CarbonCopyList,
    CarbonCopyListEx,
    ParcelInBox,
    ParcelInBoxEx,
    ParcelDownload,
    ParcelDownloadInner,
    ParcelDownloadConfirm,
    ParcelUpload,
    ParcelUploadEx,
    ParcelInfo,
    ParcelMainfest,
    ParcelInterchangeManifest,
    ParcelNoteList,
    ParcelInBoxArchive,
    ParcelInBoxArchiveEx,
    ParcelOutBoxArchive,
    ParcelOutBoxArchiveEx,
    ParcelOutBoxError,
    ParcelOutBoxErrorEx,
    InterchangeInBox,
    InterchangeInBoxEx,
    InterchangeOutBox,
    InterchangeOutBoxEx,
    InterchangeHeaderInfo,
    ParcelDownloadReset,
    InterchangeOutBoxNoRoute,
    InterchangeOutBoxNoRouteEx,
    ParcelUploadGZip,
    InterchangeInfo,
    InterchangeResend,
    ParcelUploadGZipEx,
    ParcelUploadExA,
    ParcelSetMailbagControlID,
    ParcelUpdateStatus,
    ParcelUpdateLocalStatus,
    ParcelUploadDirected,
    ParcelUploadDirectedGZip,
    ParcelDownloadConfirmPendingAck,
    InterchangeHeaderInfoB,
    ParcelDownloadGZip,
    ParcelDownloadCancel,
    ParcelTest,
    InterchangeManifest,
    ParcelOutBoxInProcess,
    ParcelOutBoxInProcessEx,
    ParcelResend,
    InterchangeCancel,
    ParcelAcknowledgmentNote,
    InterchangeOutBoxPending,
    InterchangeOutBoxPendingEx,
    InterchangeInBoxPending,
    InterchangeInBoxPendingEx,
    InterchangeInBoxArchive,
    InterchangeInBoxArchiveEx,
    InterchangeOutBoxArchive,
    InterchangeOutBoxArchiveEx,
    ParcelInBoxArchiveDescEx,
    ParcelOutBoxArchiveDescEx,
    CallBackAdd,
    CallBackActivate,
    CallBackSuspend,
    CallBackTerminate,
    CallBackList,
    CallBackListEx,
    CallBackEventList,
    CallBackEventListEx,
    CallBackInvoke,
    CallBackTest,
    CallBackPendingList,
    CallBackPendingListEx,
    CallBackQueueInfo,
    CallBackEventInfo,
    CallBackAddEx,
    CallBackFailedList,
    CallBackFailedListEx,
    CallBackEventSetStatus,
    ReportMonthly,
    ReportMonthlyEx,
    ReportTrafficStats,
    ReportTrafficStatsEx,
    ReportInstantStats,
    ReportInstantStatsEx,
    AS2Add,
    AS2Update,
    AS2Activate,
    AS2Suspend,
    AS2Terminate,
    AS2CertAddPublic,
    AS2CertAddPrivate,
    AS2CertTerminate,
    AS2Find,
    AS2List,
    AS2ListEx,
    AS2Info,
    AS2CertCreatePrivate,
    AS2Pair,
    AS2DefaultMailbox,
    AS2SetPair,
    AS2SetStatus,
    AS2CertRenewPrivate,
    GISBAdd,
    GISBUpdate,
    GISBActivate,
    GISBSuspend,
    GISBTerminate,
    GISBKeyAdd,
    GISBKeyTerminate,
    GISBFind,
    GISBList,
    GISBListEx,
    GISBInfo,
    CertificateAddPublic,
    CertificateAddPrivate,
    CertificateCreatePrivate,
    CertificateSetUsageDates,
    CertificateTerminate,
    CommAdd,
    CommUpdate,
    CommSetStatus,
    CommFind,
    CommList,
    CommListEx,
    CommInfo,
    CommPair,
    CommSetPair,
    ContractInfo,
    ContractList,
    ContractListEx,
    ContractAdd,
    ContractActivate,
    ContractSuspend,
    ContractTerminate,
    ContractExpiring,
    ContractSet,
    ContractSetEx,
    PricelistInfo,
    PricelistAdd,
    PricelistLineAdd,
    PricelistLineDelete,
    InvoiceCreate,
    InvoiceInfo,
    InvoiceList,
    InvoiceSetStatus,
    InvoiceCalculateLineItem,
}

/// <summary>
/// Auth Level ENUM
/// </summary>
public enum AuthLevel
{
    NoChange,
    Root,
    TechOps,
    NetOps,
    NetworkAdmin,
    NetworkUser,
    MailboxAdmin,
    MailboxUser,
    TPUser,
    General,
}

/// <summary>
/// Cell Carrier ENUM
/// </summary>
public enum CellCarrier
{
    NoChange,
    Undefined,
    ATTCingular,
    Verizon,
    TMobile,
    SprintPCS,
    Nextel,
    Alltel,
    VirginMobile,
    ATTPreCingular,
    ATT,
    BoostMobile,
    USCellular,
    MetroPCS,
    Powertel,
}

/// <summary>
/// Certificate Secure Hash Algorithm ENUM
/// </summary>
public enum CertificateSecureHashAlgorithm
{
    sha1,
    sha2,
}

/// <summary>
/// Certificate Type ENUM
/// </summary>
public enum CertificateType
{
    X509,
    PGP,
    SSH,
}

/// <summary>
/// Certificate Usage ENUM
/// </summary>
public enum CertificateUsage
{
    SSL,
    Encryption,
    Signature,
    EncryptionAndSignature,
}

/// <summary>
/// Cert Store Types ENUM
/// </summary>
public enum CertStoreTypes
{
    cstUser,
    cstMachine,
    cstPFXFile,
    cstPFXBlob,
    cstJKSFile,
    cstJKSBlob,
    cstPEMKeyFile,
    cstPEMKeyBlob,
    cstPublicKeyFile,
    cstPublicKeyBlob,
    cstSSHPublicKeyBlob,
    cstP7BFile,
    cstP7BBlob,
    cstSSHPublicKeyFile,
    cstPPKFile,
    cstPPKBlob,
    cstXMLFile,
    cstXMLBlob,
}

/// <summary>
/// Direction ENUM
/// </summary>
public enum Direction
{
    NoDir,
    OutBox,
    InBox,
}

/// <summary>
/// EDI Standard ENUM
/// </summary>
public enum EDIStandard
{
    X12,
    EDIFACT,
    TRADACOMS,
    VDA,
    XML,
    TXT,
    PDF,
    Binary,
}

/// <summary>
/// EMail Payload ENUM
/// </summary>
public enum EMailPayload
{
    Body,
    Attachment,
}

/// <summary>
/// EMail System ENUM
/// </summary>
public enum EMailSystem
{
    smtp,
    x400,
}

/// <summary>
/// eMail To ENUM
/// </summary>
public enum eMailTo
{
    NoEMail,
    Requestor,
    Network,
    RequestorAndNetwork,
    Other,
    RequestorAndOther,
    NetworkAndOther,
    EMailAll,
}

/// <summary>
/// HTTP Auth Type ENUM
/// </summary>
public enum HTTPAuthType
{
    None,
    Basic,
    Digest,
}

/// <summary>
/// HTTP Status Code ENUM
/// </summary>
public enum HttpStatusCode
{
    Continue,
    SwitchingProtocols,
    OK,
    Created,
    Accepted,
    NonAuthoritativeInformation,
    NoContent,
    ResetContent,
    PartialContent,
    MultipleChoices,
    Ambiguous,
    MovedPermanently,
    Moved,
    Found,
    Redirect,
    SeeOther,
    RedirectMethod,
    NotModified,
    UseProxy,
    Unused,
    TemporaryRedirect,
    RedirectKeepVerb,
    BadRequest,
    Unauthorized,
    PaymentRequired,
    Forbidden,
    NotFound,
    MethodNotAllowed,
    NotAcceptable,
    ProxyAuthenticationRequired,
    RequestTimeout,
    Conflict,
    Gone,
    LengthRequired,
    PreconditionFailed,
    RequestEntityTooLarge,
    RequestUriTooLong,
    UnsupportedMediaType,
    RequestedRangeNotSatisfiable,
    ExpectationFailed,
    UpgradeRequired,
    InternalServerError,
    NotImplemented,
    BadGateway,
    ServiceUnavailable,
    GatewayTimeout,
    HttpVersionNotSupported
}

/// <summary>
/// Invoice Include ENUM
/// </summary>
public enum InvoiceInclude
{
    AllCurrentCharges,
    MonthlyItemsOnly,
    SpecialChargesOnly,
}

/// <summary>
/// Invoice Status ENUM
/// </summary>
public enum InvoiceStatus
{
    Pending,
    Sent,
    Paid,
    Canceled,
    AllUnpaid,
    All,
}

/// <summary>
/// Key Visibility ENUM
/// </summary>
public enum KeyVisibility
{
    Private,
    Shared,
    Public,
    Session,
}

/// <summary>
/// Manifest Type ENUM
/// </summary>
public enum ManifestType
{
    System,
    Error,
    Manual,
    ECGridOS,
}

/// <summary>
/// Migration Status ENUM
/// </summary>
public enum MigrationStatus
{
    All,
    Canceled,
    Planned,
    Requested,
    Confirmed,
    Active,
    Completed,
}

/// <summary>
/// Migration Type ENUM
/// </summary>
public enum MigrationType
{
    Expected,
    Unexpected,
}

/// <summary>
/// Migration TP Status ENUM
/// </summary>
public enum MigrationTPStatus
{
    Pending,
    Inbound,
    Outbound,
    Complete,
}

/// <summary>
/// Network Contact Type ENUM
/// </summary>
public enum NetworkContactType
{
    Owner,
    Errors,
    Interconnects,
    Notices,
    Reports,
    Accounting,
    CustomerService,
}

/// <summary>
/// Network Gateway Comm Channel ENUM
/// </summary>
public enum NetworkGatewayCommChannel
{
    none,
    ftp,
    sftp,
    as2,
    http,
    oftp,
    x400,
    gisb,
    rnif,
    undefined,
}

/// <summary>
/// Network Gateway Connection ENUM
/// </summary>
public enum NetworkGatewayConnection
{
    Internet,
    VPN,
    Dial,
    Other,
}

/// <summary>
/// Network Gateway Handshake ENUM
/// </summary>
public enum NetworkGatewayHandshake
{
    Push,
    Pull,
    PushPull,
}

/// <summary>
/// Network Log Status ENUM
/// </summary>
public enum NetworkLogStatus
{
    Start,
    CheckIn,
    Access,
    Pause,
    Restart,
    Shutdown,
    StatusChange,
}

/// <summary>
/// Network Log Type ENUM
/// </summary>
public enum NetworkLogType
{
    SystemResponse,
    SystemAutomated,
    User,
}

/// <summary>
/// Network Routing Type ENUM
/// </summary>
public enum NetworkRoutingType
{
    Open,
    OpenWithSenderValidation,
    TradingPartnerPairs,
    MultiNetwork,
    ECGridOpen,
    ECGridTradingPartnerPairs,
}

public enum NetworkRunStatus
{
    Restart,
    OffLine,
    Active,
    Sleeping,
    Alert,
}

public enum NetworkServiceType
{
    SVC,
    VAN,
    MBX,
    NET,
    APP,
    HUB,
}

public enum NetworkStatus
{
    Redirected,
    NormalOperation,
    ECGridScheduledOutage,
    ECGridUnscheduledOutage,
    NetworkScheduledOutage,
    NetworkUnscheduledOutage,
}

public enum NetworkType
{
    Network,
    Router,
}

public enum NetworkWebsiteType
{
    Home,
    Support,
    Login,
}

public enum NetworkVPNEncryptionMethod
{
    _3DES_SHA1,
    _DES_SHA1,
    _3DES_MD5,
    _DES_MD5,
}

public enum Objects
{
    System,
    User,
    Network,
    Mailbox,
    ECGridID,
    Interconnect,
    Migration,
    Parcel,
    Interchange,
    CarbonCopy,
    CallBackEvent,
    AS2,
    Comm,
    GISB,
    ParcelNotes,
    InterconnectNote,
    PriceList,
    Contract,
    Invoice,
}

public enum OrderBy
{
    Description,
    QID,
}

public enum ParcelStatus
{
    InBoxReady,
    InBoxTransferred,
    x1256Pending,
    as2Receive,
    as2MDNSent,
    as2MDNPending,
    as2MDNRejected,
    as2MDNConfirmed,
    as2Sent,
    as2SendFailed,
    gisbReceived,
    gisbSent,
    gisbSendFailed,
}

public enum ParcelValid
{
    Pending,
    Invalid,
    Valid,
    PartialValid,
    ValidNoneRouted,
    Duplicate,
    ZeroByte,
    VallidRouted,
    ValidPartialRouted,
    ValidNoneRoutedx,
}

public enum PricelistAccountReports
{
    FixedRate,
    Statistics,
    TrafficAll,
    TrafficIntraNetwork,
    TrafficInterECGrid,
    TrafficOffNetwork,
    TrafficSpecial,
    TrafficKCInterchangeTiered
}

public enum PricelistItemLevel
{
    Additional,
    OneTime,
    General,
    Developement,
    Level1,
    Level2,
    Level3,
    Level4,
    Level5,
    Level6,
    Level7,
    Level8,
    Level9,
    Tier1,
    Tier2,
    Tier3,
    Tier4,
    Tier5,
    Tier6,
    Tier7,
    Tier8,
    Tier9,
}

public enum PricelistMeasureField
{
    Each,
    FixedRate,
    NewInterconnects,
    CurrentMailboxes,
    ActiveQIDs,
    ActiveTPs,
    TotalTrans,
    ToTrans,
    FromTrans,
    TotalKCs,
    ToKCs,
    FromKCs,
    RegisteredQIDs,
    RegisteredTPs,
    MigratedTPs,
    CreditPercentage,
    DebitPercentage,
    Subtotal,
    TieredKCIntCount,
    MonthlyMinimum,
    Credit
}

public enum PricelistModel
{
    Simple,
    Tiered,
    Stacked,
}

public enum ReceiptType
{
    None,
    SynchronousUnsigned,
    SynchronousSigned,
    AsynchronousUnsigned,
    AsynchronousSigned,
}

public enum RetCode
{
    Unknown,
    Success,
    SesssionTimeout,
    AccessDenied,
    NotFound,
    InvalidID,
    Duplicate,
    IDExistsOnNetwork,
    InvalidDataType,
    InvalidDataLength,
    DataError,
    SQLError,
    InternalError,
}

public enum RoutingGroup
{
    ProductionA,
    ProductionB,
    Migration1,
    Migration2,
    NetOpsOnly1,
    NetOpsOnly2,
    ManagedFileTransfer,
    SuperHub,
    Test,
    Suspense1,
    Suspense2,
    Suspense3,
}

public enum SessionStatus
{
    Open,
    Closed,
    Expired,
}

public enum StatisticsPeriod
{
    Hour,
    Day,
    Week,
    Month,
}

public enum Status
{
    Development,
    Active,
    Preproduction,
    Suspended,
    Terminated,
}

public enum StatusCallBack
{
    Active,
    Pending,
    Completed,
    Error,
    Canceled,
}

public enum StatusECGridID
{
    Active,
    AutoRoute,
    Pending,
    Suspended,
    Terminated,
    Duplicate,
}

public enum StatusInterconnect
{
    Pending,
    Completed,
    Canceled,
    Delayed,
    Problem,
    AuthorizationRequired,
    NoStatusChange,
}

public enum UseType
{
    Undefined,
    Test,
    Production,
    TestAndProduction,
}

#endregion

#region Status Codes

public struct InterchangeStatusCode
{
    public static readonly InterchangeStatusCode E1000 = new InterchangeStatusCode("E1000", 0, "Info: Interchange Opened");
    public static readonly InterchangeStatusCode E1001 = new InterchangeStatusCode("E1001", 1, "Info: Interchange Removed from In-Mailbag");
    public static readonly InterchangeStatusCode E1002 = new InterchangeStatusCode("E1002", 2, "Info: Interchange Added to ECGrid Archive");
    public static readonly InterchangeStatusCode E1003 = new InterchangeStatusCode("E1003", 3, "Info: Interchange Routed");
    public static readonly InterchangeStatusCode E1004 = new InterchangeStatusCode("E1004", 4, "Info: Interchange Rerouted");
    public static readonly InterchangeStatusCode E1005 = new InterchangeStatusCode("E1005", 5, "Info: Interchange CC Created");
    public static readonly InterchangeStatusCode E1006 = new InterchangeStatusCode("E1006", 6, "Info: Interchange TaaS Created");
    public static readonly InterchangeStatusCode E1101 = new InterchangeStatusCode("E1101", 7, "Error: Interchange **Control Number Mismatch**");
    public static readonly InterchangeStatusCode E1102 = new InterchangeStatusCode("E1102", 8, "Error: Interchange **Missing/Invalid Segment Terminator**");
    public static readonly InterchangeStatusCode E1103 = new InterchangeStatusCode("E1103", 9, "Error: Interchange **Unknown Route**");
    public static readonly InterchangeStatusCode E1104 = new InterchangeStatusCode("E1104", 10, "Error: Interchange **Partial or Incomplete**");
    public static readonly InterchangeStatusCode E1105 = new InterchangeStatusCode("E1105", 11, "Error: Interchange **Invalid ISA**");
    public static readonly InterchangeStatusCode E1106 = new InterchangeStatusCode("E1106", 12, "Error: Interchange **Invalid ISA11**");
    public static readonly InterchangeStatusCode E1111 = new InterchangeStatusCode("E1111", 13, "Delay: Interchange **Pending Interconnect Approval**");
    public static readonly InterchangeStatusCode E1203 = new InterchangeStatusCode("E1203", 14, "Error: Mailbag Error");
    public static readonly InterchangeStatusCode E1303 = new InterchangeStatusCode("E1303", 15, "Error: Interchange VAN-2-VAN routing blocked");
    public static readonly InterchangeStatusCode E1403 = new InterchangeStatusCode("E1403", 16, "Interchange: DUPLICATE");
    public static readonly InterchangeStatusCode E2000 = new InterchangeStatusCode("E2000", 17, "Info: Interchange Ready for Mailbag");
    public static readonly InterchangeStatusCode E2001 = new InterchangeStatusCode("E2001", 18, "Info: Interchange Queued for Mailbag");
    public static readonly InterchangeStatusCode E2002 = new InterchangeStatusCode("E2002", 19, "Info: Interchange Delimiters Translated");
    public static readonly InterchangeStatusCode E2003 = new InterchangeStatusCode("E2003", 20, "Info: Interchange Added to Out-Mailbag");
    public static readonly InterchangeStatusCode E2004 = new InterchangeStatusCode("E2004", 21, "Info: Interchanged Column Blocked");
    public static readonly InterchangeStatusCode E2005 = new InterchangeStatusCode("E2005", 22, "Info: Interchange Translated (TaaS)");
    public static readonly InterchangeStatusCode E2500 = new InterchangeStatusCode("E2500", 23, "Info: Interchange Ready for Transfer to Node");
    public static readonly InterchangeStatusCode E3000 = new InterchangeStatusCode("E3000", 24, "Info: Interchange Pending Transfer to External Network/Mailbox");
    public static readonly InterchangeStatusCode E3001 = new InterchangeStatusCode("E3001", 25, "Info: Interchange Transferred to External Network/Mailbox");
    public static readonly InterchangeStatusCode E3002 = new InterchangeStatusCode("E3002", 26, "Info: Interchange Transferred to External Network/Pending Ack");
    public static readonly InterchangeStatusCode E3003 = new InterchangeStatusCode("E3003", 27, "Info: Interchange Confirmed");
    public static readonly InterchangeStatusCode E3006 = new InterchangeStatusCode("E3006", 28, "Info: Translated - Original Not Forwarded");
    public static readonly InterchangeStatusCode E3010 = new InterchangeStatusCode("E3010", 29, "Delay: Interchange Retry");
    public static readonly InterchangeStatusCode E3101 = new InterchangeStatusCode("E3101", 30, "Error: Sending");
    public static readonly InterchangeStatusCode E3102 = new InterchangeStatusCode("E3102", 31, "Error: Rejected");
    public static readonly InterchangeStatusCode E3103 = new InterchangeStatusCode("E3103", 32, "Error: X12.56 Rejected");
    public static readonly InterchangeStatusCode E4000 = new InterchangeStatusCode("E4000", 33, "Info: Interchange Complete: CLOSED");
    public static readonly InterchangeStatusCode E4001 = new InterchangeStatusCode("E4001", 34, "Info: Interchange Complete: Charge Sender");
    public static readonly InterchangeStatusCode E4002 = new InterchangeStatusCode("E4002", 35, "Info: Interchange Complete: Charge Receiver");
    public static readonly InterchangeStatusCode E4003 = new InterchangeStatusCode("E4003", 36, "Info: Interchange Complete: No Charge");
    public static readonly InterchangeStatusCode E4101 = new InterchangeStatusCode("E4101", 37, "Info: Interchange CANCELED");
    public static readonly InterchangeStatusCode E4500 = new InterchangeStatusCode("E4500", 38, "Info: Interchange ARCHIVED");

    public string Code { get; private set; }

    public short Index { get; private set; }

    public string Description { get; private set; }

    /// <summary>
    /// Initializes a new instance of the InterchangeStatusCode struct.
    /// </summary>
    /// <param name="code">Code.</param>
    /// <param name="index">Index.</param>
    /// <param name="description">Description.</param>
    private InterchangeStatusCode(string code, short index, string description)
    {
        Code = code;
        Index = index;
        Description = description;
    }

    private bool Equals(InterchangeStatusCode other)
    {
        return string.Equals(Code, other.Code, StringComparison.Ordinal) && string.Equals(Description, other.Description, StringComparison.Ordinal) && Index == other.Index;
    }

    public override bool Equals(object obj)
    {
        if (obj is null) return false;
        //if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((InterchangeStatusCode)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = ((Code != null ? Code.GetHashCode(StringComparison.Ordinal) : 0) * 397);
            hashCode = (hashCode * 397) ^ Index;
            hashCode = (hashCode * 397) ^ (Description != null ? Description.GetHashCode(StringComparison.Ordinal) : 0);
            return hashCode;
        }
    }

    public static bool operator ==(InterchangeStatusCode left, InterchangeStatusCode right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(InterchangeStatusCode left, InterchangeStatusCode right)
    {
        return !Equals(left, right);
    }

    public static bool operator >(InterchangeStatusCode left, InterchangeStatusCode right)
    {
        return left.Index > right.Index;
    }

    public static bool operator <(InterchangeStatusCode left, InterchangeStatusCode right)
    {
        return left.Index < right.Index;
    }

    public static bool operator >=(InterchangeStatusCode left, InterchangeStatusCode right)
    {
        return left.Index >= right.Index;
    }

    public static bool operator <=(InterchangeStatusCode left, InterchangeStatusCode right)
    {
        return left.Index <= right.Index;
    }

    public static string GetInterchangeStatusText(string code)
    {
        return code switch
        {
            "E1000" => "Info: Interchange Opened",
            "E1001" => "Info: Interchange Removed from In-Mailbag",
            "E1002" => "Info: Interchange Added to ECGrid Archive",
            "E1003" => "Info: Interchange Routed",
            "E1004" => "Info: Interchange Rerouted",
            "E1005" => "Info: Interchange CC Created",
            "E1006" => "Info: Interchange TaaS Created",
            "E1101" => "Error: Interchange **Control Number Mismatch**",
            "E1102" => "Error: Interchange **Missing/Invalid Segment Terminator**",
            "E1103" => "Error: Interchange **Unknown Route**",
            "E1104" => "Error: Interchange **Partial or Incomplete**",
            "E1105" => "Error: Interchange **Invalid ISA**",
            "E1106" => "Error: Interchange **Invalid ISA11**",
            "E1111" => "Delay: Interchange **Pending Interconnect Approval**",
            "E1203" => "Error: Mailbag Error",
            "E1303" => "Error: Interchange VAN-2-VAN routing blocked",
            "E1403" => "Interchange: DUPLICATE",
            "E2000" => "Info: Interchange Ready for Mailbag",
            "E2001" => "Info: Interchange Queued for Mailbag",
            "E2002" => "Info: Interchange Delimiters Translated",
            "E2003" => "Info: Interchange Added to Out-Mailbag",
            "E2004" => "Info: Interchanged Column Blocked",
            "E2005" => "Info: Interchange Translated (TaaS)",
            "E2500" => "Info: Interchange Ready for Transfer to Node",
            "E3000" => "Info: Interchange Pending Transfer to External Network/Mailbox",
            "E3001" => "Info: Interchange Transferred to External Network/Mailbox",
            "E3002" => "Info: Interchange Transferred to External Network/Pending Ack",
            "E3003" => "Info: Interchange Confirmed",
            "E3006" => "Info: Translated - Original Not Forwarded",
            "E3010" => "Delay: Interchange Retry",
            "E3101" => "Error: Sending",
            "E3102" => "Error: Rejected",
            "E3103" => "Error: X12.56 Rejected",
            "E4000" => "Info: Interchange Complete: CLOSED",
            "E4001" => "Info: Interchange Complete: Charge Sender",
            "E4002" => "Info: Interchange Complete: Charge Receiver",
            "E4003" => "Info: Interchange Complete: No Charge",
            "E4101" => "Info: Interchange CANCELED",
            "E4500" => "Info: Interchange ARCHIVED",
            _ => code,
        };
    }

    public static StatusDisplayCode InterchangeDisplayStatusText(string code)
    {
        StatusDisplayCode statusDisplayCode = null;

        switch (code)
        {
            case "E1000": statusDisplayCode = new StatusDisplayCode() { Code = "E1000", Description = "Info: Interchange Opened", ColorClass = "success" }; break;
            case "E1001": statusDisplayCode = new StatusDisplayCode() { Code = "E1001", Description = "Info: Interchange Removed from In-Mailbag", ColorClass = "black" }; break;
            case "E1002": statusDisplayCode = new StatusDisplayCode() { Code = "E1002", Description = "Info: Interchange Added to ECGrid Archive", ColorClass = "black" }; break;
            case "E1003": statusDisplayCode = new StatusDisplayCode() { Code = "E1003", Description = "Info: Interchange Routed", ColorClass = "black" }; break;
            case "E1004": statusDisplayCode = new StatusDisplayCode() { Code = "E1004", Description = "Info: Interchange Rerouted", ColorClass = "warning" }; break;
            case "E1005": statusDisplayCode = new StatusDisplayCode() { Code = "E1005", Description = "Info: Interchange CC Created", ColorClass = "success" }; break;
            case "E1006": statusDisplayCode = new StatusDisplayCode() { Code = "E1006", Description = "Info: Interchange TaaS Created", ColorClass = "success" }; break;
            case "E1101": statusDisplayCode = new StatusDisplayCode() { Code = "E1101", Description = "Error: Interchange **Control Number Mismatch**", ColorClass = "danger" }; break;
            case "E1102": statusDisplayCode = new StatusDisplayCode() { Code = "E1102", Description = "Error: Interchange **Missing/Invalid Segment Terminator**", ColorClass = "danger" }; break;
            case "E1103": statusDisplayCode = new StatusDisplayCode() { Code = "E1103", Description = "Error: Interchange **Unknown Route**", ColorClass = "danger" }; break;
            case "E1104": statusDisplayCode = new StatusDisplayCode() { Code = "E1104", Description = "Error: Interchange **Partial or Incomplete**", ColorClass = "danger" }; break;
            case "E1105": statusDisplayCode = new StatusDisplayCode() { Code = "E1105", Description = "Error: Interchange **Invalid ISA**", ColorClass = "danger" }; break;
            case "E1106": statusDisplayCode = new StatusDisplayCode() { Code = "E1106", Description = "Error: Interchange **Invalid ISA11**", ColorClass = "danger" }; break;
            case "E1111": statusDisplayCode = new StatusDisplayCode() { Code = "E1111", Description = "Delay: Interchange **Pending Interconnect Approval**", ColorClass = "warning" }; break;
            case "E1203": statusDisplayCode = new StatusDisplayCode() { Code = "E1203", Description = "Error: Mailbag Error", ColorClass = "danger" }; break;
            case "E1303": statusDisplayCode = new StatusDisplayCode() { Code = "E1303", Description = "Error: Interchange VAN-2-VAN routing blocked", ColorClass = "danger" }; break;
            case "E1403": statusDisplayCode = new StatusDisplayCode() { Code = "E1403", Description = "Interchange: DUPLICATE", ColorClass = "warning" }; break;
            case "E2000": statusDisplayCode = new StatusDisplayCode() { Code = "E2000", Description = "Info: Interchange Ready for Mailbag", ColorClass = "black" }; break;
            case "E2001": statusDisplayCode = new StatusDisplayCode() { Code = "E2001", Description = "Info: Interchange Queued for Mailbag", ColorClass = "black" }; break;
            case "E2002": statusDisplayCode = new StatusDisplayCode() { Code = "E2002", Description = "Info: Interchange Delimiters Translated", ColorClass = "success" }; break;
            case "E2003": statusDisplayCode = new StatusDisplayCode() { Code = "E2003", Description = "Info: Interchange Added to Out-Mailbag", ColorClass = "black" }; break;
            case "E2004": statusDisplayCode = new StatusDisplayCode() { Code = "E2004", Description = "Info: Interchanged Column Blocked", ColorClass = "black" }; break;
            case "E2005": statusDisplayCode = new StatusDisplayCode() { Code = "E2005", Description = "Info: Interchange Translated (TaaS)", ColorClass = "success" }; break;
            case "E2500": statusDisplayCode = new StatusDisplayCode() { Code = "E2500", Description = "Info: Interchange Ready for Transfer to Node", ColorClass = "black" }; break;
            case "E3000": statusDisplayCode = new StatusDisplayCode() { Code = "E3000", Description = "Info: Interchange Pending Transfer to External Network/Mailbox", ColorClass = "black" }; break;
            case "E3001": statusDisplayCode = new StatusDisplayCode() { Code = "E3001", Description = "Info: Interchange Transferred to External Network/Mailbox", ColorClass = "black" }; break;
            case "E3002": statusDisplayCode = new StatusDisplayCode() { Code = "E3002", Description = "Info: Interchange Transferred to External Network/Pending Ack", ColorClass = "black" }; break;
            case "E3003": statusDisplayCode = new StatusDisplayCode() { Code = "E3003", Description = "Info: Interchange Confirmed", ColorClass = "black" }; break;
            case "E3006": statusDisplayCode = new StatusDisplayCode() { Code = "E3006", Description = "Info: Translated - Original Not Forwarded", ColorClass = "black" }; break;
            case "E3010": statusDisplayCode = new StatusDisplayCode() { Code = "E3010", Description = "Delay: Interchange Retry", ColorClass = "warning" }; break;
            case "E3101": statusDisplayCode = new StatusDisplayCode() { Code = "E3101", Description = "Error: Sending", ColorClass = "danger" }; break;
            case "E3102": statusDisplayCode = new StatusDisplayCode() { Code = "E3102", Description = "Error: Rejected", ColorClass = "danger" }; break;
            case "E3103": statusDisplayCode = new StatusDisplayCode() { Code = "E3103", Description = "Error: X12.56 Rejected", ColorClass = "danger" }; break;
            case "E4000": statusDisplayCode = new StatusDisplayCode() { Code = "E4000", Description = "Info: Interchange Complete: CLOSED", ColorClass = "success" }; break;
            case "E4001": statusDisplayCode = new StatusDisplayCode() { Code = "E4001", Description = "Info: Interchange Complete: Charge Sender", ColorClass = "success" }; break;
            case "E4002": statusDisplayCode = new StatusDisplayCode() { Code = "E4002", Description = "Info: Interchange Complete: Charge Receiver", ColorClass = "success" }; break;
            case "E4003": statusDisplayCode = new StatusDisplayCode() { Code = "E4003", Description = "Info: Interchange Complete: No Charge", ColorClass = "success" }; break;
            case "E4101": statusDisplayCode = new StatusDisplayCode() { Code = "E4101", Description = "Info: Interchange CANCELED", ColorClass = "danger" }; break;
            case "E4500": statusDisplayCode = new StatusDisplayCode() { Code = "E4500", Description = "Info: Interchange ARCHIVED", ColorClass = "success" }; break;
    }

        return statusDisplayCode;
    }
}

public struct ParcelStatusCode
{
    public static readonly ParcelStatusCode M900 = new ParcelStatusCode("M900", 0, "NETWORK-IN: Parcel Received by AS2");
    public static readonly ParcelStatusCode M901 = new ParcelStatusCode("M901", 1, "NETWORK-IN: Parcel Received by GISB/NAESB");
    public static readonly ParcelStatusCode M902 = new ParcelStatusCode("M902", 2, "NETWORK-IN: Parcel Received by CXML");
    public static readonly ParcelStatusCode M903 = new ParcelStatusCode("M903", 3, "NETWORK-IN: Parcel Received by FTP");
    public static readonly ParcelStatusCode M904 = new ParcelStatusCode("M904", 4, "NETWORK-IN: Parcel Received by X.400");
    public static readonly ParcelStatusCode M905 = new ParcelStatusCode("M905", 5, "NETWORK-IN: Parcel Received by SMTP");
    public static readonly ParcelStatusCode M906 = new ParcelStatusCode("M906", 6, "NETWORK-IN: Parcel Received by OFTP");
    public static readonly ParcelStatusCode M1000 = new ParcelStatusCode("M1000", 7, "NETWORK-IN: ECGridOS Parcel Uploaded");
    public static readonly ParcelStatusCode M1001 = new ParcelStatusCode("M1001", 8, "NETWORK-IN: Parcel Picked Up");
    public static readonly ParcelStatusCode M1002 = new ParcelStatusCode("M1002", 9, "NETWORK-IN: Parcel Added to Out-Box Archive");
    public static readonly ParcelStatusCode M1003 = new ParcelStatusCode("M1003", 10, "NETWORK-IN: Parcel Added to Network Archive");
    public static readonly ParcelStatusCode M1004 = new ParcelStatusCode("M1004", 11, "NETWORK-IN: Parcel Transferred to Grid");
    public static readonly ParcelStatusCode M1005 = new ParcelStatusCode("M1005", 12, "NETWORK-IN: Parcel Transfer Validated");
    public static readonly ParcelStatusCode M1006 = new ParcelStatusCode("M1006", 13, "NETWORK-IN: Rejected Parcel Received by Network");
    public static readonly ParcelStatusCode M1007 = new ParcelStatusCode("M1007", 14, "NETWORK-IN: Rejected Parcel Filed in Out-Box Error Directory");
    public static readonly ParcelStatusCode M1008 = new ParcelStatusCode("M1008", 15, "NETWORK-IN: AS2 MDN Sent");
    public static readonly ParcelStatusCode M1104 = new ParcelStatusCode("M1104", 16, "NETWORK-IN: Error Transferring Parcel to Grid");
    public static readonly ParcelStatusCode M1105 = new ParcelStatusCode("M1105", 17, "NETWORK-IN: Parcel Validation Error");
    public static readonly ParcelStatusCode M1999 = new ParcelStatusCode("M1999", 18, "NETWORK-IN: Carbon Copy Parcel Created");
    public static readonly ParcelStatusCode M2000 = new ParcelStatusCode("M2000", 19, "NETWORK-IN: Parcel Ready for Grid Processing");
    public static readonly ParcelStatusCode M2001 = new ParcelStatusCode("M2001", 20, "ECGRID-IN: Parcel Opened by Grid");
    public static readonly ParcelStatusCode M2002 = new ParcelStatusCode("M2002", 21, "ECGRID-IN: Parcel Added to Grid Archive");
    public static readonly ParcelStatusCode M2003 = new ParcelStatusCode("M2003", 22, "ECGRID-IN: Parcel Structure Validated");
    public static readonly ParcelStatusCode M2004 = new ParcelStatusCode("M2004", 23, "ECGRID-IN: X12.56 IA Created");
    public static readonly ParcelStatusCode M2005 = new ParcelStatusCode("M2005", 24, "ECGRID-IN: All Parcel Contents Routed");
    public static readonly ParcelStatusCode M2006 = new ParcelStatusCode("M2006", 25, "NETWORK-IN: Translated");
    public static readonly ParcelStatusCode M2013 = new ParcelStatusCode("M2013", 26, "ECGRID-IN: Parcel Unblocked");
    public static readonly ParcelStatusCode M2101 = new ParcelStatusCode("M2101", 27, "ECGRID-IN: Parcel Zero-Byte ERROR");
    public static readonly ParcelStatusCode M2102 = new ParcelStatusCode("M2102", 28, "ECGRID-IN: Parcel Segment Terminator ERROR");
    public static readonly ParcelStatusCode M2103 = new ParcelStatusCode("M2103", 29, "ECGRID-IN: Parcel Structure Validation ERROR");
    public static readonly ParcelStatusCode M2104 = new ParcelStatusCode("M2104", 30, "ECGRID-IN: Parcel DUPLICATE");
    public static readonly ParcelStatusCode M2105 = new ParcelStatusCode("M2105", 31, "ECGRID-IN: Partial Parcel Contents Routed");
    public static readonly ParcelStatusCode M2106 = new ParcelStatusCode("M2106", 32, "ECGRID-IN: Parcel Structure ERROR: Too Corrupt to Process");
    public static readonly ParcelStatusCode M2205 = new ParcelStatusCode("M2205", 33, "ECGRID-IN: No Parcel Contents Could Be Routed");
    public static readonly ParcelStatusCode M2300 = new ParcelStatusCode("M2300", 34, "ECGRID-IN: Mailbag Ready for Acknowledgment");
    public static readonly ParcelStatusCode M2301 = new ParcelStatusCode("M2301", 35, "ECGRID-IN: Mailbag Acknowledging");
    public static readonly ParcelStatusCode M2302 = new ParcelStatusCode("M2302", 36, "ECGRID-IN: Mailbag Acknowledged");
    public static readonly ParcelStatusCode M2312 = new ParcelStatusCode("M2312", 37, "ECGRID-IN: Mailbag Acknowledged with Errors");
    public static readonly ParcelStatusCode M2320 = new ParcelStatusCode("M2320", 38, "ECGRID-IN: Mailbag Ready for Pass-Thru Acknowledgment");
    public static readonly ParcelStatusCode M2321 = new ParcelStatusCode("M2321", 39, "ECGRID-IN: Mailbag Pass-Thru Acknowledging");
    public static readonly ParcelStatusCode M2322 = new ParcelStatusCode("M2322", 40, "ECGRID-IN: Mailbag Pass-Thru Acknowledged");
    public static readonly ParcelStatusCode M2400 = new ParcelStatusCode("M2400", 41, "ECGRID-IN: Parcel Completed");
    public static readonly ParcelStatusCode M2401 = new ParcelStatusCode("M2401", 42, "ECGRID-IN: Parcel Completed w/Errors");
    public static readonly ParcelStatusCode M2500 = new ParcelStatusCode("M2500", 43, "ECGRID-ARC: Parcel Archived");
    public static readonly ParcelStatusCode M3001 = new ParcelStatusCode("M3001", 44, "ECGRID-OUT: Parcel Opened");
    public static readonly ParcelStatusCode M3002 = new ParcelStatusCode("M3002", 45, "ECGRID-OUT: X12.56 Mailbag Header Added to Parcel");
    public static readonly ParcelStatusCode M3003 = new ParcelStatusCode("M3003", 46, "ECGRID-OUT: X12.56 Mailbag Acknowledgment(s) Added to Parcel");
    public static readonly ParcelStatusCode M3004 = new ParcelStatusCode("M3004", 47, "ECGRID-OUT: Interchanges Added to Parcel");
    public static readonly ParcelStatusCode M3005 = new ParcelStatusCode("M3005", 48, "ECGRID-OUT: X12.56 Mailbag Trailer Added to Parcel");
    public static readonly ParcelStatusCode M3006 = new ParcelStatusCode("M3006", 49, "ECGRID-OUT: Parcel Closed");
    public static readonly ParcelStatusCode M3007 = new ParcelStatusCode("M3007", 50, "ECGRID-OUT: Parcel Added to Grid Archive");
    public static readonly ParcelStatusCode M4000 = new ParcelStatusCode("M4000", 51, "ECGRID-OUT: Parcel Ready for Transfer to Network");
    public static readonly ParcelStatusCode M4001 = new ParcelStatusCode("M4001", 52, "ECGRID-OUT: Parcel Queued for Transfer");
    public static readonly ParcelStatusCode M4002 = new ParcelStatusCode("M4002", 53, "ECGRID-OUT: Parcel Transferred to Network Node");
    public static readonly ParcelStatusCode M4003 = new ParcelStatusCode("M4003", 54, "ECGRID-OUT: Parcel Transfer Validated");
    public static readonly ParcelStatusCode M4006 = new ParcelStatusCode("M4006", 55, "NETWORK-OUT: Translated");
    public static readonly ParcelStatusCode M4102 = new ParcelStatusCode("M4102", 56, "ECGRID-OUT: Error Transferring Parcel to Network Node");
    public static readonly ParcelStatusCode M4103 = new ParcelStatusCode("M4103", 57, "ECGRID-OUT: Parcel Validation Error");
    public static readonly ParcelStatusCode M5000 = new ParcelStatusCode("M5000", 58, "ECGRID-OUT: Parcel Ready for Network Node Processing");
    public static readonly ParcelStatusCode M5001 = new ParcelStatusCode("M5001", 59, "NETWORK-OUT: Parcel Transferred to Network Node");
    public static readonly ParcelStatusCode M5002 = new ParcelStatusCode("M5002", 60, "NETWORK-OUT: Parcel Added to Network Node Archive");
    public static readonly ParcelStatusCode M5003 = new ParcelStatusCode("M5003", 61, "NETWORK-OUT: Parcel Renamed to Network Specifications");
    public static readonly ParcelStatusCode M5004 = new ParcelStatusCode("M5004", 62, "NETWORK-OUT: Parcel Added to In-Box Archive");
    public static readonly ParcelStatusCode M5005 = new ParcelStatusCode("M5005", 63, "NETWORK-OUT: Parcel Assigned to Mailbox");
    public static readonly ParcelStatusCode M6000 = new ParcelStatusCode("M6000", 64, "NETWORK-OUT: Parcel Pending in In-Box");
    public static readonly ParcelStatusCode M6001 = new ParcelStatusCode("M6001", 65, "NETWORK-OUT: Parcel Transferred to External Network/Mailbox");
    public static readonly ParcelStatusCode M6002 = new ParcelStatusCode("M6002", 66, "NETWORK-OUT: Parcel Pending X12.56 Mailbag Ack from Network");
    public static readonly ParcelStatusCode M6003 = new ParcelStatusCode("M6003", 67, "ECGRID-CONF: X12.56 Mailbag Accepted");
    public static readonly ParcelStatusCode M6004 = new ParcelStatusCode("M6004", 68, "ECGRID-CONF: Parcel Confirmed");
    public static readonly ParcelStatusCode M6005 = new ParcelStatusCode("M6005", 69, "ECGRID-CONF: X12.56 Mailbag Delivered");
    public static readonly ParcelStatusCode M6006 = new ParcelStatusCode("M6006", 70, "NETWORK-OUT: Translated - Original Not Forwarded");
    public static readonly ParcelStatusCode M6010 = new ParcelStatusCode("M6010", 71, "NETWORK-OUT: Parcel Sent by AS2");
    public static readonly ParcelStatusCode M6011 = new ParcelStatusCode("M6011", 72, "NETWORK-OUT: Parcel Sent by GISB/NAESB");
    public static readonly ParcelStatusCode M6012 = new ParcelStatusCode("M6012", 73, "NETWORK-OUT: Parcel Pending AS2 MDN");
    public static readonly ParcelStatusCode M6013 = new ParcelStatusCode("M6013", 74, "ECGRID-CONF: AS2 MDN Accepted");
    public static readonly ParcelStatusCode M6014 = new ParcelStatusCode("M6014", 75, "NETWORK-OUT: Parcel Sent by CXML");
    public static readonly ParcelStatusCode M6100 = new ParcelStatusCode("M6100", 76, "NETWORK-OUT: Parcel Delivery Error");
    public static readonly ParcelStatusCode M6103 = new ParcelStatusCode("M6103", 77, "ECGRID-CONF: X12.56 Mailbag Rejected");
    public static readonly ParcelStatusCode M6104 = new ParcelStatusCode("M6104", 78, "ECGRID-CONF: X12.56 Mailbag Duplicate");
    public static readonly ParcelStatusCode M6110 = new ParcelStatusCode("M6110", 79, "NETWORK-OUT: AS2 Send Failure/Retrying");
    public static readonly ParcelStatusCode M6111 = new ParcelStatusCode("M6111", 80, "NETWORK-OUT: GISB/NAESB Send Failure");
    public static readonly ParcelStatusCode M6112 = new ParcelStatusCode("M6112", 81, "NETWORK-OUT: CXML Send Failure/Retrying");
    public static readonly ParcelStatusCode M6113 = new ParcelStatusCode("M6113", 82, "ECGRID-CONF: AS2 MDN Rejected");
    public static readonly ParcelStatusCode M6120 = new ParcelStatusCode("M6120", 83, "NETWORK-OUT: AS2 Send Aborted");
    public static readonly ParcelStatusCode M6121 = new ParcelStatusCode("M6121", 84, "NETWORK-OUT: GISB/NAESB Send Aborted");
    public static readonly ParcelStatusCode M6122 = new ParcelStatusCode("M6122", 85, "NETWORK-OUT: CXML Send Aborted");
    public static readonly ParcelStatusCode M7000 = new ParcelStatusCode("M7000", 86, "ECGRID-OUT: Parcel Complete");
    public static readonly ParcelStatusCode M7500 = new ParcelStatusCode("M7500", 87, "ECGRID-ARC: Parcel Archived");

    public string Code { get; private set; }

    public short Index { get; private set; }

    public string Description { get; private set; }

    /// <summary>
    /// Initializes a new instance of the ParcelStatusCode struct.
    /// </summary>
    /// <param name="code">Code.</param>
    /// <param name="index">Index.</param>
    /// <param name="description">Description.</param>
    private ParcelStatusCode(string code, short index, string description)
    {
        Code = code;
        Index = index;
        Description = description;
    }

    private bool Equals(ParcelStatusCode other)
    {
        return string.Equals(Code, other.Code, StringComparison.Ordinal) && string.Equals(Description, other.Description, StringComparison.Ordinal) && Index == other.Index;
    }

    public override bool Equals(object obj)
    {
        if (obj is null) return false;
        //if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ParcelStatusCode)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = ((Code != null ? Code.GetHashCode(StringComparison.Ordinal) : 0) * 397);
            hashCode = (hashCode * 397) ^ Index;
            hashCode = (hashCode * 397) ^ (Description != null ? Description.GetHashCode(StringComparison.Ordinal) : 0);
            return hashCode;
        }
    }

    public static bool operator ==(ParcelStatusCode left, ParcelStatusCode right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(ParcelStatusCode left, ParcelStatusCode right)
    {
        return !Equals(left, right);
    }

    public static bool operator >(ParcelStatusCode left, ParcelStatusCode right)
    {
        return left.Index > right.Index;
    }

    public static bool operator <(ParcelStatusCode left, ParcelStatusCode right)
    {
        return left.Index < right.Index;
    }

    public static bool operator >=(ParcelStatusCode left, ParcelStatusCode right)
    {
        return left.Index >= right.Index;
    }

    public static bool operator <=(ParcelStatusCode left, ParcelStatusCode right)
    {
        return left.Index <= right.Index;
    }

    public static string GetParcelStatusText(string code)
    {
        return code switch
        {
            "M900" => "NETWORK-IN: Parcel Received by AS2",
            "M901" => "NETWORK-IN: Parcel Received by GISB/NAESB",
            "M902" => "NETWORK-IN: Parcel Received by CXML",
            "M903" => "NETWORK-IN: Parcel Received by FTP",
            "M904" => "NETWORK-IN: Parcel Received by X.400",
            "M905" => "NETWORK-IN: Parcel Received by SMTP",
            "M906" => "NETWORK-IN: Parcel Received by OFTP",
            "M1000" => "NETWORK-IN: ECGridOS Parcel Uploaded",
            "M1001" => "NETWORK-IN: Parcel Picked Up",
            "M1002" => "NETWORK-IN: Parcel Added to Out-Box Archive",
            "M1003" =>  "NETWORK-IN: Parcel Added to Network Archive",
            "M1004" =>  "NETWORK-IN: Parcel Transferred to Grid",
            "M1005" =>  "NETWORK-IN: Parcel Transfer Validated",
            "M1006" =>  "NETWORK-IN: Rejected Parcel Received by Network",
            "M1007" =>  "NETWORK-IN: Rejected Parcel Filed in Out-Box Error Directory",
            "M1008" =>  "NETWORK-IN: AS2 MDN Sent",
            "M1104" =>  "NETWORK-IN: Error Transferring Parcel to Grid",
            "M1105" =>  "NETWORK-IN: Parcel Validation Error",
            "M1999" =>  "NETWORK-IN: Carbon Copy Parcel Created",
            "M2000" =>  "NETWORK-IN: Parcel Ready for Grid Processing",
            "M2001" =>  "ECGRID-IN: Parcel Opened by Grid",
            "M2002" =>  "ECGRID-IN: Parcel Added to Grid Archive",
            "M2003" =>  "ECGRID-IN: Parcel Structure Validated",
            "M2004" =>  "ECGRID-IN: X12.56 IA Created",
            "M2005" =>  "ECGRID-IN: All Parcel Contents Routed",
            "M2006" =>  "NETWORK-IN: Translated",
            "M2013" =>  "ECGRID-IN: Parcel Unblocked",
            "M2101" =>  "ECGRID-IN: Parcel Zero-Byte ERROR",
            "M2102" =>  "ECGRID-IN: Parcel Segment Terminator ERROR",
            "M2103" =>  "ECGRID-IN: Parcel Structure Validation ERROR",
            "M2104" =>  "ECGRID-IN: Parcel DUPLICATE",
            "M2105" =>  "ECGRID-IN: Partial Parcel Contents Routed",
            "M2106" =>  "ECGRID-IN: Parcel Structure ERROR: Too Corrupt to Process",
            "M2205" =>  "ECGRID-IN: No Parcel Contents Could Be Routed",
            "M2300" =>  "ECGRID-IN: Mailbag Ready for Acknowledgment",
            "M2301" =>  "ECGRID-IN: Mailbag Acknowledging",
            "M2302" =>  "ECGRID-IN: Mailbag Acknowledged",
            "M2312" =>  "ECGRID-IN: Mailbag Acknowledged with Errors",
            "M2320" =>  "ECGRID-IN: Mailbag Ready for Pass-Thru Acknowledgment",
            "M2321" =>  "ECGRID-IN: Mailbag Pass-Thru Acknowledging",
            "M2322" =>  "ECGRID-IN: Mailbag Pass-Thru Acknowledged",
            "M2400" =>  "ECGRID-IN: Parcel Completed",
            "M2401" =>  "ECGRID-IN: Parcel Completed w/Errors",
            "M2500" =>  "ECGRID-ARC: Parcel Archived",
            "M3001" =>  "ECGRID-OUT: Parcel Opened",
            "M3002" =>  "ECGRID-OUT: X12.56 Mailbag Header Added to Parcel",
            "M3003" =>  "ECGRID-OUT: X12.56 Mailbag Acknowledgment(s) Added to Parcel",
            "M3004" =>  "ECGRID-OUT: Interchanges Added to Parcel",
            "M3005" =>  "ECGRID-OUT: X12.56 Mailbag Trailer Added to Parcel",
            "M3006" =>  "ECGRID-OUT: Parcel Closed",
            "M3007" =>  "ECGRID-OUT: Parcel Added to Grid Archive",
            "M4000" =>  "ECGRID-OUT: Parcel Ready for Transfer to Network",
            "M4001" =>  "ECGRID-OUT: Parcel Queued for Transfer",
            "M4002" =>  "ECGRID-OUT: Parcel Transferred to Network Node",
            "M4003" =>  "ECGRID-OUT: Parcel Transfer Validated",
            "M4006" =>  "NETWORK-OUT: Translated",
            "M4102" =>  "ECGRID-OUT: Error Transferring Parcel to Network Node",
            "M4103" =>  "ECGRID-OUT: Parcel Validation Error",
            "M5000" =>  "ECGRID-OUT: Parcel Ready for Network Node Processing",
            "M5001" =>  "NETWORK-OUT: Parcel Transferred to Network Node",
            "M5002" =>  "NETWORK-OUT: Parcel Added to Network Node Archive",
            "M5003" =>  "NETWORK-OUT: Parcel Renamed to Network Specifications",
            "M5004" =>  "NETWORK-OUT: Parcel Added to In-Box Archive",
            "M5005" =>  "NETWORK-OUT: Parcel Assigned to Mailbox",
            "M6000" =>  "NETWORK-OUT: Parcel Pending in In-Box",
            "M6001" =>  "NETWORK-OUT: Parcel Transferred to External Network/Mailbox",
            "M6002" =>  "NETWORK-OUT: Parcel Pending X12.56 Mailbag Ack from Network",
            "M6003" =>  "ECGRID-CONF: X12.56 Mailbag Accepted",
            "M6004" =>  "ECGRID-CONF: Parcel Confirmed",
            "M6005" =>  "ECGRID-CONF: X12.56 Mailbag Delivered",
            "M6006" =>  "NETWORK-OUT: Translated - Original Not Forwarded",
            "M6010" =>  "NETWORK-OUT: Parcel Sent by AS2",
            "M6011" =>  "NETWORK-OUT: Parcel Sent by GISB/NAESB",
            "M6012" =>  "NETWORK-OUT: Parcel Pending AS2 MDN",
            "M6013" =>  "ECGRID-CONF: AS2 MDN Accepted",
            "M6014" =>  "NETWORK-OUT: Parcel Sent by CXML",
            "M6100" =>  "NETWORK-OUT: Parcel Delivery Error",
            "M6103" =>  "ECGRID-CONF: X12.56 Mailbag Rejected",
            "M6104" =>  "ECGRID-CONF: X12.56 Mailbag Duplicate",
            "M6110" =>  "NETWORK-OUT: AS2 Send Failure/Retrying",
            "M6111" =>  "NETWORK-OUT: GISB/NAESB Send Failure",
            "M6112" =>  "NETWORK-OUT: CXML Send Failure/Retrying",
            "M6113" =>  "ECGRID-CONF: AS2 MDN Rejected",
            "M6120" =>  "NETWORK-OUT: AS2 Send Aborted",
            "M6121" =>  "NETWORK-OUT: GISB/NAESB Send Aborted",
            "M6122" =>  "NETWORK-OUT: CXML Send Aborted",
            "M7000" =>  "ECGRID-OUT: Parcel Complete",
            "M7500" =>  "ECGRID-ARC: Parcel Archived",
            _ => code,
        };
    }

    public static StatusDisplayCode ParcelDisplayStatusText(string code)
    {
        StatusDisplayCode statusDisplayCode = null;

        switch (code)
        {
            case "M900": statusDisplayCode = new StatusDisplayCode() { Code = "M900", Description = "NETWORK-IN: Parcel Received by AS2", ColorClass = "success" }; break;
            case "M901": statusDisplayCode = new StatusDisplayCode() { Code = "M901", Description = "NETWORK-IN: Parcel Received by GISB/NAESB", ColorClass = "success" }; break;
            case "M902": statusDisplayCode = new StatusDisplayCode() { Code = "M902", Description = "NETWORK-IN: Parcel Received by CXML", ColorClass = "success" }; break;
            case "M903": statusDisplayCode = new StatusDisplayCode() { Code = "M903", Description = "NETWORK-IN: Parcel Received by FTP", ColorClass = "success" }; break;
            case "M904": statusDisplayCode = new StatusDisplayCode() { Code = "M904", Description = "NETWORK-IN: Parcel Received by X.400", ColorClass = "success" }; break;
            case "M905": statusDisplayCode = new StatusDisplayCode() { Code = "M905", Description = "NETWORK-IN: Parcel Received by SMTP", ColorClass = "success" }; break;
            case "M906": statusDisplayCode = new StatusDisplayCode() { Code = "M906", Description = "NETWORK-IN: Parcel Received by OFTP", ColorClass = "success" }; break;
            case "M1000": statusDisplayCode = new StatusDisplayCode() { Code="M1000", Description= "NETWORK-IN: ECGridOS Parcel Uploaded", ColorClass = "black" }; break;
            case "M1001": statusDisplayCode = new StatusDisplayCode() { Code="M1001", Description= "NETWORK-IN: Parcel Picked Up", ColorClass = "black" }; break;
            case "M1002": statusDisplayCode = new StatusDisplayCode() { Code="M1002", Description= "NETWORK-IN: Parcel Added to Out-Box Archive", ColorClass = "black" }; break;
            case "M1003": statusDisplayCode = new StatusDisplayCode() { Code="M1003", Description= "NETWORK-IN: Parcel Added to Network Archive", ColorClass = "black" }; break;
            case "M1004": statusDisplayCode = new StatusDisplayCode() { Code="M1004", Description= "NETWORK-IN: Parcel Transferred to Grid", ColorClass = "black" }; break;
            case "M1005": statusDisplayCode = new StatusDisplayCode() { Code="M1005", Description= "NETWORK-IN: Parcel Transfer Validated", ColorClass = "black" }; break;
            case "M1006": statusDisplayCode = new StatusDisplayCode() { Code="M1006", Description= "NETWORK-IN: Rejected Parcel Received by Network", ColorClass = "danger" }; break;
            case "M1007": statusDisplayCode = new StatusDisplayCode() { Code="M1007", Description= "NETWORK-IN: Rejected Parcel Filed in Out-Box Error Directory", ColorClass = "danger" }; break;
            case "M1008": statusDisplayCode = new StatusDisplayCode() { Code="M1008", Description= "NETWORK-IN: AS2 MDN Sent", ColorClass = "success" }; break;
            case "M1104": statusDisplayCode = new StatusDisplayCode() { Code="M1104", Description= "NETWORK-IN: Error Transferring Parcel to Grid", ColorClass = "danger" }; break;
            case "M1105": statusDisplayCode = new StatusDisplayCode() { Code="M1105", Description= "NETWORK-IN: Parcel Validation Error", ColorClass = "danger" }; break;
            case "M1999": statusDisplayCode = new StatusDisplayCode() { Code="M1999", Description= "NETWORK-IN: Carbon Copy Parcel Created", ColorClass = "success" }; break;
            case "M2000": statusDisplayCode = new StatusDisplayCode() { Code="M2000", Description= "NETWORK-IN: Parcel Ready for Grid Processing", ColorClass = "black" }; break;
            case "M2001": statusDisplayCode = new StatusDisplayCode() { Code="M2001", Description= "ECGRID-IN: Parcel Opened by Grid", ColorClass = "black" }; break;
            case "M2002": statusDisplayCode = new StatusDisplayCode() { Code="M2002", Description= "ECGRID-IN: Parcel Added to Grid Archive", ColorClass = "black" }; break;
            case "M2003": statusDisplayCode = new StatusDisplayCode() { Code="M2003", Description= "ECGRID-IN: Parcel Structure Validated", ColorClass = "success" }; break;
            case "M2004": statusDisplayCode = new StatusDisplayCode() { Code="M2004", Description= "ECGRID-IN: X12.56 IA Created", ColorClass = "success" }; break;
            case "M2005": statusDisplayCode = new StatusDisplayCode() { Code="M2005", Description= "ECGRID-IN: All Parcel Contents Routed", ColorClass = "success" }; break;
            case "M2006": statusDisplayCode = new StatusDisplayCode() { Code="M2006", Description= "NETWORK-IN: Translated", ColorClass = "black" }; break;
            case "M2013": statusDisplayCode = new StatusDisplayCode() { Code="M2013", Description= "ECGRID-IN: Parcel Unblocked", ColorClass = "black" }; break;
            case "M2101": statusDisplayCode = new StatusDisplayCode() { Code="M2101", Description= "ECGRID-IN: Parcel Zero-Byte ERROR", ColorClass = "danger" }; break;
            case "M2102": statusDisplayCode = new StatusDisplayCode() { Code="M2102", Description= "ECGRID-IN: Parcel Segment Terminator ERROR", ColorClass = "danger" }; break;
            case "M2103": statusDisplayCode = new StatusDisplayCode() { Code="M2103", Description= "ECGRID-IN: Parcel Structure Validation ERROR", ColorClass = "danger" }; break;
            case "M2104": statusDisplayCode = new StatusDisplayCode() { Code="M2104", Description= "ECGRID-IN: Parcel DUPLICATE", ColorClass = "warning" }; break;
            case "M2105": statusDisplayCode = new StatusDisplayCode() { Code="M2105", Description= "ECGRID-IN: Partial Parcel Contents Routed", ColorClass = "warning" }; break;
            case "M2106": statusDisplayCode = new StatusDisplayCode() { Code="M2106", Description= "ECGRID-IN: Parcel Structure ERROR: Too Corrupt to Process", ColorClass = "danger" }; break;
            case "M2205": statusDisplayCode = new StatusDisplayCode() { Code="M2205", Description= "ECGRID-IN: No Parcel Contents Could Be Routed", ColorClass = "danger" }; break;
            case "M2300": statusDisplayCode = new StatusDisplayCode() { Code="M2300", Description= "ECGRID-IN: Mailbag Ready for Acknowledgment", ColorClass = "black" }; break;
            case "M2301": statusDisplayCode = new StatusDisplayCode() { Code="M2301", Description= "ECGRID-IN: Mailbag Acknowledging", ColorClass = "black" }; break;
            case "M2302": statusDisplayCode = new StatusDisplayCode() { Code="M2302", Description= "ECGRID-IN: Mailbag Acknowledged", ColorClass = "black" }; break;
            case "M2312": statusDisplayCode = new StatusDisplayCode() { Code="M2312", Description= "ECGRID-IN: Mailbag Acknowledged with Errors", ColorClass = "warning" }; break;
            case "M2320": statusDisplayCode = new StatusDisplayCode() { Code="M2320", Description= "ECGRID-IN: Mailbag Ready for Pass-Thru Acknowledgment", ColorClass = "black" }; break;
            case "M2321": statusDisplayCode = new StatusDisplayCode() { Code="M2321", Description= "ECGRID-IN: Mailbag Pass-Thru Acknowledging", ColorClass = "black" }; break;
            case "M2322": statusDisplayCode = new StatusDisplayCode() { Code="M2322", Description= "ECGRID-IN: Mailbag Pass-Thru Acknowledged", ColorClass = "black" }; break;
            case "M2400": statusDisplayCode = new StatusDisplayCode() { Code="M2400", Description= "ECGRID-IN: Parcel Completed", ColorClass = "success" }; break;
            case "M2401": statusDisplayCode = new StatusDisplayCode() { Code="M2401", Description= "ECGRID-IN: Parcel Completed w/Errors", ColorClass = "danger" }; break;
            case "M2500": statusDisplayCode = new StatusDisplayCode() { Code="M2500", Description= "ECGRID-ARC: Parcel Archived", ColorClass = "success" }; break;
            case "M3001": statusDisplayCode = new StatusDisplayCode() { Code="M3001", Description= "ECGRID-OUT: Parcel Opened", ColorClass = "black" }; break;
            case "M3002": statusDisplayCode = new StatusDisplayCode() { Code="M3002", Description= "ECGRID-OUT: X12.56 Mailbag Header Added to Parcel", ColorClass = "black" }; break;
            case "M3003": statusDisplayCode = new StatusDisplayCode() { Code="M3003", Description= "ECGRID-OUT: X12.56 Mailbag Acknowledgment(s) Added to Parcel", ColorClass = "black" }; break;
            case "M3004": statusDisplayCode = new StatusDisplayCode() { Code="M3004", Description= "ECGRID-OUT: Interchanges Added to Parcel", ColorClass = "black" }; break;
            case "M3005": statusDisplayCode = new StatusDisplayCode() { Code="M3005", Description= "ECGRID-OUT: X12.56 Mailbag Trailer Added to Parcel", ColorClass = "black" }; break;
            case "M3006": statusDisplayCode = new StatusDisplayCode() { Code="M3006", Description= "ECGRID-OUT: Parcel Closed", ColorClass = "black" }; break;
            case "M3007": statusDisplayCode = new StatusDisplayCode() { Code="M3007", Description= "ECGRID-OUT: Parcel Added to Grid Archive", ColorClass = "black" }; break;
            case "M4000": statusDisplayCode = new StatusDisplayCode() { Code="M4000", Description= "ECGRID-OUT: Parcel Ready for Transfer to Network", ColorClass = "black" }; break;
            case "M4001": statusDisplayCode = new StatusDisplayCode() { Code="M4001", Description= "ECGRID-OUT: Parcel Queued for Transfer", ColorClass = "black" }; break;
            case "M4002": statusDisplayCode = new StatusDisplayCode() { Code="M4002", Description= "ECGRID-OUT: Parcel Transferred to Network Node", ColorClass = "black" }; break;
            case "M4003": statusDisplayCode = new StatusDisplayCode() { Code="M4003", Description= "ECGRID-OUT: Parcel Transfer Validated", ColorClass = "black" }; break;
            case "M4006": statusDisplayCode = new StatusDisplayCode() { Code="M4006", Description= "NETWORK-OUT: Translated", ColorClass = "success" }; break;
            case "M4102": statusDisplayCode = new StatusDisplayCode() { Code="M4102", Description= "ECGRID-OUT: Error Transferring Parcel to Network Node", ColorClass = "danger" }; break;
            case "M4103": statusDisplayCode = new StatusDisplayCode() { Code="M4103", Description= "ECGRID-OUT: Parcel Validation Error", ColorClass = "danger" }; break;
            case "M5000": statusDisplayCode = new StatusDisplayCode() { Code="M5000", Description= "ECGRID-OUT: Parcel Ready for Network Node Processing", ColorClass = "black" }; break;
            case "M5001": statusDisplayCode = new StatusDisplayCode() { Code="M5001", Description= "NETWORK-OUT: Parcel Transferred to Network Node", ColorClass = "black" }; break;
            case "M5002": statusDisplayCode = new StatusDisplayCode() { Code="M5002", Description= "NETWORK-OUT: Parcel Added to Network Node Archive", ColorClass = "black" }; break;
            case "M5003": statusDisplayCode = new StatusDisplayCode() { Code="M5003", Description= "NETWORK-OUT: Parcel Renamed to Network Specifications", ColorClass = "black" }; break;
            case "M5004": statusDisplayCode = new StatusDisplayCode() { Code="M5004", Description= "NETWORK-OUT: Parcel Added to In-Box Archive", ColorClass = "black" }; break;
            case "M5005": statusDisplayCode = new StatusDisplayCode() { Code="M5005", Description= "NETWORK-OUT: Parcel Assigned to Mailbox", ColorClass = "black" }; break;
            case "M6000": statusDisplayCode = new StatusDisplayCode() { Code="M6000", Description= "NETWORK-OUT: Parcel Pending in In-Box", ColorClass = "primary" }; break;
            case "M6001": statusDisplayCode = new StatusDisplayCode() { Code="M6001", Description= "NETWORK-OUT: Parcel Transferred to External Network/Mailbox", ColorClass = "grey" }; break;
            case "M6002": statusDisplayCode = new StatusDisplayCode() { Code="M6002", Description= "NETWORK-OUT: Parcel Pending X12.56 Mailbag Ack from Network", ColorClass = "grey" }; break;
            case "M6003": statusDisplayCode = new StatusDisplayCode() { Code="M6003", Description= "ECGRID-CONF: X12.56 Mailbag Accepted", ColorClass = "primary" }; break;
            case "M6004": statusDisplayCode = new StatusDisplayCode() { Code="M6004", Description= "ECGRID-CONF: Parcel Confirmed", ColorClass = "success" }; break;
            case "M6005": statusDisplayCode = new StatusDisplayCode() { Code="M6005", Description= "ECGRID-CONF: X12.56 Mailbag Delivered", ColorClass = "grey" }; break;
            case "M6006": statusDisplayCode = new StatusDisplayCode() { Code="M6006", Description= "NETWORK-OUT: Translated - Original Not Forwarded", ColorClass = "grey" }; break;
            case "M6010": statusDisplayCode = new StatusDisplayCode() { Code="M6010", Description= "NETWORK-OUT: Parcel Sent by AS2", ColorClass = "grey" }; break;
            case "M6011": statusDisplayCode = new StatusDisplayCode() { Code="M6011", Description= "NETWORK-OUT: Parcel Sent by GISB/NAESB", ColorClass = "grey" }; break;
            case "M6012": statusDisplayCode = new StatusDisplayCode() { Code="M6012", Description= "NETWORK-OUT: Parcel Pending AS2 MDN", ColorClass = "primary" }; break;
            case "M6013": statusDisplayCode = new StatusDisplayCode() { Code="M6013", Description= "ECGRID-CONF: AS2 MDN Accepted", ColorClass = "success" }; break;
            case "M6014": statusDisplayCode = new StatusDisplayCode() { Code="M6014", Description= "NETWORK-OUT: Parcel Sent by CXML", ColorClass = "success" }; break;
            case "M6100": statusDisplayCode = new StatusDisplayCode() { Code="M6100", Description= "NETWORK-OUT: Parcel Delivery Error", ColorClass = "danger" }; break;
            case "M6103": statusDisplayCode = new StatusDisplayCode() { Code="M6103", Description= "ECGRID-CONF: X12.56 Mailbag Rejected", ColorClass = "danger" }; break;
            case "M6104": statusDisplayCode = new StatusDisplayCode() { Code="M6104", Description= "ECGRID-CONF: X12.56 Mailbag Duplicate", ColorClass = "danger" }; break;
            case "M6110": statusDisplayCode = new StatusDisplayCode() { Code="M6110", Description= "NETWORK-OUT: AS2 Send Failure/Retrying", ColorClass = "danger" }; break;
            case "M6111": statusDisplayCode = new StatusDisplayCode() { Code="M6111", Description= "NETWORK-OUT: GISB/NAESB Send Failure", ColorClass = "danger" }; break;
            case "M6112": statusDisplayCode = new StatusDisplayCode() { Code="M6112", Description= "NETWORK-OUT: CXML Send Failure/Retrying", ColorClass = "danger" }; break;
            case "M6113": statusDisplayCode = new StatusDisplayCode() { Code="M6113", Description= "ECGRID-CONF: AS2 MDN Rejected", ColorClass = "danger" }; break;
            case "M6120": statusDisplayCode = new StatusDisplayCode() { Code="M6120", Description= "NETWORK-OUT: AS2 Send Aborted", ColorClass = "danger" }; break;
            case "M6121": statusDisplayCode = new StatusDisplayCode() { Code="M6121", Description= "NETWORK-OUT: GISB/NAESB Send Aborted", ColorClass = "danger" }; break;
            case "M6122": statusDisplayCode = new StatusDisplayCode() { Code="M6122", Description= "NETWORK-OUT: CXML Send Aborted", ColorClass = "danger" }; break;
            case "M7000": statusDisplayCode = new StatusDisplayCode() { Code="M7000", Description= "ECGRID-OUT: Parcel Complete", ColorClass = "success" }; break;
            case "M7500": statusDisplayCode = new StatusDisplayCode() { Code="M7500", Description= "ECGRID-ARC: Parcel Archived", ColorClass = "success" }; break;
        }

        return statusDisplayCode;
    }
}

#endregion

#region StatusDisplayCode

public class StatusDisplayCode
{
    public string Code { get; set; }

    public string Description { get; set; }

    public string ColorClass { get; set; }
}

#endregion
