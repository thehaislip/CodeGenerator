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
[Table("License")]
public partial class License
:IAuditable{ 
public License()
{
}
[Required]
[Column(name:"AcademicPreparation")]
[StringLength(2)]
public string AcademicPreparation {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EffectiveDate",TypeName = "datetime2")]
public DateTime? EffectiveDate {get; set;}
[Column(name:"ExpirationDate",TypeName = "datetime2")]
public DateTime? ExpirationDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IssueDate",TypeName = "datetime2")]
public DateTime? IssueDate {get; set;}
[Required]
[Column(name:"LicenseNumber")]
public int LicenseNumber {get; set;}
[Column(name:"LicenseTierID")]
public int? LicenseTierID {get; set;}
[Required]
[Column(name:"PersonID")]
public int PersonID {get; set;}
[Required]
[Column(name:"RevisionNumber")]
public int RevisionNumber {get; set;}
[Column(name:"StatusDate",TypeName = "datetime2")]
public DateTime? StatusDate {get; set;}
[Required]
[Column(name:"StatusID")]
public int StatusID {get; set;}
[Column(name:"YearsValid")]
public int? YearsValid {get; set;}
}
[Table("LicenseAudit")]
public partial class LicenseAudit
:IAudit{ 
public LicenseAudit()
{
}
[Required]
[Column(name:"AcademicPreparation")]
[StringLength(2)]
public string AcademicPreparation {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EffectiveDate",TypeName = "datetime2")]
public DateTime? EffectiveDate {get; set;}
[Column(name:"ExpirationDate",TypeName = "datetime2")]
public DateTime? ExpirationDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IssueDate",TypeName = "datetime2")]
public DateTime? IssueDate {get; set;}
[Required]
[Column(name:"LicenseNumber")]
public int LicenseNumber {get; set;}
[Column(name:"LicenseTierID")]
public int? LicenseTierID {get; set;}
[Required]
[Column(name:"PersonID")]
public int PersonID {get; set;}
[Required]
[Column(name:"RevisionNumber")]
public int RevisionNumber {get; set;}
[Column(name:"StatusDate",TypeName = "datetime2")]
public DateTime? StatusDate {get; set;}
[Required]
[Column(name:"StatusID")]
public int StatusID {get; set;}
[Column(name:"YearsValid")]
public int? YearsValid {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
