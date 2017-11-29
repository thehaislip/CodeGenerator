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
[Table("DistPlanIntnt")]
public partial class DistPlanIntnt
:IAuditable{ 
public DistPlanIntnt()
{
this.PlanOfIntentToRequirementOptionGroups = new HashSet<PlanOfIntentToRequirementOptionGroup>();
this.POISpedTaskss = new HashSet<POISpedTasks>();
}
[Column(name:"AssessedGradeSpanID")]
public int? AssessedGradeSpanID {get; set;}
[Column(name:"AssgnCodeID")]
public int? AssgnCodeID {get; set;}
[Column(name:"AttCtrID")]
public int? AttCtrID {get; set;}
[Required]
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"CompletionDate",TypeName = "datetime2")]
public DateTime? CompletionDate {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EndorsementID")]
public int? EndorsementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InitialSaveDate",TypeName = "datetime2")]
public DateTime? InitialSaveDate {get; set;}
[Column(name:"IsDakotaStepA")]
public bool? IsDakotaStepA {get; set;}
[Column(name:"IsOfficialWaiver")]
public bool? IsOfficialWaiver {get; set;}
[Column(name:"IsOtherDOEWaiver")]
public bool? IsOtherDOEWaiver {get; set;}
[Column(name:"NumberOfStudents")]
public int? NumberOfStudents {get; set;}
[Required]
[Column(name:"PlanOfAction")]
[StringLength(2000)]
public string PlanOfAction {get; set;}
[Column(name:"PreparationID")]
public int? PreparationID {get; set;}
[Column(name:"PRFInfoID")]
public int? PRFInfoID {get; set;}
[Column(name:"ReasonHiredID")]
public int? ReasonHiredID {get; set;}
[Required]
[Column(name:"Retire")]
public bool Retire {get; set;}
[Column(name:"SpedLookupID")]
public int? SpedLookupID {get; set;}
[Required]
[Column(name:"TempHire")]
public bool TempHire {get; set;}
[Column(name:"ThirdYearWaiverIssued")]
public bool? ThirdYearWaiverIssued {get; set;}
[Column(name:"ThirdYearWaiverRequired")]
public bool? ThirdYearWaiverRequired {get; set;}
[ForeignKey("AssgnCodeID")]
public virtual Assignment Assignment{get; set;}
[ForeignKey("AttCtrID")]
public virtual AttCtrSS AttCtrSS{get; set;}
[ForeignKey("PlanOfIntentID")]
public virtual ICollection<PlanOfIntentToRequirementOptionGroup> PlanOfIntentToRequirementOptionGroups{get; set;}
[ForeignKey("POIID")]
public virtual ICollection<POISpedTasks> POISpedTaskss{get; set;}
[ForeignKey("PRFInfoID")]
public virtual PRFInfo PRFInfo{get; set;}
}
[Table("DistPlanIntntAudit")]
public partial class DistPlanIntntAudit
:IAudit{ 
public DistPlanIntntAudit()
{
}
[Column(name:"AssessedGradeSpanID")]
public int? AssessedGradeSpanID {get; set;}
[Column(name:"AssgnCodeID")]
public int? AssgnCodeID {get; set;}
[Column(name:"AttCtrID")]
public int? AttCtrID {get; set;}
[Required]
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"CompletionDate",TypeName = "datetime2")]
public DateTime? CompletionDate {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EndorsementID")]
public int? EndorsementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InitialSaveDate",TypeName = "datetime2")]
public DateTime? InitialSaveDate {get; set;}
[Column(name:"IsDakotaStepA")]
public bool? IsDakotaStepA {get; set;}
[Column(name:"IsOfficialWaiver")]
public bool? IsOfficialWaiver {get; set;}
[Column(name:"IsOtherDOEWaiver")]
public bool? IsOtherDOEWaiver {get; set;}
[Column(name:"NumberOfStudents")]
public int? NumberOfStudents {get; set;}
[Required]
[Column(name:"PlanOfAction")]
[StringLength(2000)]
public string PlanOfAction {get; set;}
[Column(name:"PreparationID")]
public int? PreparationID {get; set;}
[Column(name:"PRFInfoID")]
public int? PRFInfoID {get; set;}
[Column(name:"ReasonHiredID")]
public int? ReasonHiredID {get; set;}
[Required]
[Column(name:"Retire")]
public bool Retire {get; set;}
[Column(name:"SpedLookupID")]
public int? SpedLookupID {get; set;}
[Required]
[Column(name:"TempHire")]
public bool TempHire {get; set;}
[Column(name:"ThirdYearWaiverIssued")]
public bool? ThirdYearWaiverIssued {get; set;}
[Column(name:"ThirdYearWaiverRequired")]
public bool? ThirdYearWaiverRequired {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
