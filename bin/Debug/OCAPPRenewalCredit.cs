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
[Table("OCAPPRenewalCredit")]
public partial class OCAPPRenewalCredit
:IAuditable{ 
public OCAPPRenewalCredit()
{
this.OCDOETranscriptss = new HashSet<OCDOETranscripts>();
}
[Column(name:"AgencyOrInstructor")]
[StringLength(100)]
public string AgencyOrInstructor {get; set;}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"CourseNumber")]
[StringLength(25)]
public string CourseNumber {get; set;}
[Column(name:"CreditsOrHours")]
public int? CreditsOrHours {get; set;}
[Required]
[Column(name:"CreditTypeID")]
public int CreditTypeID {get; set;}
[Column(name:"DateCompleted",TypeName = "datetime2")]
public DateTime? DateCompleted {get; set;}
[Column(name:"DocumentsExpected")]
[StringLength(1)]
public string DocumentsExpected {get; set;}
[Column(name:"FromDate",TypeName = "datetime2")]
public DateTime? FromDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InstitutionType")]
[StringLength(2)]
public string InstitutionType {get; set;}
[Column(name:"Location")]
[StringLength(100)]
public string Location {get; set;}
[Column(name:"OtherUniversity")]
[StringLength(100)]
public string OtherUniversity {get; set;}
[Column(name:"SDUnivID")]
public int? SDUnivID {get; set;}
[Column(name:"SemestorOrQuarter")]
[StringLength(1)]
public string SemestorOrQuarter {get; set;}
[Column(name:"TitleOrCourseDescription")]
[StringLength(100)]
public string TitleOrCourseDescription {get; set;}
[Column(name:"ToDate",TypeName = "datetime2")]
public DateTime? ToDate {get; set;}
[Column(name:"WorkExperienceSponsor")]
[StringLength(100)]
public string WorkExperienceSponsor {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("CreditTypeID")]
public virtual OCDOECreditTypeSupt OCDOECreditTypeSupt{get; set;}
[ForeignKey("OCAPPRenewalCreditID")]
public virtual ICollection<OCDOETranscripts> OCDOETranscriptss{get; set;}
[ForeignKey("SDUnivID")]
public virtual OCAPPSDUnivSupt OCAPPSDUnivSupt{get; set;}
}
[Table("OCAPPRenewalCreditAudit")]
public partial class OCAPPRenewalCreditAudit
:IAudit{ 
public OCAPPRenewalCreditAudit()
{
}
[Column(name:"AgencyOrInstructor")]
[StringLength(100)]
public string AgencyOrInstructor {get; set;}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"CourseNumber")]
[StringLength(25)]
public string CourseNumber {get; set;}
[Column(name:"CreditsOrHours")]
public int? CreditsOrHours {get; set;}
[Required]
[Column(name:"CreditTypeID")]
public int CreditTypeID {get; set;}
[Column(name:"DateCompleted",TypeName = "datetime2")]
public DateTime? DateCompleted {get; set;}
[Column(name:"DocumentsExpected")]
[StringLength(1)]
public string DocumentsExpected {get; set;}
[Column(name:"FromDate",TypeName = "datetime2")]
public DateTime? FromDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InstitutionType")]
[StringLength(2)]
public string InstitutionType {get; set;}
[Column(name:"Location")]
[StringLength(100)]
public string Location {get; set;}
[Column(name:"OtherUniversity")]
[StringLength(100)]
public string OtherUniversity {get; set;}
[Column(name:"SDUnivID")]
public int? SDUnivID {get; set;}
[Column(name:"SemestorOrQuarter")]
[StringLength(1)]
public string SemestorOrQuarter {get; set;}
[Column(name:"TitleOrCourseDescription")]
[StringLength(100)]
public string TitleOrCourseDescription {get; set;}
[Column(name:"ToDate",TypeName = "datetime2")]
public DateTime? ToDate {get; set;}
[Column(name:"WorkExperienceSponsor")]
[StringLength(100)]
public string WorkExperienceSponsor {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
