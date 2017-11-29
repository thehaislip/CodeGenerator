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
[Table("CertCred")]
public partial class CertCred
:IAuditable{ 
public CertCred()
{
}
[Required]
[Column(name:"AcademicPreparation")]
[StringLength(2)]
public string AcademicPreparation {get; set;}
[Required]
[Column(name:"BatchPrint")]
[StringLength(1)]
public string BatchPrint {get; set;}
[Column(name:"BatchPrintDate",TypeName = "datetime2")]
public DateTime? BatchPrintDate {get; set;}
[Column(name:"CertCredNumber")]
public int? CertCredNumber {get; set;}
[Required]
[Column(name:"CertCredPrefix")]
[StringLength(2)]
public string CertCredPrefix {get; set;}
[Column(name:"CertCredRevisionNumber")]
public int? CertCredRevisionNumber {get; set;}
[Column(name:"CertCredTypeID")]
public int? CertCredTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateExpire",TypeName = "datetime2")]
public DateTime? DateExpire {get; set;}
[Column(name:"DateIssued",TypeName = "datetime2")]
public DateTime? DateIssued {get; set;}
[Required]
[Column(name:"HumanRelations")]
[StringLength(1)]
public string HumanRelations {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"PrintCodeID")]
public int? PrintCodeID {get; set;}
[ForeignKey("PersonnelID")]
public virtual COMMPerson COMMPerson{get; set;}
[ForeignKey("PrintCodeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("CertCredAudit")]
public partial class CertCredAudit
:IAudit{ 
public CertCredAudit()
{
}
[Required]
[Column(name:"AcademicPreparation")]
[StringLength(2)]
public string AcademicPreparation {get; set;}
[Required]
[Column(name:"BatchPrint")]
[StringLength(1)]
public string BatchPrint {get; set;}
[Column(name:"BatchPrintDate",TypeName = "datetime2")]
public DateTime? BatchPrintDate {get; set;}
[Column(name:"CertCredNumber")]
public int? CertCredNumber {get; set;}
[Required]
[Column(name:"CertCredPrefix")]
[StringLength(2)]
public string CertCredPrefix {get; set;}
[Column(name:"CertCredRevisionNumber")]
public int? CertCredRevisionNumber {get; set;}
[Column(name:"CertCredTypeID")]
public int? CertCredTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateExpire",TypeName = "datetime2")]
public DateTime? DateExpire {get; set;}
[Column(name:"DateIssued",TypeName = "datetime2")]
public DateTime? DateIssued {get; set;}
[Required]
[Column(name:"HumanRelations")]
[StringLength(1)]
public string HumanRelations {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"PrintCodeID")]
public int? PrintCodeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
