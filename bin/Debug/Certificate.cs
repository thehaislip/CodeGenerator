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
[Table("Certificate")]
public partial class Certificate
:IAuditable{ 
public Certificate()
{
this.SDIndStudiess = new HashSet<SDIndStudies>();
this.CertificateTypeToCertificates = new HashSet<CertificateTypeToCertificate>();
this.CPrtRecs = new HashSet<CPrtRec>();
this.OCDOECertMailOpts = new HashSet<OCDOECertMailOpt>();
this.CPSubjs = new HashSet<CPSubj>();
this.OCDOESuspensionss = new HashSet<OCDOESuspensions>();
this.CertificatePrints = new HashSet<CertificatePrint>();
this.LevelToCertificates = new HashSet<LevelToCertificate>();
this.CPMAJRs = new HashSet<CPMAJR>();
this.EndorsementToCertificates = new HashSet<EndorsementToCertificate>();
this.PreparationToCertificates = new HashSet<PreparationToCertificate>();
this.CertHistorys = new HashSet<CertHistory>();
}
[Column(name:"ActiveCertificateIndicator")]
public bool? ActiveCertificateIndicator {get; set;}
[Required]
[Column(name:"CertificateNumber")]
[StringLength(50)]
public string CertificateNumber {get; set;}
[Column(name:"concurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EffectiveDate",TypeName = "datetime2")]
public DateTime? EffectiveDate {get; set;}
[Column(name:"ExpirationDate",TypeName = "datetime2")]
public DateTime? ExpirationDate {get; set;}
[Column(name:"FinalizedIndicator")]
public bool? FinalizedIndicator {get; set;}
[Column(name:"HOUSSE")]
public bool? HOUSSE {get; set;}
[Column(name:"HumanRelations")]
public bool? HumanRelations {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IssueDate",TypeName = "datetime2")]
public DateTime? IssueDate {get; set;}
[Required]
[Column(name:"PersonID")]
public int PersonID {get; set;}
[Column(name:"PrintCodeID")]
public int? PrintCodeID {get; set;}
[Column(name:"ReasonID")]
public int? ReasonID {get; set;}
[Column(name:"RevisionNumber")]
public int? RevisionNumber {get; set;}
[Column(name:"SDIndianStudies")]
public bool? SDIndianStudies {get; set;}
[Column(name:"SnapshotTakenByID")]
public int? SnapshotTakenByID {get; set;}
[Column(name:"StatusDate",TypeName = "datetime2")]
public DateTime? StatusDate {get; set;}
[Column(name:"StatusID")]
public int? StatusID {get; set;}
[Column(name:"SuspendedDate",TypeName = "datetime2")]
public DateTime? SuspendedDate {get; set;}
[Column(name:"SuspendedEndDated",TypeName = "datetime2")]
public DateTime? SuspendedEndDated {get; set;}
[ForeignKey("CertCredID")]
public virtual ICollection<SDIndStudies> SDIndStudiess{get; set;}
[ForeignKey("CertificateID")]
public virtual ICollection<CertificateTypeToCertificate> CertificateTypeToCertificates{get; set;}
[ForeignKey("CertCredID")]
public virtual ICollection<CPrtRec> CPrtRecs{get; set;}
[ForeignKey("CertCredID")]
public virtual ICollection<OCDOECertMailOpt> OCDOECertMailOpts{get; set;}
[ForeignKey("DE04CertCredID")]
public virtual ICollection<CPSubj> CPSubjs{get; set;}
[ForeignKey("CertificateID")]
public virtual ICollection<OCDOESuspensions> OCDOESuspensionss{get; set;}
[ForeignKey("CertificateID")]
public virtual ICollection<CertificatePrint> CertificatePrints{get; set;}
[ForeignKey("CertificateID")]
public virtual ICollection<LevelToCertificate> LevelToCertificates{get; set;}
[ForeignKey("DE04CertCredID")]
public virtual ICollection<CPMAJR> CPMAJRs{get; set;}
[ForeignKey("CertificateID")]
public virtual ICollection<EndorsementToCertificate> EndorsementToCertificates{get; set;}
[ForeignKey("CertificateID")]
public virtual ICollection<PreparationToCertificate> PreparationToCertificates{get; set;}
[ForeignKey("CertCredID")]
public virtual ICollection<CertHistory> CertHistorys{get; set;}
[ForeignKey("PersonID")]
public virtual COMMPerson COMMPerson{get; set;}
[ForeignKey("PrintCodeID")]
public virtual PrntCode PrntCode{get; set;}
[ForeignKey("ReasonID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("SnapshotTakenByID")]
public virtual CommLookup CommLookup1{get; set;}
[ForeignKey("StatusID")]
public virtual CommLookup CommLookup2{get; set;}
}
[Table("CertificateAudit")]
public partial class CertificateAudit
:IAudit{ 
public CertificateAudit()
{
}
[Column(name:"ActiveCertificateIndicator")]
public bool? ActiveCertificateIndicator {get; set;}
[Required]
[Column(name:"CertificateNumber")]
[StringLength(50)]
public string CertificateNumber {get; set;}
[Column(name:"concurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EffectiveDate",TypeName = "datetime2")]
public DateTime? EffectiveDate {get; set;}
[Column(name:"ExpirationDate",TypeName = "datetime2")]
public DateTime? ExpirationDate {get; set;}
[Column(name:"FinalizedIndicator")]
public bool? FinalizedIndicator {get; set;}
[Column(name:"HOUSSE")]
public bool? HOUSSE {get; set;}
[Column(name:"HumanRelations")]
public bool? HumanRelations {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IssueDate",TypeName = "datetime2")]
public DateTime? IssueDate {get; set;}
[Required]
[Column(name:"PersonID")]
public int PersonID {get; set;}
[Column(name:"PrintCodeID")]
public int? PrintCodeID {get; set;}
[Column(name:"ReasonID")]
public int? ReasonID {get; set;}
[Column(name:"RevisionNumber")]
public int? RevisionNumber {get; set;}
[Column(name:"SDIndianStudies")]
public bool? SDIndianStudies {get; set;}
[Column(name:"SnapshotTakenByID")]
public int? SnapshotTakenByID {get; set;}
[Column(name:"StatusDate",TypeName = "datetime2")]
public DateTime? StatusDate {get; set;}
[Column(name:"StatusID")]
public int? StatusID {get; set;}
[Column(name:"SuspendedDate",TypeName = "datetime2")]
public DateTime? SuspendedDate {get; set;}
[Column(name:"SuspendedEndDated",TypeName = "datetime2")]
public DateTime? SuspendedEndDated {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
