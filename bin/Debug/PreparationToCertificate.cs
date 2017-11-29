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
[Table("PreparationToCertificate")]
public partial class PreparationToCertificate
:IAuditable{ 
public PreparationToCertificate()
{
}
[Required]
[Column(name:"CertificateID")]
public int CertificateID {get; set;}
[Required]
[Column(name:"CertificateNumber")]
[StringLength(50)]
public string CertificateNumber {get; set;}
[Required]
[Column(name:"CertificateTypeToCertificateID")]
public int CertificateTypeToCertificateID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"CurrentIndicator")]
public bool CurrentIndicator {get; set;}
[Required]
[Column(name:"EffectiveEndDate",TypeName = "datetime2")]
public DateTime EffectiveEndDate {get; set;}
[Required]
[Column(name:"EffectiveStartDate",TypeName = "datetime2")]
public DateTime EffectiveStartDate {get; set;}
[Column(name:"FinalizedIndicator")]
public bool? FinalizedIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PreparationID")]
public int PreparationID {get; set;}
[ForeignKey("CertificateID")]
public virtual Certificate Certificate{get; set;}
[ForeignKey("CertificateTypeToCertificateID")]
public virtual CertificateTypeToCertificate CertificateTypeToCertificate{get; set;}
[ForeignKey("PreparationID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("PreparationToCertificateAudit")]
public partial class PreparationToCertificateAudit
:IAudit{ 
public PreparationToCertificateAudit()
{
}
[Required]
[Column(name:"CertificateID")]
public int CertificateID {get; set;}
[Required]
[Column(name:"CertificateNumber")]
[StringLength(50)]
public string CertificateNumber {get; set;}
[Required]
[Column(name:"CertificateTypeToCertificateID")]
public int CertificateTypeToCertificateID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"CurrentIndicator")]
public bool CurrentIndicator {get; set;}
[Required]
[Column(name:"EffectiveEndDate",TypeName = "datetime2")]
public DateTime EffectiveEndDate {get; set;}
[Required]
[Column(name:"EffectiveStartDate",TypeName = "datetime2")]
public DateTime EffectiveStartDate {get; set;}
[Column(name:"FinalizedIndicator")]
public bool? FinalizedIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PreparationID")]
public int PreparationID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
