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
[Table("CertificateCompletion")]
public partial class CertificateCompletion
:IAuditable{ 
public CertificateCompletion()
{
}
[Required]
[Column(name:"CertificateNumber")]
[StringLength(50)]
public string CertificateNumber {get; set;}
[Required]
[Column(name:"CompletionIndicatorID")]
public int CompletionIndicatorID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"EffectiveEndDate",TypeName = "datetime2")]
public DateTime EffectiveEndDate {get; set;}
[Required]
[Column(name:"EffectiveStartDate",TypeName = "datetime2")]
public DateTime EffectiveStartDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"IsComplete")]
public bool IsComplete {get; set;}
[ForeignKey("CompletionIndicatorID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("CertificateCompletionAudit")]
public partial class CertificateCompletionAudit
:IAudit{ 
public CertificateCompletionAudit()
{
}
[Required]
[Column(name:"CertificateNumber")]
[StringLength(50)]
public string CertificateNumber {get; set;}
[Required]
[Column(name:"CompletionIndicatorID")]
public int CompletionIndicatorID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"EffectiveEndDate",TypeName = "datetime2")]
public DateTime EffectiveEndDate {get; set;}
[Required]
[Column(name:"EffectiveStartDate",TypeName = "datetime2")]
public DateTime EffectiveStartDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"IsComplete")]
public bool IsComplete {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
