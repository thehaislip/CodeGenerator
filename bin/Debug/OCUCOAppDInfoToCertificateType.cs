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
[Table("OCUCOAppDInfoToCertificateType")]
public partial class OCUCOAppDInfoToCertificateType
:IAuditable{ 
public OCUCOAppDInfoToCertificateType()
{
}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Column(name:"CertificateOnly")]
public bool? CertificateOnly {get; set;}
[Required]
[Column(name:"CertificateTypeID")]
public int CertificateTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"UCOProfileID")]
public int? UCOProfileID {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual CertificateType CertificateType{get; set;}
[ForeignKey("UCOProfileID")]
public virtual OCUCOProfile OCUCOProfile{get; set;}
}
[Table("OCUCOAppDInfoToCertificateTypeAudit")]
public partial class OCUCOAppDInfoToCertificateTypeAudit
:IAudit{ 
public OCUCOAppDInfoToCertificateTypeAudit()
{
}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Column(name:"CertificateOnly")]
public bool? CertificateOnly {get; set;}
[Required]
[Column(name:"CertificateTypeID")]
public int CertificateTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"UCOProfileID")]
public int? UCOProfileID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
