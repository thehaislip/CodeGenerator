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
[Table("CertHistory")]
public partial class CertHistory
:IAuditable{ 
public CertHistory()
{
}
[Required]
[Column(name:"ActionBy")]
[StringLength(15)]
public string ActionBy {get; set;}
[Column(name:"ActionDate",TypeName = "datetime2")]
public DateTime? ActionDate {get; set;}
[Column(name:"CertCredID")]
public int? CertCredID {get; set;}
[Column(name:"CertTypeID")]
public int? CertTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateExpired",TypeName = "datetime2")]
public DateTime? DateExpired {get; set;}
[Column(name:"DateIssued",TypeName = "datetime2")]
public DateTime? DateIssued {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"RevisionNumber")]
public int? RevisionNumber {get; set;}
[ForeignKey("CertCredID")]
public virtual Certificate Certificate{get; set;}
[ForeignKey("CertTypeID")]
public virtual CertificateType CertificateType{get; set;}
[ForeignKey("PersonnelID")]
public virtual COMMPerson COMMPerson{get; set;}
}
[Table("CertHistoryAudit")]
public partial class CertHistoryAudit
:IAudit{ 
public CertHistoryAudit()
{
}
[Required]
[Column(name:"ActionBy")]
[StringLength(15)]
public string ActionBy {get; set;}
[Column(name:"ActionDate",TypeName = "datetime2")]
public DateTime? ActionDate {get; set;}
[Column(name:"CertCredID")]
public int? CertCredID {get; set;}
[Column(name:"CertTypeID")]
public int? CertTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateExpired",TypeName = "datetime2")]
public DateTime? DateExpired {get; set;}
[Column(name:"DateIssued",TypeName = "datetime2")]
public DateTime? DateIssued {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"RevisionNumber")]
public int? RevisionNumber {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
