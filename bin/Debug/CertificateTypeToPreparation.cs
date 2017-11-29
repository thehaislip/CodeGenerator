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
[Table("CertificateTypeToPreparation")]
public partial class CertificateTypeToPreparation
:IAuditable{ 
public CertificateTypeToPreparation()
{
this.OCAppDInfoToPreparations = new HashSet<OCAppDInfoToPreparation>();
this.OCUCOAppDInfoToPreparations = new HashSet<OCUCOAppDInfoToPreparation>();
this.OCDOEAppDInfoToPreparations = new HashSet<OCDOEAppDInfoToPreparation>();
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
[Column(name:"EndDate",TypeName = "datetime2")]
public DateTime? EndDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"StartDate",TypeName = "datetime2")]
public DateTime StartDate {get; set;}
[ForeignKey("CertificateTypeID")]
public virtual CertificateType CertificateType{get; set;}
[ForeignKey("CommLookupID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("CertificateTypeToPreparationID")]
public virtual ICollection<OCAppDInfoToPreparation> OCAppDInfoToPreparations{get; set;}
[ForeignKey("CertificateTypeToPreparationID")]
public virtual ICollection<OCUCOAppDInfoToPreparation> OCUCOAppDInfoToPreparations{get; set;}
[ForeignKey("CertificateTypeToPreparationID")]
public virtual ICollection<OCDOEAppDInfoToPreparation> OCDOEAppDInfoToPreparations{get; set;}
}
[Table("CertificateTypeToPreparationAudit")]
public partial class CertificateTypeToPreparationAudit
:IAudit{ 
public CertificateTypeToPreparationAudit()
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
[Column(name:"EndDate",TypeName = "datetime2")]
public DateTime? EndDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"StartDate",TypeName = "datetime2")]
public DateTime StartDate {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
