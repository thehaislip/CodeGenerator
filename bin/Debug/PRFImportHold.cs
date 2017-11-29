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
[Table("PRFImportHold")]
public partial class PRFImportHold
:IAuditable{ 
public PRFImportHold()
{
}
[Column(name:"Asian")]
[StringLength(1)]
public string Asian {get; set;}
[Column(name:"Black")]
[StringLength(1)]
public string Black {get; set;}
[Column(name:"DistrictSnapshotID")]
public int? DistrictSnapshotID {get; set;}
[Column(name:"Email")]
[StringLength(256)]
public string Email {get; set;}
[Column(name:"ErrorCode")]
[StringLength(2)]
public string ErrorCode {get; set;}
[Column(name:"Hawaiian")]
[StringLength(1)]
public string Hawaiian {get; set;}
[Column(name:"Hispanic")]
[StringLength(1)]
public string Hispanic {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Indian")]
[StringLength(1)]
public string Indian {get; set;}
[Column(name:"NoLongerEmplCode")]
public int? NoLongerEmplCode {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Required]
[Column(name:"PRFImportLogID")]
public int PRFImportLogID {get; set;}
[Column(name:"RawLine")]
[StringLength(2000)]
public string RawLine {get; set;}
[Column(name:"StatusCodeID")]
public int? StatusCodeID {get; set;}
[Column(name:"TotalAdminExp")]
public int? TotalAdminExp {get; set;}
[Column(name:"TotalAdminSalary",TypeName = "money")]
public decimal? TotalAdminSalary {get; set;}
[Column(name:"TotalInstSalary",TypeName = "money")]
public decimal? TotalInstSalary {get; set;}
[Column(name:"TotalTeachingExp")]
public int? TotalTeachingExp {get; set;}
[Column(name:"VacancyOptionID")]
public int? VacancyOptionID {get; set;}
[Column(name:"VacantPositionFilledFirstDay")]
[StringLength(1)]
public string VacantPositionFilledFirstDay {get; set;}
[Column(name:"VacanyOther")]
[StringLength(1000)]
public string VacanyOther {get; set;}
[Column(name:"White")]
[StringLength(1)]
public string White {get; set;}
[ForeignKey("PRFImportLogID")]
public virtual PRFImportLog PRFImportLog{get; set;}
}
[Table("PRFImportHoldAudit")]
public partial class PRFImportHoldAudit
:IAudit{ 
public PRFImportHoldAudit()
{
}
[Column(name:"Asian")]
[StringLength(1)]
public string Asian {get; set;}
[Column(name:"Black")]
[StringLength(1)]
public string Black {get; set;}
[Column(name:"DistrictSnapshotID")]
public int? DistrictSnapshotID {get; set;}
[Column(name:"Email")]
[StringLength(256)]
public string Email {get; set;}
[Column(name:"ErrorCode")]
[StringLength(2)]
public string ErrorCode {get; set;}
[Column(name:"Hawaiian")]
[StringLength(1)]
public string Hawaiian {get; set;}
[Column(name:"Hispanic")]
[StringLength(1)]
public string Hispanic {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Indian")]
[StringLength(1)]
public string Indian {get; set;}
[Column(name:"NoLongerEmplCode")]
public int? NoLongerEmplCode {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Required]
[Column(name:"PRFImportLogID")]
public int PRFImportLogID {get; set;}
[Column(name:"RawLine")]
[StringLength(2000)]
public string RawLine {get; set;}
[Column(name:"StatusCodeID")]
public int? StatusCodeID {get; set;}
[Column(name:"TotalAdminExp")]
public int? TotalAdminExp {get; set;}
[Column(name:"TotalAdminSalary",TypeName = "money")]
public decimal? TotalAdminSalary {get; set;}
[Column(name:"TotalInstSalary",TypeName = "money")]
public decimal? TotalInstSalary {get; set;}
[Column(name:"TotalTeachingExp")]
public int? TotalTeachingExp {get; set;}
[Column(name:"VacancyOptionID")]
public int? VacancyOptionID {get; set;}
[Column(name:"VacantPositionFilledFirstDay")]
[StringLength(1)]
public string VacantPositionFilledFirstDay {get; set;}
[Column(name:"VacanyOther")]
[StringLength(1000)]
public string VacanyOther {get; set;}
[Column(name:"White")]
[StringLength(1)]
public string White {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
