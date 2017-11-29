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
[Table("CertificateTypeToLevel")]
public partial class CertificateTypeToLevel
:IAuditable{ 
public CertificateTypeToLevel()
{
this.OCUCOAppDInfoToLevels = new HashSet<OCUCOAppDInfoToLevel>();
this.OCAppDInfoToLevels = new HashSet<OCAppDInfoToLevel>();
this.OCDOEAppDInfoToLevels = new HashSet<OCDOEAppDInfoToLevel>();
}
[Required]
[Column(name:"CertificateTypeID")]
public int CertificateTypeID {get; set;}
[Required]
[Column(name:"CommLookupID")]
public int CommLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DisabledIndicator")]
public bool? DisabledIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("CertificateTypeID")]
public virtual CertificateType CertificateType{get; set;}
[ForeignKey("CommLookupID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("CertificateTypeToLevelID")]
public virtual ICollection<OCUCOAppDInfoToLevel> OCUCOAppDInfoToLevels{get; set;}
[ForeignKey("CertificateTypeToLevelID")]
public virtual ICollection<OCAppDInfoToLevel> OCAppDInfoToLevels{get; set;}
[ForeignKey("CertificateTypeToLevelID")]
public virtual ICollection<OCDOEAppDInfoToLevel> OCDOEAppDInfoToLevels{get; set;}
}
[Table("CertificateTypeToLevelAudit")]
public partial class CertificateTypeToLevelAudit
:IAudit{ 
public CertificateTypeToLevelAudit()
{
}
[Required]
[Column(name:"CertificateTypeID")]
public int CertificateTypeID {get; set;}
[Required]
[Column(name:"CommLookupID")]
public int CommLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DisabledIndicator")]
public bool? DisabledIndicator {get; set;}
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
