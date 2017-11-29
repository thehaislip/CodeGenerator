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
[Table("OCUCOAppDInfoToLevel")]
public partial class OCUCOAppDInfoToLevel
:IAuditable{ 
public OCUCOAppDInfoToLevel()
{
}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Required]
[Column(name:"CertificateTypeToLevelID")]
public int CertificateTypeToLevelID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("CertificateTypeToLevelID")]
public virtual CertificateTypeToLevel CertificateTypeToLevel{get; set;}
}
[Table("OCUCOAppDInfoToLevelAudit")]
public partial class OCUCOAppDInfoToLevelAudit
:IAudit{ 
public OCUCOAppDInfoToLevelAudit()
{
}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Required]
[Column(name:"CertificateTypeToLevelID")]
public int CertificateTypeToLevelID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
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
