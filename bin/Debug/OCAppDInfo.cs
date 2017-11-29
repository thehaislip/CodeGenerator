using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Infrastructure;
using System.Security.Principal;
using System.Security.Principal;
using System.Security.Claims; 
namespace GeneratedContext
{ 
[Table("OCAppDInfo")]
public partial class OCAppDInfo
:IAuditable{ 
public OCAppDInfo()
{
this.OCDOEAppExpedites = new HashSet<OCDOEAppExpedite>();
this.OCDOEActiveLogons = new HashSet<OCDOEActiveLogon>();
this.OCUCOCommentss = new HashSet<OCUCOComments>();
this.OCDOEPraxisTests = new HashSet<OCDOEPraxisTest>();
this.OCAPPExperienceResponses = new HashSet<OCAPPExperienceResponse>();
this.OCUCOMajorsCns = new HashSet<OCUCOMajorsCn>();
this.OCUCOProfessionalPrepCns = new HashSet<OCUCOProfessionalPrepCn>();
this.OCDOELegalitiess = new HashSet<OCDOELegalities>();
this.OCUCOActiveUsers = new HashSet<OCUCOActiveUser>();
this.OCAPPSubjAssgnCns = new HashSet<OCAPPSubjAssgnCn>();
this.Answers = new HashSet<Answer>();
this.OCDOEAppDInfoToPreparations = new HashSet<OCDOEAppDInfoToPreparation>();
this.OCETSPraxisTests = new HashSet<OCETSPraxisTest>();
this.OCAPPOverrideQueues = new HashSet<OCAPPOverrideQueue>();
this.OCDOEOtherCertss = new HashSet<OCDOEOtherCerts>();
this.OCAPPPraxisTestss = new HashSet<OCAPPPraxisTests>();
this.OCAPPProcessingFees = new HashSet<OCAPPProcessingFee>();
this.OCAPPSectionCompletes = new HashSet<OCAPPSectionComplete>();
this.OCUCOAppSignOffs = new HashSet<OCUCOAppSignOff>();
this.OCDOEAppDInfoToLevels = new HashSet<OCDOEAppDInfoToLevel>();
this.OCAppDInfoToLevels = new HashSet<OCAppDInfoToLevel>();
this.OCDOEAppFlagss = new HashSet<OCDOEAppFlags>();
this.OCAPPAppEducs = new HashSet<OCAPPAppEduc>();
this.OCAppDInfoToEndorsements = new HashSet<OCAppDInfoToEndorsement>();
this.OCAPPRenewMajorsCns = new HashSet<OCAPPRenewMajorsCn>();
this.OCDOESectionComps = new HashSet<OCDOESectionComp>();
this.OCUCOAppDInfoToPreparations = new HashSet<OCUCOAppDInfoToPreparation>();
this.OCAPPProfPrepCns = new HashSet<OCAPPProfPrepCn>();
this.OCDOEOtherNationalCertss = new HashSet<OCDOEOtherNationalCerts>();
this.OCAPPPaymentOptions = new HashSet<OCAPPPaymentOption>();
this.OCAPPOtherNationalCertss = new HashSet<OCAPPOtherNationalCerts>();
this.OCAppDInfoToPreparations = new HashSet<OCAppDInfoToPreparation>();
this.OCUCOEducations = new HashSet<OCUCOEducation>();
this.OCUCOAppDInfoToLevels = new HashSet<OCUCOAppDInfoToLevel>();
this.OCAppDInfoToCertificateTypes = new HashSet<OCAppDInfoToCertificateType>();
this.OCAPPRenewProPrpCns = new HashSet<OCAPPRenewProPrpCn>();
this.OCAPPRenewalTypes = new HashSet<OCAPPRenewalType>();
this.OCAPPUploadChoices = new HashSet<OCAPPUploadChoice>();
this.OCDOETranscriptss = new HashSet<OCDOETranscripts>();
this.OCUCOPraxisTestss = new HashSet<OCUCOPraxisTests>();
this.OCDOEAppDInfoToCertificateTypes = new HashSet<OCDOEAppDInfoToCertificateType>();
this.OCUCOEndorsementCns = new HashSet<OCUCOEndorsementCn>();
this.OCAPPFedHisps = new HashSet<OCAPPFedHisp>();
this.OCUCOAppDInfoToCertificateTypes = new HashSet<OCUCOAppDInfoToCertificateType>();
this.OCUCOSectionCompletes = new HashSet<OCUCOSectionComplete>();
this.OCAPPRenewalCredits = new HashSet<OCAPPRenewalCredit>();
this.OCAPPFedEths = new HashSet<OCAPPFedEth>();
this.OCAPPConReviewCns = new HashSet<OCAPPConReviewCn>();
this.OCAPPPrevLastNames = new HashSet<OCAPPPrevLastName>();
this.OCAPPOtherCertss = new HashSet<OCAPPOtherCerts>();
this.OCDOEConReviewCns = new HashSet<OCDOEConReviewCn>();
}
[Required]
[Column(name:"Address1")]
[StringLength(40)]
public string Address1 {get; set;}
[Column(name:"Address2")]
[StringLength(40)]
public string Address2 {get; set;}
[Column(name:"AppDate",TypeName = "datetime2")]
public DateTime? AppDate {get; set;}
[Column(name:"AppNumber")]
[StringLength(30)]
public string AppNumber {get; set;}
[Column(name:"AppTrue")]
[StringLength(1)]
public string AppTrue {get; set;}
[Column(name:"AppTypeID")]
public int? AppTypeID {get; set;}
[Column(name:"BirthDate",TypeName = "datetime2")]
public DateTime? BirthDate {get; set;}
[Column(name:"Citizenship")]
[StringLength(1)]
public string Citizenship {get; set;}
[Column(name:"CitizenshipCountry")]
[StringLength(100)]
public string CitizenshipCountry {get; set;}
[Required]
[Column(name:"City")]
[StringLength(40)]
public string City {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ContractSignedDistrict")]
[StringLength(60)]
public string ContractSignedDistrict {get; set;}
[Column(name:"ContractSignedFlag")]
[StringLength(1)]
public string ContractSignedFlag {get; set;}
[Required]
[Column(name:"Country")]
[StringLength(30)]
public string Country {get; set;}
[Column(name:"CtryBorn")]
[StringLength(30)]
public string CtryBorn {get; set;}
[Required]
[Column(name:"DayPhone")]
[StringLength(10)]
public string DayPhone {get; set;}
[Column(name:"DOEQueue")]
[StringLength(2)]
public string DOEQueue {get; set;}
[Required]
[Column(name:"Email")]
[StringLength(100)]
public string Email {get; set;}
[Column(name:"EvenPhone")]
[StringLength(10)]
public string EvenPhone {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Required]
[Column(name:"Gender")]
[StringLength(1)]
public string Gender {get; set;}
[Column(name:"HighestDegreeObtainedID")]
public int? HighestDegreeObtainedID {get; set;}
[Column(name:"HoldsNatCertificateFlag")]
[StringLength(1)]
public string HoldsNatCertificateFlag {get; set;}
[Column(name:"HoldsOtherCertificateFlag")]
[StringLength(1)]
public string HoldsOtherCertificateFlag {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IndianStudies")]
public bool? IndianStudies {get; set;}
[Column(name:"InitiatedDate",TypeName = "datetime2")]
public DateTime? InitiatedDate {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(60)]
public string LastName {get; set;}
[Column(name:"MiddleName")]
[StringLength(60)]
public string MiddleName {get; set;}
[Column(name:"MilitarySpouseFlag")]
[StringLength(1)]
public string MilitarySpouseFlag {get; set;}
[Column(name:"MilitarySpouseLeftEmploymentFlag")]
[StringLength(1)]
public string MilitarySpouseLeftEmploymentFlag {get; set;}
[Column(name:"Oath")]
[StringLength(1)]
public string Oath {get; set;}
[Column(name:"OldAppTypeID")]
public int? OldAppTypeID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[Required]
[Column(name:"State")]
[StringLength(40)]
public string State {get; set;}
[Column(name:"Status")]
[StringLength(10)]
public string Status {get; set;}
[Column(name:"SuicidePreventionIndicator")]
public bool? SuicidePreventionIndicator {get; set;}
[Required]
[Column(name:"Zip")]
[StringLength(10)]
public string Zip {get; set;}
[ForeignKey("AppTypeID")]
public virtual ApplicationType ApplicationType{get; set;}
[ForeignKey("HighestDegreeObtainedID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCDOEAppExpedite> OCDOEAppExpedites{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCDOEActiveLogon> OCDOEActiveLogons{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOComments> OCUCOCommentss{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCDOEPraxisTest> OCDOEPraxisTests{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPExperienceResponse> OCAPPExperienceResponses{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOMajorsCn> OCUCOMajorsCns{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOProfessionalPrepCn> OCUCOProfessionalPrepCns{get; set;}
[ForeignKey("ApplicantID")]
public virtual ICollection<OCDOELegalities> OCDOELegalitiess{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOActiveUser> OCUCOActiveUsers{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPSubjAssgnCn> OCAPPSubjAssgnCns{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<Answer> Answers{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCDOEAppDInfoToPreparation> OCDOEAppDInfoToPreparations{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCETSPraxisTest> OCETSPraxisTests{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPOverrideQueue> OCAPPOverrideQueues{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCDOEOtherCerts> OCDOEOtherCertss{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPPraxisTests> OCAPPPraxisTestss{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPProcessingFee> OCAPPProcessingFees{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPSectionComplete> OCAPPSectionCompletes{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOAppSignOff> OCUCOAppSignOffs{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCDOEAppDInfoToLevel> OCDOEAppDInfoToLevels{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAppDInfoToLevel> OCAppDInfoToLevels{get; set;}
[ForeignKey("ApplicationID")]
public virtual ICollection<OCDOEAppFlags> OCDOEAppFlagss{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPAppEduc> OCAPPAppEducs{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAppDInfoToEndorsement> OCAppDInfoToEndorsements{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPRenewMajorsCn> OCAPPRenewMajorsCns{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCDOESectionComp> OCDOESectionComps{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOAppDInfoToPreparation> OCUCOAppDInfoToPreparations{get; set;}
[ForeignKey("ApplicationID")]
public virtual ICollection<OCAPPProfPrepCn> OCAPPProfPrepCns{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCDOEOtherNationalCerts> OCDOEOtherNationalCertss{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPPaymentOption> OCAPPPaymentOptions{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPOtherNationalCerts> OCAPPOtherNationalCertss{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAppDInfoToPreparation> OCAppDInfoToPreparations{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOEducation> OCUCOEducations{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOAppDInfoToLevel> OCUCOAppDInfoToLevels{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAppDInfoToCertificateType> OCAppDInfoToCertificateTypes{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPRenewProPrpCn> OCAPPRenewProPrpCns{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPRenewalType> OCAPPRenewalTypes{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPUploadChoice> OCAPPUploadChoices{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCDOETranscripts> OCDOETranscriptss{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOPraxisTests> OCUCOPraxisTestss{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCDOEAppDInfoToCertificateType> OCDOEAppDInfoToCertificateTypes{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOEndorsementCn> OCUCOEndorsementCns{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPFedHisp> OCAPPFedHisps{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOAppDInfoToCertificateType> OCUCOAppDInfoToCertificateTypes{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCUCOSectionComplete> OCUCOSectionCompletes{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPRenewalCredit> OCAPPRenewalCredits{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPFedEth> OCAPPFedEths{get; set;}
[ForeignKey("ApplicationID")]
public virtual ICollection<OCAPPConReviewCn> OCAPPConReviewCns{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPPrevLastName> OCAPPPrevLastNames{get; set;}
[ForeignKey("AppID")]
public virtual ICollection<OCAPPOtherCerts> OCAPPOtherCertss{get; set;}
[ForeignKey("ApplicationID")]
public virtual ICollection<OCDOEConReviewCn> OCDOEConReviewCns{get; set;}
[ForeignKey("OldAppTypeID")]
public virtual OCAppTypeSupt OCAppTypeSupt{get; set;}
[ForeignKey("PersonnelID")]
public virtual COMMPerson COMMPerson{get; set;}
}
[Table("OCAppDInfoAudit")]
public partial class OCAppDInfoAudit
:IAudit{ 
public OCAppDInfoAudit()
{
}
[Required]
[Column(name:"Address1")]
[StringLength(40)]
public string Address1 {get; set;}
[Column(name:"Address2")]
[StringLength(40)]
public string Address2 {get; set;}
[Column(name:"AppDate",TypeName = "datetime2")]
public DateTime? AppDate {get; set;}
[Column(name:"AppNumber")]
[StringLength(30)]
public string AppNumber {get; set;}
[Column(name:"AppTrue")]
[StringLength(1)]
public string AppTrue {get; set;}
[Column(name:"AppTypeID")]
public int? AppTypeID {get; set;}
[Column(name:"BirthDate",TypeName = "datetime2")]
public DateTime? BirthDate {get; set;}
[Column(name:"Citizenship")]
[StringLength(1)]
public string Citizenship {get; set;}
[Column(name:"CitizenshipCountry")]
[StringLength(100)]
public string CitizenshipCountry {get; set;}
[Required]
[Column(name:"City")]
[StringLength(40)]
public string City {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ContractSignedDistrict")]
[StringLength(60)]
public string ContractSignedDistrict {get; set;}
[Column(name:"ContractSignedFlag")]
[StringLength(1)]
public string ContractSignedFlag {get; set;}
[Required]
[Column(name:"Country")]
[StringLength(30)]
public string Country {get; set;}
[Column(name:"CtryBorn")]
[StringLength(30)]
public string CtryBorn {get; set;}
[Required]
[Column(name:"DayPhone")]
[StringLength(10)]
public string DayPhone {get; set;}
[Column(name:"DOEQueue")]
[StringLength(2)]
public string DOEQueue {get; set;}
[Required]
[Column(name:"Email")]
[StringLength(100)]
public string Email {get; set;}
[Column(name:"EvenPhone")]
[StringLength(10)]
public string EvenPhone {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Required]
[Column(name:"Gender")]
[StringLength(1)]
public string Gender {get; set;}
[Column(name:"HighestDegreeObtainedID")]
public int? HighestDegreeObtainedID {get; set;}
[Column(name:"HoldsNatCertificateFlag")]
[StringLength(1)]
public string HoldsNatCertificateFlag {get; set;}
[Column(name:"HoldsOtherCertificateFlag")]
[StringLength(1)]
public string HoldsOtherCertificateFlag {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IndianStudies")]
public bool? IndianStudies {get; set;}
[Column(name:"InitiatedDate",TypeName = "datetime2")]
public DateTime? InitiatedDate {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(60)]
public string LastName {get; set;}
[Column(name:"MiddleName")]
[StringLength(60)]
public string MiddleName {get; set;}
[Column(name:"MilitarySpouseFlag")]
[StringLength(1)]
public string MilitarySpouseFlag {get; set;}
[Column(name:"MilitarySpouseLeftEmploymentFlag")]
[StringLength(1)]
public string MilitarySpouseLeftEmploymentFlag {get; set;}
[Column(name:"Oath")]
[StringLength(1)]
public string Oath {get; set;}
[Column(name:"OldAppTypeID")]
public int? OldAppTypeID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[Required]
[Column(name:"State")]
[StringLength(40)]
public string State {get; set;}
[Column(name:"Status")]
[StringLength(10)]
public string Status {get; set;}
[Column(name:"SuicidePreventionIndicator")]
public bool? SuicidePreventionIndicator {get; set;}
[Required]
[Column(name:"Zip")]
[StringLength(10)]
public string Zip {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
