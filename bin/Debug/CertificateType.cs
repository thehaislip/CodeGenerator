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
[Table("CertificateType")]
public partial class CertificateType
:IAuditable{ 
public CertificateType()
{
this.CertificateTypeToCertificates = new HashSet<CertificateTypeToCertificate>();
this.CertificateTypeToEndorsements = new HashSet<CertificateTypeToEndorsement>();
this.ApplicationTypeToCertificateTypes = new HashSet<ApplicationTypeToCertificateType>();
this.OCDOEAppDInfoToCertificateTypes = new HashSet<OCDOEAppDInfoToCertificateType>();
this.OCUCOAppDInfoToCertificateTypes = new HashSet<OCUCOAppDInfoToCertificateType>();
this.OCAppDInfoToCertificateTypes = new HashSet<OCAppDInfoToCertificateType>();
this.CertificateTypeToPreparations = new HashSet<CertificateTypeToPreparation>();
this.CertHistorys = new HashSet<CertHistory>();
this.CPrtRecs = new HashSet<CPrtRec>();
this.FeeTypeToCertificateTypes = new HashSet<FeeTypeToCertificateType>();
this.CertificateTypeToLevels = new HashSet<CertificateTypeToLevel>();
this.CPSubjs = new HashSet<CPSubj>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Name")]
[StringLength(150)]
public string Name {get; set;}
[Column(name:"RequiresExistingLicenseInd")]
public bool? RequiresExistingLicenseInd {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[Column(name:"YearsValid")]
public int? YearsValid {get; set;}
[ForeignKey("CertificateTypeID")]
public virtual ICollection<CertificateTypeToCertificate> CertificateTypeToCertificates{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual ICollection<CertificateTypeToEndorsement> CertificateTypeToEndorsements{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual ICollection<ApplicationTypeToCertificateType> ApplicationTypeToCertificateTypes{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual ICollection<OCDOEAppDInfoToCertificateType> OCDOEAppDInfoToCertificateTypes{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual ICollection<OCUCOAppDInfoToCertificateType> OCUCOAppDInfoToCertificateTypes{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual ICollection<OCAppDInfoToCertificateType> OCAppDInfoToCertificateTypes{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual ICollection<CertificateTypeToPreparation> CertificateTypeToPreparations{get; set;}
[ForeignKey("CertTypeID")]
public virtual ICollection<CertHistory> CertHistorys{get; set;}
[ForeignKey("CertCredTypeID")]
public virtual ICollection<CPrtRec> CPrtRecs{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual ICollection<FeeTypeToCertificateType> FeeTypeToCertificateTypes{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual ICollection<CertificateTypeToLevel> CertificateTypeToLevels{get; set;}
[ForeignKey("DE04CertCredTypeID")]
public virtual ICollection<CPSubj> CPSubjs{get; set;}
}
[Table("CertificateTypeAudit")]
public partial class CertificateTypeAudit
:IAudit{ 
public CertificateTypeAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Name")]
[StringLength(150)]
public string Name {get; set;}
[Column(name:"RequiresExistingLicenseInd")]
public bool? RequiresExistingLicenseInd {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[Column(name:"YearsValid")]
public int? YearsValid {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
