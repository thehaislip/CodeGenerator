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
[Table("OCUCOAppDInfoToPreparation")]
public partial class OCUCOAppDInfoToPreparation
:IAuditable{ 
public OCUCOAppDInfoToPreparation()
{
}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Required]
[Column(name:"CertificateTypeToPreparationID")]
public int CertificateTypeToPreparationID {get; set;}
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
[ForeignKey("CertificateTypeToPreparationID")]
public virtual CertificateTypeToPreparation CertificateTypeToPreparation{get; set;}
[ForeignKey("UCOProfileID")]
public virtual OCUCOProfile OCUCOProfile{get; set;}
}
[Table("OCUCOAppDInfoToPreparationAudit")]
public partial class OCUCOAppDInfoToPreparationAudit
:IAudit{ 
public OCUCOAppDInfoToPreparationAudit()
{
}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Required]
[Column(name:"CertificateTypeToPreparationID")]
public int CertificateTypeToPreparationID {get; set;}
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
