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
public partial class de69pers
:AuditContext{ 
public de69pers()
: base("name = de69pers")
{
}
public virtual DbSet<Address> Addresses { get; set; }
public virtual DbSet<AddressAudit> AddressAudits { get; set; }
public virtual DbSet<AddressType> AddressTypes { get; set; }
public virtual DbSet<AddressTypeAudit> AddressTypeAudits { get; set; }
public virtual DbSet<AddressTypeToAddress> AddressTypeToAddresses { get; set; }
public virtual DbSet<AddressTypeToAddressAudit> AddressTypeToAddressAudits { get; set; }
public virtual DbSet<Answer> Answers { get; set; }
public virtual DbSet<AnswerAudit> AnswerAudits { get; set; }
public virtual DbSet<AnswerToCommlookup> AnswerToCommlookups { get; set; }
public virtual DbSet<AnswerToCommlookupAudit> AnswerToCommlookupAudits { get; set; }
public virtual DbSet<ApplicationType> ApplicationTypes { get; set; }
public virtual DbSet<ApplicationTypeAudit> ApplicationTypeAudits { get; set; }
public virtual DbSet<ApplicationTypeToCertificateType> ApplicationTypeToCertificateTypes { get; set; }
public virtual DbSet<ApplicationTypeToCertificateTypeAudit> ApplicationTypeToCertificateTypeAudits { get; set; }
public virtual DbSet<ApplicationTypeToSection> ApplicationTypeToSections { get; set; }
public virtual DbSet<ApplicationTypeToSectionAudit> ApplicationTypeToSectionAudits { get; set; }
public virtual DbSet<AssgnAltDesc> AssgnAltDescs { get; set; }
public virtual DbSet<AssgnAltDescAudit> AssgnAltDescAudits { get; set; }
public virtual DbSet<AssgnCatCn> AssgnCatCns { get; set; }
public virtual DbSet<AssgnCatCnAudit> AssgnCatCnAudits { get; set; }
public virtual DbSet<Assignment> Assignments { get; set; }
public virtual DbSet<AssignmentAudit> AssignmentAudits { get; set; }
public virtual DbSet<AssignmentToEndorsement> AssignmentToEndorsements { get; set; }
public virtual DbSet<AssignmentToEndorsementAudit> AssignmentToEndorsementAudits { get; set; }
public virtual DbSet<AssignmentToPosition> AssignmentToPositions { get; set; }
public virtual DbSet<AssignmentToPositionAudit> AssignmentToPositionAudits { get; set; }
public virtual DbSet<AssignmentToSpedEndorsement> AssignmentToSpedEndorsements { get; set; }
public virtual DbSet<AssignmentToSpedEndorsementAudit> AssignmentToSpedEndorsementAudits { get; set; }
public virtual DbSet<AssignmentType> AssignmentTypes { get; set; }
public virtual DbSet<AssignmentTypeAudit> AssignmentTypeAudits { get; set; }
public virtual DbSet<AssignmentTypeToAssignment> AssignmentTypeToAssignments { get; set; }
public virtual DbSet<AssignmentTypeToAssignmentAudit> AssignmentTypeToAssignmentAudits { get; set; }
public virtual DbSet<AssurDsQ> AssurDsQs { get; set; }
public virtual DbSet<AssurDsQAudit> AssurDsQAudits { get; set; }
public virtual DbSet<AssurDsS> AssurDsSes { get; set; }
public virtual DbSet<AssurDsSAudit> AssurDsSAudits { get; set; }
public virtual DbSet<AssurQues> AssurQues { get; set; }
public virtual DbSet<AssurQuesAudit> AssurQuesAudits { get; set; }
public virtual DbSet<AttCtrSS> AttCtrSSes { get; set; }
public virtual DbSet<AttCtrSSAudit> AttCtrSSAudits { get; set; }
public virtual DbSet<BaseSalary> BaseSalaries { get; set; }
public virtual DbSet<BaseSalaryAudit> BaseSalaryAudits { get; set; }
public virtual DbSet<BusDrivr> BusDrivrs { get; set; }
public virtual DbSet<BusDrivrAudit> BusDrivrAudits { get; set; }
public virtual DbSet<CDstSort> CDstSorts { get; set; }
public virtual DbSet<CDstSortAudit> CDstSortAudits { get; set; }
public virtual DbSet<CertCred> CertCreds { get; set; }
public virtual DbSet<CertCredAudit> CertCredAudits { get; set; }
public virtual DbSet<CertCredBridge> CertCredBridges { get; set; }
public virtual DbSet<CertCredBridgeAudit> CertCredBridgeAudits { get; set; }
public virtual DbSet<CertHistory> CertHistories { get; set; }
public virtual DbSet<CertHistoryAudit> CertHistoryAudits { get; set; }
public virtual DbSet<Certificate> Certificates { get; set; }
public virtual DbSet<CertificateAudit> CertificateAudits { get; set; }
public virtual DbSet<CertificateCompletion> CertificateCompletions { get; set; }
public virtual DbSet<CertificateCompletionAudit> CertificateCompletionAudits { get; set; }
public virtual DbSet<CertificatePrint> CertificatePrints { get; set; }
public virtual DbSet<CertificatePrintAudit> CertificatePrintAudits { get; set; }
public virtual DbSet<CertificateSequenceNumber> CertificateSequenceNumbers { get; set; }
public virtual DbSet<CertificateSequenceNumberAudit> CertificateSequenceNumberAudits { get; set; }
public virtual DbSet<CertificateType> CertificateTypes { get; set; }
public virtual DbSet<CertificateTypeAudit> CertificateTypeAudits { get; set; }
public virtual DbSet<CertificateTypeToCertificate> CertificateTypeToCertificates { get; set; }
public virtual DbSet<CertificateTypeToCertificateAudit> CertificateTypeToCertificateAudits { get; set; }
public virtual DbSet<CertificateTypeToEndorsement> CertificateTypeToEndorsements { get; set; }
public virtual DbSet<CertificateTypeToEndorsementAudit> CertificateTypeToEndorsementAudits { get; set; }
public virtual DbSet<CertificateTypeToLevel> CertificateTypeToLevels { get; set; }
public virtual DbSet<CertificateTypeToLevelAudit> CertificateTypeToLevelAudits { get; set; }
public virtual DbSet<CertificateTypeToPreparation> CertificateTypeToPreparations { get; set; }
public virtual DbSet<CertificateTypeToPreparationAudit> CertificateTypeToPreparationAudits { get; set; }
public virtual DbSet<CertType> CertTypes { get; set; }
public virtual DbSet<CertTypeAudit> CertTypeAudits { get; set; }
public virtual DbSet<ClasCode> ClasCodes { get; set; }
public virtual DbSet<ClasCodeAudit> ClasCodeAudits { get; set; }
public virtual DbSet<Classfid> Classfids { get; set; }
public virtual DbSet<ClassfidAudit> ClassfidAudits { get; set; }
public virtual DbSet<CommLookup> CommLookups { get; set; }
public virtual DbSet<CommLookupAudit> CommLookupAudits { get; set; }
public virtual DbSet<CommLookupBridge> CommLookupBridges { get; set; }
public virtual DbSet<CommLookupBridgeAudit> CommLookupBridgeAudits { get; set; }
public virtual DbSet<CommLookupType> CommLookupTypes { get; set; }
public virtual DbSet<CommLookupTypeAudit> CommLookupTypeAudits { get; set; }
public virtual DbSet<CommLookupTypeToCommLookup> CommLookupTypeToCommLookups { get; set; }
public virtual DbSet<CommLookupTypeToCommLookupAudit> CommLookupTypeToCommLookupAudits { get; set; }
public virtual DbSet<COMMPerson> COMMPersons { get; set; }
public virtual DbSet<COMMPersonAudit> COMMPersonAudits { get; set; }
public virtual DbSet<CommPersonToMajor> CommPersonToMajors { get; set; }
public virtual DbSet<CommPersonToMajorAudit> CommPersonToMajorAudits { get; set; }
public virtual DbSet<CommPersonType> CommPersonTypes { get; set; }
public virtual DbSet<CommPersonTypeAudit> CommPersonTypeAudits { get; set; }
public virtual DbSet<CommPersonTypeToCommPerson> CommPersonTypeToCommPersons { get; set; }
public virtual DbSet<CommPersonTypeToCommPersonAudit> CommPersonTypeToCommPersonAudits { get; set; }
public virtual DbSet<CoopClassifid> CoopClassifids { get; set; }
public virtual DbSet<CoopClassifidAudit> CoopClassifidAudits { get; set; }
public virtual DbSet<CoreAMaj> CoreAMajs { get; set; }
public virtual DbSet<CoreAMajAudit> CoreAMajAudits { get; set; }
public virtual DbSet<CorrDet> CorrDets { get; set; }
public virtual DbSet<CorrDetAudit> CorrDetAudits { get; set; }
public virtual DbSet<CorrInfo> CorrInfos { get; set; }
public virtual DbSet<CorrInfoAudit> CorrInfoAudits { get; set; }
public virtual DbSet<CPMAJR> CPMAJRs { get; set; }
public virtual DbSet<CPMAJRAudit> CPMAJRAudits { get; set; }
public virtual DbSet<CPrtRec> CPrtRecs { get; set; }
public virtual DbSet<CPrtRecAudit> CPrtRecAudits { get; set; }
public virtual DbSet<CPSubj> CPSubjs { get; set; }
public virtual DbSet<CPSubjAudit> CPSubjAudits { get; set; }
public virtual DbSet<CredType> CredTypes { get; set; }
public virtual DbSet<CredTypeAudit> CredTypeAudits { get; set; }
public virtual DbSet<CSEAssgn> CSEAssgns { get; set; }
public virtual DbSet<CSEAssgnAudit> CSEAssgnAudits { get; set; }
public virtual DbSet<CSEClass> CSEClasses { get; set; }
public virtual DbSet<CSEClassAudit> CSEClassAudits { get; set; }
public virtual DbSet<CSEPrvd> CSEPrvds { get; set; }
public virtual DbSet<CSEPrvdAudit> CSEPrvdAudits { get; set; }
public virtual DbSet<CTEndr> CTEndrs { get; set; }
public virtual DbSet<CTEndrAudit> CTEndrAudits { get; set; }
public virtual DbSet<DataTypeExamples> DataTypeExamples { get; set; }
public virtual DbSet<DataTypeExamplesAudit> DataTypeExamplesAudits { get; set; }
public virtual DbSet<DE04CommLookup> DE04CommLookups { get; set; }
public virtual DbSet<DE04CommLookupAudit> DE04CommLookupAudits { get; set; }
public virtual DbSet<DE04CommLookupType> DE04CommLookupTypes { get; set; }
public virtual DbSet<DE04CommLookupTypeAudit> DE04CommLookupTypeAudits { get; set; }
public virtual DbSet<DE04CommLookupTypeToCommLookup> DE04CommLookupTypeToCommLookups { get; set; }
public virtual DbSet<DE04CommLookupTypeToCommLookupAudit> DE04CommLookupTypeToCommLookupAudits { get; set; }
public virtual DbSet<DE04RollForwardAttendanceCenters> DE04RollForwardAttendanceCenters { get; set; }
public virtual DbSet<DE04RollForwardAttendanceCentersAudit> DE04RollForwardAttendanceCentersAudits { get; set; }
public virtual DbSet<DE04RollForwardDistricts> DE04RollForwardDistricts { get; set; }
public virtual DbSet<DE04RollForwardDistrictsAudit> DE04RollForwardDistrictsAudits { get; set; }
public virtual DbSet<DE04RollForwardMessages> DE04RollForwardMessages { get; set; }
public virtual DbSet<DE04RollForwardMessagesAudit> DE04RollForwardMessagesAudits { get; set; }
public virtual DbSet<DE04RollForwardSortCodes> DE04RollForwardSortCodes { get; set; }
public virtual DbSet<DE04RollForwardSortCodesAudit> DE04RollForwardSortCodesAudits { get; set; }
public virtual DbSet<DECANTLogon> DECANTLogons { get; set; }
public virtual DbSet<DECANTLogonAudit> DECANTLogonAudits { get; set; }
public virtual DbSet<DECANTLogonToDECANTLogonType> DECANTLogonToDECANTLogonTypes { get; set; }
public virtual DbSet<DECANTLogonToDECANTLogonTypeAudit> DECANTLogonToDECANTLogonTypeAudits { get; set; }
public virtual DbSet<DECANTLogonType> DECANTLogonTypes { get; set; }
public virtual DbSet<DECANTLogonTypeAudit> DECANTLogonTypeAudits { get; set; }
public virtual DbSet<Degree> Degrees { get; set; }
public virtual DbSet<DegreeAudit> DegreeAudits { get; set; }
public virtual DbSet<DegreeToDegreeType> DegreeToDegreeTypes { get; set; }
public virtual DbSet<DegreeToDegreeTypeAudit> DegreeToDegreeTypeAudits { get; set; }
public virtual DbSet<DistBus> DistBus { get; set; }
public virtual DbSet<DistBusAudit> DistBusAudits { get; set; }
public virtual DbSet<DistPlanIntnt> DistPlanIntnts { get; set; }
public virtual DbSet<DistPlanIntntAudit> DistPlanIntntAudits { get; set; }
public virtual DbSet<DistrictVacancy> DistrictVacancies { get; set; }
public virtual DbSet<DistrictVacancyAudit> DistrictVacancyAudits { get; set; }
public virtual DbSet<DistSped> DistSpeds { get; set; }
public virtual DbSet<DistSpedAudit> DistSpedAudits { get; set; }
public virtual DbSet<DistSS> DistSSes { get; set; }
public virtual DbSet<DistSSAudit> DistSSAudits { get; set; }
public virtual DbSet<DistVac> DistVacs { get; set; }
public virtual DbSet<DistVacAudit> DistVacAudits { get; set; }
public virtual DbSet<EndOnlyPhsOut> EndOnlyPhsOuts { get; set; }
public virtual DbSet<EndOnlyPhsOutAudit> EndOnlyPhsOutAudits { get; set; }
public virtual DbSet<Endorsement> Endorsements { get; set; }
public virtual DbSet<EndorsementAudit> EndorsementAudits { get; set; }
public virtual DbSet<EndorsementRequirement> EndorsementRequirements { get; set; }
public virtual DbSet<EndorsementRequirementAudit> EndorsementRequirementAudits { get; set; }
public virtual DbSet<EndorsementToCertificate> EndorsementToCertificates { get; set; }
public virtual DbSet<EndorsementToCertificateAudit> EndorsementToCertificateAudits { get; set; }
public virtual DbSet<FDImportLog> FDImportLogs { get; set; }
public virtual DbSet<FDImportLogAudit> FDImportLogAudits { get; set; }
public virtual DbSet<FedEth> FedEths { get; set; }
public virtual DbSet<FedEthAudit> FedEthAudits { get; set; }
public virtual DbSet<FedHisp> FedHisps { get; set; }
public virtual DbSet<FedHispAudit> FedHispAudits { get; set; }
public virtual DbSet<FeeType> FeeTypes { get; set; }
public virtual DbSet<FeeTypeAudit> FeeTypeAudits { get; set; }
public virtual DbSet<FeeTypeToCertificateType> FeeTypeToCertificateTypes { get; set; }
public virtual DbSet<FeeTypeToCertificateTypeAudit> FeeTypeToCertificateTypeAudits { get; set; }
public virtual DbSet<GenPosAS> GenPosAs { get; set; }
public virtual DbSet<GenPosASAudit> GenPosASAudits { get; set; }
public virtual DbSet<GradCRSS> GradCRSSes { get; set; }
public virtual DbSet<GradCRSSAudit> GradCRSSAudits { get; set; }
public virtual DbSet<GradMajCatToAsgn> GradMajCatToAsgns { get; set; }
public virtual DbSet<GradMajCatToAsgnAudit> GradMajCatToAsgnAudits { get; set; }
public virtual DbSet<GradOpts> GradOpts { get; set; }
public virtual DbSet<GradOptsAudit> GradOptsAudits { get; set; }
public virtual DbSet<GradRASS> GradRASSes { get; set; }
public virtual DbSet<GradRASSAudit> GradRASSAudits { get; set; }
public virtual DbSet<GradSCSS> GradSCSSes { get; set; }
public virtual DbSet<GradSCSSAudit> GradSCSSAudits { get; set; }
public virtual DbSet<GraduateMajorCategoryCnn> GraduateMajorCategoryCnns { get; set; }
public virtual DbSet<GraduateMajorCategoryCnnAudit> GraduateMajorCategoryCnnAudits { get; set; }
public virtual DbSet<GradUnit> GradUnits { get; set; }
public virtual DbSet<GradUnitAudit> GradUnitAudits { get; set; }
public virtual DbSet<HQExper> HQExpers { get; set; }
public virtual DbSet<HQExperAudit> HQExperAudits { get; set; }
public virtual DbSet<HQTestAssgn> HQTestAssgns { get; set; }
public virtual DbSet<HQTestAssgnAudit> HQTestAssgnAudits { get; set; }
public virtual DbSet<IndividualTest> IndividualTests { get; set; }
public virtual DbSet<IndividualTestAudit> IndividualTestAudits { get; set; }
public virtual DbSet<IndivTst> IndivTsts { get; set; }
public virtual DbSet<IndivTstAudit> IndivTstAudits { get; set; }
public virtual DbSet<LevelToCertificate> LevelToCertificates { get; set; }
public virtual DbSet<LevelToCertificateAudit> LevelToCertificateAudits { get; set; }
public virtual DbSet<License> Licenses { get; set; }
public virtual DbSet<LicenseAudit> LicenseAudits { get; set; }
public virtual DbSet<LicenseType> LicenseTypes { get; set; }
public virtual DbSet<LicenseTypeAudit> LicenseTypeAudits { get; set; }
public virtual DbSet<ListGroup> ListGroups { get; set; }
public virtual DbSet<ListGroupAudit> ListGroupAudits { get; set; }
public virtual DbSet<MajAssgn> MajAssgns { get; set; }
public virtual DbSet<MajAssgnAudit> MajAssgnAudits { get; set; }
public virtual DbSet<NASDTEC> NASDTECs { get; set; }
public virtual DbSet<NASDTECAudit> NASDTECAudits { get; set; }
public virtual DbSet<NASDTECBackup> NASDTECBackups { get; set; }
public virtual DbSet<NASDTECBackupAudit> NASDTECBackupAudits { get; set; }
public virtual DbSet<OCAPPAppEduc> OCAPPAppEducs { get; set; }
public virtual DbSet<OCAPPAppEducAudit> OCAPPAppEducAudits { get; set; }
public virtual DbSet<OCAPPAttTypeSup> OCAPPAttTypeSups { get; set; }
public virtual DbSet<OCAPPAttTypeSupAudit> OCAPPAttTypeSupAudits { get; set; }
public virtual DbSet<OCAPPConReviewAppTypeCn> OCAPPConReviewAppTypeCns { get; set; }
public virtual DbSet<OCAPPConReviewAppTypeCnAudit> OCAPPConReviewAppTypeCnAudits { get; set; }
public virtual DbSet<OCAPPConReviewCn> OCAPPConReviewCns { get; set; }
public virtual DbSet<OCAPPConReviewCnAudit> OCAPPConReviewCnAudits { get; set; }
public virtual DbSet<OCAPPConReviewSup> OCAPPConReviewSups { get; set; }
public virtual DbSet<OCAPPConReviewSupAudit> OCAPPConReviewSupAudits { get; set; }
public virtual DbSet<OCAPPDegreeTypSupt> OCAPPDegreeTypSupts { get; set; }
public virtual DbSet<OCAPPDegreeTypSuptAudit> OCAPPDegreeTypSuptAudits { get; set; }
public virtual DbSet<OCAppDInfo> OCAppDInfos { get; set; }
public virtual DbSet<OCAppDInfoAudit> OCAppDInfoAudits { get; set; }
public virtual DbSet<OCAppDInfoToCertificateType> OCAppDInfoToCertificateTypes { get; set; }
public virtual DbSet<OCAppDInfoToCertificateTypeAudit> OCAppDInfoToCertificateTypeAudits { get; set; }
public virtual DbSet<OCAppDInfoToEndorsement> OCAppDInfoToEndorsements { get; set; }
public virtual DbSet<OCAppDInfoToEndorsementAudit> OCAppDInfoToEndorsementAudits { get; set; }
public virtual DbSet<OCAppDInfoToLevel> OCAppDInfoToLevels { get; set; }
public virtual DbSet<OCAppDInfoToLevelAudit> OCAppDInfoToLevelAudits { get; set; }
public virtual DbSet<OCAppDInfoToPreparation> OCAppDInfoToPreparations { get; set; }
public virtual DbSet<OCAppDInfoToPreparationAudit> OCAppDInfoToPreparationAudits { get; set; }
public virtual DbSet<OCAPPExperienceResponse> OCAPPExperienceResponses { get; set; }
public virtual DbSet<OCAPPExperienceResponseAudit> OCAPPExperienceResponseAudits { get; set; }
public virtual DbSet<OCAPPFedEth> OCAPPFedEths { get; set; }
public virtual DbSet<OCAPPFedEthAudit> OCAPPFedEthAudits { get; set; }
public virtual DbSet<OCAPPFedHisp> OCAPPFedHisps { get; set; }
public virtual DbSet<OCAPPFedHispAudit> OCAPPFedHispAudits { get; set; }
public virtual DbSet<OCAppIDMap> OCAppIDMaps { get; set; }
public virtual DbSet<OCAppIDMapAudit> OCAppIDMapAudits { get; set; }
public virtual DbSet<OCAPPOtherCerts> OCAPPOtherCerts { get; set; }
public virtual DbSet<OCAPPOtherCertsAudit> OCAPPOtherCertsAudits { get; set; }
public virtual DbSet<OCAPPOtherNationalCerts> OCAPPOtherNationalCerts { get; set; }
public virtual DbSet<OCAPPOtherNationalCertsAudit> OCAPPOtherNationalCertsAudits { get; set; }
public virtual DbSet<OCAPPOverrideQueue> OCAPPOverrideQueues { get; set; }
public virtual DbSet<OCAPPOverrideQueueAudit> OCAPPOverrideQueueAudits { get; set; }
public virtual DbSet<OCAPPPaymentDetail> OCAPPPaymentDetails { get; set; }
public virtual DbSet<OCAPPPaymentDetailAudit> OCAPPPaymentDetailAudits { get; set; }
public virtual DbSet<OCAPPPaymentOption> OCAPPPaymentOptions { get; set; }
public virtual DbSet<OCAPPPaymentOptionAudit> OCAPPPaymentOptionAudits { get; set; }
public virtual DbSet<OCAPPPraxisTests> OCAPPPraxisTests { get; set; }
public virtual DbSet<OCAPPPraxisTestsAudit> OCAPPPraxisTestsAudits { get; set; }
public virtual DbSet<OCAPPPrevLastName> OCAPPPrevLastNames { get; set; }
public virtual DbSet<OCAPPPrevLastNameAudit> OCAPPPrevLastNameAudits { get; set; }
public virtual DbSet<OCAPPProcessingFee> OCAPPProcessingFees { get; set; }
public virtual DbSet<OCAPPProcessingFeeAudit> OCAPPProcessingFeeAudits { get; set; }
public virtual DbSet<OCAPPProfPrep> OCAPPProfPreps { get; set; }
public virtual DbSet<OCAPPProfPrepAudit> OCAPPProfPrepAudits { get; set; }
public virtual DbSet<OCAPPProfPrepCn> OCAPPProfPrepCns { get; set; }
public virtual DbSet<OCAPPProfPrepCnAudit> OCAPPProfPrepCnAudits { get; set; }
public virtual DbSet<OCAPPRenewalCredit> OCAPPRenewalCredits { get; set; }
public virtual DbSet<OCAPPRenewalCreditAudit> OCAPPRenewalCreditAudits { get; set; }
public virtual DbSet<OCAPPRenewalType> OCAPPRenewalTypes { get; set; }
public virtual DbSet<OCAPPRenewalTypeAudit> OCAPPRenewalTypeAudits { get; set; }
public virtual DbSet<OCAPPRenewCodeCategorySupt> OCAPPRenewCodeCategorySupts { get; set; }
public virtual DbSet<OCAPPRenewCodeCategorySuptAudit> OCAPPRenewCodeCategorySuptAudits { get; set; }
public virtual DbSet<OCAPPRenewMajorsCn> OCAPPRenewMajorsCns { get; set; }
public virtual DbSet<OCAPPRenewMajorsCnAudit> OCAPPRenewMajorsCnAudits { get; set; }
public virtual DbSet<OCAPPRenewProPrpCn> OCAPPRenewProPrpCns { get; set; }
public virtual DbSet<OCAPPRenewProPrpCnAudit> OCAPPRenewProPrpCnAudits { get; set; }
public virtual DbSet<OCAPPRenewScreenCn> OCAPPRenewScreenCns { get; set; }
public virtual DbSet<OCAPPRenewScreenCnAudit> OCAPPRenewScreenCnAudits { get; set; }
public virtual DbSet<OCAPPSDUnivSupt> OCAPPSDUnivSupts { get; set; }
public virtual DbSet<OCAPPSDUnivSuptAudit> OCAPPSDUnivSuptAudits { get; set; }
public virtual DbSet<OCAPPSectionComplete> OCAPPSectionCompletes { get; set; }
public virtual DbSet<OCAPPSectionCompleteAudit> OCAPPSectionCompleteAudits { get; set; }
public virtual DbSet<OCAPPStandAloneEndorsements> OCAPPStandAloneEndorsements { get; set; }
public virtual DbSet<OCAPPStandAloneEndorsementsAudit> OCAPPStandAloneEndorsementsAudits { get; set; }
public virtual DbSet<OCAPPSubjAssgnCn> OCAPPSubjAssgnCns { get; set; }
public virtual DbSet<OCAPPSubjAssgnCnAudit> OCAPPSubjAssgnCnAudits { get; set; }
public virtual DbSet<OCAppTypeSupt> OCAppTypeSupts { get; set; }
public virtual DbSet<OCAppTypeSuptAudit> OCAppTypeSuptAudits { get; set; }
public virtual DbSet<OCAPPUploadChoice> OCAPPUploadChoices { get; set; }
public virtual DbSet<OCAPPUploadChoiceAudit> OCAPPUploadChoiceAudits { get; set; }
public virtual DbSet<OCAPPUploadFile> OCAPPUploadFiles { get; set; }
public virtual DbSet<OCAPPUploadFileAudit> OCAPPUploadFileAudits { get; set; }
public virtual DbSet<OCDOEActiveLogon> OCDOEActiveLogons { get; set; }
public virtual DbSet<OCDOEActiveLogonAudit> OCDOEActiveLogonAudits { get; set; }
public virtual DbSet<OCDOEAppDInfoToCertificateType> OCDOEAppDInfoToCertificateTypes { get; set; }
public virtual DbSet<OCDOEAppDInfoToCertificateTypeAudit> OCDOEAppDInfoToCertificateTypeAudits { get; set; }
public virtual DbSet<OCDOEAppDInfoToLevel> OCDOEAppDInfoToLevels { get; set; }
public virtual DbSet<OCDOEAppDInfoToLevelAudit> OCDOEAppDInfoToLevelAudits { get; set; }
public virtual DbSet<OCDOEAppDInfoToPreparation> OCDOEAppDInfoToPreparations { get; set; }
public virtual DbSet<OCDOEAppDInfoToPreparationAudit> OCDOEAppDInfoToPreparationAudits { get; set; }
public virtual DbSet<OCDOEAppExpedite> OCDOEAppExpedites { get; set; }
public virtual DbSet<OCDOEAppExpediteAudit> OCDOEAppExpediteAudits { get; set; }
public virtual DbSet<OCDOEAppFlags> OCDOEAppFlags { get; set; }
public virtual DbSet<OCDOEAppFlagsAudit> OCDOEAppFlagsAudits { get; set; }
public virtual DbSet<OCDOECertMailOpt> OCDOECertMailOpts { get; set; }
public virtual DbSet<OCDOECertMailOptAudit> OCDOECertMailOptAudits { get; set; }
public virtual DbSet<OCDOECertSnapshot> OCDOECertSnapshots { get; set; }
public virtual DbSet<OCDOECertSnapshotAudit> OCDOECertSnapshotAudits { get; set; }
public virtual DbSet<OCDOECertSSDetail> OCDOECertSSDetails { get; set; }
public virtual DbSet<OCDOECertSSDetailAudit> OCDOECertSSDetailAudits { get; set; }
public virtual DbSet<OCDOEComment> OCDOEComments { get; set; }
public virtual DbSet<OCDOECommentAudit> OCDOECommentAudits { get; set; }
public virtual DbSet<OCDOEConReviewCn> OCDOEConReviewCns { get; set; }
public virtual DbSet<OCDOEConReviewCnAudit> OCDOEConReviewCnAudits { get; set; }
public virtual DbSet<OCDOECreditTypeSupt> OCDOECreditTypeSupts { get; set; }
public virtual DbSet<OCDOECreditTypeSuptAudit> OCDOECreditTypeSuptAudits { get; set; }
public virtual DbSet<OCDOELegalities> OCDOELegalities { get; set; }
public virtual DbSet<OCDOELegalitiesAudit> OCDOELegalitiesAudits { get; set; }
public virtual DbSet<OCDOEOtherCerts> OCDOEOtherCerts { get; set; }
public virtual DbSet<OCDOEOtherCertsAudit> OCDOEOtherCertsAudits { get; set; }
public virtual DbSet<OCDOEOtherDoc> OCDOEOtherDocs { get; set; }
public virtual DbSet<OCDOEOtherDocAudit> OCDOEOtherDocAudits { get; set; }
public virtual DbSet<OCDOEOtherDocSupt> OCDOEOtherDocSupts { get; set; }
public virtual DbSet<OCDOEOtherDocSuptAudit> OCDOEOtherDocSuptAudits { get; set; }
public virtual DbSet<OCDOEOtherNationalCerts> OCDOEOtherNationalCerts { get; set; }
public virtual DbSet<OCDOEOtherNationalCertsAudit> OCDOEOtherNationalCertsAudits { get; set; }
public virtual DbSet<OCDOEPraxisTest> OCDOEPraxisTests { get; set; }
public virtual DbSet<OCDOEPraxisTestAudit> OCDOEPraxisTestAudits { get; set; }
public virtual DbSet<OCDOEPreferences> OCDOEPreferences { get; set; }
public virtual DbSet<OCDOEPreferencesAudit> OCDOEPreferencesAudits { get; set; }
public virtual DbSet<OCDOEScanDocToCorrType> OCDOEScanDocToCorrTypes { get; set; }
public virtual DbSet<OCDOEScanDocToCorrTypeAudit> OCDOEScanDocToCorrTypeAudits { get; set; }
public virtual DbSet<OCDOESectionCategoryCompletionMatrix> OCDOESectionCategoryCompletionMatrices { get; set; }
public virtual DbSet<OCDOESectionCategoryCompletionMatrixAudit> OCDOESectionCategoryCompletionMatricesAudit { get; set; }
public virtual DbSet<OCDOESectionComp> OCDOESectionComps { get; set; }
public virtual DbSet<OCDOESectionCompAudit> OCDOESectionCompAudits { get; set; }
public virtual DbSet<OCDOESectionLookup> OCDOESectionLookups { get; set; }
public virtual DbSet<OCDOESectionLookupAudit> OCDOESectionLookupAudits { get; set; }
public virtual DbSet<OCDOESuspensions> OCDOESuspensions { get; set; }
public virtual DbSet<OCDOESuspensionsAudit> OCDOESuspensionsAudits { get; set; }
public virtual DbSet<OCDOETranscriptMatchLog> OCDOETranscriptMatchLogs { get; set; }
public virtual DbSet<OCDOETranscriptMatchLogAudit> OCDOETranscriptMatchLogAudits { get; set; }
public virtual DbSet<OCDOETranscripts> OCDOETranscripts { get; set; }
public virtual DbSet<OCDOETranscriptsAudit> OCDOETranscriptsAudits { get; set; }
public virtual DbSet<OCETSPraxisTest> OCETSPraxisTests { get; set; }
public virtual DbSet<OCETSPraxisTestAudit> OCETSPraxisTestAudits { get; set; }
public virtual DbSet<OCUCOActiveUser> OCUCOActiveUsers { get; set; }
public virtual DbSet<OCUCOActiveUserAudit> OCUCOActiveUserAudits { get; set; }
public virtual DbSet<OCUCOAppDInfoToCertificateType> OCUCOAppDInfoToCertificateTypes { get; set; }
public virtual DbSet<OCUCOAppDInfoToCertificateTypeAudit> OCUCOAppDInfoToCertificateTypeAudits { get; set; }
public virtual DbSet<OCUCOAppDInfoToLevel> OCUCOAppDInfoToLevels { get; set; }
public virtual DbSet<OCUCOAppDInfoToLevelAudit> OCUCOAppDInfoToLevelAudits { get; set; }
public virtual DbSet<OCUCOAppDInfoToPreparation> OCUCOAppDInfoToPreparations { get; set; }
public virtual DbSet<OCUCOAppDInfoToPreparationAudit> OCUCOAppDInfoToPreparationAudits { get; set; }
public virtual DbSet<OCUCOAppEducVerification> OCUCOAppEducVerifications { get; set; }
public virtual DbSet<OCUCOAppEducVerificationAudit> OCUCOAppEducVerificationAudits { get; set; }
public virtual DbSet<OCUCOAppSignOff> OCUCOAppSignOffs { get; set; }
public virtual DbSet<OCUCOAppSignOffAudit> OCUCOAppSignOffAudits { get; set; }
public virtual DbSet<OCUCOComments> OCUCOComments { get; set; }
public virtual DbSet<OCUCOCommentsAudit> OCUCOCommentsAudits { get; set; }
public virtual DbSet<OCUCOEducation> OCUCOEducations { get; set; }
public virtual DbSet<OCUCOEducationAudit> OCUCOEducationAudits { get; set; }
public virtual DbSet<OCUCOEndorsementCn> OCUCOEndorsementCns { get; set; }
public virtual DbSet<OCUCOEndorsementCnAudit> OCUCOEndorsementCnAudits { get; set; }
public virtual DbSet<OCUCOMajorsCn> OCUCOMajorsCns { get; set; }
public virtual DbSet<OCUCOMajorsCnAudit> OCUCOMajorsCnAudits { get; set; }
public virtual DbSet<OCUCOOnlineAppCC> OCUCOOnlineAppCCs { get; set; }
public virtual DbSet<OCUCOOnlineAppCCAudit> OCUCOOnlineAppCCAudits { get; set; }
public virtual DbSet<OCUCOPraxisTests> OCUCOPraxisTests { get; set; }
public virtual DbSet<OCUCOPraxisTestsAudit> OCUCOPraxisTestsAudits { get; set; }
public virtual DbSet<OCUCOProfessionalPrepCn> OCUCOProfessionalPrepCns { get; set; }
public virtual DbSet<OCUCOProfessionalPrepCnAudit> OCUCOProfessionalPrepCnAudits { get; set; }
public virtual DbSet<OCUCOProfile> OCUCOProfiles { get; set; }
public virtual DbSet<OCUCOProfileAudit> OCUCOProfileAudits { get; set; }
public virtual DbSet<OCUCOSectionComplete> OCUCOSectionCompletes { get; set; }
public virtual DbSet<OCUCOSectionCompleteAudit> OCUCOSectionCompleteAudits { get; set; }
public virtual DbSet<Option> Options { get; set; }
public virtual DbSet<OptionAudit> OptionAudits { get; set; }
public virtual DbSet<OtherAct> OtherActs { get; set; }
public virtual DbSet<OtherActAudit> OtherActAudits { get; set; }
public virtual DbSet<ParaAttn> ParaAttns { get; set; }
public virtual DbSet<ParaAttnAudit> ParaAttnAudits { get; set; }
public virtual DbSet<ParaFundingFTEPct> ParaFundingFTEPcts { get; set; }
public virtual DbSet<ParaFundingFTEPctAudit> ParaFundingFTEPctAudits { get; set; }
public virtual DbSet<ParaJobResp> ParaJobResps { get; set; }
public virtual DbSet<ParaJobRespAudit> ParaJobRespAudits { get; set; }
public virtual DbSet<ParaProf> ParaProfs { get; set; }
public virtual DbSet<ParaProfAudit> ParaProfAudits { get; set; }
public virtual DbSet<ParaQual> ParaQuals { get; set; }
public virtual DbSet<ParaQualAudit> ParaQualAudits { get; set; }
public virtual DbSet<ParaStudInfo> ParaStudInfos { get; set; }
public virtual DbSet<ParaStudInfoAudit> ParaStudInfoAudits { get; set; }
public virtual DbSet<ParaSupport> ParaSupports { get; set; }
public virtual DbSet<ParaSupportAudit> ParaSupportAudits { get; set; }
public virtual DbSet<PersonFlagged> PersonFlaggeds { get; set; }
public virtual DbSet<PersonFlaggedAudit> PersonFlaggedAudits { get; set; }
public virtual DbSet<PersonInfo> PersonInfos { get; set; }
public virtual DbSet<PersonInfoAudit> PersonInfoAudits { get; set; }
public virtual DbSet<PersonNonAuthPositionCodeMap> PersonNonAuthPositionCodeMaps { get; set; }
public virtual DbSet<PersonNonAuthPositionCodeMapAudit> PersonNonAuthPositionCodeMapAudits { get; set; }
public virtual DbSet<PlanOfIntentToRequirementOptionGroup> PlanOfIntentToRequirementOptionGroups { get; set; }
public virtual DbSet<PlanOfIntentToRequirementOptionGroupAudit> PlanOfIntentToRequirementOptionGroupAudits { get; set; }
public virtual DbSet<PlanOfIntentToRequirementOptionGroupToListGroup> PlanOfIntentToRequirementOptionGroupToListGroups { get; set; }
public virtual DbSet<PlanOfIntentToRequirementOptionGroupToListGroupAudit> PlanOfIntentToRequirementOptionGroupToListGroupAudits { get; set; }
public virtual DbSet<POISpedInd> POISpedInds { get; set; }
public virtual DbSet<POISpedIndAudit> POISpedIndAudits { get; set; }
public virtual DbSet<POISpedTasks> POISpedTasks { get; set; }
public virtual DbSet<POISpedTasksAudit> POISpedTasksAudits { get; set; }
public virtual DbSet<PraxisAssgnCn> PraxisAssgnCns { get; set; }
public virtual DbSet<PraxisAssgnCnAudit> PraxisAssgnCnAudits { get; set; }
public virtual DbSet<Preclusion> Preclusions { get; set; }
public virtual DbSet<PreclusionAudit> PreclusionAudits { get; set; }
public virtual DbSet<PreparationToCertificate> PreparationToCertificates { get; set; }
public virtual DbSet<PreparationToCertificateAudit> PreparationToCertificateAudits { get; set; }
public virtual DbSet<PreviousLastName> PreviousLastNames { get; set; }
public virtual DbSet<PreviousLastNameAudit> PreviousLastNameAudits { get; set; }
public virtual DbSet<PRFAssgn> PRFAssgns { get; set; }
public virtual DbSet<PRFAssgnAudit> PRFAssgnAudits { get; set; }
public virtual DbSet<PRFAssgnTypeToEndorsement> PRFAssgnTypeToEndorsements { get; set; }
public virtual DbSet<PRFAssgnTypeToEndorsementAudit> PRFAssgnTypeToEndorsementAudits { get; set; }
public virtual DbSet<PRFAssignmentImportHold> PRFAssignmentImportHolds { get; set; }
public virtual DbSet<PRFAssignmentImportHoldAudit> PRFAssignmentImportHoldAudits { get; set; }
public virtual DbSet<PRFAssignmentImportLog> PRFAssignmentImportLogs { get; set; }
public virtual DbSet<PRFAssignmentImportLogAudit> PRFAssignmentImportLogAudits { get; set; }
public virtual DbSet<PRFImportControlTotals> PRFImportControlTotals { get; set; }
public virtual DbSet<PRFImportControlTotalsAudit> PRFImportControlTotalsAudits { get; set; }
public virtual DbSet<PRFImportHold> PRFImportHolds { get; set; }
public virtual DbSet<PRFImportHoldAudit> PRFImportHoldAudits { get; set; }
public virtual DbSet<PRFImportLog> PRFImportLogs { get; set; }
public virtual DbSet<PRFImportLogAudit> PRFImportLogAudits { get; set; }
public virtual DbSet<PRFInfo> PRFInfos { get; set; }
public virtual DbSet<PRFInfoAudit> PRFInfoAudits { get; set; }
public virtual DbSet<PrntCode> PrntCodes { get; set; }
public virtual DbSet<PrntCodeAudit> PrntCodeAudits { get; set; }
public virtual DbSet<PrvdT2> PrvdT2s { get; set; }
public virtual DbSet<PrvdT2Audit> PrvdT2Audits { get; set; }
public virtual DbSet<Qualification> Qualifications { get; set; }
public virtual DbSet<QualificationAudit> QualificationAudits { get; set; }
public virtual DbSet<Question> Questions { get; set; }
public virtual DbSet<QuestionAudit> QuestionAudits { get; set; }
public virtual DbSet<QuestionAnswerToTrigger> QuestionAnswerToTriggers { get; set; }
public virtual DbSet<QuestionAnswerToTriggerAudit> QuestionAnswerToTriggerAudits { get; set; }
public virtual DbSet<Requirement> Requirements { get; set; }
public virtual DbSet<RequirementAudit> RequirementAudits { get; set; }
public virtual DbSet<RequirementOptionGroup> RequirementOptionGroups { get; set; }
public virtual DbSet<RequirementOptionGroupAudit> RequirementOptionGroupAudits { get; set; }
public virtual DbSet<RevkDriv> RevkDrivs { get; set; }
public virtual DbSet<RevkDrivAudit> RevkDrivAudits { get; set; }
public virtual DbSet<RollForwardCodeMaintenance> RollForwardCodeMaintenances { get; set; }
public virtual DbSet<RollForwardCodeMaintenanceAudit> RollForwardCodeMaintenanceAudits { get; set; }
public virtual DbSet<SchoolTypeToPosition> SchoolTypeToPositions { get; set; }
public virtual DbSet<SchoolTypeToPositionAudit> SchoolTypeToPositionAudits { get; set; }
public virtual DbSet<SchoolYear> SchoolYears { get; set; }
public virtual DbSet<SchoolYearAudit> SchoolYearAudits { get; set; }
public virtual DbSet<ScoreLinkData> ScoreLinkDatas { get; set; }
public virtual DbSet<ScoreLinkDataAudit> ScoreLinkDataAudits { get; set; }
public virtual DbSet<SDIndStudies> SDIndStudies { get; set; }
public virtual DbSet<SDIndStudiesAudit> SDIndStudiesAudits { get; set; }
public virtual DbSet<Section> Sections { get; set; }
public virtual DbSet<SectionAudit> SectionAudits { get; set; }
public virtual DbSet<SectionToQuestion> SectionToQuestions { get; set; }
public virtual DbSet<SectionToQuestionAudit> SectionToQuestionAudits { get; set; }
public virtual DbSet<SpedEndAssgn> SpedEndAssgns { get; set; }
public virtual DbSet<SpedEndAssgnAudit> SpedEndAssgnAudits { get; set; }
public virtual DbSet<SpEdIndAssgn> SpEdIndAssgns { get; set; }
public virtual DbSet<SpEdIndAssgnAudit> SpEdIndAssgnAudits { get; set; }
public virtual DbSet<SpedMajAssgn> SpedMajAssgns { get; set; }
public virtual DbSet<SpedMajAssgnAudit> SpedMajAssgnAudits { get; set; }
public virtual DbSet<SpedPrepAssgn> SpedPrepAssgns { get; set; }
public virtual DbSet<SpedPrepAssgnAudit> SpedPrepAssgnAudits { get; set; }
public virtual DbSet<SpedSubjAssgn> SpedSubjAssgns { get; set; }
public virtual DbSet<SpedSubjAssgnAudit> SpedSubjAssgnAudits { get; set; }
public virtual DbSet<SPEDTestCombine> SPEDTestCombines { get; set; }
public virtual DbSet<SPEDTestCombineAudit> SPEDTestCombineAudits { get; set; }
public virtual DbSet<SPEDTstCombin> SPEDTstCombins { get; set; }
public virtual DbSet<SPEDTstCombinAudit> SPEDTstCombinAudits { get; set; }
public virtual DbSet<StateData> StateDatas { get; set; }
public virtual DbSet<StateDataAudit> StateDataAudits { get; set; }
public virtual DbSet<StateTest> StateTests { get; set; }
public virtual DbSet<StateTestAudit> StateTestAudits { get; set; }
public virtual DbSet<StateTst> StateTsts { get; set; }
public virtual DbSet<StateTstAudit> StateTstAudits { get; set; }
public virtual DbSet<StateTstETSCn> StateTstETSCns { get; set; }
public virtual DbSet<StateTstETSCnAudit> StateTstETSCnAudits { get; set; }
public virtual DbSet<SubAssgn> SubAssgns { get; set; }
public virtual DbSet<SubAssgnAudit> SubAssgnAudits { get; set; }
public virtual DbSet<TimeOpt> TimeOpts { get; set; }
public virtual DbSet<TimeOptAudit> TimeOptAudits { get; set; }
public virtual DbSet<Trigger> Triggers { get; set; }
public virtual DbSet<TriggerAudit> TriggerAudits { get; set; }
public virtual DbSet<User> Users { get; set; }
public virtual DbSet<UserAudit> UserAudits { get; set; }
public virtual DbSet<UserTemporaryToken> UserTemporaryTokens { get; set; }
public virtual DbSet<UserTemporaryTokenAudit> UserTemporaryTokenAudits { get; set; }
public virtual DbSet<Vacancy> Vacancies { get; set; }
public virtual DbSet<VacancyAudit> VacancyAudits { get; set; }
public virtual DbSet<VacPosCnn> VacPosCnns { get; set; }
public virtual DbSet<VacPosCnnAudit> VacPosCnnAudits { get; set; }
public virtual DbSet<VirtualSchool> VirtualSchools { get; set; }
public virtual DbSet<VirtualSchoolAudit> VirtualSchoolAudits { get; set; }
public virtual DbSet<VSCntCrs> VSCntCrs { get; set; }
public virtual DbSet<VSCntCrsAudit> VSCntCrsAudits { get; set; }
public virtual DbSet<VSCourse> VSCourses { get; set; }
public virtual DbSet<VSCourseAudit> VSCourseAudits { get; set; }
public virtual DbSet<VSCourse2016> VSCourse2016s { get; set; }
public virtual DbSet<VSCourse2016Audit> VSCourse2016Audits { get; set; }

protected override void OnModelCreating(DbModelBuilder modelBuilder)
{
modelBuilder.Entity<Address>()
.Property(e => e.Address1)
.IsUnicode(false);
modelBuilder.Entity<Address>()
.Property(e => e.Address2)
.IsUnicode(false);
modelBuilder.Entity<Address>()
.Property(e => e.City)
.IsUnicode(false);
modelBuilder.Entity<Address>()
.Property(e => e.State)
.IsUnicode(false);
modelBuilder.Entity<Address>()
.Property(e => e.Zip)
.IsUnicode(false);
RegisterAuditType(typeof(Address), typeof(AddressAudit));
modelBuilder.Entity<AddressType>()
.Property(e => e.BriefDescription)
.IsUnicode(false);
modelBuilder.Entity<AddressType>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<AddressType>()
.Property(e => e.Name)
.IsUnicode(false);
RegisterAuditType(typeof(AddressType), typeof(AddressTypeAudit));
RegisterAuditType(typeof(AddressTypeToAddress), typeof(AddressTypeToAddressAudit));
modelBuilder.Entity<Answer>()
.Property(e => e.AnswerText)
.IsUnicode(false);
RegisterAuditType(typeof(Answer), typeof(AnswerAudit));
RegisterAuditType(typeof(AnswerToCommlookup), typeof(AnswerToCommlookupAudit));
RegisterAuditType(typeof(ApplicationType), typeof(ApplicationTypeAudit));
RegisterAuditType(typeof(ApplicationTypeToCertificateType), typeof(ApplicationTypeToCertificateTypeAudit));
RegisterAuditType(typeof(ApplicationTypeToSection), typeof(ApplicationTypeToSectionAudit));
modelBuilder.Entity<AssgnAltDesc>()
.Property(e => e.AltDescription)
.IsUnicode(false);
RegisterAuditType(typeof(AssgnAltDesc), typeof(AssgnAltDescAudit));
RegisterAuditType(typeof(AssgnCatCn), typeof(AssgnCatCnAudit));
modelBuilder.Entity<Assignment>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<Assignment>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<Assignment>()
.Property(e => e.SchoolStructure)
.IsUnicode(false);
RegisterAuditType(typeof(Assignment), typeof(AssignmentAudit));
RegisterAuditType(typeof(AssignmentToEndorsement), typeof(AssignmentToEndorsementAudit));
RegisterAuditType(typeof(AssignmentToPosition), typeof(AssignmentToPositionAudit));
RegisterAuditType(typeof(AssignmentToSpedEndorsement), typeof(AssignmentToSpedEndorsementAudit));
modelBuilder.Entity<AssignmentType>()
.Property(e => e.BriefDescription)
.IsUnicode(false);
modelBuilder.Entity<AssignmentType>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<AssignmentType>()
.Property(e => e.KeyPrefix)
.IsUnicode(false);
modelBuilder.Entity<AssignmentType>()
.Property(e => e.Name)
.IsUnicode(false);
RegisterAuditType(typeof(AssignmentType), typeof(AssignmentTypeAudit));
RegisterAuditType(typeof(AssignmentTypeToAssignment), typeof(AssignmentTypeToAssignmentAudit));
modelBuilder.Entity<AssurDsQ>()
.Property(e => e.Answer)
.IsUnicode(false);
modelBuilder.Entity<AssurDsQ>()
.Property(e => e.Comments)
.IsUnicode(false);
RegisterAuditType(typeof(AssurDsQ), typeof(AssurDsQAudit));
modelBuilder.Entity<AssurDsS>()
.Property(e => e.AssurName)
.IsUnicode(false);
modelBuilder.Entity<AssurDsS>()
.Property(e => e.Signed)
.IsUnicode(false);
modelBuilder.Entity<AssurDsS>()
.Property(e => e.Title)
.IsUnicode(false);
RegisterAuditType(typeof(AssurDsS), typeof(AssurDsSAudit));
modelBuilder.Entity<AssurQues>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<AssurQues>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<AssurQues>()
.Property(e => e.SchoolYear)
.IsUnicode(false);
RegisterAuditType(typeof(AssurQues), typeof(AssurQuesAudit));
modelBuilder.Entity<AttCtrSS>()
.Property(e => e.AttendanceCenterName)
.IsUnicode(false);
modelBuilder.Entity<AttCtrSS>()
.Property(e => e.AttendanceCenterNum)
.IsUnicode(false);
modelBuilder.Entity<AttCtrSS>()
.Property(e => e.BegGradeSpan)
.IsUnicode(false);
modelBuilder.Entity<AttCtrSS>()
.Property(e => e.EndGradeSpan)
.IsUnicode(false);
RegisterAuditType(typeof(AttCtrSS), typeof(AttCtrSSAudit));
RegisterAuditType(typeof(BaseSalary), typeof(BaseSalaryAudit));
modelBuilder.Entity<BusDrivr>()
.Property(e => e.ARSDTraining)
.IsUnicode(false);
modelBuilder.Entity<BusDrivr>()
.Property(e => e.EmployeeType)
.IsUnicode(false);
modelBuilder.Entity<BusDrivr>()
.Property(e => e.FirstName)
.IsUnicode(false);
modelBuilder.Entity<BusDrivr>()
.Property(e => e.LastName)
.IsUnicode(false);
modelBuilder.Entity<BusDrivr>()
.Property(e => e.MiddleName)
.IsUnicode(false);
modelBuilder.Entity<BusDrivr>()
.Property(e => e.OverrideComments)
.IsUnicode(false);
modelBuilder.Entity<BusDrivr>()
.Property(e => e.SSN)
.IsUnicode(false);
modelBuilder.Entity<BusDrivr>()
.Property(e => e.TrainingDate)
.IsUnicode(false);
modelBuilder.Entity<BusDrivr>()
.Property(e => e.TrainingOverride)
.IsUnicode(false);
RegisterAuditType(typeof(BusDrivr), typeof(BusDrivrAudit));
RegisterAuditType(typeof(CDstSort), typeof(CDstSortAudit));
modelBuilder.Entity<CertCred>()
.Property(e => e.AcademicPreparation)
.IsUnicode(false);
modelBuilder.Entity<CertCred>()
.Property(e => e.BatchPrint)
.IsUnicode(false);
modelBuilder.Entity<CertCred>()
.Property(e => e.CertCredPrefix)
.IsUnicode(false);
modelBuilder.Entity<CertCred>()
.Property(e => e.HumanRelations)
.IsUnicode(false);
RegisterAuditType(typeof(CertCred), typeof(CertCredAudit));
RegisterAuditType(typeof(CertCredBridge), typeof(CertCredBridgeAudit));
modelBuilder.Entity<CertHistory>()
.Property(e => e.ActionBy)
.IsUnicode(false);
RegisterAuditType(typeof(CertHistory), typeof(CertHistoryAudit));
modelBuilder.Entity<Certificate>()
.Property(e => e.CertificateNumber)
.IsUnicode(false);
RegisterAuditType(typeof(Certificate), typeof(CertificateAudit));
modelBuilder.Entity<CertificateCompletion>()
.Property(e => e.CertificateNumber)
.IsUnicode(false);
RegisterAuditType(typeof(CertificateCompletion), typeof(CertificateCompletionAudit));
RegisterAuditType(typeof(CertificatePrint), typeof(CertificatePrintAudit));
RegisterAuditType(typeof(CertificateSequenceNumber), typeof(CertificateSequenceNumberAudit));
modelBuilder.Entity<CertificateType>()
.Property(e => e.Name)
.IsUnicode(false);
RegisterAuditType(typeof(CertificateType), typeof(CertificateTypeAudit));
modelBuilder.Entity<CertificateTypeToCertificate>()
.Property(e => e.CertificateNumber)
.IsUnicode(false);
RegisterAuditType(typeof(CertificateTypeToCertificate), typeof(CertificateTypeToCertificateAudit));
RegisterAuditType(typeof(CertificateTypeToEndorsement), typeof(CertificateTypeToEndorsementAudit));
RegisterAuditType(typeof(CertificateTypeToLevel), typeof(CertificateTypeToLevelAudit));
RegisterAuditType(typeof(CertificateTypeToPreparation), typeof(CertificateTypeToPreparationAudit));
modelBuilder.Entity<CertType>()
.Property(e => e.CertifiedTypeCode)
.IsUnicode(false);
modelBuilder.Entity<CertType>()
.Property(e => e.CertifiedTypeDesc)
.IsUnicode(false);
RegisterAuditType(typeof(CertType), typeof(CertTypeAudit));
modelBuilder.Entity<ClasCode>()
.Property(e => e.ClassifiedCode)
.IsUnicode(false);
modelBuilder.Entity<ClasCode>()
.Property(e => e.ClassifiedCodeDesc)
.IsUnicode(false);
modelBuilder.Entity<ClasCode>()
.Property(e => e.Disabled)
.IsUnicode(false);
modelBuilder.Entity<ClasCode>()
.Property(e => e.IsValidForContractedSped)
.IsUnicode(false);
RegisterAuditType(typeof(ClasCode), typeof(ClasCodeAudit));
RegisterAuditType(typeof(Classfid), typeof(ClassfidAudit));
modelBuilder.Entity<CommLookup>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<CommLookup>()
.Property(e => e.Description)
.IsUnicode(false);
RegisterAuditType(typeof(CommLookup), typeof(CommLookupAudit));
RegisterAuditType(typeof(CommLookupBridge), typeof(CommLookupBridgeAudit));
modelBuilder.Entity<CommLookupType>()
.Property(e => e.BriefDescription)
.IsUnicode(false);
modelBuilder.Entity<CommLookupType>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<CommLookupType>()
.Property(e => e.KeyPrefix)
.IsUnicode(false);
modelBuilder.Entity<CommLookupType>()
.Property(e => e.Name)
.IsUnicode(false);
RegisterAuditType(typeof(CommLookupType), typeof(CommLookupTypeAudit));
RegisterAuditType(typeof(CommLookupTypeToCommLookup), typeof(CommLookupTypeToCommLookupAudit));
modelBuilder.Entity<COMMPerson>()
.Property(e => e.Country)
.IsUnicode(false);
modelBuilder.Entity<COMMPerson>()
.Property(e => e.DayPhone)
.IsUnicode(false);
modelBuilder.Entity<COMMPerson>()
.Property(e => e.EmailAddress)
.IsUnicode(false);
modelBuilder.Entity<COMMPerson>()
.Property(e => e.EveningPhone)
.IsUnicode(false);
modelBuilder.Entity<COMMPerson>()
.Property(e => e.FirstName)
.IsUnicode(false);
modelBuilder.Entity<COMMPerson>()
.Property(e => e.LastName)
.IsUnicode(false);
modelBuilder.Entity<COMMPerson>()
.Property(e => e.MiddleName)
.IsUnicode(false);
modelBuilder.Entity<COMMPerson>()
.Property(e => e.Sex)
.IsUnicode(false);
modelBuilder.Entity<COMMPerson>()
.Property(e => e.SSN)
.IsUnicode(false);
RegisterAuditType(typeof(COMMPerson), typeof(COMMPersonAudit));
modelBuilder.Entity<CommPersonToMajor>()
.Property(e => e.Other)
.IsUnicode(false);
RegisterAuditType(typeof(CommPersonToMajor), typeof(CommPersonToMajorAudit));
modelBuilder.Entity<CommPersonType>()
.Property(e => e.BriefDescription)
.IsUnicode(false);
modelBuilder.Entity<CommPersonType>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<CommPersonType>()
.Property(e => e.Name)
.IsUnicode(false);
RegisterAuditType(typeof(CommPersonType), typeof(CommPersonTypeAudit));
RegisterAuditType(typeof(CommPersonTypeToCommPerson), typeof(CommPersonTypeToCommPersonAudit));
RegisterAuditType(typeof(CoopClassifid), typeof(CoopClassifidAudit));
RegisterAuditType(typeof(CoreAMaj), typeof(CoreAMajAudit));
RegisterAuditType(typeof(CorrDet), typeof(CorrDetAudit));
modelBuilder.Entity<CorrInfo>()
.Property(e => e.BlueSheeted)
.IsUnicode(false);
modelBuilder.Entity<CorrInfo>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<CorrInfo>()
.Property(e => e.MaidenName)
.IsUnicode(false);
RegisterAuditType(typeof(CorrInfo), typeof(CorrInfoAudit));
RegisterAuditType(typeof(CPMAJR), typeof(CPMAJRAudit));
RegisterAuditType(typeof(CPrtRec), typeof(CPrtRecAudit));
RegisterAuditType(typeof(CPSubj), typeof(CPSubjAudit));
modelBuilder.Entity<CredType>()
.Property(e => e.CredentialTypeCode)
.IsUnicode(false);
modelBuilder.Entity<CredType>()
.Property(e => e.CredentialTypeDesc)
.IsUnicode(false);
RegisterAuditType(typeof(CredType), typeof(CredTypeAudit));
RegisterAuditType(typeof(CSEAssgn), typeof(CSEAssgnAudit));
RegisterAuditType(typeof(CSEClass), typeof(CSEClassAudit));
modelBuilder.Entity<CSEPrvd>()
.Property(e => e.Provider)
.IsUnicode(false);
modelBuilder.Entity<CSEPrvd>()
.Property(e => e.ProviderName)
.IsUnicode(false);
modelBuilder.Entity<CSEPrvd>()
.Property(e => e.SSN)
.IsUnicode(false);
RegisterAuditType(typeof(CSEPrvd), typeof(CSEPrvdAudit));
RegisterAuditType(typeof(CTEndr), typeof(CTEndrAudit));
modelBuilder.Entity<DataTypeExamples>()
.Property(e => e.Xvarchar)
.IsUnicode(false);
RegisterAuditType(typeof(DataTypeExamples), typeof(DataTypeExamplesAudit));
modelBuilder.Entity<DE04CommLookup>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<DE04CommLookup>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<DE04CommLookup>()
.Property(e => e.Disabled)
.IsUnicode(false);
RegisterAuditType(typeof(DE04CommLookup), typeof(DE04CommLookupAudit));
modelBuilder.Entity<DE04CommLookupType>()
.Property(e => e.BriefDescription)
.IsUnicode(false);
modelBuilder.Entity<DE04CommLookupType>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<DE04CommLookupType>()
.Property(e => e.Name)
.IsUnicode(false);
RegisterAuditType(typeof(DE04CommLookupType), typeof(DE04CommLookupTypeAudit));
RegisterAuditType(typeof(DE04CommLookupTypeToCommLookup), typeof(DE04CommLookupTypeToCommLookupAudit));
modelBuilder.Entity<DE04RollForwardAttendanceCenters>()
.Property(e => e.BegGradeSpan)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardAttendanceCenters>()
.Property(e => e.DistrictNumber)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardAttendanceCenters>()
.Property(e => e.EndingGradeSpan)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardAttendanceCenters>()
.Property(e => e.ID)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardAttendanceCenters>()
.Property(e => e.SchoolName)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardAttendanceCenters>()
.Property(e => e.SchoolNumber)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardAttendanceCenters>()
.Property(e => e.SortCode)
.IsUnicode(false);
RegisterAuditType(typeof(DE04RollForwardAttendanceCenters), typeof(DE04RollForwardAttendanceCentersAudit));
modelBuilder.Entity<DE04RollForwardDistricts>()
.Property(e => e.County)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardDistricts>()
.Property(e => e.CountyID)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardDistricts>()
.Property(e => e.CountyName)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardDistricts>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardDistricts>()
.Property(e => e.DistrictCodeNumber)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardDistricts>()
.Property(e => e.DistrictName)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardDistricts>()
.Property(e => e.DistrictNumber)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardDistricts>()
.Property(e => e.DistrictType)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardDistricts>()
.Property(e => e.DistrictTypeID)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardDistricts>()
.Property(e => e.SchoolYear)
.IsUnicode(false);
RegisterAuditType(typeof(DE04RollForwardDistricts), typeof(DE04RollForwardDistrictsAudit));
modelBuilder.Entity<DE04RollForwardMessages>()
.Property(e => e.Message)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardMessages>()
.Property(e => e.ProcedureName)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardMessages>()
.Property(e => e.RecordInformation)
.IsUnicode(false);
RegisterAuditType(typeof(DE04RollForwardMessages), typeof(DE04RollForwardMessagesAudit));
modelBuilder.Entity<DE04RollForwardSortCodes>()
.Property(e => e.DistrictNumber)
.IsUnicode(false);
modelBuilder.Entity<DE04RollForwardSortCodes>()
.Property(e => e.SortCode)
.IsUnicode(false);
RegisterAuditType(typeof(DE04RollForwardSortCodes), typeof(DE04RollForwardSortCodesAudit));
modelBuilder.Entity<DECANTLogon>()
.Property(e => e.DistShortName)
.IsUnicode(false);
modelBuilder.Entity<DECANTLogon>()
.Property(e => e.NTLogonID)
.IsUnicode(false);
RegisterAuditType(typeof(DECANTLogon), typeof(DECANTLogonAudit));
RegisterAuditType(typeof(DECANTLogonToDECANTLogonType), typeof(DECANTLogonToDECANTLogonTypeAudit));
modelBuilder.Entity<DECANTLogonType>()
.Property(e => e.BriefDescription)
.IsUnicode(false);
modelBuilder.Entity<DECANTLogonType>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<DECANTLogonType>()
.Property(e => e.Name)
.IsUnicode(false);
RegisterAuditType(typeof(DECANTLogonType), typeof(DECANTLogonTypeAudit));
modelBuilder.Entity<Degree>()
.Property(e => e.CompletedDate)
.IsUnicode(false);
modelBuilder.Entity<Degree>()
.Property(e => e.MajMinOther)
.IsUnicode(false);
RegisterAuditType(typeof(Degree), typeof(DegreeAudit));
RegisterAuditType(typeof(DegreeToDegreeType), typeof(DegreeToDegreeTypeAudit));
modelBuilder.Entity<DistBus>()
.Property(e => e.HasBusDrivers)
.IsUnicode(false);
RegisterAuditType(typeof(DistBus), typeof(DistBusAudit));
modelBuilder.Entity<DistPlanIntnt>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<DistPlanIntnt>()
.Property(e => e.PlanOfAction)
.IsUnicode(false);
RegisterAuditType(typeof(DistPlanIntnt), typeof(DistPlanIntntAudit));
modelBuilder.Entity<DistrictVacancy>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<DistrictVacancy>()
.Property(e => e.PositionFilledFirstDay)
.IsUnicode(false);
RegisterAuditType(typeof(DistrictVacancy), typeof(DistrictVacancyAudit));
modelBuilder.Entity<DistSped>()
.Property(e => e.HasSped)
.IsUnicode(false);
RegisterAuditType(typeof(DistSped), typeof(DistSpedAudit));
modelBuilder.Entity<DistSS>()
.Property(e => e.CountyCode)
.IsUnicode(false);
modelBuilder.Entity<DistSS>()
.Property(e => e.CountyCodeDescription)
.IsUnicode(false);
modelBuilder.Entity<DistSS>()
.Property(e => e.DistrictCodeNum)
.IsUnicode(false);
modelBuilder.Entity<DistSS>()
.Property(e => e.DistrictFacilityType)
.IsUnicode(false);
modelBuilder.Entity<DistSS>()
.Property(e => e.DistrictFacilityTypeDesc)
.IsUnicode(false);
modelBuilder.Entity<DistSS>()
.Property(e => e.HasClssStaff)
.IsUnicode(false);
modelBuilder.Entity<DistSS>()
.Property(e => e.HasParaProf)
.IsUnicode(false);
modelBuilder.Entity<DistSS>()
.Property(e => e.SchoolDistrictName)
.IsUnicode(false);
modelBuilder.Entity<DistSS>()
.Property(e => e.SchoolYear)
.IsUnicode(false);
modelBuilder.Entity<DistSS>()
.Property(e => e.ShortName)
.IsUnicode(false);
RegisterAuditType(typeof(DistSS), typeof(DistSSAudit));
modelBuilder.Entity<DistVac>()
.Property(e => e.HasVac)
.IsUnicode(false);
RegisterAuditType(typeof(DistVac), typeof(DistVacAudit));
RegisterAuditType(typeof(EndOnlyPhsOut), typeof(EndOnlyPhsOutAudit));
modelBuilder.Entity<Endorsement>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<Endorsement>()
.Property(e => e.Description)
.IsUnicode(false);
RegisterAuditType(typeof(Endorsement), typeof(EndorsementAudit));
RegisterAuditType(typeof(EndorsementRequirement), typeof(EndorsementRequirementAudit));
modelBuilder.Entity<EndorsementToCertificate>()
.Property(e => e.CertificateNumber)
.IsUnicode(false);
RegisterAuditType(typeof(EndorsementToCertificate), typeof(EndorsementToCertificateAudit));
modelBuilder.Entity<FDImportLog>()
.Property(e => e.DocumentType)
.IsUnicode(false);
modelBuilder.Entity<FDImportLog>()
.Property(e => e.FileName)
.IsUnicode(false);
modelBuilder.Entity<FDImportLog>()
.Property(e => e.Result)
.IsUnicode(false);
modelBuilder.Entity<FDImportLog>()
.Property(e => e.StampUser)
.IsUnicode(false);
RegisterAuditType(typeof(FDImportLog), typeof(FDImportLogAudit));
RegisterAuditType(typeof(FedEth), typeof(FedEthAudit));
RegisterAuditType(typeof(FedHisp), typeof(FedHispAudit));
RegisterAuditType(typeof(FeeType), typeof(FeeTypeAudit));
RegisterAuditType(typeof(FeeTypeToCertificateType), typeof(FeeTypeToCertificateTypeAudit));
RegisterAuditType(typeof(GenPosAS), typeof(GenPosASAudit));
modelBuilder.Entity<GradCRSS>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<GradCRSS>()
.Property(e => e.GradCatCode)
.IsUnicode(false);
modelBuilder.Entity<GradCRSS>()
.Property(e => e.GradCatDesc)
.IsUnicode(false);
modelBuilder.Entity<GradCRSS>()
.Property(e => e.SchoolYear)
.IsUnicode(false);
RegisterAuditType(typeof(GradCRSS), typeof(GradCRSSAudit));
RegisterAuditType(typeof(GradMajCatToAsgn), typeof(GradMajCatToAsgnAudit));
modelBuilder.Entity<GradOpts>()
.Property(e => e.OptAction)
.IsUnicode(false);
modelBuilder.Entity<GradOpts>()
.Property(e => e.OptCode)
.IsUnicode(false);
modelBuilder.Entity<GradOpts>()
.Property(e => e.OptDesc)
.IsUnicode(false);
RegisterAuditType(typeof(GradOpts), typeof(GradOptsAudit));
modelBuilder.Entity<GradRASS>()
.Property(e => e.SchoolYear)
.IsUnicode(false);
RegisterAuditType(typeof(GradRASS), typeof(GradRASSAudit));
modelBuilder.Entity<GradSCSS>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<GradSCSS>()
.Property(e => e.GradSubcatCode)
.IsUnicode(false);
modelBuilder.Entity<GradSCSS>()
.Property(e => e.GradSubcatDesc)
.IsUnicode(false);
modelBuilder.Entity<GradSCSS>()
.Property(e => e.SchoolYear)
.IsUnicode(false);
RegisterAuditType(typeof(GradSCSS), typeof(GradSCSSAudit));
RegisterAuditType(typeof(GraduateMajorCategoryCnn), typeof(GraduateMajorCategoryCnnAudit));
modelBuilder.Entity<GradUnit>()
.Property(e => e.IsPRF)
.IsUnicode(false);
modelBuilder.Entity<GradUnit>()
.Property(e => e.SchoolInfor)
.IsUnicode(false);
RegisterAuditType(typeof(GradUnit), typeof(GradUnitAudit));
modelBuilder.Entity<HQExper>()
.Property(e => e.ExperienceLevel)
.IsUnicode(false);
RegisterAuditType(typeof(HQExper), typeof(HQExperAudit));
modelBuilder.Entity<HQTestAssgn>()
.Property(e => e.CheckPosition)
.IsUnicode(false);
RegisterAuditType(typeof(HQTestAssgn), typeof(HQTestAssgnAudit));
modelBuilder.Entity<IndividualTest>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<IndividualTest>()
.Property(e => e.InsertedBy)
.IsUnicode(false);
modelBuilder.Entity<IndividualTest>()
.Property(e => e.Score)
.IsUnicode(false);
RegisterAuditType(typeof(IndividualTest), typeof(IndividualTestAudit));
modelBuilder.Entity<IndivTst>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<IndivTst>()
.Property(e => e.InsertedBy)
.IsUnicode(false);
modelBuilder.Entity<IndivTst>()
.Property(e => e.Score)
.IsUnicode(false);
RegisterAuditType(typeof(IndivTst), typeof(IndivTstAudit));
modelBuilder.Entity<LevelToCertificate>()
.Property(e => e.CertificateNumber)
.IsUnicode(false);
RegisterAuditType(typeof(LevelToCertificate), typeof(LevelToCertificateAudit));
modelBuilder.Entity<License>()
.Property(e => e.AcademicPreparation)
.IsUnicode(false);
RegisterAuditType(typeof(License), typeof(LicenseAudit));
RegisterAuditType(typeof(LicenseType), typeof(LicenseTypeAudit));
RegisterAuditType(typeof(ListGroup), typeof(ListGroupAudit));
RegisterAuditType(typeof(MajAssgn), typeof(MajAssgnAudit));
modelBuilder.Entity<NASDTEC>()
.Property(e => e.CorrIndicator)
.IsUnicode(false);
modelBuilder.Entity<NASDTEC>()
.Property(e => e.FirstName)
.IsUnicode(false);
modelBuilder.Entity<NASDTEC>()
.Property(e => e.LastName)
.IsUnicode(false);
modelBuilder.Entity<NASDTEC>()
.Property(e => e.SSN)
.IsUnicode(false);
modelBuilder.Entity<NASDTEC>()
.Property(e => e.State)
.IsUnicode(false);
RegisterAuditType(typeof(NASDTEC), typeof(NASDTECAudit));
modelBuilder.Entity<NASDTECBackup>()
.Property(e => e.CorrIndicator)
.IsUnicode(false);
modelBuilder.Entity<NASDTECBackup>()
.Property(e => e.FirstName)
.IsUnicode(false);
modelBuilder.Entity<NASDTECBackup>()
.Property(e => e.LastName)
.IsUnicode(false);
modelBuilder.Entity<NASDTECBackup>()
.Property(e => e.SSN)
.IsUnicode(false);
modelBuilder.Entity<NASDTECBackup>()
.Property(e => e.State)
.IsUnicode(false);
RegisterAuditType(typeof(NASDTECBackup), typeof(NASDTECBackupAudit));
modelBuilder.Entity<OCAPPAppEduc>()
.Property(e => e.City)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAppEduc>()
.Property(e => e.Country)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAppEduc>()
.Property(e => e.Major)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAppEduc>()
.Property(e => e.Minor)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAppEduc>()
.Property(e => e.OtherUniv)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAppEduc>()
.Property(e => e.SpecializationText)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAppEduc>()
.Property(e => e.State)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAppEduc>()
.Property(e => e.StudentID)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAppEduc>()
.Property(e => e.TranscriptComing)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAppEduc>()
.Property(e => e.Zip)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPAppEduc), typeof(OCAPPAppEducAudit));
modelBuilder.Entity<OCAPPAttTypeSup>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAttTypeSup>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<OCAPPAttTypeSup>()
.Property(e => e.Disabled)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPAttTypeSup), typeof(OCAPPAttTypeSupAudit));
modelBuilder.Entity<OCAPPConReviewAppTypeCn>()
.Property(e => e.DisplayOrder)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPConReviewAppTypeCn), typeof(OCAPPConReviewAppTypeCnAudit));
modelBuilder.Entity<OCAPPConReviewCn>()
.Property(e => e.Answer)
.IsUnicode(false);
modelBuilder.Entity<OCAPPConReviewCn>()
.Property(e => e.Comments)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPConReviewCn), typeof(OCAPPConReviewCnAudit));
modelBuilder.Entity<OCAPPConReviewSup>()
.Property(e => e.Disabled)
.IsUnicode(false);
modelBuilder.Entity<OCAPPConReviewSup>()
.Property(e => e.QuestionHTML)
.IsUnicode(false);
modelBuilder.Entity<OCAPPConReviewSup>()
.Property(e => e.RequiresCourtDocumentation)
.IsUnicode(false);
modelBuilder.Entity<OCAPPConReviewSup>()
.Property(e => e.RequiresReviewIfYes)
.IsUnicode(false);
modelBuilder.Entity<OCAPPConReviewSup>()
.Property(e => e.YesResponseInstructionsHTML)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPConReviewSup), typeof(OCAPPConReviewSupAudit));
modelBuilder.Entity<OCAPPDegreeTypSupt>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<OCAPPDegreeTypSupt>()
.Property(e => e.Description)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPDegreeTypSupt), typeof(OCAPPDegreeTypSuptAudit));
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.Address1)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.Address2)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.AppNumber)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.AppTrue)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.Citizenship)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.CitizenshipCountry)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.City)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.ContractSignedDistrict)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.Country)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.CtryBorn)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.DayPhone)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.Email)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.EvenPhone)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.FirstName)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.Gender)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.LastName)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.MiddleName)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.Oath)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.SSN)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.State)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.Status)
.IsUnicode(false);
modelBuilder.Entity<OCAppDInfo>()
.Property(e => e.Zip)
.IsUnicode(false);
RegisterAuditType(typeof(OCAppDInfo), typeof(OCAppDInfoAudit));
RegisterAuditType(typeof(OCAppDInfoToCertificateType), typeof(OCAppDInfoToCertificateTypeAudit));
RegisterAuditType(typeof(OCAppDInfoToEndorsement), typeof(OCAppDInfoToEndorsementAudit));
RegisterAuditType(typeof(OCAppDInfoToLevel), typeof(OCAppDInfoToLevelAudit));
RegisterAuditType(typeof(OCAppDInfoToPreparation), typeof(OCAppDInfoToPreparationAudit));
modelBuilder.Entity<OCAPPExperienceResponse>()
.Property(e => e.HasRequiredExperience)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPExperienceResponse), typeof(OCAPPExperienceResponseAudit));
RegisterAuditType(typeof(OCAPPFedEth), typeof(OCAPPFedEthAudit));
modelBuilder.Entity<OCAPPFedHisp>()
.Property(e => e.Hispanic)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPFedHisp), typeof(OCAPPFedHispAudit));
modelBuilder.Entity<OCAppIDMap>()
.Property(e => e.DirectReference)
.IsUnicode(false);
modelBuilder.Entity<OCAppIDMap>()
.Property(e => e.IndirectReference)
.IsUnicode(false);
RegisterAuditType(typeof(OCAppIDMap), typeof(OCAppIDMapAudit));
modelBuilder.Entity<OCAPPOtherCerts>()
.Property(e => e.ForeignCountry)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPOtherCerts), typeof(OCAPPOtherCertsAudit));
modelBuilder.Entity<OCAPPOtherNationalCerts>()
.Property(e => e.Country)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPOtherNationalCerts), typeof(OCAPPOtherNationalCertsAudit));
modelBuilder.Entity<OCAPPOverrideQueue>()
.Property(e => e.Queue)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPOverrideQueue), typeof(OCAPPOverrideQueueAudit));
modelBuilder.Entity<OCAPPPaymentDetail>()
.Property(e => e.ResponseCode)
.IsUnicode(false);
modelBuilder.Entity<OCAPPPaymentDetail>()
.Property(e => e.ResponseText)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPPaymentDetail), typeof(OCAPPPaymentDetailAudit));
RegisterAuditType(typeof(OCAPPPaymentOption), typeof(OCAPPPaymentOptionAudit));
modelBuilder.Entity<OCAPPPraxisTests>()
.Property(e => e.Score)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPPraxisTests), typeof(OCAPPPraxisTestsAudit));
modelBuilder.Entity<OCAPPPrevLastName>()
.Property(e => e.PrevLastName)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPPrevLastName), typeof(OCAPPPrevLastNameAudit));
RegisterAuditType(typeof(OCAPPProcessingFee), typeof(OCAPPProcessingFeeAudit));
modelBuilder.Entity<OCAPPProfPrep>()
.Property(e => e.AdministrativeRuleLink)
.IsUnicode(false);
modelBuilder.Entity<OCAPPProfPrep>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<OCAPPProfPrep>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<OCAPPProfPrep>()
.Property(e => e.Disabled)
.IsUnicode(false);
modelBuilder.Entity<OCAPPProfPrep>()
.Property(e => e.RequirementsDescription)
.IsUnicode(false);
modelBuilder.Entity<OCAPPProfPrep>()
.Property(e => e.VerifyExperience)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPProfPrep), typeof(OCAPPProfPrepAudit));
RegisterAuditType(typeof(OCAPPProfPrepCn), typeof(OCAPPProfPrepCnAudit));
modelBuilder.Entity<OCAPPRenewalCredit>()
.Property(e => e.AgencyOrInstructor)
.IsUnicode(false);
modelBuilder.Entity<OCAPPRenewalCredit>()
.Property(e => e.CourseNumber)
.IsUnicode(false);
modelBuilder.Entity<OCAPPRenewalCredit>()
.Property(e => e.InstitutionType)
.IsUnicode(false);
modelBuilder.Entity<OCAPPRenewalCredit>()
.Property(e => e.Location)
.IsUnicode(false);
modelBuilder.Entity<OCAPPRenewalCredit>()
.Property(e => e.OtherUniversity)
.IsUnicode(false);
modelBuilder.Entity<OCAPPRenewalCredit>()
.Property(e => e.TitleOrCourseDescription)
.IsUnicode(false);
modelBuilder.Entity<OCAPPRenewalCredit>()
.Property(e => e.WorkExperienceSponsor)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPRenewalCredit), typeof(OCAPPRenewalCreditAudit));
RegisterAuditType(typeof(OCAPPRenewalType), typeof(OCAPPRenewalTypeAudit));
modelBuilder.Entity<OCAPPRenewCodeCategorySupt>()
.Property(e => e.Description)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPRenewCodeCategorySupt), typeof(OCAPPRenewCodeCategorySuptAudit));
modelBuilder.Entity<OCAPPRenewMajorsCn>()
.Property(e => e.MajorName)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPRenewMajorsCn), typeof(OCAPPRenewMajorsCnAudit));
RegisterAuditType(typeof(OCAPPRenewProPrpCn), typeof(OCAPPRenewProPrpCnAudit));
RegisterAuditType(typeof(OCAPPRenewScreenCn), typeof(OCAPPRenewScreenCnAudit));
modelBuilder.Entity<OCAPPSDUnivSupt>()
.Property(e => e.Address1)
.IsUnicode(false);
modelBuilder.Entity<OCAPPSDUnivSupt>()
.Property(e => e.City)
.IsUnicode(false);
modelBuilder.Entity<OCAPPSDUnivSupt>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<OCAPPSDUnivSupt>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<OCAPPSDUnivSupt>()
.Property(e => e.Disabled)
.IsUnicode(false);
modelBuilder.Entity<OCAPPSDUnivSupt>()
.Property(e => e.State)
.IsUnicode(false);
modelBuilder.Entity<OCAPPSDUnivSupt>()
.Property(e => e.TranscriptCode)
.IsUnicode(false);
modelBuilder.Entity<OCAPPSDUnivSupt>()
.Property(e => e.Zip)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPSDUnivSupt), typeof(OCAPPSDUnivSuptAudit));
RegisterAuditType(typeof(OCAPPSectionComplete), typeof(OCAPPSectionCompleteAudit));
modelBuilder.Entity<OCAPPStandAloneEndorsements>()
.Property(e => e.URL)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPStandAloneEndorsements), typeof(OCAPPStandAloneEndorsementsAudit));
RegisterAuditType(typeof(OCAPPSubjAssgnCn), typeof(OCAPPSubjAssgnCnAudit));
modelBuilder.Entity<OCAppTypeSupt>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<OCAppTypeSupt>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<OCAppTypeSupt>()
.Property(e => e.Disabled)
.IsUnicode(false);
RegisterAuditType(typeof(OCAppTypeSupt), typeof(OCAppTypeSuptAudit));
modelBuilder.Entity<OCAPPUploadChoice>()
.Property(e => e.ObjectName)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPUploadChoice), typeof(OCAPPUploadChoiceAudit));
modelBuilder.Entity<OCAPPUploadFile>()
.Property(e => e.ContentType)
.IsUnicode(false);
modelBuilder.Entity<OCAPPUploadFile>()
.Property(e => e.Extension)
.IsUnicode(false);
modelBuilder.Entity<OCAPPUploadFile>()
.Property(e => e.FileDirectorID)
.IsUnicode(false);
modelBuilder.Entity<OCAPPUploadFile>()
.Property(e => e.FileName)
.IsUnicode(false);
RegisterAuditType(typeof(OCAPPUploadFile), typeof(OCAPPUploadFileAudit));
modelBuilder.Entity<OCDOEActiveLogon>()
.Property(e => e.Logon)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEActiveLogon), typeof(OCDOEActiveLogonAudit));
RegisterAuditType(typeof(OCDOEAppDInfoToCertificateType), typeof(OCDOEAppDInfoToCertificateTypeAudit));
RegisterAuditType(typeof(OCDOEAppDInfoToLevel), typeof(OCDOEAppDInfoToLevelAudit));
RegisterAuditType(typeof(OCDOEAppDInfoToPreparation), typeof(OCDOEAppDInfoToPreparationAudit));
RegisterAuditType(typeof(OCDOEAppExpedite), typeof(OCDOEAppExpediteAudit));
modelBuilder.Entity<OCDOEAppFlags>()
.Property(e => e.FlaggedBy)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEAppFlags), typeof(OCDOEAppFlagsAudit));
RegisterAuditType(typeof(OCDOECertMailOpt), typeof(OCDOECertMailOptAudit));
modelBuilder.Entity<OCDOECertSnapshot>()
.Property(e => e.CertificateTitle)
.IsUnicode(false);
modelBuilder.Entity<OCDOECertSnapshot>()
.Property(e => e.CertifiedTypeCode)
.IsUnicode(false);
modelBuilder.Entity<OCDOECertSnapshot>()
.Property(e => e.CertifiedTypeDescription)
.IsUnicode(false);
modelBuilder.Entity<OCDOECertSnapshot>()
.Property(e => e.FirstName)
.IsUnicode(false);
modelBuilder.Entity<OCDOECertSnapshot>()
.Property(e => e.HighestDegree)
.IsUnicode(false);
modelBuilder.Entity<OCDOECertSnapshot>()
.Property(e => e.LastName)
.IsUnicode(false);
modelBuilder.Entity<OCDOECertSnapshot>()
.Property(e => e.MiddleName)
.IsUnicode(false);
modelBuilder.Entity<OCDOECertSnapshot>()
.Property(e => e.SnapshotUser)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOECertSnapshot), typeof(OCDOECertSnapshotAudit));
modelBuilder.Entity<OCDOECertSSDetail>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<OCDOECertSSDetail>()
.Property(e => e.Description)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOECertSSDetail), typeof(OCDOECertSSDetailAudit));
modelBuilder.Entity<OCDOEComment>()
.Property(e => e.AddedByLogon)
.IsUnicode(false);
modelBuilder.Entity<OCDOEComment>()
.Property(e => e.AddedByName)
.IsUnicode(false);
modelBuilder.Entity<OCDOEComment>()
.Property(e => e.Comment)
.IsUnicode(false);
modelBuilder.Entity<OCDOEComment>()
.Property(e => e.SectionCode)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEComment), typeof(OCDOECommentAudit));
modelBuilder.Entity<OCDOEConReviewCn>()
.Property(e => e.Answer)
.IsUnicode(false);
modelBuilder.Entity<OCDOEConReviewCn>()
.Property(e => e.Comments)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEConReviewCn), typeof(OCDOEConReviewCnAudit));
modelBuilder.Entity<OCDOECreditTypeSupt>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<OCDOECreditTypeSupt>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<OCDOECreditTypeSupt>()
.Property(e => e.ShortDescription)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOECreditTypeSupt), typeof(OCDOECreditTypeSuptAudit));
modelBuilder.Entity<OCDOELegalities>()
.Property(e => e.CitizenshipCountry)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOELegalities), typeof(OCDOELegalitiesAudit));
modelBuilder.Entity<OCDOEOtherCerts>()
.Property(e => e.ForeignCountry)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEOtherCerts), typeof(OCDOEOtherCertsAudit));
modelBuilder.Entity<OCDOEOtherDoc>()
.Property(e => e.AddedByDOE)
.IsUnicode(false);
modelBuilder.Entity<OCDOEOtherDoc>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<OCDOEOtherDoc>()
.Property(e => e.ElectronicEntry)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEOtherDoc), typeof(OCDOEOtherDocAudit));
modelBuilder.Entity<OCDOEOtherDocSupt>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<OCDOEOtherDocSupt>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<OCDOEOtherDocSupt>()
.Property(e => e.Link)
.IsUnicode(false);
modelBuilder.Entity<OCDOEOtherDocSupt>()
.Property(e => e.ShortDescription)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEOtherDocSupt), typeof(OCDOEOtherDocSuptAudit));
modelBuilder.Entity<OCDOEOtherNationalCerts>()
.Property(e => e.Country)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEOtherNationalCerts), typeof(OCDOEOtherNationalCertsAudit));
modelBuilder.Entity<OCDOEPraxisTest>()
.Property(e => e.DOEProfileID)
.IsUnicode(false);
modelBuilder.Entity<OCDOEPraxisTest>()
.Property(e => e.Score)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEPraxisTest), typeof(OCDOEPraxisTestAudit));
modelBuilder.Entity<OCDOEPreferences>()
.Property(e => e.AppTypes)
.IsUnicode(false);
modelBuilder.Entity<OCDOEPreferences>()
.Property(e => e.Logon)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEPreferences), typeof(OCDOEPreferencesAudit));
modelBuilder.Entity<OCDOEScanDocToCorrType>()
.Property(e => e.ScanDocumentType)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOEScanDocToCorrType), typeof(OCDOEScanDocToCorrTypeAudit));
RegisterAuditType(typeof(OCDOESectionCategoryCompletionMatrix), typeof(OCDOESectionCategoryCompletionMatrixAudit));
modelBuilder.Entity<OCDOESectionComp>()
.Property(e => e.CompletedBy)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOESectionComp), typeof(OCDOESectionCompAudit));
modelBuilder.Entity<OCDOESectionLookup>()
.Property(e => e.SectionDescription)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOESectionLookup), typeof(OCDOESectionLookupAudit));
RegisterAuditType(typeof(OCDOESuspensions), typeof(OCDOESuspensionsAudit));
modelBuilder.Entity<OCDOETranscriptMatchLog>()
.Property(e => e.FileName)
.IsUnicode(false);
modelBuilder.Entity<OCDOETranscriptMatchLog>()
.Property(e => e.StampUser)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOETranscriptMatchLog), typeof(OCDOETranscriptMatchLogAudit));
modelBuilder.Entity<OCDOETranscripts>()
.Property(e => e.Country)
.IsUnicode(false);
modelBuilder.Entity<OCDOETranscripts>()
.Property(e => e.UniversityName)
.IsUnicode(false);
RegisterAuditType(typeof(OCDOETranscripts), typeof(OCDOETranscriptsAudit));
modelBuilder.Entity<OCETSPraxisTest>()
.Property(e => e.Score)
.IsUnicode(false);
RegisterAuditType(typeof(OCETSPraxisTest), typeof(OCETSPraxisTestAudit));
modelBuilder.Entity<OCUCOActiveUser>()
.Property(e => e.UCOName)
.IsUnicode(false);
RegisterAuditType(typeof(OCUCOActiveUser), typeof(OCUCOActiveUserAudit));
RegisterAuditType(typeof(OCUCOAppDInfoToCertificateType), typeof(OCUCOAppDInfoToCertificateTypeAudit));
RegisterAuditType(typeof(OCUCOAppDInfoToLevel), typeof(OCUCOAppDInfoToLevelAudit));
RegisterAuditType(typeof(OCUCOAppDInfoToPreparation), typeof(OCUCOAppDInfoToPreparationAudit));
modelBuilder.Entity<OCUCOAppEducVerification>()
.Property(e => e.UCOResponse)
.IsUnicode(false);
RegisterAuditType(typeof(OCUCOAppEducVerification), typeof(OCUCOAppEducVerificationAudit));
RegisterAuditType(typeof(OCUCOAppSignOff), typeof(OCUCOAppSignOffAudit));
modelBuilder.Entity<OCUCOComments>()
.Property(e => e.Comment)
.IsUnicode(false);
RegisterAuditType(typeof(OCUCOComments), typeof(OCUCOCommentsAudit));
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.City)
.IsUnicode(false);
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.Correction)
.IsUnicode(false);
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.Country)
.IsUnicode(false);
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.Major)
.IsUnicode(false);
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.Minor)
.IsUnicode(false);
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.OtherUniv)
.IsUnicode(false);
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.ReleaseToUniversity)
.IsUnicode(false);
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.State)
.IsUnicode(false);
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.StudentID)
.IsUnicode(false);
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.TranscriptComing)
.IsUnicode(false);
modelBuilder.Entity<OCUCOEducation>()
.Property(e => e.Zip)
.IsUnicode(false);
RegisterAuditType(typeof(OCUCOEducation), typeof(OCUCOEducationAudit));
RegisterAuditType(typeof(OCUCOEndorsementCn), typeof(OCUCOEndorsementCnAudit));
RegisterAuditType(typeof(OCUCOMajorsCn), typeof(OCUCOMajorsCnAudit));
modelBuilder.Entity<OCUCOOnlineAppCC>()
.Property(e => e.Login)
.IsUnicode(false);
modelBuilder.Entity<OCUCOOnlineAppCC>()
.Property(e => e.Transkey)
.IsUnicode(false);
RegisterAuditType(typeof(OCUCOOnlineAppCC), typeof(OCUCOOnlineAppCCAudit));
modelBuilder.Entity<OCUCOPraxisTests>()
.Property(e => e.Score)
.IsUnicode(false);
RegisterAuditType(typeof(OCUCOPraxisTests), typeof(OCUCOPraxisTestsAudit));
RegisterAuditType(typeof(OCUCOProfessionalPrepCn), typeof(OCUCOProfessionalPrepCnAudit));
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.Address1)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.Address2)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.ApplicantSubmissionNotification)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.City)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.Disabled)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.Email)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.FirstName)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.LastName)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.MustChangePassword)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.Password)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.Phone)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.UCONotificationSubmission)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.Username)
.IsUnicode(false);
modelBuilder.Entity<OCUCOProfile>()
.Property(e => e.Zip)
.IsUnicode(false);
RegisterAuditType(typeof(OCUCOProfile), typeof(OCUCOProfileAudit));
modelBuilder.Entity<OCUCOSectionComplete>()
.Property(e => e.Complete)
.IsUnicode(false);
RegisterAuditType(typeof(OCUCOSectionComplete), typeof(OCUCOSectionCompleteAudit));
modelBuilder.Entity<Option>()
.Property(e => e.Text)
.IsUnicode(false);
modelBuilder.Entity<Option>()
.Property(e => e.Type)
.IsUnicode(false);
RegisterAuditType(typeof(Option), typeof(OptionAudit));
modelBuilder.Entity<OtherAct>()
.Property(e => e.ActivityDescr)
.IsUnicode(false);
RegisterAuditType(typeof(OtherAct), typeof(OtherActAudit));
modelBuilder.Entity<ParaAttn>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<ParaAttn>()
.Property(e => e.ParaRec)
.IsUnicode(false);
modelBuilder.Entity<ParaAttn>()
.Property(e => e.PartD)
.IsUnicode(false);
modelBuilder.Entity<ParaAttn>()
.Property(e => e.SchoolWide)
.IsUnicode(false);
modelBuilder.Entity<ParaAttn>()
.Property(e => e.TargeteDAst)
.IsUnicode(false);
RegisterAuditType(typeof(ParaAttn), typeof(ParaAttnAudit));
RegisterAuditType(typeof(ParaFundingFTEPct), typeof(ParaFundingFTEPctAudit));
RegisterAuditType(typeof(ParaJobResp), typeof(ParaJobRespAudit));
modelBuilder.Entity<ParaProf>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<ParaProf>()
.Property(e => e.ContractedOther)
.IsUnicode(false);
modelBuilder.Entity<ParaProf>()
.Property(e => e.FirstName)
.IsUnicode(false);
modelBuilder.Entity<ParaProf>()
.Property(e => e.HQTeachers)
.IsUnicode(false);
modelBuilder.Entity<ParaProf>()
.Property(e => e.HSDiploma)
.IsUnicode(false);
modelBuilder.Entity<ParaProf>()
.Property(e => e.LastName)
.IsUnicode(false);
modelBuilder.Entity<ParaProf>()
.Property(e => e.MI)
.IsUnicode(false);
modelBuilder.Entity<ParaProf>()
.Property(e => e.ParaYear)
.IsUnicode(false);
modelBuilder.Entity<ParaProf>()
.Property(e => e.SSN)
.IsUnicode(false);
RegisterAuditType(typeof(ParaProf), typeof(ParaProfAudit));
RegisterAuditType(typeof(ParaQual), typeof(ParaQualAudit));
RegisterAuditType(typeof(ParaStudInfo), typeof(ParaStudInfoAudit));
modelBuilder.Entity<ParaSupport>()
.Property(e => e.Paraprof)
.IsUnicode(false);
modelBuilder.Entity<ParaSupport>()
.Property(e => e.ParaType)
.IsUnicode(false);
RegisterAuditType(typeof(ParaSupport), typeof(ParaSupportAudit));
modelBuilder.Entity<PersonFlagged>()
.Property(e => e.FlagAddedBy)
.IsUnicode(false);
RegisterAuditType(typeof(PersonFlagged), typeof(PersonFlaggedAudit));
modelBuilder.Entity<PersonInfo>()
.Property(e => e.Country)
.IsUnicode(false);
modelBuilder.Entity<PersonInfo>()
.Property(e => e.DayPhone)
.IsUnicode(false);
modelBuilder.Entity<PersonInfo>()
.Property(e => e.EmailAddress)
.IsUnicode(false);
modelBuilder.Entity<PersonInfo>()
.Property(e => e.EveningPhone)
.IsUnicode(false);
RegisterAuditType(typeof(PersonInfo), typeof(PersonInfoAudit));
modelBuilder.Entity<PersonNonAuthPositionCodeMap>()
.Property(e => e.AssignmentCode)
.IsUnicode(false);
modelBuilder.Entity<PersonNonAuthPositionCodeMap>()
.Property(e => e.DistrictNumber)
.IsUnicode(false);
modelBuilder.Entity<PersonNonAuthPositionCodeMap>()
.Property(e => e.PositionCode)
.IsUnicode(false);
modelBuilder.Entity<PersonNonAuthPositionCodeMap>()
.Property(e => e.SchoolNumber)
.IsUnicode(false);
modelBuilder.Entity<PersonNonAuthPositionCodeMap>()
.Property(e => e.SSN)
.IsUnicode(false);
RegisterAuditType(typeof(PersonNonAuthPositionCodeMap), typeof(PersonNonAuthPositionCodeMapAudit));
RegisterAuditType(typeof(PlanOfIntentToRequirementOptionGroup), typeof(PlanOfIntentToRequirementOptionGroupAudit));
RegisterAuditType(typeof(PlanOfIntentToRequirementOptionGroupToListGroup), typeof(PlanOfIntentToRequirementOptionGroupToListGroupAudit));
modelBuilder.Entity<POISpedInd>()
.Property(e => e.AlreadyTakenPraxis)
.IsUnicode(false);
modelBuilder.Entity<POISpedInd>()
.Property(e => e.PubNonPub)
.IsUnicode(false);
modelBuilder.Entity<POISpedInd>()
.Property(e => e.ReqAddlAuth)
.IsUnicode(false);
modelBuilder.Entity<POISpedInd>()
.Property(e => e.ReqCrsworkTest)
.IsUnicode(false);
modelBuilder.Entity<POISpedInd>()
.Property(e => e.ReqPraxisAndDegree)
.IsUnicode(false);
modelBuilder.Entity<POISpedInd>()
.Property(e => e.ReqPraxisAndSpedCrswrk)
.IsUnicode(false);
modelBuilder.Entity<POISpedInd>()
.Property(e => e.ReqPraxisAndSpedDegree)
.IsUnicode(false);
modelBuilder.Entity<POISpedInd>()
.Property(e => e.ThreeYearsExp)
.IsUnicode(false);
modelBuilder.Entity<POISpedInd>()
.Property(e => e.ValidCoursework)
.IsUnicode(false);
modelBuilder.Entity<POISpedInd>()
.Property(e => e.WillTakePraxis)
.IsUnicode(false);
RegisterAuditType(typeof(POISpedInd), typeof(POISpedIndAudit));
RegisterAuditType(typeof(POISpedTasks), typeof(POISpedTasksAudit));
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.AlreadyTakenPraxis)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.LapsedCert)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.PubNonPub)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.PursueCert)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.RegOrSped)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.ReqAddlAuth)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.ReqCrsworkTest)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.ReqPraxisAndDegree)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.Retire)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.TempHire)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.ThreeYearsExp)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.ValidCoursework)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.WillTakePraxis)
.IsUnicode(false);
modelBuilder.Entity<PraxisAssgnCn>()
.Property(e => e.WorkExp)
.IsUnicode(false);
RegisterAuditType(typeof(PraxisAssgnCn), typeof(PraxisAssgnCnAudit));
modelBuilder.Entity<Preclusion>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<Preclusion>()
.Property(e => e.TargetType)
.IsUnicode(false);
modelBuilder.Entity<Preclusion>()
.Property(e => e.WouldPrecludeType)
.IsUnicode(false);
RegisterAuditType(typeof(Preclusion), typeof(PreclusionAudit));
modelBuilder.Entity<PreparationToCertificate>()
.Property(e => e.CertificateNumber)
.IsUnicode(false);
RegisterAuditType(typeof(PreparationToCertificate), typeof(PreparationToCertificateAudit));
modelBuilder.Entity<PreviousLastName>()
.Property(e => e.PrevLastName)
.IsUnicode(false);
RegisterAuditType(typeof(PreviousLastName), typeof(PreviousLastNameAudit));
modelBuilder.Entity<PRFAssgn>()
.Property(e => e.Qtr1)
.IsUnicode(false);
modelBuilder.Entity<PRFAssgn>()
.Property(e => e.Qtr2)
.IsUnicode(false);
modelBuilder.Entity<PRFAssgn>()
.Property(e => e.Qtr3)
.IsUnicode(false);
modelBuilder.Entity<PRFAssgn>()
.Property(e => e.Qtr4)
.IsUnicode(false);
modelBuilder.Entity<PRFAssgn>()
.Property(e => e.Trimester1)
.IsUnicode(false);
modelBuilder.Entity<PRFAssgn>()
.Property(e => e.Trimester2)
.IsUnicode(false);
modelBuilder.Entity<PRFAssgn>()
.Property(e => e.Trimester3)
.IsUnicode(false);
RegisterAuditType(typeof(PRFAssgn), typeof(PRFAssgnAudit));
RegisterAuditType(typeof(PRFAssgnTypeToEndorsement), typeof(PRFAssgnTypeToEndorsementAudit));
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.BVIIndicator)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.DHIIndicator)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.ErrorCode)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.ESLIndicator)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.IsAtOtherDistrict)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.IsClassSizeReductionTeacher)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.IsDigitalCurriculum)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.IsElectronicDistanceInstruction)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.IsInterventionTeacher)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.IsPDCTeacher)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.Qtr1)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.Qtr2)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.Qtr3)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.Qtr4)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.RawLine)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.SPEDIndicator)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.Trimester1)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.Trimester2)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportHold>()
.Property(e => e.Trimester3)
.IsUnicode(false);
RegisterAuditType(typeof(PRFAssignmentImportHold), typeof(PRFAssignmentImportHoldAudit));
modelBuilder.Entity<PRFAssignmentImportLog>()
.Property(e => e.FileName)
.IsUnicode(false);
modelBuilder.Entity<PRFAssignmentImportLog>()
.Property(e => e.StampUser)
.IsUnicode(false);
RegisterAuditType(typeof(PRFAssignmentImportLog), typeof(PRFAssignmentImportLogAudit));
modelBuilder.Entity<PRFImportControlTotals>()
.Property(e => e.UploadType)
.IsUnicode(false);
RegisterAuditType(typeof(PRFImportControlTotals), typeof(PRFImportControlTotalsAudit));
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.Asian)
.IsUnicode(false);
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.Black)
.IsUnicode(false);
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.Email)
.IsUnicode(false);
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.ErrorCode)
.IsUnicode(false);
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.Hawaiian)
.IsUnicode(false);
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.Hispanic)
.IsUnicode(false);
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.Indian)
.IsUnicode(false);
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.RawLine)
.IsUnicode(false);
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.VacantPositionFilledFirstDay)
.IsUnicode(false);
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.VacanyOther)
.IsUnicode(false);
modelBuilder.Entity<PRFImportHold>()
.Property(e => e.White)
.IsUnicode(false);
RegisterAuditType(typeof(PRFImportHold), typeof(PRFImportHoldAudit));
modelBuilder.Entity<PRFImportLog>()
.Property(e => e.FileName)
.IsUnicode(false);
modelBuilder.Entity<PRFImportLog>()
.Property(e => e.StampUser)
.IsUnicode(false);
RegisterAuditType(typeof(PRFImportLog), typeof(PRFImportLogAudit));
modelBuilder.Entity<PRFInfo>()
.Property(e => e.Email)
.IsUnicode(false);
modelBuilder.Entity<PRFInfo>()
.Property(e => e.HiringComment)
.IsUnicode(false);
modelBuilder.Entity<PRFInfo>()
.Property(e => e.Vacancy)
.IsUnicode(false);
RegisterAuditType(typeof(PRFInfo), typeof(PRFInfoAudit));
modelBuilder.Entity<PrntCode>()
.Property(e => e.Disabled)
.IsUnicode(false);
modelBuilder.Entity<PrntCode>()
.Property(e => e.Printcode)
.IsUnicode(false);
modelBuilder.Entity<PrntCode>()
.Property(e => e.Printcodedescription)
.IsUnicode(false);
RegisterAuditType(typeof(PrntCode), typeof(PrntCodeAudit));
modelBuilder.Entity<PrvdT2>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<PrvdT2>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<PrvdT2>()
.Property(e => e.Disabled)
.IsUnicode(false);
RegisterAuditType(typeof(PrvdT2), typeof(PrvdT2Audit));
modelBuilder.Entity<Qualification>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<Qualification>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<Qualification>()
.Property(e => e.Type)
.IsUnicode(false);
RegisterAuditType(typeof(Qualification), typeof(QualificationAudit));
modelBuilder.Entity<Question>()
.Property(e => e.QuestionText)
.IsUnicode(false);
modelBuilder.Entity<Question>()
.Property(e => e.Title)
.IsUnicode(false);
modelBuilder.Entity<Question>()
.Property(e => e.Type)
.IsUnicode(false);
RegisterAuditType(typeof(Question), typeof(QuestionAudit));
modelBuilder.Entity<QuestionAnswerToTrigger>()
.Property(e => e.Message)
.IsUnicode(false);
RegisterAuditType(typeof(QuestionAnswerToTrigger), typeof(QuestionAnswerToTriggerAudit));
modelBuilder.Entity<Requirement>()
.Property(e => e.Text)
.IsUnicode(false);
modelBuilder.Entity<Requirement>()
.Property(e => e.Type)
.IsUnicode(false);
RegisterAuditType(typeof(Requirement), typeof(RequirementAudit));
RegisterAuditType(typeof(RequirementOptionGroup), typeof(RequirementOptionGroupAudit));
modelBuilder.Entity<RevkDriv>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<RevkDriv>()
.Property(e => e.FirstName)
.IsUnicode(false);
modelBuilder.Entity<RevkDriv>()
.Property(e => e.LastName)
.IsUnicode(false);
modelBuilder.Entity<RevkDriv>()
.Property(e => e.MiddleName)
.IsUnicode(false);
modelBuilder.Entity<RevkDriv>()
.Property(e => e.SSN)
.IsUnicode(false);
RegisterAuditType(typeof(RevkDriv), typeof(RevkDrivAudit));
modelBuilder.Entity<RollForwardCodeMaintenance>()
.Property(e => e.NewCode)
.IsUnicode(false);
modelBuilder.Entity<RollForwardCodeMaintenance>()
.Property(e => e.NewDescription)
.IsUnicode(false);
modelBuilder.Entity<RollForwardCodeMaintenance>()
.Property(e => e.OldDescription)
.IsUnicode(false);
modelBuilder.Entity<RollForwardCodeMaintenance>()
.Property(e => e.OriginalCode)
.IsUnicode(false);
RegisterAuditType(typeof(RollForwardCodeMaintenance), typeof(RollForwardCodeMaintenanceAudit));
RegisterAuditType(typeof(SchoolTypeToPosition), typeof(SchoolTypeToPositionAudit));
modelBuilder.Entity<SchoolYear>()
.Property(e => e.SchoolYearColumn)
.IsUnicode(false);
RegisterAuditType(typeof(SchoolYear), typeof(SchoolYearAudit));
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.Address)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.AttendInst)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.BirthDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CandidateIDNumber)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.City)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CountryCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CreationDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest1Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest1Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest1Filler)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest1NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest1ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest1Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest2Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest2Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest2Filler)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest2NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest2ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest2Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest3Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest3Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest3Filler)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest3NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest3ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest3Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest4Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest4Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest4Filler)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest4NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest4ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest4Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest5Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest5Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest5Filler)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest5NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest5ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest5Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest6Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest6Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest6Filler)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest6NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest6ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.CurrTest6Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.EducationLevel)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.EthnicityCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.FirstName)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.GradMajor)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest10Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest10Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest10NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest10ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest10RSI)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest10Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest1Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest1Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest1NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest1ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest1RSI)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest1Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest2Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest2Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest2NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest2ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest2RSI)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest2Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest3Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest3Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest3NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest3ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest3RSI)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest3Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest4Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest4Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest4NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest4ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest4RSI)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest4Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest5Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest5Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest5NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest5ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest5RSI)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest5Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest6Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest6Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest6NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest6ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest6RSI)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest6Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest7Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest7Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest7NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest7ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest7RSI)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest7Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest8Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest8Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest8NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest8ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest8RSI)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest8Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest9Code)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest9Date)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest9NonStandAdmin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest9ROE)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest9RSI)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.HiScoreTest9Score)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.LastName)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.LowValueFiller)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.MiddleInitial)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest10HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest10HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest10HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest10HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest10HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest10HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest10HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest11HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest11HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest11HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest11HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest11HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest11HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest11HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest12HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest12HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest12HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest12HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest12HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest12HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest12HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest13HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest13HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest13HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest13HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest13HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest13HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest13HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest14HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest14HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest14HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest14HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest14HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest14HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest14HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest15HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest15HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest15HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest15HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest15HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest15HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest15HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest16HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest16HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest16HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest16HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest16HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest16HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest16HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest17HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest17HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest17HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest17HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest17HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest17HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest17HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest18HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest18HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest18HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest18HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest18HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest18HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest18HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest19HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest19HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest19HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest19HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest19HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest19HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest19HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest1HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest1HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest1HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest1HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest1HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest1HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest1HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest20HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest20HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest20HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest20HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest20HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest20HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest20HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest21HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest21HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest21HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest21HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest21HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest21HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest21HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest22HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest22HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest22HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest22HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest22HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest22HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest22HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest23HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest23HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest23HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest23HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest23HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest23HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest23HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest24HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest24HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest24HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest24HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest24HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest24HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest24HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest25HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest25HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest25HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest25HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest25HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest25HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest25HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest26HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest26HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest26HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest26HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest26HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest26HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest26HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest27HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest27HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest27HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest27HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest27HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest27HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest27HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest28HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest28HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest28HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest28HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest28HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest28HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest28HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest29HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest29HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest29HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest29HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest29HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest29HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest29HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest2HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest2HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest2HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest2HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest2HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest2HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest2HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest30HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest30HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest30HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest30HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest30HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest30HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest30HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest31HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest31HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest31HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest31HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest31HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest31HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest31HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest32HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest32HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest32HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest32HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest32HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest32HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest32HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest33HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest33HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest33HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest33HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest33HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest33HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest33HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest34HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest34HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest34HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest34HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest34HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest34HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest34HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest35HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest35HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest35HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest35HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest35HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest35HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest35HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest36HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest36HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest36HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest36HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest36HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest36HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest36HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest3HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest3HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest3HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest3HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest3HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest3HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest3HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest4HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest4HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest4HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest4HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest4HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest4HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest4HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest5HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest5HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest5HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest5HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest5HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest5HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest5HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest6HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest6HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest6HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest6HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest6HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest6HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest6HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest7HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest7HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest7HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest7HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest7HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest7HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest7HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest8HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest8HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest8HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest8HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest8HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest8HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest8HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest9HiScoreCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest9HiScoreDate)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest9HiScoreMetNM)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest9HiScorePassedNP)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest9HiScoreReqMin)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest9HiScoreReqPass)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.PassNPTest9HiScoreScore)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.ProgramIdentifier)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.RecipientCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.Sex)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.SSN)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.State)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.StateCode)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.UndergradGPA)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.UndergradMajor)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.UniqueRecNum)
.IsUnicode(false);
modelBuilder.Entity<ScoreLinkData>()
.Property(e => e.Zip)
.IsUnicode(false);
RegisterAuditType(typeof(ScoreLinkData), typeof(ScoreLinkDataAudit));
modelBuilder.Entity<SDIndStudies>()
.Property(e => e.Completed)
.IsUnicode(false);
RegisterAuditType(typeof(SDIndStudies), typeof(SDIndStudiesAudit));
modelBuilder.Entity<Section>()
.Property(e => e.Name)
.IsUnicode(false);
modelBuilder.Entity<Section>()
.Property(e => e.SectionCode)
.IsUnicode(false);
modelBuilder.Entity<Section>()
.Property(e => e.URL)
.IsUnicode(false);
RegisterAuditType(typeof(Section), typeof(SectionAudit));
RegisterAuditType(typeof(SectionToQuestion), typeof(SectionToQuestionAudit));
RegisterAuditType(typeof(SpedEndAssgn), typeof(SpedEndAssgnAudit));
modelBuilder.Entity<SpEdIndAssgn>()
.Property(e => e.SpedAssgn)
.IsUnicode(false);
RegisterAuditType(typeof(SpEdIndAssgn), typeof(SpEdIndAssgnAudit));
RegisterAuditType(typeof(SpedMajAssgn), typeof(SpedMajAssgnAudit));
RegisterAuditType(typeof(SpedPrepAssgn), typeof(SpedPrepAssgnAudit));
RegisterAuditType(typeof(SpedSubjAssgn), typeof(SpedSubjAssgnAudit));
modelBuilder.Entity<SPEDTestCombine>()
.Property(e => e.IncludeOnPOI)
.IsUnicode(false);
RegisterAuditType(typeof(SPEDTestCombine), typeof(SPEDTestCombineAudit));
modelBuilder.Entity<SPEDTstCombin>()
.Property(e => e.IncludeOnPOI)
.IsUnicode(false);
RegisterAuditType(typeof(SPEDTstCombin), typeof(SPEDTstCombinAudit));
modelBuilder.Entity<StateData>()
.Property(e => e.DegreeDate)
.IsUnicode(false);
RegisterAuditType(typeof(StateData), typeof(StateDataAudit));
modelBuilder.Entity<StateTest>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<StateTest>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<StateTest>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<StateTest>()
.Property(e => e.Disabled)
.IsUnicode(false);
modelBuilder.Entity<StateTest>()
.Property(e => e.QualifyingHighScore)
.IsUnicode(false);
modelBuilder.Entity<StateTest>()
.Property(e => e.QualifyingLowScore)
.IsUnicode(false);
modelBuilder.Entity<StateTest>()
.Property(e => e.ValidForCutScore)
.IsUnicode(false);
modelBuilder.Entity<StateTest>()
.Property(e => e.ValidForSouthDakota)
.IsUnicode(false);
RegisterAuditType(typeof(StateTest), typeof(StateTestAudit));
modelBuilder.Entity<StateTst>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<StateTst>()
.Property(e => e.Comments)
.IsUnicode(false);
modelBuilder.Entity<StateTst>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<StateTst>()
.Property(e => e.Disabled)
.IsUnicode(false);
modelBuilder.Entity<StateTst>()
.Property(e => e.QualifyingHighScore)
.IsUnicode(false);
modelBuilder.Entity<StateTst>()
.Property(e => e.QualifyingLowScore)
.IsUnicode(false);
modelBuilder.Entity<StateTst>()
.Property(e => e.ValidForCutScore)
.IsUnicode(false);
modelBuilder.Entity<StateTst>()
.Property(e => e.ValidForSouthDakota)
.IsUnicode(false);
RegisterAuditType(typeof(StateTst), typeof(StateTstAudit));
RegisterAuditType(typeof(StateTstETSCn), typeof(StateTstETSCnAudit));
RegisterAuditType(typeof(SubAssgn), typeof(SubAssgnAudit));
modelBuilder.Entity<TimeOpt>()
.Property(e => e.TimeOption)
.IsUnicode(false);
RegisterAuditType(typeof(TimeOpt), typeof(TimeOptAudit));
modelBuilder.Entity<Trigger>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<Trigger>()
.Property(e => e.Name)
.IsUnicode(false);
RegisterAuditType(typeof(Trigger), typeof(TriggerAudit));
modelBuilder.Entity<User>()
.Property(e => e.Email)
.IsUnicode(false);
modelBuilder.Entity<User>()
.Property(e => e.Password)
.IsUnicode(false);
modelBuilder.Entity<User>()
.Property(e => e.RecoveryEmail)
.IsUnicode(false);
modelBuilder.Entity<User>()
.Property(e => e.SSN)
.IsUnicode(false);
RegisterAuditType(typeof(User), typeof(UserAudit));
modelBuilder.Entity<UserTemporaryToken>()
.Property(e => e.TemporaryToken)
.IsUnicode(false);
RegisterAuditType(typeof(UserTemporaryToken), typeof(UserTemporaryTokenAudit));
modelBuilder.Entity<Vacancy>()
.Property(e => e.Comments)
.IsUnicode(false);
RegisterAuditType(typeof(Vacancy), typeof(VacancyAudit));
RegisterAuditType(typeof(VacPosCnn), typeof(VacPosCnnAudit));
modelBuilder.Entity<VirtualSchool>()
.Property(e => e.HasCourses)
.IsUnicode(false);
RegisterAuditType(typeof(VirtualSchool), typeof(VirtualSchoolAudit));
RegisterAuditType(typeof(VSCntCrs), typeof(VSCntCrsAudit));
RegisterAuditType(typeof(VSCourse), typeof(VSCourseAudit));
RegisterAuditType(typeof(VSCourse2016), typeof(VSCourse2016Audit));
}

}
}
