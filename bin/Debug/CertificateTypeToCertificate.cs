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
[Table("CertificateTypeToCertificate")]
public partial class CertificateTypeToCertificate
:IAuditable{ 
public CertificateTypeToCertificate()
{
this.LevelToCertificates = new HashSet<LevelToCertificate>();
this.PreparationToCertificates = new HashSet<PreparationToCertificate>();
}
[Required]
[Column(name:"CertificateID")]
public int CertificateID {get; set;}
[Required]
[Column(name:"CertificateNumber")]
[StringLength(50)]
public string CertificateNumber {get; set;}
[Required]
[Column(name:"CertificateTypeID")]
public int CertificateTypeID {get; set;}
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
[ForeignKey("CertificateID")]
public virtual Certificate Certificate{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual CertificateType CertificateType{get; set;}
[ForeignKey("CertificateTypeToCertificateID")]
public virtual ICollection<LevelToCertificate> LevelToCertificates{get; set;}
[ForeignKey("CertificateTypeToCertificateID")]
public virtual ICollection<PreparationToCertificate> PreparationToCertificates{get; set;}
}
[Table("CertificateTypeToCertificateAudit")]
public partial class CertificateTypeToCertificateAudit
:IAudit{ 
public CertificateTypeToCertificateAudit()
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
[Column(name:"CertificateTypeID")]
public int CertificateTypeID {get; set;}
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
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
