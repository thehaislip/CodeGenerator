using System;
using System.Data.Entity;
 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace GeneratedContext
{ 
public partial class de69persContext
:DbContext{ 
 public Context()
: base("name = de69persContext")
{
}
public virtual DbSet<Address> Address { get; set; }
public virtual DbSet<Assignment> Assignment { get; set; }
public virtual DbSet<AssignmentsOldToNew> AssignmentsOldToNew { get; set; }
public virtual DbSet<AssignmentToEndorsement> AssignmentToEndorsement { get; set; }
public virtual DbSet<AssignmentType> AssignmentType { get; set; }
public virtual DbSet<AssignmentTypesOldToNew> AssignmentTypesOldToNew { get; set; }
public virtual DbSet<AssignmentTypeToAssignment> AssignmentTypeToAssignment { get; set; }
public virtual DbSet<CertCred> CertCred { get; set; }
public virtual DbSet<CertCredBridge> CertCredBridge { get; set; }
public virtual DbSet<CertHistory> CertHistory { get; set; }
public virtual DbSet<CertType> CertType { get; set; }
public virtual DbSet<CommLookup> CommLookup { get; set; }
public virtual DbSet<CommLookupBridge> CommLookupBridge { get; set; }
public virtual DbSet<CommLookupOldToNew> CommLookupOldToNew { get; set; }
public virtual DbSet<CommLookupType> CommLookupType { get; set; }
public virtual DbSet<CommLookupTypeToCommLookup> CommLookupTypeToCommLookup { get; set; }
public virtual DbSet<COMMPerson> COMMPerson { get; set; }
public virtual DbSet<CredType> CredType { get; set; }
public virtual DbSet<DataTypeExamples> DataTypeExamples { get; set; }
public virtual DbSet<DE04AssgnAltDesc> DE04AssgnAltDesc { get; set; }
public virtual DbSet<DE04CommLookup> DE04CommLookup { get; set; }
public virtual DbSet<DE04CommLookupType> DE04CommLookupType { get; set; }
public virtual DbSet<DE04CommLookupTypeToCommLookup> DE04CommLookupTypeToCommLookup { get; set; }
public virtual DbSet<DE04EndAssgnOBDTA> DE04EndAssgnOBDTA { get; set; }
public virtual DbSet<DE04EndrCodeOBDTA> DE04EndrCodeOBDTA { get; set; }
public virtual DbSet<Degree> Degree { get; set; }
public virtual DbSet<Endorsement> Endorsement { get; set; }
public virtual DbSet<EndorsementRequirement> EndorsementRequirement { get; set; }
public virtual DbSet<FedEth> FedEth { get; set; }
public virtual DbSet<FedHisp> FedHisp { get; set; }
public virtual DbSet<License> License { get; set; }
public virtual DbSet<LicenseType> LicenseType { get; set; }
public virtual DbSet<ListGroup> ListGroup { get; set; }
public virtual DbSet<OCAPPAppEduc> OCAPPAppEduc { get; set; }
public virtual DbSet<OCAPPAttTypeSup> OCAPPAttTypeSup { get; set; }
public virtual DbSet<OCAPPConReviewAppTypeCn> OCAPPConReviewAppTypeCn { get; set; }
public virtual DbSet<OCAPPConReviewCn> OCAPPConReviewCn { get; set; }
public virtual DbSet<OCAPPConReviewSup> OCAPPConReviewSup { get; set; }
public virtual DbSet<OCAPPDegreeTypSupt> OCAPPDegreeTypSupt { get; set; }
public virtual DbSet<OCAppDInfo> OCAppDInfo { get; set; }
public virtual DbSet<OCAPPExperienceResponse> OCAPPExperienceResponse { get; set; }
public virtual DbSet<OCAPPFedEth> OCAPPFedEth { get; set; }
public virtual DbSet<OCAPPFedHisp> OCAPPFedHisp { get; set; }
public virtual DbSet<OCAPPOtherCerts> OCAPPOtherCerts { get; set; }
public virtual DbSet<OCAPPOverrideQueue> OCAPPOverrideQueue { get; set; }
public virtual DbSet<OCAPPPaymentDetail> OCAPPPaymentDetail { get; set; }
public virtual DbSet<OCAPPPaymentOption> OCAPPPaymentOption { get; set; }
public virtual DbSet<OCAPPPraxisTests> OCAPPPraxisTests { get; set; }
public virtual DbSet<OCAPPPrevLastName> OCAPPPrevLastName { get; set; }
public virtual DbSet<OCAPPProcessingFee> OCAPPProcessingFee { get; set; }
public virtual DbSet<OCAPPProfPrep> OCAPPProfPrep { get; set; }
public virtual DbSet<OCAPPProfPrepCn> OCAPPProfPrepCn { get; set; }
public virtual DbSet<OCAPPRenewalCredit> OCAPPRenewalCredit { get; set; }
public virtual DbSet<OCAPPRenewalType> OCAPPRenewalType { get; set; }
public virtual DbSet<OCAPPRenewCodeCategorySupt> OCAPPRenewCodeCategorySupt { get; set; }
public virtual DbSet<OCAPPRenewMajorsCn> OCAPPRenewMajorsCn { get; set; }
public virtual DbSet<OCAPPRenewProPrpCn> OCAPPRenewProPrpCn { get; set; }
public virtual DbSet<OCAPPSDUnivSupt> OCAPPSDUnivSupt { get; set; }
public virtual DbSet<OCAppTypeSupt> OCAppTypeSupt { get; set; }
public virtual DbSet<Option> Option { get; set; }
public virtual DbSet<PersonInfo> PersonInfo { get; set; }
public virtual DbSet<PrevLastName> PrevLastName { get; set; }
public virtual DbSet<Qualification> Qualification { get; set; }
public virtual DbSet<Requirement> Requirement { get; set; }
public virtual DbSet<RequirementOptionGroup> RequirementOptionGroup { get; set; }

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
modelBuilder.Entity<Assignment>()
.Property(e => e.Code)
.IsUnicode(false);
modelBuilder.Entity<Assignment>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<AssignmentType>()
.Property(e => e.Name)
.IsUnicode(false);
modelBuilder.Entity<AssignmentType>()
.Property(e => e.BriefDescription)
.IsUnicode(false);
modelBuilder.Entity<AssignmentType>()
.Property(e => e.Description)
.IsUnicode(false);
modelBuilder.Entity<AssignmentType>()
.Property(e => e.KeyPrefix)
.IsUnicode(false);
modelBuilder.Entity<CertCred>()
.Property(e => e.CertCredPrefix)
.IsUnicode(false);
modelBuilder.Entity<CertCred>()
.Property(e => e.HumanRelations)
.IsUnicode(false);
modelBuilder.Entity<CertCred>()
.Property(e => e.AcademicPreparation)
.IsUnicode(false);
modelBuilder.Entity<CertCred>()
.Property(e => e.BatchPrint)
.IsUnicode(false);
modelBuilder.Entity<CertHistory>()
.Property(e => e.ActionBy)
.IsUnicode(false);
}

}
}
using System;
using System.Data.Entity;
 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace GeneratedContext
{ 
public partial class Address
{ 
public Address()
{
}
[Required]
public int ID {get; set;}
[Required]
StringLength(40)
public string Address1 {get; set;}
[Required]
StringLength(40)
public string Address2 {get; set;}
[Required]
StringLength(40)
public string City {get; set;}
[Required]
StringLength(40)
public string State {get; set;}
[Required]
StringLength(10)
public string Zip {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? PersonneID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
}
public partial class Assignment
{ 
public Assignment()
{
this.AssignmentToEndorsements = new HashSet<AssignmentToEndorsement>();
this.AssignmentTypeToAssignments = new HashSet<AssignmentTypeToAssignment>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Required]
StringLength(20)
public string Code {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
[Required]
public bool DisabledInd {get; set;}
[Column(TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? SchoolStructureID {get; set;}
public virtual ICollection<AssignmentToEndorsement> AssignmentToEndorsements{get; set;}
public virtual ICollection<AssignmentTypeToAssignment> AssignmentTypeToAssignments{get; set;}
public virtual CommLookup CommLookup{get; set;}
}
public partial class AssignmentsOldToNew
{ 
public AssignmentsOldToNew()
{
}
[Required]
public uniqueidentifier NewID {get; set;}
[Required]
public int OldID {get; set;}
}
public partial class AssignmentToEndorsement
{ 
public AssignmentToEndorsement()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int Id {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int AssignmentID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int EndorsementID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual Assignment Assignment{get; set;}
public virtual Endorsement Endorsement{get; set;}
}
public partial class AssignmentType
{ 
public AssignmentType()
{
this.AssignmentTypeToAssignments = new HashSet<AssignmentTypeToAssignment>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Required]
StringLength(80)
public string Name {get; set;}
[Required]
StringLength(80)
public string BriefDescription {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
[Required]
StringLength(10)
public string KeyPrefix {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual ICollection<AssignmentTypeToAssignment> AssignmentTypeToAssignments{get; set;}
}
public partial class AssignmentTypesOldToNew
{ 
public AssignmentTypesOldToNew()
{
}
[Required]
public int ID {get; set;}
[Required]
public uniqueidentifier NewID {get; set;}
}
public partial class AssignmentTypeToAssignment
{ 
public AssignmentTypeToAssignment()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int AssignmentID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int AssignmentTypeID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual Assignment Assignment{get; set;}
public virtual AssignmentType AssignmentType{get; set;}
}
public partial class CertCred
{ 
public CertCred()
{
}
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
StringLength(2)
public string CertCredPrefix {get; set;}
public int? CertCredNumber {get; set;}
public int? CertCredRevisionNumber {get; set;}
public DateTime? DateIssued {get; set;}
public DateTime? DateExpire {get; set;}
[Required]
StringLength(1)
public string HumanRelations {get; set;}
[Required]
StringLength(2)
public string AcademicPreparation {get; set;}
public int? CertCredTypeID {get; set;}
public int? PrintCodeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? PersonnelID {get; set;}
[Required]
StringLength(1)
public string BatchPrint {get; set;}
public DateTime? BatchPrintDate {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
}
public partial class CertCredBridge
{ 
public CertCredBridge()
{
}
[Required]
public int ObjectID {get; set;}
[Required]
public int TypeID {get; set;}
}
public partial class CertHistory
{ 
public CertHistory()
{
}
[Required]
public int ID {get; set;}
public int? PersonnelID {get; set;}
public int? CertCredID {get; set;}
public int? CertTypeID {get; set;}
public int? RevisionNumber {get; set;}
public DateTime? DateIssued {get; set;}
public DateTime? DateExpired {get; set;}
[Required]
StringLength(15)
public string ActionBy {get; set;}
public DateTime? ActionDate {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
}
public partial class CertType
{ 
public CertType()
{
}
[Required]
public int ID {get; set;}
[Required]
StringLength(12)
public string CertifiedTypeCode {get; set;}
[Required]
StringLength(120)
public string CertifiedTypeDesc {get; set;}
[Required]
public bool AuthToAct {get; set;}
[Required]
public bool Disabled {get; set;}
public DateTime? DateDisabled {get; set;}
public int? ValidLengthOfYears {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
}
public partial class CommLookup
{ 
public CommLookup()
{
this.OCAPPPaymentOptions = new HashSet<OCAPPPaymentOption>();
this.OCAPPRenewMajorsCns = new HashSet<OCAPPRenewMajorsCn>();
this.ListGroups = new HashSet<ListGroup>();
this.OCAPPOtherCertss = new HashSet<OCAPPOtherCerts>();
this.Endorsements = new HashSet<Endorsement>();
this.CommLookupTypeToCommLookups = new HashSet<CommLookupTypeToCommLookup>();
this.EndorsementRequirements = new HashSet<EndorsementRequirement>();
this.Assignments = new HashSet<Assignment>();
this.OCAPPFedEths = new HashSet<OCAPPFedEth>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int Id {get; set;}
[Required]
StringLength(20)
public string Code {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
public bool? DisabledInd {get; set;}
[Column(TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public int? DisplayOrder {get; set;}
public virtual ICollection<OCAPPPaymentOption> OCAPPPaymentOptions{get; set;}
public virtual ICollection<OCAPPRenewMajorsCn> OCAPPRenewMajorsCns{get; set;}
public virtual ICollection<ListGroup> ListGroups{get; set;}
public virtual ICollection<OCAPPOtherCerts> OCAPPOtherCertss{get; set;}
public virtual ICollection<Endorsement> Endorsements{get; set;}
public virtual ICollection<CommLookupTypeToCommLookup> CommLookupTypeToCommLookups{get; set;}
public virtual ICollection<EndorsementRequirement> EndorsementRequirements{get; set;}
public virtual ICollection<Assignment> Assignments{get; set;}
public virtual ICollection<OCAPPFedEth> OCAPPFedEths{get; set;}
}
public partial class CommLookupBridge
{ 
public CommLookupBridge()
{
}
[Required]
public int ObjectID {get; set;}
[Required]
public int TypeID {get; set;}
}
public partial class CommLookupOldToNew
{ 
public CommLookupOldToNew()
{
}
[Required]
public uniqueidentifier NewID {get; set;}
[Required]
public int OldID {get; set;}
}
public partial class CommLookupType
{ 
public CommLookupType()
{
this.Qualifications = new HashSet<Qualification>();
this.CommLookupTypeToCommLookups = new HashSet<CommLookupTypeToCommLookup>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Required]
StringLength(80)
public string Name {get; set;}
[Required]
StringLength(80)
public string BriefDescription {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
[Required]
StringLength(10)
public string KeyPrefix {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual ICollection<Qualification> Qualifications{get; set;}
public virtual ICollection<CommLookupTypeToCommLookup> CommLookupTypeToCommLookups{get; set;}
}
public partial class CommLookupTypeToCommLookup
{ 
public CommLookupTypeToCommLookup()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int CommLookupTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int CommLookupID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual CommLookup CommLookup{get; set;}
public virtual CommLookupType CommLookupType{get; set;}
}
public partial class COMMPerson
{ 
public COMMPerson()
{
this.OCAppDInfos = new HashSet<OCAppDInfo>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Required]
StringLength(60)
public string FirstName {get; set;}
[Required]
StringLength(60)
public string MiddleName {get; set;}
[Required]
StringLength(60)
public string LastName {get; set;}
[Required]
StringLength(10)
public string Salutation {get; set;}
[Required]
StringLength(10)
public string Suffix {get; set;}
public DateTime? BirthDate {get; set;}
[Required]
StringLength(9)
public string SSN {get; set;}
[Required]
StringLength(1)
public string Sex {get; set;}
[Required]
StringLength(30)
public string AliasID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public int? Ethnicity {get; set;}
public virtual ICollection<OCAppDInfo> OCAppDInfos{get; set;}
}
public partial class CredType
{ 
public CredType()
{
}
[Required]
public int ID {get; set;}
[Required]
StringLength(12)
public string CredentialTypeCode {get; set;}
[Required]
StringLength(120)
public string CredentialTypeDesc {get; set;}
[Required]
public bool AuthToAct {get; set;}
[Required]
public bool Disabled {get; set;}
public DateTime? DateDisabled {get; set;}
public int? ValidLengthOfYears {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
}
public partial class DataTypeExamples
{ 
public DataTypeExamples()
{
}
public uniqueidentifier? xuniqueidentifier {get; set;}
StringLength(500)
public string? xvarchar {get; set;}
[Column(TypeName = "money")]
public decimal? xmoney {get; set;}
[Required]
public double xfloat {get; set;}
public decimal? xdecimal {get; set;}
public int? xinteger {get; set;}
[Column(TypeName = "date")]
public DateTime? xdate {get; set;}
public DateTime? xdatetime {get; set;}
[Column(TypeName = "datetime2")]
public DateTime? xdatetime2 {get; set;}
public bool? xbit {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? xtimestamp {get; set;}
}
public partial class DE04AssgnAltDesc
{ 
public DE04AssgnAltDesc()
{
}
[Required]
public int ID {get; set;}
public int? CommLookupID {get; set;}
[Required]
StringLength(300)
public string AltDescription {get; set;}
[Required]
public int ConcurrencyID {get; set;}
}
public partial class DE04CommLookup
{ 
public DE04CommLookup()
{
}
[Required]
public int ID {get; set;}
[Required]
StringLength(20)
public string Code {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
[Required]
StringLength(1)
public string Disabled {get; set;}
[Column(TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
public int ConcurrencyID {get; set;}
}
public partial class DE04CommLookupType
{ 
public DE04CommLookupType()
{
}
[Required]
public int ID {get; set;}
[Required]
StringLength(80)
public string Name {get; set;}
[Required]
StringLength(80)
public string BriefDescription {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
[Required]
public char KeyPrefix {get; set;}
[Required]
public int ConcurrencyID {get; set;}
}
public partial class DE04CommLookupTypeToCommLookup
{ 
public DE04CommLookupTypeToCommLookup()
{
}
[Required]
public int ObjectID {get; set;}
[Required]
public int TypeID {get; set;}
}
public partial class DE04EndAssgnOBDTA
{ 
public DE04EndAssgnOBDTA()
{
}
[Required]
public int ID {get; set;}
public int? EndorsementCodeID {get; set;}
public int? AssignmentCodeID {get; set;}
[Required]
public int ConcurrencyID {get; set;}
}
public partial class DE04EndrCodeOBDTA
{ 
public DE04EndrCodeOBDTA()
{
}
[Required]
public int ID {get; set;}
[Required]
StringLength(12)
public string EndorsementCode {get; set;}
[Required]
StringLength(250)
public string EndorsementCodeDescription {get; set;}
[Required]
StringLength(1)
public string Disabled {get; set;}
public DateTime? DateDisabled {get; set;}
public int? EndorsementCategoryID {get; set;}
[Required]
public int ConcurrencyID {get; set;}
}
public partial class Degree
{ 
public Degree()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? PersonnelID {get; set;}
public int? DegreeTypeID {get; set;}
public int? DegreeID {get; set;}
public int? InstitutionID {get; set;}
public int? MajMinTypeID {get; set;}
public int? MajMinID {get; set;}
[Required]
StringLength(5)
public string CompletedDate {get; set;}
[Required]
public bool ConcurrencyID {get; set;}
StringLength(80)
public string? MajMinOther {get; set;}
}
public partial class Endorsement
{ 
public Endorsement()
{
this.OCAPPRenewProPrpCns = new HashSet<OCAPPRenewProPrpCn>();
this.AssignmentToEndorsements = new HashSet<AssignmentToEndorsement>();
this.EndorsementRequirements = new HashSet<EndorsementRequirement>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Required]
StringLength(12)
public string Code {get; set;}
[Required]
StringLength(250)
public string Description {get; set;}
[Required]
public bool Disabled {get; set;}
[Column(TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int EndorsementCategoryID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual CommLookup CommLookup{get; set;}
public virtual ICollection<OCAPPRenewProPrpCn> OCAPPRenewProPrpCns{get; set;}
public virtual ICollection<AssignmentToEndorsement> AssignmentToEndorsements{get; set;}
public virtual ICollection<EndorsementRequirement> EndorsementRequirements{get; set;}
}
public partial class EndorsementRequirement
{ 
public EndorsementRequirement()
{
this.Options = new HashSet<Option>();
this.Requirements = new HashSet<Requirement>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int EndorsementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int PreparationID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual Endorsement Endorsement{get; set;}
public virtual ICollection<Option> Options{get; set;}
public virtual ICollection<Requirement> Requirements{get; set;}
public virtual CommLookup CommLookup{get; set;}
}
public partial class FedEth
{ 
public FedEth()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? COMMPersonID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? EthnicityID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
}
public partial class FedHisp
{ 
public FedHisp()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? COMMPersonID {get; set;}
[Required]
public char Hispanic {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
}
public partial class License
{ 
public License()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Required]
public int PersonID {get; set;}
[Required]
public int LicenseNumber {get; set;}
[Required]
public int RevisionNumber {get; set;}
public DateTime? IssueDate {get; set;}
public DateTime? ExpirationDate {get; set;}
[Required]
StringLength(2)
public string AcademicPreparation {get; set;}
[Required]
public int StatusID {get; set;}
public DateTime? StatusDate {get; set;}
public int? YearsValid {get; set;}
public DateTime? EffectiveDate {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public int? LicenseTierID {get; set;}
}
public partial class LicenseType
{ 
public LicenseType()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? LicenseNumber {get; set;}
public int? LicenseTypeID {get; set;}
public DateTime? EffectiveStartDate {get; set;}
public DateTime? EffectiveEndDate {get; set;}
[Required]
public DateTime ConcurrencyID {get; set;}
}
public partial class ListGroup
{ 
public ListGroup()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int Id {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int CommonLookupID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int RequirementOptionGroupID {get; set;}
[Required]
public uniqueidentifier SuperGroupID {get; set;}
public virtual CommLookup CommLookup{get; set;}
public virtual RequirementOptionGroup RequirementOptionGroup{get; set;}
}
public partial class OCAPPAppEduc
{ 
public OCAPPAppEduc()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? SDUnivID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AttainmentTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? DegreeTypeID {get; set;}
public DateTime? AttainmentDate {get; set;}
public DateTime? AttendedFrom {get; set;}
public DateTime? AttendedTo {get; set;}
[Required]
StringLength(40)
public string Country {get; set;}
[Required]
StringLength(40)
public string City {get; set;}
[Required]
StringLength(40)
public string State {get; set;}
[Required]
StringLength(10)
public string Zip {get; set;}
[Required]
StringLength(100)
public string OtherUniv {get; set;}
[Required]
StringLength(100)
public string Major {get; set;}
[Required]
StringLength(30)
public string StudentID {get; set;}
[Required]
StringLength(1)
public string TranscriptComing {get; set;}
StringLength(100)
public string? Minor {get; set;}
public char? UCOSignoffRequired {get; set;}
public char? AltProgram {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
public virtual OCAPPAttTypeSup OCAPPAttTypeSup{get; set;}
public virtual OCAPPDegreeTypSupt OCAPPDegreeTypSupt{get; set;}
public virtual OCAPPSDUnivSupt OCAPPSDUnivSupt{get; set;}
}
public partial class OCAPPAttTypeSup
{ 
public OCAPPAttTypeSup()
{
this.OCAPPAppEducs = new HashSet<OCAPPAppEduc>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? DisplayOrder {get; set;}
public DateTime? DateDisabled {get; set;}
[Required]
StringLength(20)
public string Code {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
[Required]
StringLength(1)
public string Disabled {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual ICollection<OCAPPAppEduc> OCAPPAppEducs{get; set;}
}
public partial class OCAPPConReviewAppTypeCn
{ 
public OCAPPConReviewAppTypeCn()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? ConductReviewQuestionID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppTypeID {get; set;}
[Required]
StringLength(10)
public string DisplayOrder {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppTypeSupt OCAppTypeSupt{get; set;}
public virtual OCAPPConReviewSup OCAPPConReviewSup{get; set;}
}
public partial class OCAPPConReviewCn
{ 
public OCAPPConReviewCn()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ConductReviewQuestionID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ApplicationID {get; set;}
[Required]
StringLength(1)
public string Answer {get; set;}
[Required]
StringLength(2000)
public string Comments {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
public virtual OCAPPConReviewSup OCAPPConReviewSup{get; set;}
}
public partial class OCAPPConReviewSup
{ 
public OCAPPConReviewSup()
{
this.OCAPPConReviewAppTypeCns = new HashSet<OCAPPConReviewAppTypeCn>();
this.OCAPPConReviewCns = new HashSet<OCAPPConReviewCn>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public DateTime? DateDisabled {get; set;}
[Required]
StringLength(2400)
public string QuestionHTML {get; set;}
[Required]
StringLength(1)
public string Disabled {get; set;}
StringLength(2000)
public string? YesResponseInstructionsHTML {get; set;}
[Required]
StringLength(1)
public string RequiresCourtDocumentation {get; set;}
[Required]
StringLength(1)
public string RequiresReviewIfYes {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual ICollection<OCAPPConReviewAppTypeCn> OCAPPConReviewAppTypeCns{get; set;}
public virtual ICollection<OCAPPConReviewCn> OCAPPConReviewCns{get; set;}
}
public partial class OCAPPDegreeTypSupt
{ 
public OCAPPDegreeTypSupt()
{
this.OCAPPAppEducs = new HashSet<OCAPPAppEduc>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? DisplayOrder {get; set;}
public DateTime? DateDisabled {get; set;}
[Required]
StringLength(20)
public string Code {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual ICollection<OCAPPAppEduc> OCAPPAppEducs{get; set;}
}
public partial class OCAppDInfo
{ 
public OCAppDInfo()
{
this.OCAPPAppEducs = new HashSet<OCAPPAppEduc>();
this.OCAPPOverrideQueues = new HashSet<OCAPPOverrideQueue>();
this.OCAPPExperienceResponses = new HashSet<OCAPPExperienceResponse>();
this.OCAPPFedEths = new HashSet<OCAPPFedEth>();
this.OCAPPFedHisps = new HashSet<OCAPPFedHisp>();
this.OCAPPOtherCertss = new HashSet<OCAPPOtherCerts>();
this.OCAPPPaymentOptions = new HashSet<OCAPPPaymentOption>();
this.OCAPPPraxisTestss = new HashSet<OCAPPPraxisTests>();
this.OCAPPPrevLastNames = new HashSet<OCAPPPrevLastName>();
this.OCAPPProcessingFees = new HashSet<OCAPPProcessingFee>();
this.OCAPPProfPrepCns = new HashSet<OCAPPProfPrepCn>();
this.OCAPPConReviewCns = new HashSet<OCAPPConReviewCn>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? EthnicityID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? PersonnelID {get; set;}
public DateTime? BirthDate {get; set;}
public DateTime? AppDate {get; set;}
[Required]
StringLength(9)
public string SSN {get; set;}
[Required]
StringLength(60)
public string FirstName {get; set;}
[Required]
StringLength(60)
public string MiddleName {get; set;}
[Required]
StringLength(60)
public string LastName {get; set;}
[Required]
StringLength(30)
public string Country {get; set;}
[Required]
StringLength(1)
public string Gender {get; set;}
[Required]
StringLength(10)
public string Status {get; set;}
[Required]
StringLength(30)
public string AppNumber {get; set;}
StringLength(100)
public string? CitizenshipCountry {get; set;}
StringLength(60)
public string? ContractSignedDistrict {get; set;}
[Required]
StringLength(10)
public string EvenPhone {get; set;}
[Required]
StringLength(100)
public string Email {get; set;}
[Required]
StringLength(1)
public string Citizenship {get; set;}
[Required]
StringLength(1)
public string Oath {get; set;}
[Required]
StringLength(1)
public string AppTrue {get; set;}
[Required]
StringLength(30)
public string CtryBorn {get; set;}
[Required]
StringLength(40)
public string Address1 {get; set;}
StringLength(40)
public string? Address2 {get; set;}
[Required]
StringLength(40)
public string City {get; set;}
[Required]
StringLength(40)
public string State {get; set;}
[Required]
StringLength(10)
public string Zip {get; set;}
[Required]
StringLength(10)
public string DayPhone {get; set;}
public char? DOEQueue {get; set;}
public char? MilitarySpouseFlag {get; set;}
public char? MilitarySpouseLeftEmploymentFlag {get; set;}
public char? HoldsOtherCertificateFlag {get; set;}
public char? ContractSignedFlag {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppTypeSupt OCAppTypeSupt{get; set;}
public virtual ICollection<OCAPPAppEduc> OCAPPAppEducs{get; set;}
public virtual ICollection<OCAPPOverrideQueue> OCAPPOverrideQueues{get; set;}
public virtual ICollection<OCAPPExperienceResponse> OCAPPExperienceResponses{get; set;}
public virtual ICollection<OCAPPFedEth> OCAPPFedEths{get; set;}
public virtual ICollection<OCAPPFedHisp> OCAPPFedHisps{get; set;}
public virtual ICollection<OCAPPOtherCerts> OCAPPOtherCertss{get; set;}
public virtual ICollection<OCAPPPaymentOption> OCAPPPaymentOptions{get; set;}
public virtual ICollection<OCAPPPraxisTests> OCAPPPraxisTestss{get; set;}
public virtual ICollection<OCAPPPrevLastName> OCAPPPrevLastNames{get; set;}
public virtual ICollection<OCAPPProcessingFee> OCAPPProcessingFees{get; set;}
public virtual ICollection<OCAPPProfPrepCn> OCAPPProfPrepCns{get; set;}
public virtual ICollection<OCAPPConReviewCn> OCAPPConReviewCns{get; set;}
public virtual COMMPerson COMMPerson{get; set;}
}
public partial class OCAPPExperienceResponse
{ 
public OCAPPExperienceResponse()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
StringLength(1)
public string? HasRequiredExperience {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
}
public partial class OCAPPFedEth
{ 
public OCAPPFedEth()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? EthnicityID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
public virtual CommLookup CommLookup{get; set;}
}
public partial class OCAPPFedHisp
{ 
public OCAPPFedHisp()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
[Required]
StringLength(1)
public string Hispanic {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
}
public partial class OCAPPOtherCerts
{ 
public OCAPPOtherCerts()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? OtherStateID {get; set;}
StringLength(60)
public string? ForeignCountry {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
public virtual CommLookup CommLookup{get; set;}
}
public partial class OCAPPOverrideQueue
{ 
public OCAPPOverrideQueue()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? SDUnivID {get; set;}
[Required]
StringLength(20)
public string Queue {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
public virtual OCAPPSDUnivSupt OCAPPSDUnivSupt{get; set;}
}
public partial class OCAPPPaymentDetail
{ 
public OCAPPPaymentDetail()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppPaymentID {get; set;}
public DateTime? TransactionDate {get; set;}
[Required]
StringLength(1)
public string ResponseCode {get; set;}
[Required]
StringLength(500)
public string ResponseText {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAPPPaymentOption OCAPPPaymentOption{get; set;}
}
public partial class OCAPPPaymentOption
{ 
public OCAPPPaymentOption()
{
this.OCAPPPaymentDetails = new HashSet<OCAPPPaymentDetail>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int PaymentTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
[Column(TypeName = "money")]
public decimal? Amount {get; set;}
public DateTime? TransactionDate {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
public virtual ICollection<OCAPPPaymentDetail> OCAPPPaymentDetails{get; set;}
public virtual CommLookup CommLookup{get; set;}
}
public partial class OCAPPPraxisTests
{ 
public OCAPPPraxisTests()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
public int? StateTestID {get; set;}
public DateTime? DateTaken {get; set;}
[Required]
StringLength(10)
public string Score {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
}
public partial class OCAPPPrevLastName
{ 
public OCAPPPrevLastName()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
[Required]
StringLength(60)
public string PrevLastName {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
}
public partial class OCAPPProcessingFee
{ 
public OCAPPProcessingFee()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? AppID {get; set;}
[Column(TypeName = "money")]
public decimal? Fee {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
}
public partial class OCAPPProfPrep
{ 
public OCAPPProfPrep()
{
this.OCAPPProfPrepCns = new HashSet<OCAPPProfPrepCn>();
}
[Required]
public int DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public DateTime? DateDisabled {get; set;}
StringLength(1)
public string? VerifyExperience {get; set;}
[Required]
StringLength(20)
public string Code {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
[Required]
StringLength(1)
public string Disabled {get; set;}
StringLength(2000)
public string? RequirementsDescription {get; set;}
StringLength(200)
public string? AdministrativeRuleLink {get; set;}
public char? UCOSignoffRequired {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual ICollection<OCAPPProfPrepCn> OCAPPProfPrepCns{get; set;}
}
public partial class OCAPPProfPrepCn
{ 
public OCAPPProfPrepCn()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? ProfPrepID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? ApplicationID {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual OCAppDInfo OCAppDInfo{get; set;}
public virtual OCAPPProfPrep OCAPPProfPrep{get; set;}
}
public partial class OCAPPRenewalCredit
{ 
public OCAPPRenewalCredit()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? AppID {get; set;}
public int? CreditTypeID {get; set;}
public int? SDUnivID {get; set;}
public int? CreditsOrHours {get; set;}
public DateTime? DateCompleted {get; set;}
public DateTime? FromDate {get; set;}
public DateTime? ToDate {get; set;}
[Required]
StringLength(100)
public string TitleOrCourseDescription {get; set;}
[Required]
StringLength(100)
public string OtherUniversity {get; set;}
[Required]
StringLength(100)
public string Location {get; set;}
[Required]
StringLength(100)
public string WorkExperienceSponsor {get; set;}
StringLength(2)
public string? InstitutionType {get; set;}
[Required]
public char SemestorOrQuarter {get; set;}
[Required]
public char DocumentsExpected {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
}
public partial class OCAPPRenewalType
{ 
public OCAPPRenewalType()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? AppID {get; set;}
public int? RenewalTypeID {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
}
public partial class OCAPPRenewCodeCategorySupt
{ 
public OCAPPRenewCodeCategorySupt()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
StringLength(80)
public string? Description {get; set;}
public char? Code {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
}
public partial class OCAPPRenewMajorsCn
{ 
public OCAPPRenewMajorsCn()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int MajorID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? AppID {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual CommLookup CommLookup{get; set;}
}
public partial class OCAPPRenewProPrpCn
{ 
public OCAPPRenewProPrpCn()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? AppID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? EndrCodeID {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual Endorsement Endorsement{get; set;}
}
public partial class OCAPPSDUnivSupt
{ 
public OCAPPSDUnivSupt()
{
this.OCAPPAppEducs = new HashSet<OCAPPAppEduc>();
this.OCAPPOverrideQueues = new HashSet<OCAPPOverrideQueue>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? DisplayOrder {get; set;}
public DateTime? DateDisabled {get; set;}
[Required]
StringLength(20)
public string Code {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
[Required]
StringLength(1)
public string Disabled {get; set;}
[Required]
StringLength(100)
public string Address1 {get; set;}
[Required]
StringLength(60)
public string City {get; set;}
[Required]
StringLength(2)
public string State {get; set;}
[Required]
StringLength(9)
public string Zip {get; set;}
public char? UCOSignOff {get; set;}
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[]? ConcurrencyID {get; set;}
public virtual ICollection<OCAPPAppEduc> OCAPPAppEducs{get; set;}
public virtual ICollection<OCAPPOverrideQueue> OCAPPOverrideQueues{get; set;}
}
public partial class OCAppTypeSupt
{ 
public OCAppTypeSupt()
{
this.OCAPPConReviewAppTypeCns = new HashSet<OCAPPConReviewAppTypeCn>();
this.OCAppDInfos = new HashSet<OCAppDInfo>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Required]
StringLength(20)
public string Code {get; set;}
[Required]
StringLength(255)
public string Description {get; set;}
public DateTime? DateDisabled {get; set;}
[Required]
StringLength(1)
public string Disabled {get; set;}
public int? DisplayOrder {get; set;}
[Column(TypeName = "money")]
public decimal? Fee {get; set;}
[Column(TypeName = "money")]
public decimal? OneYearFee {get; set;}
[Column(TypeName = "money")]
public decimal? TenYearFee {get; set;}
[Column(TypeName = "money")]
public decimal? TenYearReducedFee {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual ICollection<OCAPPConReviewAppTypeCn> OCAPPConReviewAppTypeCns{get; set;}
public virtual ICollection<OCAppDInfo> OCAppDInfos{get; set;}
}
public partial class Option
{ 
public Option()
{
this.RequirementOptionGroups = new HashSet<RequirementOptionGroup>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int Id {get; set;}
[Required]
StringLength(50)
public string Type {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int QualificationID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int EndorsementRequirementID {get; set;}
StringLength(750)
public string? Text {get; set;}
[Required]
public uniqueidentifier SuperOptionID {get; set;}
public virtual EndorsementRequirement EndorsementRequirement{get; set;}
public virtual ICollection<RequirementOptionGroup> RequirementOptionGroups{get; set;}
public virtual Qualification Qualification{get; set;}
}
public partial class PersonInfo
{ 
public PersonInfo()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? PersonnelID {get; set;}
[Required]
StringLength(30)
public string Country {get; set;}
[Required]
StringLength(10)
public string DayPhone {get; set;}
[Required]
StringLength(10)
public string EveningPhone {get; set;}
[Required]
StringLength(100)
public string EmailAddress {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
}
public partial class PrevLastName
{ 
public PrevLastName()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
public int? PersonnelID {get; set;}
[Required]
StringLength(60)
public string PrevLastName {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
}
public partial class Qualification
{ 
public Qualification()
{
this.Options = new HashSet<Option>();
this.Requirements = new HashSet<Requirement>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Required]
StringLength(12)
public string Code {get; set;}
[Required]
StringLength(250)
public string Description {get; set;}
public bool? DisabledInd {get; set;}
[Column(TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? LookupTypeID {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
StringLength(20)
public string? Type {get; set;}
[Required]
public int DisplayOrder {get; set;}
public virtual ICollection<Option> Options{get; set;}
public virtual ICollection<Requirement> Requirements{get; set;}
public virtual CommLookupType CommLookupType{get; set;}
}
public partial class Requirement
{ 
public Requirement()
{
this.RequirementOptionGroups = new HashSet<RequirementOptionGroup>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int Id {get; set;}
[Required]
StringLength(50)
public string Type {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int QualificationID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int EndorsementRequirementID {get; set;}
StringLength(750)
public string? Text {get; set;}
public virtual EndorsementRequirement EndorsementRequirement{get; set;}
public virtual ICollection<RequirementOptionGroup> RequirementOptionGroups{get; set;}
public virtual Qualification Qualification{get; set;}
}
public partial class RequirementOptionGroup
{ 
public RequirementOptionGroup()
{
this.ListGroups = new HashSet<ListGroup>();
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
public int ID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? RequirementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int? OptionID {get; set;}
[Required]
public int NumberRequired {get; set;}
[Required]
[Column(TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
public virtual ICollection<ListGroup> ListGroups{get; set;}
public virtual Option Option{get; set;}
public virtual Requirement Requirement{get; set;}
}
}
