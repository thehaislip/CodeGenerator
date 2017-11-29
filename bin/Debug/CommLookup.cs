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
[Table("CommLookup")]
public partial class CommLookup
:IAuditable{ 
public CommLookup()
{
this.IndividualTests = new HashSet<IndividualTest>();
this.CPSubjs = new HashSet<CPSubj>();
this.OCAppDInfos = new HashSet<OCAppDInfo>();
this.FedEths = new HashSet<FedEth>();
this.Certificates = new HashSet<Certificate>();
this.SpEdIndAssgns = new HashSet<SpEdIndAssgn>();
this.AttCtrSSs = new HashSet<AttCtrSS>();
this.AttCtrSS1s = new HashSet<AttCtrSS>();
this.SubAssgns = new HashSet<SubAssgn>();
this.SpedSubjAssgns = new HashSet<SpedSubjAssgn>();
this.CommPersonToMajors = new HashSet<CommPersonToMajor>();
this.OCDOEOtherCertss = new HashSet<OCDOEOtherCerts>();
this.SchoolTypeToPositions = new HashSet<SchoolTypeToPosition>();
this.ApplicationTypes = new HashSet<ApplicationType>();
this.MajAssgns = new HashSet<MajAssgn>();
this.ApplicationType1s = new HashSet<ApplicationType>();
this.MajAssgn1s = new HashSet<MajAssgn>();
this.RevkDrivs = new HashSet<RevkDriv>();
this.GraduateMajorCategoryCnns = new HashSet<GraduateMajorCategoryCnn>();
this.GraduateMajorCategoryCnn1s = new HashSet<GraduateMajorCategoryCnn>();
this.HQTestAssgns = new HashSet<HQTestAssgn>();
this.OCAPPSubjAssgnCns = new HashSet<OCAPPSubjAssgnCn>();
this.CertificateTypeToLevels = new HashSet<CertificateTypeToLevel>();
this.SchoolTypeToPosition1s = new HashSet<SchoolTypeToPosition>();
this.FeeTypes = new HashSet<FeeType>();
this.PRFInfos = new HashSet<PRFInfo>();
this.EndOnlyPhsOuts = new HashSet<EndOnlyPhsOut>();
this.CertificateCompletions = new HashSet<CertificateCompletion>();
this.GradMajCatToAsgns = new HashSet<GradMajCatToAsgn>();
this.GradMajCatToAsgn1s = new HashSet<GradMajCatToAsgn>();
this.StateTests = new HashSet<StateTest>();
this.CSEPrvds = new HashSet<CSEPrvd>();
this.AnswerToCommlookups = new HashSet<AnswerToCommlookup>();
this.StateTest1s = new HashSet<StateTest>();
this.ListGroups = new HashSet<ListGroup>();
this.PRFInfo1s = new HashSet<PRFInfo>();
this.VSCntCrss = new HashSet<VSCntCrs>();
this.DegreeToDegreeTypes = new HashSet<DegreeToDegreeType>();
this.VSCourses = new HashSet<VSCourse>();
this.DegreeToDegreeType1s = new HashSet<DegreeToDegreeType>();
this.VSCourse2016s = new HashSet<VSCourse2016>();
this.SpedMajAssgns = new HashSet<SpedMajAssgn>();
this.Vacancys = new HashSet<Vacancy>();
this.VacPosCnns = new HashSet<VacPosCnn>();
this.VacPosCnn1s = new HashSet<VacPosCnn>();
this.OCAPPRenewMajorsCns = new HashSet<OCAPPRenewMajorsCn>();
this.VSCntCrs1s = new HashSet<VSCntCrs>();
this.ParaQuals = new HashSet<ParaQual>();
this.OCAPPOtherNationalCertss = new HashSet<OCAPPOtherNationalCerts>();
this.ParaStudInfos = new HashSet<ParaStudInfo>();
this.OCAPPPaymentOptions = new HashSet<OCAPPPaymentOption>();
this.CertificateTypeToPreparations = new HashSet<CertificateTypeToPreparation>();
this.CorrDets = new HashSet<CorrDet>();
this.CorrDet1s = new HashSet<CorrDet>();
this.OCDOETranscriptss = new HashSet<OCDOETranscripts>();
this.PRFAssgns = new HashSet<PRFAssgn>();
this.ParaFundingFTEPcts = new HashSet<ParaFundingFTEPct>();
this.PRFAssgn1s = new HashSet<PRFAssgn>();
this.OCDOEOtherNationalCertss = new HashSet<OCDOEOtherNationalCerts>();
this.ParaJobResps = new HashSet<ParaJobResp>();
this.OCDOEScanDocToCorrTypes = new HashSet<OCDOEScanDocToCorrType>();
this.DistrictVacancys = new HashSet<DistrictVacancy>();
this.OCAPPRenewalTypes = new HashSet<OCAPPRenewalType>();
this.Endorsements = new HashSet<Endorsement>();
this.GenPosASs = new HashSet<GenPosAS>();
this.IndivTsts = new HashSet<IndivTst>();
this.CSEAssgns = new HashSet<CSEAssgn>();
this.ParaProfs = new HashSet<ParaProf>();
this.ParaProf1s = new HashSet<ParaProf>();
this.EndorsementRequirements = new HashSet<EndorsementRequirement>();
this.ParaProf1s = new HashSet<ParaProf>();
this.OCUCOSectionCompletes = new HashSet<OCUCOSectionComplete>();
this.Certificate1s = new HashSet<Certificate>();
this.Degrees = new HashSet<Degree>();
this.Degree1s = new HashSet<Degree>();
this.CoreAMajs = new HashSet<CoreAMaj>();
this.CoreAMaj1s = new HashSet<CoreAMaj>();
this.PreparationToCertificates = new HashSet<PreparationToCertificate>();
this.CommLookupTypeToCommLookups = new HashSet<CommLookupTypeToCommLookup>();
this.QuestionAnswerToTriggers = new HashSet<QuestionAnswerToTrigger>();
this.QuestionAnswerToTrigger1s = new HashSet<QuestionAnswerToTrigger>();
this.Certificate1s = new HashSet<Certificate>();
this.Degree1s = new HashSet<Degree>();
this.Degree1s = new HashSet<Degree>();
this.OCAPPOtherCertss = new HashSet<OCAPPOtherCerts>();
this.AssignmentToPositions = new HashSet<AssignmentToPosition>();
this.CPMAJRs = new HashSet<CPMAJR>();
this.AssgnCatCns = new HashSet<AssgnCatCn>();
this.CertCreds = new HashSet<CertCred>();
this.Assignments = new HashSet<Assignment>();
this.OCUCOMajorsCns = new HashSet<OCUCOMajorsCn>();
this.OCUCOProfiles = new HashSet<OCUCOProfile>();
this.OCAPPFedEths = new HashSet<OCAPPFedEth>();
this.POISpedTaskss = new HashSet<POISpedTasks>();
this.PRFAssgnTypeToEndorsements = new HashSet<PRFAssgnTypeToEndorsement>();
this.LevelToCertificates = new HashSet<LevelToCertificate>();
}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Column(name:"DisabledInd")]
public bool? DisabledInd {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("StateID")]
public virtual ICollection<IndividualTest> IndividualTests{get; set;}
[ForeignKey("COMMLookupID")]
public virtual ICollection<CPSubj> CPSubjs{get; set;}
[ForeignKey("HighestDegreeObtainedID")]
public virtual ICollection<OCAppDInfo> OCAppDInfos{get; set;}
[ForeignKey("EthnicityID")]
public virtual ICollection<FedEth> FedEths{get; set;}
[ForeignKey("SnapshotTakenByID")]
public virtual ICollection<Certificate> Certificates{get; set;}
[ForeignKey("PRFAssgnTypeID")]
public virtual ICollection<SpEdIndAssgn> SpEdIndAssgns{get; set;}
[ForeignKey("SchoolTermCodeID")]
public virtual ICollection<AttCtrSS> AttCtrSSs{get; set;}
[ForeignKey("SchoolTypeID")]
public virtual ICollection<AttCtrSS> AttCtrSS1s{get; set;}
[ForeignKey("SubjectAssignmentCodeID")]
public virtual ICollection<SubAssgn> SubAssgns{get; set;}
[ForeignKey("SubjAssgnCodeID")]
public virtual ICollection<SpedSubjAssgn> SpedSubjAssgns{get; set;}
[ForeignKey("MajorID")]
public virtual ICollection<CommPersonToMajor> CommPersonToMajors{get; set;}
[ForeignKey("OtherStateID")]
public virtual ICollection<OCDOEOtherCerts> OCDOEOtherCertss{get; set;}
[ForeignKey("PositionCodeID")]
public virtual ICollection<SchoolTypeToPosition> SchoolTypeToPositions{get; set;}
[ForeignKey("ApplicationTypeID")]
public virtual ICollection<ApplicationType> ApplicationTypes{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<MajAssgn> MajAssgns{get; set;}
[ForeignKey("ApplicationCategoryID")]
public virtual ICollection<ApplicationType> ApplicationType1s{get; set;}
[ForeignKey("MajorCodeID")]
public virtual ICollection<MajAssgn> MajAssgn1s{get; set;}
[ForeignKey("LiceseStatus")]
public virtual ICollection<RevkDriv> RevkDrivs{get; set;}
[ForeignKey("CategoryID")]
public virtual ICollection<GraduateMajorCategoryCnn> GraduateMajorCategoryCnns{get; set;}
[ForeignKey("GradMajorID")]
public virtual ICollection<GraduateMajorCategoryCnn> GraduateMajorCategoryCnn1s{get; set;}
[ForeignKey("AssignID")]
public virtual ICollection<HQTestAssgn> HQTestAssgns{get; set;}
[ForeignKey("COMMLookupID")]
public virtual ICollection<OCAPPSubjAssgnCn> OCAPPSubjAssgnCns{get; set;}
[ForeignKey("CommLookupID")]
public virtual ICollection<CertificateTypeToLevel> CertificateTypeToLevels{get; set;}
[ForeignKey("SchoolTypeID")]
public virtual ICollection<SchoolTypeToPosition> SchoolTypeToPosition1s{get; set;}
[ForeignKey("AnswerID")]
public virtual ICollection<FeeType> FeeTypes{get; set;}
[ForeignKey("NoLongerEmplCode")]
public virtual ICollection<PRFInfo> PRFInfos{get; set;}
[ForeignKey("Level3ID")]
public virtual ICollection<EndOnlyPhsOut> EndOnlyPhsOuts{get; set;}
[ForeignKey("CompletionIndicatorID")]
public virtual ICollection<CertificateCompletion> CertificateCompletions{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<GradMajCatToAsgn> GradMajCatToAsgns{get; set;}
[ForeignKey("GradMajCatID")]
public virtual ICollection<GradMajCatToAsgn> GradMajCatToAsgn1s{get; set;}
[ForeignKey("CategoryID")]
public virtual ICollection<StateTest> StateTests{get; set;}
[ForeignKey("ProviderType")]
public virtual ICollection<CSEPrvd> CSEPrvds{get; set;}
[ForeignKey("CommlookupID")]
public virtual ICollection<AnswerToCommlookup> AnswerToCommlookups{get; set;}
[ForeignKey("CommLookupID")]
public virtual ICollection<StateTest> StateTest1s{get; set;}
[ForeignKey("CommonLookupID")]
public virtual ICollection<ListGroup> ListGroups{get; set;}
[ForeignKey("StatusCodeID")]
public virtual ICollection<PRFInfo> PRFInfo1s{get; set;}
[ForeignKey("VSCourseNameID")]
public virtual ICollection<VSCntCrs> VSCntCrss{get; set;}
[ForeignKey("DegreeID")]
public virtual ICollection<DegreeToDegreeType> DegreeToDegreeTypes{get; set;}
[ForeignKey("VSSchoolTypeID")]
public virtual ICollection<VSCourse> VSCourses{get; set;}
[ForeignKey("DegreeTypeID")]
public virtual ICollection<DegreeToDegreeType> DegreeToDegreeType1s{get; set;}
[ForeignKey("VSCourseID")]
public virtual ICollection<VSCourse2016> VSCourse2016s{get; set;}
[ForeignKey("MajorCodeID")]
public virtual ICollection<SpedMajAssgn> SpedMajAssgns{get; set;}
[ForeignKey("VacOptionID")]
public virtual ICollection<Vacancy> Vacancys{get; set;}
[ForeignKey("VacCategoryID")]
public virtual ICollection<VacPosCnn> VacPosCnns{get; set;}
[ForeignKey("VacPositionID")]
public virtual ICollection<VacPosCnn> VacPosCnn1s{get; set;}
[ForeignKey("MajorID")]
public virtual ICollection<OCAPPRenewMajorsCn> OCAPPRenewMajorsCns{get; set;}
[ForeignKey("ContentAreaID")]
public virtual ICollection<VSCntCrs> VSCntCrs1s{get; set;}
[ForeignKey("QualificationTypeID")]
public virtual ICollection<ParaQual> ParaQuals{get; set;}
[ForeignKey("OtherStateID")]
public virtual ICollection<OCAPPOtherNationalCerts> OCAPPOtherNationalCertss{get; set;}
[ForeignKey("StudentInfoTypeID")]
public virtual ICollection<ParaStudInfo> ParaStudInfos{get; set;}
[ForeignKey("PaymentTypeID")]
public virtual ICollection<OCAPPPaymentOption> OCAPPPaymentOptions{get; set;}
[ForeignKey("CommLookupID")]
public virtual ICollection<CertificateTypeToPreparation> CertificateTypeToPreparations{get; set;}
[ForeignKey("CorrTypeID")]
public virtual ICollection<CorrDet> CorrDets{get; set;}
[ForeignKey("PaymentTypeID")]
public virtual ICollection<CorrDet> CorrDet1s{get; set;}
[ForeignKey("StateID")]
public virtual ICollection<OCDOETranscripts> OCDOETranscriptss{get; set;}
[ForeignKey("LicenseStatusID")]
public virtual ICollection<PRFAssgn> PRFAssgns{get; set;}
[ForeignKey("FundingTypeID")]
public virtual ICollection<ParaFundingFTEPct> ParaFundingFTEPcts{get; set;}
[ForeignKey("PositionCodeID")]
public virtual ICollection<PRFAssgn> PRFAssgn1s{get; set;}
[ForeignKey("OtherStateID")]
public virtual ICollection<OCDOEOtherNationalCerts> OCDOEOtherNationalCertss{get; set;}
[ForeignKey("JobResponsibilityID")]
public virtual ICollection<ParaJobResp> ParaJobResps{get; set;}
[ForeignKey("CorrespondenceTypeID")]
public virtual ICollection<OCDOEScanDocToCorrType> OCDOEScanDocToCorrTypes{get; set;}
[ForeignKey("VacOptionID")]
public virtual ICollection<DistrictVacancy> DistrictVacancys{get; set;}
[ForeignKey("RenewalTypeID")]
public virtual ICollection<OCAPPRenewalType> OCAPPRenewalTypes{get; set;}
[ForeignKey("EndorsementCategoryID")]
public virtual ICollection<Endorsement> Endorsements{get; set;}
[ForeignKey("PositionCodeID")]
public virtual ICollection<GenPosAS> GenPosASs{get; set;}
[ForeignKey("StateID")]
public virtual ICollection<IndivTst> IndivTsts{get; set;}
[ForeignKey("AssgnCodeID")]
public virtual ICollection<CSEAssgn> CSEAssgns{get; set;}
[ForeignKey("HiredID")]
public virtual ICollection<ParaProf> ParaProfs{get; set;}
[ForeignKey("OptionID")]
public virtual ICollection<ParaProf> ParaProf1s{get; set;}
[ForeignKey("PreparationID")]
public virtual ICollection<EndorsementRequirement> EndorsementRequirements{get; set;}
[ForeignKey("ParaSchoolWideTypeID")]
public virtual ICollection<ParaProf> ParaProf2s{get; set;}
[ForeignKey("SectionID")]
public virtual ICollection<OCUCOSectionComplete> OCUCOSectionCompletes{get; set;}
[ForeignKey("StatusID")]
public virtual ICollection<Certificate> Certificate1s{get; set;}
[ForeignKey("InstitutionID")]
public virtual ICollection<Degree> Degrees{get; set;}
[ForeignKey("MajMinID")]
public virtual ICollection<Degree> Degree1s{get; set;}
[ForeignKey("CoreContentID")]
public virtual ICollection<CoreAMaj> CoreAMajs{get; set;}
[ForeignKey("MajorCodeID")]
public virtual ICollection<CoreAMaj> CoreAMaj1s{get; set;}
[ForeignKey("PreparationID")]
public virtual ICollection<PreparationToCertificate> PreparationToCertificates{get; set;}
[ForeignKey("CommLookupID")]
public virtual ICollection<CommLookupTypeToCommLookup> CommLookupTypeToCommLookups{get; set;}
[ForeignKey("CommLookupID")]
public virtual ICollection<QuestionAnswerToTrigger> QuestionAnswerToTriggers{get; set;}
[ForeignKey("UploadTypeID")]
public virtual ICollection<QuestionAnswerToTrigger> QuestionAnswerToTrigger1s{get; set;}
[ForeignKey("ReasonID")]
public virtual ICollection<Certificate> Certificate2s{get; set;}
[ForeignKey("DegreeID")]
public virtual ICollection<Degree> Degree2s{get; set;}
[ForeignKey("DegreeTypeID")]
public virtual ICollection<Degree> Degree3s{get; set;}
[ForeignKey("OtherStateID")]
public virtual ICollection<OCAPPOtherCerts> OCAPPOtherCertss{get; set;}
[ForeignKey("PositionID")]
public virtual ICollection<AssignmentToPosition> AssignmentToPositions{get; set;}
[ForeignKey("COMMLookupID")]
public virtual ICollection<CPMAJR> CPMAJRs{get; set;}
[ForeignKey("AssignmentCategoryID")]
public virtual ICollection<AssgnCatCn> AssgnCatCns{get; set;}
[ForeignKey("PrintCodeID")]
public virtual ICollection<CertCred> CertCreds{get; set;}
[ForeignKey("SchoolStructureID")]
public virtual ICollection<Assignment> Assignments{get; set;}
[ForeignKey("MajorID")]
public virtual ICollection<OCUCOMajorsCn> OCUCOMajorsCns{get; set;}
[ForeignKey("StateID")]
public virtual ICollection<OCUCOProfile> OCUCOProfiles{get; set;}
[ForeignKey("EthnicityID")]
public virtual ICollection<OCAPPFedEth> OCAPPFedEths{get; set;}
[ForeignKey("SpedTaskID")]
public virtual ICollection<POISpedTasks> POISpedTaskss{get; set;}
[ForeignKey("PRFAssgnTypeID")]
public virtual ICollection<PRFAssgnTypeToEndorsement> PRFAssgnTypeToEndorsements{get; set;}
[ForeignKey("LevelID")]
public virtual ICollection<LevelToCertificate> LevelToCertificates{get; set;}
}
[Table("CommLookupAudit")]
public partial class CommLookupAudit
:IAudit{ 
public CommLookupAudit()
{
}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Column(name:"DisabledInd")]
public bool? DisabledInd {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
