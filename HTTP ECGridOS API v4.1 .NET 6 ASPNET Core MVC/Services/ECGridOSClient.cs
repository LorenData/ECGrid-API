using System.Data;
using System.Xml.Serialization;
using HTTP_ECGridOS_API_v4._1_.NET_6_ASPNET_Core_MVC.Models;

/*
 * ECGridOS_Client
 * Copyright: Loren Data Corp.
 * Last Updated: 09/28/2022
 * Author: Greg Kolinski
 * Description: Example ECGridOS API HTTP Client to make calls to the ECGridOS API
 *
 * This is starter template to use along with the ECGridOS_Classes for your reference.
 * Provided as Example only, is not Production Code.
 * 
 */

namespace HTTP_ECGridOS_API_v4._1_.NET_6_ASPNET_Core_MVC.Services;

/// <summary>
/// Interface for ECGridOSClient Service
/// </summary>
public interface IECGridOSClient
{
    #region Callback

    Task<CallBackEventIDInfo> CallBackAddEx(string sessionID, int networkID, int mailboxID, int userID, Objects SystemObject, short objectStatus, Direction direction,
        short frequency, short maxRetries, string uRL, HTTPAuthType hTTPAuthentication, string hTTPUser, string hTTPPassword, Status status);
    Task<CallBackEventIDInfo> CallBackEventInfo(string sessionID, int callBackEventID, short queueCount = 100);
    Task<List<CallBackEventIDInfo>> CallBackEventListEx(string sessionID, int networkID, int mailboxID, bool showInactive = false);
    Task<bool> CallBackEventSetStatus(string sessionID, int callBackEventID, Status status);
    Task<List<CallBackQueueIDInfo>> CallBackFailedList(string sessionID, short maxDays = 30);
    Task<List<CallBackQueueIDInfo>> CallBackFailedListEx(string sessionID, int networkID, int mailboxID, short maxDays = 30);
    Task<List<CallBackQueueIDInfo>> CallBackPendingList(string sessionID);
    Task<List<CallBackQueueIDInfo>> CallBackPendingListEx(string sessionID, int networkID, int mailboxID);
    Task<List<CallBackQueueIDInfo>> CallBackPendingListExA(string sessionID, int networkID, int mailboxID, string networkExclude);
    Task<CallBackQueueIDInfo> CallBackQueueInfo(string sessionID, int callBackQueueID);
    Task<CallBackQueueIDInfo> CallBackTest(string sessionID, int callBackQueueID, int parcelID, int interchangeID, int userID);

    #endregion

    #region Carbon Copy

    Task<bool> CarbonCopyActivate(string sessionID, int carbonCopyID);
    Task<int> CarbonCopyAdd(string sessionID, int eCGridIDFrom, int eCGridIDTo, int eCGridIDCCFrom, int eCGridIDCCTo, string gSFrom, string gSTo, string transactionSet);
    Task<int> CarbonCopyAddEx(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo, int eCGridIDCCFrom, int eCGridIDCCTo, string gSFrom, string gSTo, string transactionSet);
    Task<CarbonCopyIDInfo> CarbonCopyInfo(string sessionID, int carbonCopyID);
    Task<List<CarbonCopyIDInfo>> CarbonCopyList(string sessionID, int eCGridIDFrom, int eCGridIDTo, bool showInactive = false);
    Task<List<CarbonCopyIDInfo>> CarbonCopyListEx(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo, bool showInactive = false);
    Task<bool> CarbonCopySuspend(string sessionID, int carbonCopyID);
    Task<bool> CarbonCopyTerminate(string sessionID, int carbonCopyID);

    #endregion

    #region Certificate

    Task<as2CommInfo> CertAddPrivate(string sessionID, int commID, DateTime beginusage, CertificateUsage usage, string partnerAS2ID, byte[] cert, string password);
    Task<as2CommInfo> CertAddPrivateA(string sessionID, int commID, DateTime beginusage, CertificateUsage usage, string partnerAS2ID, string certBase64, string password);
    Task<CommIDInfo> CertificateAddPublic(string sessionID, int commID, CertificateType certType, string keyID, string userID, DateTime beginusage, CertificateUsage usage, string partnerCommID, string partnerURL, byte[] cert);
    Task<CommIDInfo> CertificateAddPublicA(string sessionID, int commID, CertificateType certType, string keyID, string userID, DateTime beginusage, CertificateUsage usage, string partnerCommID, string partnerURL, string certBase64);
    Task<CommIDInfo> CertificateCreatePrivate(string sessionID, int commID, DateTime beginusage, CertificateUsage usage, CertificateSecureHashAlgorithm algorithm, string partnerAS2ID, DateTime expires);
    Task<CommIDInfo> CertificateRenewPrivate(string sessionID, int commID, int certKeyID, int overlapDays, int years, CertificateSecureHashAlgorithm algorithm);
    Task<bool> CertificateTerminate(string sessionID, int commID, int certKeyID);

    #endregion

    #region ChangePassword

    Task<bool> ChangePassword(string sessionID, string oldPassword, string newPassword);

    #endregion

    #region Comm

    Task<CommIDInfo> CommAdd(string sessionID, int networkID, int mailboxID, NetworkGatewayCommChannel commType, int ownerUserID, bool eCGridHosted,
        string identifier, string uRL, string version, bool signData, bool encryptData, bool compressData, ReceiptType receiptType,
        HTTPAuthType hTTPAuthentication, string hTTPUser, string hTTPPassword, UseType useType, DateTime beginDate, DateTime endUsage, Status status);
    Task<bool> CommDefaultMailbox(string sessionID, int commID, int mailboxID);
    Task<List<CommIDInfo>> CommFind(string sessionID, string identifier, NetworkGatewayCommChannel commType, bool privateKeyRequired, UseType useType, bool showInactive);
    Task<CommIDInfo> CommInfo(string sessionID, int commID);
    Task<List<CommIDInfo>> CommList(string sessionID, NetworkGatewayCommChannel commType, bool privateKeyRequired, UseType useType, bool showInactive, bool withCerts);
    Task<List<CommIDInfo>> CommListEx(string sessionID, int networkID, int mailboxID, NetworkGatewayCommChannel commType, bool privateKeyRequired, UseType useType, bool showInactive, bool withCerts);
    Task<List<CommIDInfo>> CommPair(string sessionID, NetworkGatewayCommChannel commType, int eCGridIDFrom, int eCGridIDTo, string defaultID, bool testMode);
    Task<List<CommIDInfo>> CommSetPair(string sessionID, int eCGridIDFrom, int eCGridIDTo, string Identifier1, string Identifier2);
    Task<bool> CommSetStatus(string sessionID, int commID, Status status);
    Task<CommIDInfo> CommUpdate(string sessionID, int commID, int ownerUserID, string identifier, string uRL, string version, bool signData, bool encryptData, bool compressData, ReceiptType receiptType,
        HTTPAuthType hTTPAuthentication, string hTTPUser, string hTTPPassword, UseType useType, DateTime beginDate, DateTime endUsage);
        

    #endregion

    #region Generate APIKey/Password

    Task<string> GenerateAPIKey(string sessionID, int userID);
    Task<string> GeneratePassword(string sessionID, short length = 13);

    #endregion

    #region Interchange

    Task<bool> InterchangeCancel(string sessionID, int interchangeID);
    Task<DateTime> InterchangeDate(string sessionID, string interchangeHeader);
    Task<InterchangeIDInfo> InterchangeHeaderInfo(string sessionID, string interchangeHeader);
    Task<InterchangeIDInfo> InterchangeHeaderInfoB(string sessionID, byte[] interchangeHeader);
    Task<List<InterchangeIDInfo>> InterchangeInBox(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID);
    Task<InterchangeIDInfoCollection> InterchangeInBoxArchive(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID, short pageNo, short recordsPerPage);
    Task<InterchangeIDInfoCollection> InterchangeInBoxArchiveEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID, short pageNo, short recordsPerPage);
    Task<List<InterchangeIDInfo>> InterchangeInBoxBlocked(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo);
    Task<List<InterchangeIDInfo>> InterchangeInBoxBlockedEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo);
    Task<List<InterchangeIDInfo>> InterchangeInBoxEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID);
    Task<List<InterchangeIDInfo>> InterchangeInBoxPending(string sessionID, int eCGridIDFrom, int eCGridIDTo);
    Task<List<InterchangeIDInfo>> InterchangeInBoxPendingEx(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo);
    Task<InterchangeIDInfo> InterchangeInfo(string sessionID, long interchangeID);
    Task<List<ManifestInfo>> InterchangeManifest(string sessionID, long interchangeID);
    Task<List<InterchangeIDInfo>> InterchangeOutBox(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID);
    Task<InterchangeIDInfoCollection> InterchangeOutBoxArchive(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID, short pageNo, short recordsPerPage);
    Task<InterchangeIDInfoCollection> InterchangeOutBoxArchiveEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID, short pageNo, short recordsPerPage);
    Task<List<InterchangeIDInfo>> InterchangeOutBoxBlocked(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo);
    Task<List<InterchangeIDInfo>> InterchangeOutBoxBlockedEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo);
    Task<List<InterchangeIDInfo>> InterchangeOutBoxEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID);
    Task<List<InterchangeIDInfo>> InterchangeOutBoxNoRoute(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo);
    Task<List<InterchangeIDInfo>> InterchangeOutBoxNoRouteEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo);
    Task<List<InterchangeIDInfo>> InterchangeOutBoxPending(string sessionID, int eCGridIDFrom, int eCGridIDTo);
    Task<List<InterchangeIDInfo>> InterchangeOutBoxPendingEx(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo);
    Task<long> InterchangeResend(string sessionID, long interchangeID);

    #endregion

    #region Interconnect

    Task<InterconnectIDInfo> InterconnectAdd(string sessionID, int eCGridID1, int eCGridID2, string reference, string contactName, string contactEMail, bool notifyContact, bool preconfirm, string note);
    Task<bool> InterconnectCancel(string sessionID, int interconnectID, string note, eMailTo eMailTo, string otherEMailAddress);
    Task<DataSet> InterconnectCount(string sessionID, short maxDays);
    Task<DataSet> InterconnectCountEx(string sessionID, int networkID, int mailboxID, int eCGridID, short maxDays);
    Task<InterconnectIDInfo> InterconnectInfo(string sessionID, int interconnectID);
    Task<InterconnectIDInfo> InterconnectInfoGUID(string sessionID, string uniqueID);
    Task<List<InterconnectIDInfo>> InterconnectListByECGridID(string sessionID, int eCGridID1, int eCGridID2);
    Task<List<InterconnectIDInfo>> InterconnectListByStatus(string sessionID, StatusInterconnect status, int eCGridID, short maxDays);
    Task<List<InterconnectIDInfo>> InterconnectListByStatusEx(string sessionID, int networkID, int mailboxID, StatusInterconnect intStatus, int eCGridID, short maxDays);
    Task<bool> InterconnectNote(string sessionID, int interconnectID, AuthLevel authLevel, string note, string attachmentName, byte[] attachmentContent, string eMailTo, string otherEMailAddress);
    Task<List<InterconnectNote>> InterconnectNoteList(string sessionID, int interconnectID);
        
    #endregion

    #region Key Set/Get/List/Remove

    Task<KeyValue> KeyGet(string sessionID, string key, Objects systemObject, int objectID, KeyVisibility visibility = KeyVisibility.Shared);
    Task<List<KeyValue>> KeyList(string sessionID, Objects systemObject, int objectID);
    Task<bool> KeyRemove(string sessionID, string key, Objects systemObject, int objectID, KeyVisibility visibility = KeyVisibility.Shared);
    Task<bool> KeySet(string sessionID, string key, Objects systemObject, int objectID, KeyVisibility visibility, string value, string meta, int daysToLive);

    #endregion

    #region Login/Logout

    Task<string> Login(string username, string password);
    Task<int> Logout(string sessionID);

    #endregion

    #region Mailbox

    Task<bool> MailboxActivate(string sessionID, int mailboxID);
    Task<int> MailboxAdd(string sessionID, string name, int userID);
    Task<int> MailboxAddEx(string sessionID, int networkID, string name, string userID);
    Task<bool> MailboxDeleteOnDownload(string sessionID, int mailboxID, bool deleteOnDownload);
    Task<bool> MailboxDescription(string sessionID, int mailboxID, string description);
    Task<bool> MailboxInBoxTimeout(string sessionID, int mailboxID, short minutes);
    Task<MailboxIDInfo> MailboxInfo(string sessionID, int mailboxID);
    Task<List<MailboxIDInfo>> MailboxList(string sessionID, string name = "");
    Task<List<MailboxIDInfo>> MailboxListEx(string sessionID, int networkID, string name = "");
    Task<bool> MailboxManaged(string sessionID, int mailboxID, bool managed);
    Task<bool> MailboxName(string sessionID, int mailboxID, string name);
    Task<bool> MailboxSetContact(string sessionID, int mailboxID, int userID, NetworkContactType contactType);
    Task<bool> MailboxSuspend(string sessionID, int mailboxID);
    Task<bool> MailboxTerminate(string sessionID, int mailboxID);
    Task<bool> MailboxUse(string sessionID, int mailboxID, UseType useType);
    Task<bool> MailboxX12Delimiters(string sessionID, int mailboxID, byte segTerm, byte elmSep, byte subElmSep);

    #endregion

    #region Mirgation

    Task<int> MigrationAdd(string sessionID, string name, DateTime scheduled, int targetNetworkId, int targetMailboxId, MigrationStatus status);
    Task<int> MigrationAddEx(string sessionID, int networkID, int mailboxID, string name, DateTime scheduled, int targetNetworkId, int targetMailboxId, MigrationStatus status);
    Task<bool> MigrationAddTP(string sessionID, int migrationID, int migrationBatchID, int eCGridID);
    Task<MigrationIDInfo> MigrationInfo(string sessionID, int migrationID, int migrationBatchID);
    Task<List<MigrationIDInfo>> MigrationList(string sessionID, MigrationStatus status, bool showCanceled = false);
    Task<List<MigrationIDInfo>> MigrationListEx(string sessionID, int networkID, int mailboxID, MigrationStatus status, bool showCanceled = false);

    #endregion

    #region Network

    Task<UserIDInfo> NetworkGetContact(string sessionID, int networkID, NetworkContactType contactType);
    Task<NetworkIDInfo> NetworkInfo(string sessionID, int networkID);
    Task<NetworkIDInfo> NetworkInfoWithLog(string sessionID, int networkID);
    Task<List<NetworkIDInfo>> NetworkList(string sessionID, string name = "");
    Task<List<NetworkIDInfo>> NetworkOutageList(string sessionID);
    Task<bool> NetworkRootDeleteOnDownload(string sessionID, int networkID, bool deleteOnDownload);
    Task<bool> NetworkSetContact(string sessionID, int networkID, int userID, NetworkContactType contactType);
    Task<bool> NetworkSetWebsite(string sessionID, int networkID, string uRL, NetworkWebsiteType websiteType);
    Task<DataSet> NetworkStatusSummary(string sessionID, bool showInactive);
    Task<bool> NetworkUpdate(string sessionID, int networkID, string name, string location);
    Task<bool> NetworkX12Delimiters(string sessionID, int networkID, byte segTerm, byte elmSep, byte subElmSep);

    #endregion

    #region NowUTC

    Task<DateTime> NowUTC();

    #endregion

    #region Parcel

    Task<bool> ParcelAcknowledgmentNote(string sessionID, long parcelID, string subject, string note);
    Task<Models.FileInfo> ParcelDownload(string sessionID, long parcelID);
    Task<Models.FileInfo> ParcelDownloadA(string sessionID, long parcelID);
    Task<bool> ParcelDownloadCancel(string sessionID, long parcelID);
    Task<bool> ParcelDownloadConfirm(string sessionID, long parcelID);
    Task<bool> ParcelDownloadConfirmPendingAck(string sessionID, long parcelID, ParcelStatus status);
    Task<Models.FileInfo> ParcelDownloadNoUpdate(string sessionID, long parcelID);
    Task<Models.FileInfo> ParcelDownloadNoUpdateA(string sessionID, long parcelID);
    Task<bool> ParcelDownloadReset(string sessionID, long parcelID);
    Task<string> ParcelDownloadS3(string sessionID, long parcelID, string accessKey, string secretKey, string bucket, string prefix, string region);
    Task<List<ParcelIDInfo>> ParcelFindMailbagControlID(string sessionID, int networkID, int mailboxID, string mailbagControlID);
    Task<ParcelIDInfoCollection> ParcelInBox(string sessionID);
    Task<ParcelIDInfoCollection> ParcelInBoxArchive(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage);
    Task<ParcelIDInfoCollection> ParcelInBoxArchiveDescEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage);
    Task<ParcelIDInfoCollection> ParcelInBoxArchiveEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage);
    Task<ParcelIDInfoCollection> ParcelInBoxArchiveExShort(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage);
    Task<ParcelIDInfoCollection> ParcelInBoxEx(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo);
    Task<ParcelIDInfoCollection> ParcelInBoxExShort(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo, ParcelStatus status);
    Task<ParcelIDInfo> ParcelInfo(string sessionID, long parcelID);
    Task<List<ManifestInfo>> ParcelManifest(string sessionID, long parcelID);
    Task<List<ParcelNote>> ParcelNoteList(string sessionID, long parcelID);
    Task<ParcelIDInfoCollection> ParcelOutBoxArchive(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage);
    Task<ParcelIDInfoCollection> ParcelOutBoxArchiveDescEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage);
    Task<ParcelIDInfoCollection> ParcelOutBoxArchiveEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage);
    Task<ParcelIDInfoCollection> ParcelOutBoxArchiveExShort(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage);
    Task<ParcelIDInfoCollection> ParcelOutBoxError(string sessionID, DateTime beginDate, DateTime endDate);
    Task<ParcelIDInfoCollection> ParcelOutBoxErrorEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate);
    Task<ParcelIDInfoCollection> ParcelOutBoxInProcess(string sessionID);
    Task<ParcelIDInfoCollection> ParcelOutBoxInProcessEx(string sessionID, int networkID, int mailboxID);
    Task<bool> ParcelSetMailbagControlID(string sessionID, long parcelID, string mailbagControlID);
    Task<int> ParcelTest(string sessionID, int eCGridIDFrom, int eCGridIDTo, EDIStandard documentType);
    Task<bool> ParcelUpdateLocalStatus(string sessionID, long parcelID, short status);
    Task<bool> ParcelUpdateStatus(string sessionID, long parcelID, ParcelStatus status, bool transLogOnly);
    Task<int> ParcelUpload(string sessionID, string fileName, int bytes, byte[] content);
    Task<int> ParcelUploadA(string sessionID, string fileName, string contentBase64);
    Task<int> ParcelUploadEx(string sessionID, int networkID, int mailboxID, string fileName, int bytes, byte[] content);
    Task<int> ParcelUploadExA(string sessionID, int networkID, int mailboxID, string fileName, string contentBase64);
    Task<int> ParcelUploadMft(string sessionID, string fileName, int bytes, byte[] content, int eCGridIDFrom, int eCGridIDTo);
    Task<int> ParcelUploadMftA(string sessionID, string fileName, string contentBase64, int eCGridIDFrom, int eCGridIDTo);

    #endregion

    #region Report

    Task<DataSet> ReportInstantStats(string sessionID, short minutes1, short minutes2);
    Task<DataSet> ReportInstantStatsEx(string sessionID, int networkID, int mailboxID, int eCGridID, short minutes1, short minutes2);
    Task<DataSet> ReportInterchangeStats(string sessionID, DateTime startTime, DateTime endTime, Direction direction);
    Task<DataSet> ReportInterchangeStatsEx(string sessionID, DateTime startTime, DateTime endTime, Direction direction, int networkID, int mailboxID);
    Task<DataSet> ReportMailboxStats(string sessionID);
    Task<DataSet> ReportMailboxStatsEx(string sessionID, int networkID, int mailboxID);
    Task<DataSet> ReportMonthly(string sessionID, short report, DateTime month);
    Task<DataSet> ReportMonthlyEx(string sessionID, int networkID, int mailboxID, short report, DateTime month);
    Task<DataSet> ReportTrafficStats(string sessionID, DateTime targetTime, short numPeriod, StatisticsPeriod period);
    Task<DataSet> ReportTrafficStatsEx(string sessionID, int networkID, int mailboxID, DateTime targetTime, short numPeriod, StatisticsPeriod period);
    Task<DataSet> ReportTrafficStatsPublic();

    #endregion

    #region Session

    Task<List<SessionLogInfo>> SessionLog(string sessionID, short maxRecords);
    Task<SessionLogInfo> SessionLogCurrent(string sessionID);
    Task<List<SessionLogInfo>> SessionLogEx(string sessionID, int userID, DateTime startTime, DateTime endTime, short maxRecords);

    #endregion

    #region Status

    Task<List<StatusInfo>> StatusList(string sessionID);

    #endregion

    #region Trading Partner

    Task<bool> TPActivate(string sessionID, int ecgridID);
    Task<int> TPAdd(string sessionID, string qualifier, string id, string description);
    Task<int> TPAddEx(string sessionID, int networkID, int mailboxID, string qualifier, string id, string description, RoutingGroup routingGroup);
    Task<int> TPAddVAN(string sessionID, int networkID, string qualifier, string id, string description);
    Task<List<ECGridIDInfo>> TPFindEx(string sessionID, int networkID, int mailboxID, string description, bool showInactive = false);
    Task<ECGridIDInfo> TPGetMailboxDefault(string sessionID, int networkID, int mailboxID);
    Task<ECGridIDInfo> TPInfo(string sessionID, int ecgridID);
    Task<List<ECGridIDInfo>> TPList(string sessionID, bool showInactive = false);
    Task<List<ECGridIDInfo>> TPListByOwner(string sessionID, int ownerUserID, OrderBy orderBy, bool showInactive = false, short pageSize = 25, short pageNumber = 1);
    Task<List<ECGridIDInfo>> TPListEx(string sessionID, int networkID, int mailboxID, bool showInactive = false);
    Task<List<ECGridIDInfo>> TPListExPaged(string sessionID, int networkID, int mailboxID, bool showInactive = false, short pageSize = 25, short pageNumber = 1);
    Task<int> TPMove(string sessionID, int ecgridID, DateTime moveDateTime);
    Task<int> TPMoveEx(string sessionID, int networkID, int mailboxID, int ecgridID, DateTime moveDateTime);
    Task<int> TPMoveMailbox(string sessionID, int ecgridID, int mailboxID);
    Task<List<ECGridIDInfo>> TPSearch(string sessionID, string qualifier, string id, bool showInactive = false);
    Task<List<ECGridIDInfo>> TPSearchEx(string sessionID, int networkID, int mailboxID, string qualifier, string id, bool showInactive = false);
    Task<bool> TPSetMailboxDefault(string sessionID, int ecgridID);
    Task<bool> TPSetOwner(string sessionID, int ecgridID, int ownerUserID);
    Task<bool> TPSetRoutingGroup(string sessionID, int ecgridID, RoutingGroup routingGroup);
    Task<bool> TPSuspend(string sessionID, int ecgridID);
    Task<bool> TPTerminate(string sessionID, int ecgridID);
    Task<bool> TPUpdateDataEMail(string sessionID, int ecgridID, EMailSystem eMailSystem, string dataEMail, EMailPayload payloadPosition);
    Task<bool> TPUpdateDescription(string sessionID, int ecgridID, string description);

    #endregion

    #region User

    Task<bool> UserActivate(string sessionID, int userID);
    Task<int> UserAdd(string sessionID, int mailboxID,
        string loginName, string password, string recoveryQuestion, string recoveryAnswer,
        string firstName, string lastName, string company, string eMail, string phone,
        string cellPhone = "", CellCarrier cellCarrier = CellCarrier.Undefined, AuthLevel authLevel = AuthLevel.MailboxUser);
    Task<int> UserAddEx(string sessionID, int networkID, int mailboxID,
        string loginName, string password, string recoveryQuestion, string recoveryAnswer,
        string firstName, string lastName, string company, string eMail, string phone,
        string cellPhone = "", CellCarrier cellCarrier = CellCarrier.Undefined, AuthLevel authLevel = AuthLevel.MailboxUser);
    Task<string> UserGetAPIKey(string sessionID, int userID);
    Task<UserIDInfo> UserInfo(string sessionID, int userID);
    Task<UserIDInfo> UserInfobyLogin(string sessionID, string loginname = "");
    Task<List<UserIDInfo>> UserList(string sessionID, string name = "");
    Task<List<UserIDInfo>> UserListEx(string sessionID, int networkID, int mailboxID, string name = "");
    Task<List<UserIDInfo>> UserListLockedOut(string sessionID);
    Task<List<UserIDInfo>> UserListLockedOutEx(string sessionID, int networkID, int mailboxID);
    Task<bool> UserPassword(string sessionID, int userID, string currentRecoveryAnswer, string password, string recoveryQuestion, string recoveryAnswer);
    Task<bool> UserReset(string sessionID, int userID);
    Task<bool> UserSendSMS(string sessionID, int userID, string text);
    Task<bool> UserSetAuthLevel(string sessionID, int userID, AuthLevel authLevel);
    Task<bool> UserSetNetworkMailbox(string sessionID, int userID, int networkID, int mailboxID);
    Task<bool> UserSuspend(string sessionID, int userID);
    Task<bool> UserTerminate(string sessionID, int userID);
    Task<bool> UserUpdate(string sessionID, int userID,
        string firstName, string lastName, string company, string eMail, string phone,
        string cellPhone, CellCarrier cellCarrier, AuthLevel authLevel);

    #endregion

    #region Version, WhoAmI, X400Format

    Task<string> Version();
    Task<SessionInfo> WhoAmI(string sessionID);
    Task<string> X400Format(string Country, string ADMD, string PRMD, string Organization,
        string OrganizationalUnit1, string OrganizationalUnit2, string OrganizationalUnit3, string OrganizationalUnit4,
        string Surname, string GivenName, string Initials, string Generation, string CommonName,
        string DDA, string X121, string NID, string TTY, string TID);

    #endregion
}

/// <summary>
/// ECGridOS Client Service
/// </summary>
public class ECGridOSClient : IECGridOSClient
{
    #region Class Variables

    private readonly HttpClient _client;
    private readonly string domain_name = "https://os.ecgrid.io/";

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor for the ECGridOS Client
    /// </summary>
    /// <param name="client">httpclient to use for connecting to ECGridOS</param>
    public ECGridOSClient(HttpClient client)
    {
        _client = client;
    }

    #endregion

    #region Callback

    public async Task<CallBackEventIDInfo> CallBackAddEx(string sessionID, int networkID, int mailboxID, int userID, Objects SystemObject, short objectStatus, Direction direction,
        short frequency, short maxRetries, string uRL, HTTPAuthType hTTPAuthentication, string hTTPUser, string hTTPPassword, Status status)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "UserID", userID.ToString() },
                { "SystemObject", SystemObject.ToString() },
                { "ObjectStatus", objectStatus.ToString() },
                { "Direction", direction.ToString() },
                { "Frequency", frequency.ToString() },
                { "MaxRetries", maxRetries.ToString() },
                { "URL", uRL },
                { "HTTPAuthentication", hTTPAuthentication.ToString() },
                { "HTTPUser", hTTPUser },
                { "HTTPPassword", hTTPPassword },
                { "Status", status.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackAddEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CallBackEventIDInfo), domain_name);
                return (CallBackEventIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<CallBackEventIDInfo> CallBackEventInfo(string sessionID, int callBackEventID, short queueCount = 100)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CallBackEventID", callBackEventID.ToString() },
                { "QueueCount", queueCount.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackEventInfo"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CallBackEventIDInfo), domain_name);
                return (CallBackEventIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CallBackEventIDInfo>> CallBackEventListEx(string sessionID, int networkID, int mailboxID, bool showInactive = false)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ShowInactive", showInactive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackEventListEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CallBackEventIDInfo>), domain_name);
                return (List<CallBackEventIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> CallBackEventSetStatus(string sessionID, int callBackEventID, Status status)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CallBackEventID", callBackEventID.ToString() },
                { "Status", status.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackEventSetStatus"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<List<CallBackQueueIDInfo>> CallBackFailedList(string sessionID, short maxDays = 30)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MaxDays", maxDays.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackFailedList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CallBackQueueIDInfo>), domain_name);
                return (List<CallBackQueueIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CallBackQueueIDInfo>> CallBackFailedListEx(string sessionID, int networkID, int mailboxID, short maxDays = 30)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                    { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "MaxDays", maxDays.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackFailedListEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CallBackQueueIDInfo>), domain_name);
                return (List<CallBackQueueIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CallBackQueueIDInfo>> CallBackPendingList(string sessionID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackPendingList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CallBackQueueIDInfo>), domain_name);
                return (List<CallBackQueueIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CallBackQueueIDInfo>> CallBackPendingListEx(string sessionID, int networkID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                    { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackPendingListEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CallBackQueueIDInfo>), domain_name);
                return (List<CallBackQueueIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CallBackQueueIDInfo>> CallBackPendingListExA(string sessionID, int networkID, int mailboxID, string networkExclude)
    {
        try
        {
            // Post Form Parameters NetworkExclude
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "NetworkExclude", networkExclude }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackPendingListExA"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CallBackQueueIDInfo>), domain_name);
                return (List<CallBackQueueIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<CallBackQueueIDInfo> CallBackQueueInfo(string sessionID, int callBackQueueID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CallBackQueueID", callBackQueueID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackQueueInfo"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CallBackQueueIDInfo), domain_name);
                return (CallBackQueueIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<CallBackQueueIDInfo> CallBackTest(string sessionID, int callBackQueueID, int parcelID, int interchangeID, int userID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CallBackQueueID", callBackQueueID.ToString() },
                { "ParcelID", parcelID.ToString() },
                { "InterchangeID", interchangeID.ToString() },
                { "UserID", userID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CallBackTest"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CallBackQueueIDInfo), domain_name);
                return (CallBackQueueIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    #endregion 

    #region Carbon Copy

    public async Task<bool> CarbonCopyActivate(string sessionID, int carbonCopyID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CarbonCopyID", carbonCopyID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CarbonCopyActivate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<int> CarbonCopyAdd(string sessionID, int eCGridIDFrom, int eCGridIDTo, int eCGridIDCCFrom, int eCGridIDCCTo, string gSFrom, string gSTo, string transactionSet)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "ECGridIDCCFrom", eCGridIDCCFrom.ToString() },
                { "ECGridIDCCTo", eCGridIDCCTo.ToString() },
                { "GSFrom", gSFrom },
                { "GSTo", gSTo },
                { "TransactionSet", transactionSet }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CarbonCopyAdd"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    public async Task<int> CarbonCopyAddEx(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo, int eCGridIDCCFrom, int eCGridIDCCTo, string gSFrom, string gSTo, string transactionSet)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "ECGridIDCCFrom", eCGridIDCCFrom.ToString() },
                { "ECGridIDCCTo", eCGridIDCCTo.ToString() },
                { "GSFrom", gSFrom },
                { "GSTo", gSTo },
                { "TransactionSet", transactionSet }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CarbonCopyAddEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    public async Task<CarbonCopyIDInfo> CarbonCopyInfo(string sessionID, int carbonCopyID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CarbonCopyID", carbonCopyID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CarbonCopyInfo"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CarbonCopyIDInfo), domain_name);
                return (CarbonCopyIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CarbonCopyIDInfo>> CarbonCopyList(string sessionID, int eCGridIDFrom, int eCGridIDTo, bool showInactive = false)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "ShowInactive", showInactive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CarbonCopyList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CarbonCopyIDInfo>), domain_name);
                return (List<CarbonCopyIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CarbonCopyIDInfo>> CarbonCopyListEx(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo, bool showInactive = false)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "ShowInactive", showInactive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CarbonCopyListEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CarbonCopyIDInfo>), domain_name);
                return (List<CarbonCopyIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> CarbonCopySuspend(string sessionID, int carbonCopyID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CarbonCopyID", carbonCopyID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CarbonCopySuspend"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> CarbonCopyTerminate(string sessionID, int carbonCopyID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CarbonCopyID", carbonCopyID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CarbonCopyTerminate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    #endregion

    #region Certificate

    public async Task<as2CommInfo> CertAddPrivate(string sessionID, int commID, DateTime beginusage, CertificateUsage usage, string partnerAS2ID, byte[] cert, string password)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() },
                { "BeginUsage", beginusage.ToUniversalTime().ToString() },
                { "Usage", usage.ToString() },
                { "PartnerAS2ID", partnerAS2ID },
                { "Cert", cert?.ToString() },
                { "Password", password }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CertAddPrivate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(as2CommInfo), domain_name);
                return (as2CommInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<as2CommInfo> CertAddPrivateA(string sessionID, int commID, DateTime beginusage, CertificateUsage usage, string partnerAS2ID, string certBase64, string password)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() },
                { "BeginUsage", beginusage.ToUniversalTime().ToString() },
                { "Usage", usage.ToString() },
                { "PartnerAS2ID", partnerAS2ID },
                { "CertBase64", certBase64 },
                { "Password", password }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CertAddPrivateA"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(as2CommInfo), domain_name);
                return (as2CommInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<CommIDInfo> CertificateAddPublic(string sessionID, int commID, CertificateType certType, string keyID, string userID, DateTime beginusage, CertificateUsage usage, string partnerCommID, string partnerURL, byte[] cert)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() },
                { "CertType", certType.ToString() },
                { "KeyId", keyID?.ToString() },
                { "UserId", userID?.ToString() },
                { "BeginUsage", beginusage.ToUniversalTime().ToString() },
                { "Usage", usage.ToString() },
                { "PartnerCommID", partnerCommID },
                { "PartnerURL", partnerURL },
                { "Cert", cert?.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CertificateAddPublic"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CommIDInfo), domain_name);
                return (CommIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<CommIDInfo> CertificateAddPublicA(string sessionID, int commID, CertificateType certType, string keyID, string userID, DateTime beginusage, CertificateUsage usage, string partnerCommID, string partnerURL, string certBase64)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() },
                { "CertType", certType.ToString() },
                { "KeyId", keyID?.ToString() },
                { "UserId", userID?.ToString() },
                { "BeginUsage", beginusage.ToUniversalTime().ToString() },
                { "Usage", usage.ToString() },
                { "PartnerCommID", partnerCommID },
                { "PartnerURL", partnerURL },
                { "CertBase64", certBase64?.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CertificateAddPublicA"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CommIDInfo), domain_name);
                return (CommIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<CommIDInfo> CertificateCreatePrivate(string sessionID, int commID, DateTime beginusage, CertificateUsage usage, CertificateSecureHashAlgorithm algorithm, string partnerAS2ID, DateTime expires)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() },
                { "BeginUsage", beginusage.ToUniversalTime().ToString() },
                { "Usage", usage.ToString() },
                { "SecureHashAlgorithm", algorithm.ToString() },
                { "PartnerAS2ID", partnerAS2ID },
                { "Expires", expires.ToUniversalTime().ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CertificateCreatePrivate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CommIDInfo), domain_name);
                return (CommIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<CommIDInfo> CertificateRenewPrivate(string sessionID, int commID, int certKeyID, int overlapDays, int years, CertificateSecureHashAlgorithm algorithm)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() },
                { "CertKeyID", certKeyID.ToString() },
                { "OverlapDays", overlapDays.ToString() },
                { "Years", years.ToString() },
                { "SecureHashAlgorithm", algorithm.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CertificateRenewPrivate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CommIDInfo), domain_name);
                return (CommIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> CertificateTerminate(string sessionID, int commID, int certKeyID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() },
                { "CertKeyID", certKeyID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CertificateTerminate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    #endregion

    #region ChangePassword

    public async Task<bool> ChangePassword(string sessionID, string oldPassword, string newPassword)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "OldPassword", oldPassword },
                { "NewPassword", newPassword }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ChangePassword"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    #endregion

    #region Comm

    public async Task<CommIDInfo> CommAdd(string sessionID, int networkID, int mailboxID, NetworkGatewayCommChannel commType, int ownerUserID, bool eCGridHosted,
        string identifier, string uRL, string version,
        bool signData, bool encryptData, bool compressData, ReceiptType receiptType,
        HTTPAuthType hTTPAuthentication, string hTTPUser, string hTTPPassword,
        UseType useType, DateTime beginDate, DateTime endUsage, Status status)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString()},
                { "CommType", commType.ToString() },
                { "OwnerUserID", ownerUserID.ToString() },
                { "ECGridHosted", eCGridHosted.ToString() },
                { "Identifier", identifier },
                { "URL", uRL },
                { "Version", version },
                { "SignData", signData.ToString() },
                { "EncryptData", encryptData.ToString() },
                { "CompressData", compressData.ToString() },
                { "ReceiptType", receiptType.ToString() },
                { "HTTPAuthentication", hTTPAuthentication.ToString() },
                { "HTTPUser", hTTPUser },
                { "HTTPPassword", hTTPPassword },
                { "UseType", useType.ToString() },
                { "BeginUsage", beginDate.ToUniversalTime().ToString() },
                { "EndUsage", endUsage.ToUniversalTime().ToString() },
                { "Status", status.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CommAdd"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CommIDInfo), domain_name);
                return (CommIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> CommDefaultMailbox(string sessionID, int commID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CommDefaultMailbox"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<List<CommIDInfo>> CommFind(string sessionID, string identifier, NetworkGatewayCommChannel commType, bool privateKeyRequired, UseType useType, bool showInactive)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Identifier", identifier },
                { "CommType", commType.ToString()},
                { "PrivateKeyRequired", privateKeyRequired.ToString() },
                { "UseType", useType.ToString() },
                { "ShowInactive", showInactive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CommFind"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CommIDInfo>), domain_name);
                return (List<CommIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<CommIDInfo> CommInfo(string sessionID, int commID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CommInfo"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CommIDInfo), domain_name);
                return (CommIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CommIDInfo>> CommList(string sessionID, NetworkGatewayCommChannel commType, bool privateKeyRequired, UseType useType, bool showInactive, bool withCerts)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommType", commType.ToString()},
                { "PrivateKeyRequired", privateKeyRequired.ToString() },
                { "UseType", useType.ToString() },
                { "ShowInactive", showInactive.ToString() },
                { "WithCerts", withCerts.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CommList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CommIDInfo>), domain_name);
                return (List<CommIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CommIDInfo>> CommListEx(string sessionID, int networkID, int mailboxID, NetworkGatewayCommChannel commType, bool privateKeyRequired, UseType useType, bool showInactive, bool withCerts)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString()},
                { "CommType", commType.ToString()},
                { "PrivateKeyRequired", privateKeyRequired.ToString() },
                { "UseType", useType.ToString() },
                { "ShowInactive", showInactive.ToString() },
                { "WithCerts", withCerts.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CommListEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CommIDInfo>), domain_name);
                return (List<CommIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CommIDInfo>> CommPair(string sessionID, NetworkGatewayCommChannel commType, int eCGridIDFrom, int eCGridIDTo, string defaultID, bool testMode)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommType", commType.ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "DefaultID", defaultID },
                { "TestMode", testMode.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CommPair"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CommIDInfo>), domain_name);
                return (List<CommIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<CommIDInfo>> CommSetPair(string sessionID, int eCGridIDFrom, int eCGridIDTo, string Identifier1, string Identifier2)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "Identifier1", Identifier1 },
                { "Identifier2", Identifier2 }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CommSetPair"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<CommIDInfo>), domain_name);
                return (List<CommIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<CommIDInfo> CommUpdate(string sessionID, int commID, int ownerUserID, string identifier, string uRL, string version,
        bool signData, bool encryptData, bool compressData, ReceiptType receiptType,
        HTTPAuthType hTTPAuthentication, string hTTPUser, string hTTPPassword,
        UseType useType, DateTime beginDate, DateTime endUsage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() },
                { "OwnerUserID", ownerUserID.ToString() },
                { "Identifier", identifier },
                { "URL", uRL },
                { "Version", version },
                { "SignData", signData.ToString() },
                { "EncryptData", encryptData.ToString() },
                { "CompressData", compressData.ToString() },
                { "ReceiptType", receiptType.ToString() },
                { "HTTPAuthentication", hTTPAuthentication.ToString() },
                { "HTTPUser", hTTPUser },
                { "HTTPPassword", hTTPPassword },
                { "UseType", useType.ToString() },
                { "BeginUsage", beginDate.ToUniversalTime().ToString() },
                { "EndUsage", endUsage.ToUniversalTime().ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CommUpdate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(CommIDInfo), domain_name);
                return (CommIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> CommSetStatus(string sessionID, int commID, Status status)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "CommID", commID.ToString() },
                { "Status", status.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}CommSetStatus"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    #endregion

    #region Generate APIKey/Password

    /// <summary>
    /// ECGridOS GenerateAPIKey API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <returns>String</returns>
    public async Task<string> GenerateAPIKey(string sessionID, int userID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}GenerateAPIKey"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(string), domain_name);
                return (string)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return "";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return "";
        }
    }

    /// <summary>
    /// ECGridOS GeneratePassword API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="length"></param>
    /// <returns>String</returns>
    public async Task<string> GeneratePassword(string sessionID, short length = 13)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Length", length.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}GeneratePassword"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(string), domain_name);
                return (string)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return error;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return ex.ToString();
        }
    }

    #endregion

    #region Interchange

    public async Task<bool> InterchangeCancel(string sessionID, int interchangeID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterchangeID", interchangeID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeCancel"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<DateTime> InterchangeDate(string sessionID, string interchangeHeader)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterchangeHeader", interchangeHeader }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeDate"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DateTime), domain_name);
                return (DateTime)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return new DateTime();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return new DateTime();
        }
    }

    public async Task<InterchangeIDInfo> InterchangeHeaderInfo(string sessionID, string interchangeHeader)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterchangeHeader", interchangeHeader }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeHeaderInfo"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterchangeIDInfo), domain_name);
                return (InterchangeIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<InterchangeIDInfo> InterchangeHeaderInfoB(string sessionID, byte[] interchangeHeader)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterchangeHeader", interchangeHeader?.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeHeaderInfoB"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterchangeIDInfo), domain_name);
                return (InterchangeIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeInBox(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "InterchangeControlID", interchangeControlID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeInBox"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<InterchangeIDInfoCollection> InterchangeInBoxArchive(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID, short pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "InterchangeControlID", interchangeControlID },
                { "PageNo", pageNo.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeInBoxArchive"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterchangeIDInfoCollection), domain_name);
                return (InterchangeIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<InterchangeIDInfoCollection> InterchangeInBoxArchiveEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID, short pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "InterchangeControlID", interchangeControlID },
                { "PageNo", pageNo.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeInBoxArchiveEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterchangeIDInfoCollection), domain_name);
                return (InterchangeIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeInBoxBlocked(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeInBoxBlocked"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeInBoxBlockedEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeInBoxBlockedEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeInBoxEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "InterchangeControlID", interchangeControlID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeInBoxEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeInBoxPending(string sessionID, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeInBoxPending"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeInBoxPendingEx(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeInBoxPendingEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<InterchangeIDInfo> InterchangeInfo(string sessionID, long interchangeID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterchangeID", interchangeID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeInfo"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterchangeIDInfo), domain_name);
                return (InterchangeIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<ManifestInfo>> InterchangeManifest(string sessionID, long interchangeID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterchangeID", interchangeID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeManifest"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ManifestInfo>), domain_name);
                return (List<ManifestInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeOutBox(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "InterchangeControlID", interchangeControlID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeOutBox"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<InterchangeIDInfoCollection> InterchangeOutBoxArchive(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID, short pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "InterchangeControlID", interchangeControlID },
                { "PageNo", pageNo.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeOutBoxArchive"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterchangeIDInfoCollection), domain_name);
                return (InterchangeIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<InterchangeIDInfoCollection> InterchangeOutBoxArchiveEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID, short pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "InterchangeControlID", interchangeControlID },
                { "PageNo", pageNo.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeOutBoxArchiveEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterchangeIDInfoCollection), domain_name);
                return (InterchangeIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeOutBoxBlocked(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeOutBoxBlocked"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeOutBoxBlockedEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeOutBoxBlockedEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeOutBoxEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string interchangeControlID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "InterchangeControlID", interchangeControlID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeOutBoxEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream); 
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeOutBoxNoRoute(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeOutBoxNoRoute"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream); 
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeOutBoxNoRouteEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeOutBoxNoRouteEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeOutBoxPending(string sessionID, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeOutBoxPending"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterchangeIDInfo>> InterchangeOutBoxPendingEx(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeOutBoxPendingEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterchangeIDInfo>), domain_name);
                return (List<InterchangeIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<long> InterchangeResend(string sessionID, long interchangeID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterchangeID", interchangeID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterchangeResend"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterchangeIDStatus), domain_name);
                InterchangeIDStatus intStatus = (InterchangeIDStatus)serializer.Deserialize(stream_reader);
                return intStatus.Id;
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    #endregion

    #region Interconnect

    public async Task<InterconnectIDInfo> InterconnectAdd(string sessionID, int eCGridID1, int eCGridID2, string reference, string contactName, string contactEMail, bool notifyContact, bool preconfirm, string note)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID1", eCGridID1.ToString() },
                { "ECGridID2", eCGridID2.ToString() },
                { "Reference", reference },
                { "ContactName", contactName },
                { "ContactEMail", contactEMail },
                { "NotifyContact", notifyContact.ToString() },
                { "Preconfirm", preconfirm.ToString() },
                { "Note", note },
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectAdd"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterconnectIDInfo), domain_name);
                return (InterconnectIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> InterconnectCancel(string sessionID, int interconnectID, string note, eMailTo eMailTo, string otherEMailAddress)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterconnectID", interconnectID.ToString() },
                { "Note", note },
                { "EMailTo", eMailTo.ToString() },
                { "OtherEMailAddress", otherEMailAddress }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectCancel"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<DataSet> InterconnectCount(string sessionID, short maxDays)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MaxDays", maxDays.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectCount"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> InterconnectCountEx(string sessionID, int networkID, int mailboxID, int eCGridID, short maxDays)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ECGridID", eCGridID.ToString() },
                { "MaxDays", maxDays.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectCountEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<InterconnectIDInfo> InterconnectInfo(string sessionID, int interconnectID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterconnectID", interconnectID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectInfo"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterconnectIDInfo), domain_name);
                return (InterconnectIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<InterconnectIDInfo> InterconnectInfoGUID(string sessionID, string uniqueID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UniqueID", uniqueID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectInfoGUID"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(InterconnectIDInfo), domain_name);
                return (InterconnectIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterconnectIDInfo>> InterconnectListByECGridID(string sessionID, int eCGridID1, int eCGridID2)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID1", eCGridID1.ToString() },
                { "ECGridID2", eCGridID2.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectListByECGridID"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterconnectIDInfo>), domain_name);
                return (List<InterconnectIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterconnectIDInfo>> InterconnectListByStatus(string sessionID, StatusInterconnect status, int eCGridID, short maxDays)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Status", status.ToString() },
                { "ECGridID", eCGridID.ToString() },
                { "MaxDays", maxDays.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectListByStatus"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterconnectIDInfo>), domain_name);
                return (List<InterconnectIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<InterconnectIDInfo>> InterconnectListByStatusEx(string sessionID, int networkID, int mailboxID, StatusInterconnect intStatus, int eCGridID, short maxDays)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "IntStatus", intStatus.ToString() },
                { "ECGridID", eCGridID.ToString() },
                { "MaxDays", maxDays.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectListByStatusEx"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterconnectIDInfo>), domain_name);
                return (List<InterconnectIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> InterconnectNote(string sessionID, int interconnectID, AuthLevel authLevel, string note, string attachmentName, byte[] attachmentContent, string eMailTo, string otherEMailAddress)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterconnectID", interconnectID.ToString() },
                { "AuthLevel", authLevel.ToString() },
                { "Note", note },
                { "AttachmentName", attachmentName },
                { "AttachmentContent", attachmentContent?.ToString() },
                { "EMailTo", eMailTo },
                { "OtherEMailAddress", otherEMailAddress }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectNote"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<List<InterconnectNote>> InterconnectNoteList(string sessionID, int interconnectID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "InterconnectID", interconnectID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}InterconnectNoteList"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<InterconnectNote>), domain_name);
                return (List<InterconnectNote>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    #endregion

    #region Key Set/Get

    /// <summary>
    /// ECGridOS KeyGet API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="key"></param>
    /// <param name="systemObject"></param>
    /// <param name="objectID"></param>
    /// <param name="visibility"></param>
    /// <returns>KeyValue</returns>
    public async Task<KeyValue> KeyGet(string sessionID, string key, Objects systemObject, int objectID, KeyVisibility visibility = KeyVisibility.Shared)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Key", key },
                { "SystemObject", systemObject.ToString() },
                { "ObjectID", objectID.ToString() },
                { "Visibility", visibility.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}KeyGet"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(KeyValue), domain_name);
                return (KeyValue)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS KeyList API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="systemObject"></param>
    /// <param name="objectID"></param>
    /// <returns>List of KeyValue Objects</returns>
    public async Task<List<KeyValue>> KeyList(string sessionID, Objects systemObject, int objectID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "SystemObject", systemObject.ToString() },
                { "ObjectID", objectID.ToString() },
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}KeyList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<KeyValue>), domain_name);
                return (List<KeyValue>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS KeyRemove API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="key"></param>
    /// <param name="systemObject"></param>
    /// <param name="objectID"></param>
    /// <param name="visibility"></param>
    /// <returns>True/False</returns>
    public async Task<bool> KeyRemove(string sessionID, string key, Objects systemObject, int objectID, KeyVisibility visibility = KeyVisibility.Shared)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Key", key },
                { "SystemObject", systemObject.ToString() },
                { "ObjectID", objectID.ToString() },
                { "Visibility", visibility.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}KeyRemove"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS KeySet API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="key"></param>
    /// <param name="systemObject"></param>
    /// <param name="objectID"></param>
    /// <param name="visibility"></param>
    /// <param name="value"></param>
    /// <param name="meta"></param>
    /// <param name="daysToLive"></param>
    /// <returns>True/False</returns>
    public async Task<bool> KeySet(string sessionID, string key, Objects systemObject, int objectID, KeyVisibility visibility, string value, string meta, int daysToLive)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Key", key },
                { "SystemObject", systemObject.ToString() },
                { "ObjectID", objectID.ToString() },
                { "Visibility", visibility.ToString() },
                { "Value", value },
                { "Meta", meta },
                { "DaysToLive", daysToLive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}KeySet"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    #endregion

    #region Login/Logout

    /// <summary>
    /// ECGridOS Login API Call
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns>string SessionID</returns>
    public async Task<string> Login(string username, string password)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "LoginName", username },
                { "Password", password }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}Login"),
                Content = new FormUrlEncodedContent(parameters),
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(string), domain_name);
                return (string)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return error;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return ex.ToString();
        }
    }

    /// <summary>
    /// ECGridOS Logout API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <returns>int</returns>
    public async Task<int> Logout(string sessionID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}Logout"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    #endregion

    #region Mailbox

    /// <summary>
    /// ECGridOS MailboxActivate API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="mailbox_id"></param>
    /// <returns>True/False</returns>
    public async Task<bool> MailboxActivate(string sessionID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxActivate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS MailboxAdd API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="name"></param>
    /// <param name="user_id"></param>
    /// <returns>Mailbox ID</returns>
    public async Task<int> MailboxAdd(string sessionID, string name, int userID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Name", name },
                { "UserID", userID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxAdd"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    /// <summary>
    /// ECGridOS MailboxAddEx API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="network_id"></param>
    /// <param name="name"></param>
    /// <param name="user_id"></param>
    /// <returns>Mailbox ID</returns>
    public async Task<int> MailboxAddEx(string sessionID, int networkID, string name, string userID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "Name", name },
                { "UserID", userID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxAddEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    /// <summary>
    /// ECGridOS MailboxDeleteOnDownload API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="mailbox_id"></param>
    /// <param name="deleteOnDownload"></param>
    /// <returns>True/False</returns>
    public async Task<bool> MailboxDeleteOnDownload(string sessionID, int mailboxID, bool deleteOnDownload)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() },
                { "DeleteOnDownload", deleteOnDownload.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxDeleteOnDownload"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS MailboxDescription API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="mailbox_id"></param>
    /// <param name="description"></param>
    /// <returns>True/False</returns>
    public async Task<bool> MailboxDescription(string sessionID, int mailboxID, string description)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() },
                { "Description", description }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxDescription"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS MailboxInBoxTimeout API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="mailbox_id"></param>
    /// <param name="minutes"></param>
    /// <returns>True/False</returns>
    public async Task<bool> MailboxInBoxTimeout(string sessionID, int mailboxID, short minutes)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() },
                { "Minutes", minutes.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxInBoxTimeout"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS MailboxInfo API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="mailboxID"></param>
    /// <returns>SessionInfo</returns>
    public async Task<MailboxIDInfo> MailboxInfo(string sessionID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxInfo"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(MailboxIDInfo), domain_name);
                return (MailboxIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS MailboxList API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="name"></param>
    /// <returns>SessionInfo</returns>
    public async Task<List<MailboxIDInfo>> MailboxList(string sessionID, string name = "")
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Name", name }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<MailboxIDInfo>), domain_name);
                return (List<MailboxIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS MailboxListEx API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="name"></param>
    /// <returns>SessionInfo</returns>
    public async Task<List<MailboxIDInfo>> MailboxListEx(string sessionID, int networkID, string name = "")
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "Name", name }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxListEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<MailboxIDInfo>), domain_name);
                return (List<MailboxIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> MailboxManaged(string sessionID, int mailboxID, bool managed)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() },
                { "Managed", managed.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxManaged"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS MailboxName API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="mailbox_id"></param>
    /// <param name="name"></param>
    /// <returns>True/False</returns>
    public async Task<bool> MailboxName(string sessionID, int mailboxID, string name)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() },
                { "Name", name }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxName"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> MailboxSetContact(string sessionID, int mailboxID, int userID, NetworkContactType contactType)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() },
                { "UserID", userID.ToString() },
                { "ContactType", contactType.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxSetContact"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> MailboxSuspend(string sessionID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxSuspend"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> MailboxTerminate(string sessionID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxTerminate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> MailboxUse(string sessionID, int mailboxID, UseType useType)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() },
                { "UseType", useType.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxUse"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> MailboxX12Delimiters(string sessionID, int mailboxID, byte segTerm, byte elmSep, byte subElmSep)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() },
                { "SegTerm", segTerm.ToString() },
                { "ElmSep", elmSep.ToString() },
                { "SubElmSep", subElmSep.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MailboxX12Delimiters"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    #endregion

    #region Mirgation

    public async Task<int> MigrationAdd(string sessionID, string name, DateTime scheduled, int targetNetworkId, int targetMailboxId, MigrationStatus status)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Name", name },
                { "Scheduled", scheduled.ToUniversalTime().ToString() },
                { "TargetNetworkId", targetNetworkId.ToString() },
                { "TargetMailboxId", targetMailboxId.ToString() },
                { "Status", status.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MigrationAdd"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    public async Task<int> MigrationAddEx(string sessionID, int networkID, int mailboxID, string name, DateTime scheduled, int targetNetworkId, int targetMailboxId, MigrationStatus status)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "Name", name },
                { "Scheduled", scheduled.ToUniversalTime().ToString() },
                { "TargetNetworkId", targetNetworkId.ToString() },
                { "TargetMailboxId", targetMailboxId.ToString() },
                { "Status", status.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MigrationAddEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    public async Task<bool> MigrationAddTP(string sessionID, int migrationID, int migrationBatchID, int eCGridID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MigrationID", migrationID.ToString() },
                { "MigrationBatchID", migrationBatchID.ToString() },
                { "ECGridID", eCGridID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MigrationAddTP"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<MigrationIDInfo> MigrationInfo(string sessionID, int migrationID, int migrationBatchID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MigrationID", migrationID.ToString() },
                { "MigrationBatchID", migrationBatchID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MigrationInfo"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(MigrationIDInfo), domain_name);
                return (MigrationIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<MigrationIDInfo>> MigrationList(string sessionID, MigrationStatus status, bool showCanceled = false)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Status", status.ToString() },
                { "ShowCanceled", showCanceled.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MigrationList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<MigrationIDInfo>), domain_name);
                return (List<MigrationIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<MigrationIDInfo>> MigrationListEx(string sessionID, int networkID, int mailboxID, MigrationStatus status, bool showCanceled = false)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "Status", status.ToString() },
                { "ShowCanceled", showCanceled.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}MigrationListEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<MigrationIDInfo>), domain_name);
                return (List<MigrationIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    #endregion

    #region Network

    public async Task<UserIDInfo> NetworkGetContact(string sessionID, int networkID, NetworkContactType contactType)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "ContactType", contactType.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkGetContact"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(UserIDInfo), domain_name);
                return (UserIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS NetworkInfo API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="networkID"></param>
    /// <returns>SessionInfo</returns>
    public async Task<NetworkIDInfo> NetworkInfo(string sessionID, int networkID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkInfo"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(NetworkIDInfo), domain_name);
                return (NetworkIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<NetworkIDInfo> NetworkInfoWithLog(string sessionID, int networkID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkInfoWithLog"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(NetworkIDInfo), domain_name);
                return (NetworkIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS NetworkList API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="name"></param>
    /// <returns>SessionInfo</returns>
    public async Task<List<NetworkIDInfo>> NetworkList(string sessionID, string name = "")
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Name", name }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<NetworkIDInfo>), domain_name);
                return (List<NetworkIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<NetworkIDInfo>> NetworkOutageList(string sessionID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkOutageList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<NetworkIDInfo>), domain_name);
                return (List<NetworkIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> NetworkRootDeleteOnDownload(string sessionID, int networkID, bool deleteOnDownload)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "DeleteOnDownload", deleteOnDownload.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkRootDeleteOnDownload"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> NetworkSetContact(string sessionID, int networkID, int userID, NetworkContactType contactType)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "UserID", userID.ToString() },
                { "ContactType", contactType.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkSetContact"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> NetworkSetWebsite(string sessionID, int networkID, string uRL, NetworkWebsiteType websiteType)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "URL", uRL },
                { "WebsiteType", websiteType.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkSetWebsite"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<DataSet> NetworkStatusSummary(string sessionID, bool showInactive)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ShowInactive", showInactive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkStatusSummary"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> NetworkUpdate(string sessionID, int networkID, string name, string location)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "Name", name },
                { "Location", location },
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkUpdate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> NetworkX12Delimiters(string sessionID, int networkID, byte segTerm, byte elmSep, byte subElmSep)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "SegTerm", segTerm.ToString() },
                { "ElmSep", elmSep.ToString() },
                { "SubElmSep", subElmSep.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NetworkX12Delimiters"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    #endregion

    #region NowUTC

    public async Task<DateTime> NowUTC()
    {
        try
        {
            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}NowUTC")
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DateTime), domain_name);
                return (DateTime)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return new DateTime();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return new DateTime();
        }
    }

    #endregion

    #region Parcel

    public async Task<bool> ParcelAcknowledgmentNote(string sessionID, long parcelID, string subject, string note)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() },
                { "Subject", subject },
                { "Note", note }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelAcknowledgmentNote"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<Models.FileInfo> ParcelDownload(string sessionID, long parcelID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelDownload"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(Models.FileInfo), domain_name);
                return (Models.FileInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<Models.FileInfo> ParcelDownloadA(string sessionID, long parcelID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelDownloadA"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(Models.FileInfo), domain_name);
                return (Models.FileInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> ParcelDownloadCancel(string sessionID, long parcelID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelDownloadCancel"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> ParcelDownloadConfirm(string sessionID, long parcelID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelDownloadConfirm"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> ParcelDownloadConfirmPendingAck(string sessionID, long parcelID, ParcelStatus status)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() },
                { "Status", status.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelDownloadConfirmPendingAck"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<Models.FileInfo> ParcelDownloadNoUpdate(string sessionID, long parcelID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelDownloadNoUpdate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(Models.FileInfo), domain_name);
                return (Models.FileInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<Models.FileInfo> ParcelDownloadNoUpdateA(string sessionID, long parcelID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelDownloadNoUpdateA"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(Models.FileInfo), domain_name);
                return (Models.FileInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> ParcelDownloadReset(string sessionID, long parcelID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelDownloadReset"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<string> ParcelDownloadS3(string sessionID, long parcelID, string accessKey, string secretKey, string bucket, string prefix, string region)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() },
                { "AccessKey", accessKey },
                { "SecretKey", secretKey },
                { "Bucket", bucket },
                { "Prefix", prefix },
                { "Region", region }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelDownloadS3"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(string), domain_name);
                return (string)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<ParcelIDInfo>> ParcelFindMailbagControlID(string sessionID, int networkID, int mailboxID, string mailbagControlID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "MailbagControlID", mailbagControlID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelFindMailbagControlID"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ParcelIDInfo>), domain_name);
                return (List<ParcelIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelInBox(string sessionID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelInBox"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelInBoxArchive(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "MailbagControlID", mailbagControlID },
                { "PageNo", pageNo?.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelInBoxArchive"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelInBoxArchiveDescEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "MailbagControlID", mailbagControlID },
                { "PageNo", pageNo?.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelInBoxArchiveDescEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelInBoxArchiveEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "MailbagControlID", mailbagControlID },
                { "PageNo", pageNo?.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelInBoxArchiveEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelInBoxArchiveExShort(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "MailbagControlID", mailbagControlID },
                { "PageNo", pageNo?.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelInBoxArchiveExShort"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelInBoxEx(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelInBoxEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelInBoxExShort(string sessionID, int networkID, int mailboxID, int eCGridIDFrom, int eCGridIDTo, ParcelStatus status)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "Status", status.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelInBoxExShort"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfo> ParcelInfo(string sessionID, long parcelID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelInfo"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfo), domain_name);
                return (ParcelIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<ManifestInfo>> ParcelManifest(string sessionID, long parcelID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelManifest"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ManifestInfo>), domain_name);
                return (List<ManifestInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<ParcelNote>> ParcelNoteList(string sessionID, long parcelID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelNoteList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ParcelNote>), domain_name);
                return (List<ParcelNote>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelOutBoxArchive(string sessionID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "MailbagControlID", mailbagControlID },
                { "PageNo", pageNo?.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelOutBoxArchive"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelOutBoxArchiveDescEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "MailbagControlID", mailbagControlID },
                { "PageNo", pageNo?.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelOutBoxArchiveDescEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelOutBoxArchiveEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "MailbagControlID", mailbagControlID },
                { "PageNo", pageNo?.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelOutBoxArchiveEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelOutBoxArchiveExShort(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate, int eCGridIDFrom, int eCGridIDTo, string mailbagControlID, string pageNo, short recordsPerPage)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "MailbagControlID", mailbagControlID },
                { "PageNo", pageNo?.ToString() },
                { "RecordsPerPage", recordsPerPage.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelOutBoxArchiveExShort"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelOutBoxError(string sessionID, DateTime beginDate, DateTime endDate)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelOutBoxError"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelOutBoxErrorEx(string sessionID, int networkID, int mailboxID, DateTime beginDate, DateTime endDate)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "BeginDate", beginDate.ToUniversalTime().ToString() },
                { "EndDate", endDate.ToUniversalTime().ToString() },
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelOutBoxErrorEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelOutBoxInProcess(string sessionID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelOutBoxInProcess"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<ParcelIDInfoCollection> ParcelOutBoxInProcessEx(string sessionID, int networkID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelOutBoxInProcessEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ParcelIDInfoCollection), domain_name);
                return (ParcelIDInfoCollection)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<bool> ParcelSetMailbagControlID(string sessionID, long parcelID, string mailbagControlID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() },
                { "MailbagControlID", mailbagControlID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelSetMailbagControlID"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<int> ParcelTest(string sessionID, int eCGridIDFrom, int eCGridIDTo, EDIStandard documentType)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() },
                { "DocumentType", documentType.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelTest"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    public async Task<bool> ParcelUpdateLocalStatus(string sessionID, long parcelID, short status)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() },
                { "Status", status.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelUpdateLocalStatus"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<bool> ParcelUpdateStatus(string sessionID, long parcelID, ParcelStatus status, bool transLogOnly)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ParcelID", parcelID.ToString() },
                { "Status", status.ToString() },
                { "TransLogOnly", transLogOnly.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelUpdateStatus"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    public async Task<int> ParcelUpload(string sessionID, string fileName, int bytes, byte[] content)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "FileName", fileName },
                { "Bytes", bytes.ToString() },
                { "Content", content?.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelUpload"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    public async Task<int> ParcelUploadA(string sessionID, string fileName, string contentBase64)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "FileName", fileName },
                { "ContentBase64", contentBase64 }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelUploadA"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    public async Task<int> ParcelUploadEx(string sessionID, int networkID, int mailboxID, string fileName, int bytes, byte[] content)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "FileName", fileName },
                { "Bytes", bytes.ToString() },
                { "Content", content?.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelUploadEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    public async Task<int> ParcelUploadExA(string sessionID, int networkID, int mailboxID, string fileName, string contentBase64)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "FileName", fileName },
                { "ContentBase64", contentBase64 }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelUploadExA"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    public async Task<int> ParcelUploadMft(string sessionID, string fileName, int bytes, byte[] content, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "FileName", fileName },
                { "Bytes", bytes.ToString() },
                { "Content", content?.ToString() },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelUploadMft"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    public async Task<int> ParcelUploadMftA(string sessionID, string fileName, string contentBase64, int eCGridIDFrom, int eCGridIDTo)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "FileName", fileName },
                { "ContentBase64", contentBase64 },
                { "ECGridIDFrom", eCGridIDFrom.ToString() },
                { "ECGridIDTo", eCGridIDTo.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ParcelUploadMftA"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    #endregion

    #region Report

    public async Task<DataSet> ReportInstantStats(string sessionID, short minutes1, short minutes2)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Minutes1", minutes1.ToString() },
                { "Minutes2", minutes2.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportInstantStats"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> ReportInstantStatsEx(string sessionID, int networkID, int mailboxID, int eCGridID, short minutes1, short minutes2)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ECGridID", eCGridID.ToString() },
                { "Minutes1", minutes1.ToString() },
                { "Minutes2", minutes2.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportInstantStatsEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> ReportInterchangeStats(string sessionID, DateTime startTime, DateTime endTime, Direction direction)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "StartTime", startTime.ToUniversalTime().ToString() },
                { "EndTime", endTime.ToUniversalTime().ToString() },
                { "Direction", direction.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportInterchangeStats"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> ReportInterchangeStatsEx(string sessionID, DateTime startTime, DateTime endTime, Direction direction, int networkID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "StartTime", startTime.ToUniversalTime().ToString() },
                { "EndTime", endTime.ToUniversalTime().ToString() },
                { "Direction", direction.ToString() },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportInterchangeStatsEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> ReportMailboxStats(string sessionID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportMailboxStats"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> ReportMailboxStatsEx(string sessionID, int networkID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportMailboxStatsEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> ReportMonthly(string sessionID, short report, DateTime month)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Report", report.ToString() },
                { "Month", month.ToUniversalTime().ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportMonthly"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> ReportMonthlyEx(string sessionID, int networkID, int mailboxID, short report, DateTime month)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "Report", report.ToString() },
                { "Month", month.ToUniversalTime().ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportMonthlyEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> ReportTrafficStats(string sessionID, DateTime targetTime, short numPeriod, StatisticsPeriod period)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "TargetTime", targetTime.ToUniversalTime().ToString() },
                { "NumPeriods", numPeriod.ToString() },
                { "Period", period.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportTrafficStats"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> ReportTrafficStatsEx(string sessionID, int networkID, int mailboxID, DateTime targetTime, short numPeriod, StatisticsPeriod period)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "TargetTime", targetTime.ToUniversalTime().ToString() },
                { "NumPeriods", numPeriod.ToString() },
                { "Period", period.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportTrafficStatsEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<DataSet> ReportTrafficStatsPublic()
    {
        try
        {
            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}ReportTrafficStatsPublic")
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(DataSet), domain_name);
                return (DataSet)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    #endregion

    #region Session

    public async Task<List<SessionLogInfo>> SessionLog(string sessionID, short maxRecords)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MaxRecords", maxRecords.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}SessionLog"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<SessionLogInfo>), domain_name);
                return (List<SessionLogInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<SessionLogInfo> SessionLogCurrent(string sessionID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}SessionLogCurrent"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(SessionLogInfo), domain_name);
                return (SessionLogInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    public async Task<List<SessionLogInfo>> SessionLogEx(string sessionID, int userID, DateTime startTime, DateTime endTime, short maxRecords)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() },
                { "StartTime", startTime.ToUniversalTime().ToString() },
                { "EndTime", endTime.ToUniversalTime().ToString() },
                { "MaxRecords", maxRecords.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}SessionLogEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<SessionLogInfo>), domain_name);
                return (List<SessionLogInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    #endregion

    #region Status

    public async Task<List<StatusInfo>> StatusList(string sessionID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}StatusList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<StatusInfo>), domain_name);
                return (List<StatusInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    #endregion

    #region Trading Partner

    /// <summary>
    /// ECGridOS TPActivate API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ecgrid_id"></param>
    /// <returns>True/False</returns>
    public async Task<bool> TPActivate(string sessionID, int ecgridID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPActivate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS TPAdd API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="qualifier"></param>
    /// <param name="id"></param>
    /// <param name="description"></param>
    /// <returns>ECGrid ID</returns>
    public async Task<int> TPAdd(string sessionID, string qualifier, string id, string description)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Qualifier", qualifier },
                { "ID", id },
                { "Description", description }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPAdd"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    /// <summary>
    /// ECGridOS TPAddEx API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="networkID"></param>
    /// <param name="mailboxID"></param>
    /// <param name="qualifier"></param>
    /// <param name="id"></param>
    /// <param name="description"></param>
    /// <param name="routingGroup">ProductionA or ProductionB or Migration1 or Migration2 or NetOpsOnly1 or NetOpsOnly2 or ManagedFileTransfer or SuperHub or Test or Suspense1 or Suspense2 or Suspense3</param>
    /// <returns>ECGrid ID</returns>
    public async Task<int> TPAddEx(string sessionID, int networkID, int mailboxID,
        string qualifier, string id, string description, RoutingGroup routingGroup)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "Qualifier", qualifier },
                { "ID", id },
                { "Description", description },
                { "RoutingGroup", routingGroup.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPAddEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    /// <summary>
    /// ECGridOS TPAddVAN API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="networkID"></param>
    /// <param name="qualifier"></param>
    /// <param name="id"></param>
    /// <param name="description"></param>
    /// <returns>ECGrid ID</returns>
    public async Task<int> TPAddVAN(string sessionID, int networkID, string qualifier, string id, string description)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "Qualifier", qualifier },
                { "ID", id },
                { "Description", description }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPAddVAN"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    /// <summary>
    /// ECGridOS TPFindEx API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="networkID"></param>
    /// <param name="mailboxID"></param>
    /// <param name="description"></param>
    /// <param name="showInactive"></param>
    /// <returns>List of ECGrid ID</returns>
    public async Task<List<ECGridIDInfo>> TPFindEx(string sessionID, int networkID, int mailboxID, string description, bool showInactive = false)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "Description", description },
                { "ShowInactive", showInactive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPFindEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ECGridIDInfo>), domain_name);
                return (List<ECGridIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS TPGetMailboxDefault API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="networkID"></param>
    /// <param name="mailboxID"></param>
    /// <returns>ECGridIDInfo</returns>
    public async Task<ECGridIDInfo> TPGetMailboxDefault(string sessionID, int networkID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPGetMailboxDefault"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ECGridIDInfo), domain_name);
                return (ECGridIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS TP Info API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ecgrid_id"></param>
    /// <returns>ECGridIDInfo</returns>
    public async Task<ECGridIDInfo> TPInfo(string sessionID, int ecgridID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPInfo"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(ECGridIDInfo), domain_name);
                return (ECGridIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS TPList API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="show_inactive"></param>
    /// <returns>List of ECGridIDInfo</returns>
    public async Task<List<ECGridIDInfo>> TPList(string sessionID, bool showInactive = false)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ShowInactive", showInactive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ECGridIDInfo>), domain_name);
                return (List<ECGridIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS TPListByOwner API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ownerUserID"></param>
    /// <param name="orderBy"></param>
    /// <param name="show_inactive"></param>
    /// <param name="pageSize"></param>
    /// <param name="pageNumber"></param>
    /// <returns>List of ECGridIDInfo</returns>
    public async Task<List<ECGridIDInfo>> TPListByOwner(string sessionID, int ownerUserID, OrderBy orderBy, bool showInactive = false, short pageSize = 25, short pageNumber = 1)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "OwnerUserID", ownerUserID.ToString() },
                { "OrderBy", orderBy.ToString() },
                { "ShowInactive", showInactive.ToString() },
                { "PageSize", pageSize.ToString() },
                { "PageNumber", pageNumber.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPListByOwner"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ECGridIDInfo>), domain_name);
                return (List<ECGridIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS TPListEx API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="network_id"></param>
    /// <param name="mailbox_id"></param>
    /// <param name="show_inactive"></param>
    /// <returns>List of ECGridIDInfo</returns>
    public async Task<List<ECGridIDInfo>> TPListEx(string sessionID, int networkID, int mailboxID, bool showInactive = false)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ShowInactive", showInactive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPListEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ECGridIDInfo>), domain_name);
                return (List<ECGridIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS TPListExPaged API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="network_id"></param>
    /// <param name="mailbox_id"></param>
    /// <param name="show_inactive"></param>
    /// <param name="pageSize"></param>
    /// <param name="pageNumber"></param>
    /// <returns>List of ECGridIDInfo</returns>
    public async Task<List<ECGridIDInfo>> TPListExPaged(string sessionID, int networkID, int mailboxID, bool showInactive = false, short pageSize = 25, short pageNumber = 1)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ShowInactive", showInactive.ToString() },
                { "PageSize", pageSize.ToString() },
                { "PageNumber", pageNumber.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPListExPaged"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ECGridIDInfo>), domain_name);
                return (List<ECGridIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS TPMove API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ecgrid_id"></param>
    /// <param name="moveDateTime"></param>
    /// <returns>int</returns>
    public async Task<int> TPMove(string sessionID, int ecgridID, DateTime moveDateTime)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() },
                { "MoveDateTime", moveDateTime.ToUniversalTime().ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPMove"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    /// <summary>
    /// ECGridOS TPMoveEx API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="network_id"></param>
    /// <param name="mailbox_id"></param>
    /// <param name="ecgrid_id"></param>
    /// <param name="moveDateTime"></param>
    /// <returns>int</returns>
    public async Task<int> TPMoveEx(string sessionID, int networkID, int mailboxID, int ecgridID, DateTime moveDateTime)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "ECGridID", ecgridID.ToString() },
                { "MoveDateTime", moveDateTime.ToUniversalTime().ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPMoveEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    /// <summary>
    /// ECGridOS TPMoveMailbox API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name ="ecgrid_id"></param >
    /// <param name="mailbox_id"></param>
    /// <returns>int</returns>
    public async Task<int> TPMoveMailbox(string sessionID, int ecgridID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPMoveMailbox"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    /// <summary>
    /// ECGridOS TPSearch API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="qualifier"></param>
    /// <param name="id"></param>
    /// <param name="show_inactive"></param>
    /// <returns>List of ECGridIDInfo</returns>
    public async Task<List<ECGridIDInfo>> TPSearch(string sessionID, string qualifier, string id, bool showInactive = false)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Qualifier", qualifier },
                { "ID", id },
                { "ShowInactive", showInactive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPSearch"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ECGridIDInfo>), domain_name);
                return (List<ECGridIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS TPSearchEx API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="network_id"></param>
    /// <param name="mailbox_id"></param>
    /// <param name="qualifier"></param>
    /// <param name="id"></param>
    /// <param name="show_inactive"></param>
    /// <returns>List of ECGridIDInfo</returns>
    public async Task<List<ECGridIDInfo>> TPSearchEx(string sessionID, int networkID, int mailboxID, string qualifier, string id, bool showInactive = false)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "Qualifier", qualifier },
                { "ID", id },
                { "ShowInactive", showInactive.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPSearchEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<ECGridIDInfo>), domain_name);
                return (List<ECGridIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS TPSetMailboxDefault API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ecgrid_id"></param>
    /// <returns>true/false</returns>
    public async Task<bool> TPSetMailboxDefault(string sessionID, int ecgridID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPSetMailboxDefault"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS TPSetOwner API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ecgrid_id"></param>
    /// <param name="ownerUserID"></param>
    /// <returns>true/false</returns>
    public async Task<bool> TPSetOwner(string sessionID, int ecgridID, int ownerUserID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() },
                { "OwnerUserID", ownerUserID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPSetOwner"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS TPSetRoutingGroup API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ecgrid_id"></param>
    /// <param name="routingGroup">ProductionA or ProductionB or Migration1 or Migration2 or NetOpsOnly1 or NetOpsOnly2 or ManagedFileTransfer or SuperHub or Test or Suspense1 or Suspense2 or Suspense3</param>
    /// <returns>true/false</returns>
    public async Task<bool> TPSetRoutingGroup(string sessionID, int ecgridID, RoutingGroup routingGroup)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() },
                { "RoutingGroup", routingGroup.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPSetRoutingGroup"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS TPSuspend API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ecgrid_id"></param>
    /// <returns>true/false</returns>
    public async Task<bool> TPSuspend(string sessionID, int ecgridID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPSuspend"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS TPTerminate API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ecgrid_id"></param>
    /// <returns>true/false</returns>
    public async Task<bool> TPTerminate(string sessionID, int ecgridID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPTerminate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS TPUpdateDataEMail API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ecgrid_id"></param>
    /// <param name="eMailSystem">smtp or x400</param>
    /// <param name="dataEMail"></param>
    /// <param name="payloadPosition">Body or Attachment</param>
    /// <returns>true/false</returns>
    public async Task<bool> TPUpdateDataEMail(string sessionID, int ecgridID, EMailSystem eMailSystem, string dataEMail, EMailPayload payloadPosition)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() },
                { "EMailSystem", eMailSystem.ToString() },
                { "DataEMail", dataEMail },
                { "PayloadPosition", payloadPosition.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPUpdateDataEMail"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS TPUpdateDescription API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="ecgrid_id"></param>
    /// <param name="description"></param>
    /// <returns>true/false</returns>
    public async Task<bool> TPUpdateDescription(string sessionID, int ecgridID, string description)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "ECGridID", ecgridID.ToString() },
                { "Description", description }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}TPUpdateDescription"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    #endregion

    #region User

    /// <summary>
    /// ECGridOS UserActivate API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <returns>True/False</returns>
    public async Task<bool> UserActivate(string sessionID, int userID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserActivate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS UserAdd API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="mailboxID"></param>
    /// <param name="loginName"></param>
    /// <param name="password"></param>
    /// <param name="recoveryQuestion"></param>
    /// <param name="recoveryAnswer"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="company"></param>
    /// <param name="eMail"></param>
    /// <param name="phone"></param>
    /// <param name="cellPhone"></param>
    /// <param name="cellCarrier"></param>
    /// <param name="authLevel"></param>
    /// <returns>ECGrid User ID</returns>
    public async Task<int> UserAdd(string sessionID, int mailboxID,
        string loginName, string password, string recoveryQuestion, string recoveryAnswer,
        string firstName, string lastName, string company, string eMail, string phone,
        string cellPhone = "", CellCarrier cellCarrier = CellCarrier.Undefined, AuthLevel authLevel = AuthLevel.MailboxUser)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "MailboxID", mailboxID.ToString() },
                { "LoginName", loginName },
                { "Password", password },
                { "RecoveryQuestion", recoveryQuestion },
                { "RecoveryAnswer", recoveryAnswer },
                { "FirstName", firstName },
                { "LastName", lastName },
                { "Company", company },
                { "EMail", eMail },
                { "Phone", phone },
                { "CellPhone", cellPhone },
                { "CellCarrier", cellCarrier.ToString() },
                { "AuthLevel", authLevel.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserAdd"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    /// <summary>
    /// ECGridOS UserAddEx API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="networkID"></param>
    /// <param name="mailboxID"></param>
    /// <param name="loginName"></param>
    /// <param name="password"></param>
    /// <param name="recoveryQuestion"></param>
    /// <param name="recoveryAnswer"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="company"></param>
    /// <param name="eMail"></param>
    /// <param name="phone"></param>
    /// <param name="cellPhone"></param>
    /// <param name="cellCarrier"></param>
    /// <param name="authLevel"></param>
    /// <returns>ECGrid User ID</returns>
    public async Task<int> UserAddEx(string sessionID, int networkID, int mailboxID,
        string loginName, string password, string recoveryQuestion, string recoveryAnswer,
        string firstName, string lastName, string company, string eMail, string phone,
        string cellPhone = "", CellCarrier cellCarrier = CellCarrier.Undefined, AuthLevel authLevel = AuthLevel.MailboxUser)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "LoginName", loginName },
                { "Password", password },
                { "RecoveryQuestion", recoveryQuestion },
                { "RecoveryAnswer", recoveryAnswer },
                { "FirstName", firstName },
                { "LastName", lastName },
                { "Company", company },
                { "EMail", eMail },
                { "Phone", phone },
                { "CellPhone", cellPhone },
                { "CellCarrier", cellCarrier.ToString() },
                { "AuthLevel", authLevel.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserAddEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(int), domain_name);
                return (int)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return -1;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return -1;
        }
    }

    /// <summary>
    /// ECGridOS UserGetAPIKey API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <returns>UserInfo</returns>
    public async Task<string> UserGetAPIKey(string sessionID, int userID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserGetAPIKey"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(string), domain_name);
                return (string)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return error;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return ex.ToString();
        }
    }

    /// <summary>
    /// ECGridOS UserInfo API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <returns>UserInfo</returns>
    public async Task<UserIDInfo> UserInfo(string sessionID, int userID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserInfo"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(UserIDInfo), domain_name);
                return (UserIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS UserInfobyLogin API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="loginname"></param>
    /// <returns>UserInfo</returns>
    public async Task<UserIDInfo> UserInfobyLogin(string sessionID, string loginname = "")
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "LoginName", loginname }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserInfobyLogin"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(UserIDInfo), domain_name);
                return (UserIDInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS UserList API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="name"></param>
    /// <returns>List of UserIDInfo</returns>
    public async Task<List<UserIDInfo>> UserList(string sessionID, string name = "")
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "Name", name }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserList"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<UserIDInfo>), domain_name);
                return (List<UserIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS UserListEx API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="networkID"></param>
    /// <param name="mailboxID"></param>
    /// <param name="name"></param>
    /// <returns>List of UserIDInfo</returns>
    public async Task<List<UserIDInfo>> UserListEx(string sessionID, int networkID, int mailboxID, string name = "")
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() },
                { "Name", name }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserListEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<UserIDInfo>), domain_name);
                return (List<UserIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS UserListLockedOut API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <returns>List of UserIDInfo</returns>
    public async Task<List<UserIDInfo>> UserListLockedOut(string sessionID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserListLockedOut"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<UserIDInfo>), domain_name);
                return (List<UserIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS UserListLockedOutEx API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="networkID"></param>
    /// <param name="mailboxID"></param>
    /// <returns>List of UserIDInfo</returns>
    public async Task<List<UserIDInfo>> UserListLockedOutEx(string sessionID, int networkID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserListLockedOutEx"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(List<UserIDInfo>), domain_name);
                return (List<UserIDInfo>)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS UserPassword API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <param name="currentRecoveryAnswer"></param>
    /// <param name="password"></param>
    /// <param name="recoveryQuestion"></param>
    /// <param name="recoveryAnswer"></param>
    /// <returns>True/False</returns>
    public async Task<bool> UserPassword(string sessionID, int userID, string currentRecoveryAnswer, string password, string recoveryQuestion, string recoveryAnswer)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() },
                { "CurrentRecoveryAnswer", currentRecoveryAnswer },
                { "Password", password },
                { "RecoveryQuestion", recoveryQuestion },
                { "RecoveryAnswer", recoveryAnswer }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserPassword"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS UserReset API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <returns>True/False</returns>
    public async Task<bool> UserReset(string sessionID, int userID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserReset"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS UserSendSMS API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <param name="text"></param>
    /// <returns>True/False</returns>
    public async Task<bool> UserSendSMS(string sessionID, int userID, string text)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() },
                { "Text", text }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserSendSMS"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS UserSetAuthLevel API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <param name="authLevel"></param>
    /// <returns>True/False</returns>
    public async Task<bool> UserSetAuthLevel(string sessionID, int userID, AuthLevel authLevel)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() },
                { "AuthLevel", authLevel.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserSetAuthLevel"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS UserSetNetworkMailbox API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <param name="networkID"></param>
    /// <param name="mailboxID"></param>
    /// <returns>True/False</returns>
    public async Task<bool> UserSetNetworkMailbox(string sessionID, int userID, int networkID, int mailboxID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() },
                { "NetworkID", networkID.ToString() },
                { "MailboxID", mailboxID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserSetNetworkMailbox"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS UserSuspend API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <returns>True/False</returns>
    public async Task<bool> UserSuspend(string sessionID, int userID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserSuspend"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS UserTerminate API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <returns>True/False</returns>
    public async Task<bool> UserTerminate(string sessionID, int userID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserTerminate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    /// <summary>
    /// ECGridOS UserUpdate API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <param name="userID"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="company"></param>
    /// <param name="eMail"></param>
    /// <param name="phone"></param>
    /// <param name="cellPhone"></param>
    /// <param name="cellCarrier"></param>
    /// <param name="authLevel"></param>
    /// <returns>ECGrid User ID</returns>
    public async Task<bool> UserUpdate(string sessionID, int userID,
        string firstName, string lastName, string company, string eMail, string phone,
        string cellPhone, CellCarrier cellCarrier, AuthLevel authLevel)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID },
                { "UserID", userID.ToString() },
                { "FirstName", firstName },
                { "LastName", lastName },
                { "Company", company },
                { "EMail", eMail },
                { "Phone", phone },
                { "CellPhone", cellPhone },
                { "CellCarrier", cellCarrier.ToString() },
                { "AuthLevel", authLevel.ToString() }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}UserUpdate"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(bool), domain_name);
                return (bool)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return false;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return false;
        }
    }

    #endregion

    #region Version, WhoAmI, X400Format

    /// <summary>
    /// ECGridOS Version API Call
    /// </summary>
    /// <returns>string - ECGridOS Version Info</returns>
    public async Task<string> Version()
    {
        try
        {
            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}Version")
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(string), domain_name);
                return (string)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return error;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return ex.ToString();
        }
    }

    /// <summary>
    /// ECGridOS WhoAmI API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <returns>SessionInfo</returns>
    public async Task<SessionInfo> WhoAmI(string sessionID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "SessionID", sessionID }
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}WhoAmI"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(SessionInfo), domain_name);
                return (SessionInfo)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

    /// <summary>
    /// ECGridOS X400Format API Call
    /// </summary>
    /// <param name="sessionID"></param>
    /// <returns>string</returns>
    public async Task<string> X400Format(string Country, string ADMD, string PRMD, string Organization,
        string OrganizationalUnit1, string OrganizationalUnit2, string OrganizationalUnit3, string OrganizationalUnit4,
        string Surname, string GivenName, string Initials, string Generation, string CommonName,
        string DDA, string X121, string NID, string TTY, string TID)
    {
        try
        {
            // Post Form Parameters
            var parameters = new Dictionary<string, string> {
                { "Country", Country },
                { "ADMD", ADMD },
                { "PRMD", PRMD },
                { "Organization", Organization },
                { "OrganizationalUnit1", OrganizationalUnit1 },
                { "OrganizationalUnit2", OrganizationalUnit2 },
                { "OrganizationalUnit3", OrganizationalUnit3 },
                { "OrganizationalUnit4", OrganizationalUnit4 },
                { "Surname", Surname },
                { "GivenName", GivenName },
                { "Initials", Initials },
                { "Generation", Generation },
                { "CommonName", CommonName },
                { "DDA", DDA },
                { "X_121", X121},
                { "N_ID", NID },
                { "T_TY", TTY },
                { "T_ID", TID },
            };

            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{_client.BaseAddress}X400Format"),
                Content = new FormUrlEncodedContent(parameters)
            };

            using HttpResponseMessage responseHeader = await _client.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            requestMessage.Dispose();
            if (responseHeader.IsSuccessStatusCode)
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                var serializer = new XmlSerializer(typeof(string), domain_name);
                return (string)serializer.Deserialize(stream_reader);
            }
            else
            {
                using var responseStream = await responseHeader.Content.ReadAsStreamAsync();
                using StreamReader stream_reader = new StreamReader(responseStream);
                string error = await stream_reader.ReadToEndAsync();
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error getting ECGridOS Result.");
            return null;
        }
    }

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