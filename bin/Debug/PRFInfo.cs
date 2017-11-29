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
[Table("PRFInfo")]
public partial class PRFInfo
:IAuditable{ 
public PRFInfo()
{
this.DistrictVacancys = new HashSet<DistrictVacancy>();
this.DistrictVacancy1s = new HashSet<DistrictVacancy>();
this.PRFAssgns = new HashSet<PRFAssgn>();
this.DistPlanIntnts = new HashSet<DistPlanIntnt>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictSnapshotID")]
public int? DistrictSnapshotID {get; set;}
[Column(name:"Email")]
[StringLength(256)]
public string Email {get; set;}
[Column(name:"HiringComment")]
[StringLength(2000)]
public string HiringComment {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"NoLongerEmplCode")]
public int? NoLongerEmplCode {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"StatusCodeID")]
public int? StatusCodeID {get; set;}
[Column(name:"SwitchedPosition")]
[StringLength(1)]
public string SwitchedPosition {get; set;}
[Column(name:"TotalAdminExp")]
public int? TotalAdminExp {get; set;}
[Column(name:"TotalAdminSalary",TypeName = "money")]
public decimal? TotalAdminSalary {get; set;}
[Column(name:"TotalContractHours",TypeName = "money")]
public decimal? TotalContractHours {get; set;}
[Column(name:"TotalInstSalary",TypeName = "money")]
public decimal? TotalInstSalary {get; set;}
[Column(name:"TotalTeachingExp")]
public int? TotalTeachingExp {get; set;}
[Required]
[Column(name:"Vacancy")]
[StringLength(1)]
public string Vacancy {get; set;}
[ForeignKey("DistrictSnapshotID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("PRFID")]
public virtual ICollection<DistrictVacancy> DistrictVacancys{get; set;}
[ForeignKey("PRFIDPreviousYear")]
public virtual ICollection<DistrictVacancy> DistrictVacancy1s{get; set;}
[ForeignKey("PRFInfoID")]
public virtual ICollection<PRFAssgn> PRFAssgns{get; set;}
[ForeignKey("PRFInfoID")]
public virtual ICollection<DistPlanIntnt> DistPlanIntnts{get; set;}
[ForeignKey("NoLongerEmplCode")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("PersonnelID")]
public virtual COMMPerson COMMPerson{get; set;}
[ForeignKey("StatusCodeID")]
public virtual CommLookup CommLookup1{get; set;}
}
[Table("PRFInfoAudit")]
public partial class PRFInfoAudit
:IAudit{ 
public PRFInfoAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictSnapshotID")]
public int? DistrictSnapshotID {get; set;}
[Column(name:"Email")]
[StringLength(256)]
public string Email {get; set;}
[Column(name:"HiringComment")]
[StringLength(2000)]
public string HiringComment {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"NoLongerEmplCode")]
public int? NoLongerEmplCode {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"StatusCodeID")]
public int? StatusCodeID {get; set;}
[Column(name:"SwitchedPosition")]
[StringLength(1)]
public string SwitchedPosition {get; set;}
[Column(name:"TotalAdminExp")]
public int? TotalAdminExp {get; set;}
[Column(name:"TotalAdminSalary",TypeName = "money")]
public decimal? TotalAdminSalary {get; set;}
[Column(name:"TotalContractHours",TypeName = "money")]
public decimal? TotalContractHours {get; set;}
[Column(name:"TotalInstSalary",TypeName = "money")]
public decimal? TotalInstSalary {get; set;}
[Column(name:"TotalTeachingExp")]
public int? TotalTeachingExp {get; set;}
[Required]
[Column(name:"Vacancy")]
[StringLength(1)]
public string Vacancy {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
