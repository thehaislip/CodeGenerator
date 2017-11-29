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
[Table("Endorsement")]
public partial class Endorsement
:IAuditable{ 
public Endorsement()
{
this.AssignmentToSpedEndorsements = new HashSet<AssignmentToSpedEndorsement>();
this.CertificateTypeToEndorsements = new HashSet<CertificateTypeToEndorsement>();
this.PRFAssgnTypeToEndorsements = new HashSet<PRFAssgnTypeToEndorsement>();
this.OCUCOEndorsementCns = new HashSet<OCUCOEndorsementCn>();
this.EndorsementToCertificates = new HashSet<EndorsementToCertificate>();
this.EndorsementRequirements = new HashSet<EndorsementRequirement>();
this.OCAPPRenewProPrpCns = new HashSet<OCAPPRenewProPrpCn>();
this.OCAppDInfoToEndorsements = new HashSet<OCAppDInfoToEndorsement>();
this.SpedEndAssgns = new HashSet<SpedEndAssgn>();
this.SpedPrepAssgns = new HashSet<SpedPrepAssgn>();
this.AssignmentToEndorsements = new HashSet<AssignmentToEndorsement>();
this.OCUCOProfessionalPrepCns = new HashSet<OCUCOProfessionalPrepCn>();
}
[Required]
[Column(name:"Code")]
[StringLength(12)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(250)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
public bool Disabled {get; set;}
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Required]
[Column(name:"EndorsementCategoryID")]
public int EndorsementCategoryID {get; set;}
[Column(name:"HistoricInd")]
public bool? HistoricInd {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("EndorsementCategoryID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("EndorsementID")]
public virtual ICollection<AssignmentToSpedEndorsement> AssignmentToSpedEndorsements{get; set;}
[ForeignKey("EndorsementID")]
public virtual ICollection<CertificateTypeToEndorsement> CertificateTypeToEndorsements{get; set;}
[ForeignKey("EndorsementID")]
public virtual ICollection<PRFAssgnTypeToEndorsement> PRFAssgnTypeToEndorsements{get; set;}
[ForeignKey("EndorsementID")]
public virtual ICollection<OCUCOEndorsementCn> OCUCOEndorsementCns{get; set;}
[ForeignKey("EndorsementID")]
public virtual ICollection<EndorsementToCertificate> EndorsementToCertificates{get; set;}
[ForeignKey("EndorsementID")]
public virtual ICollection<EndorsementRequirement> EndorsementRequirements{get; set;}
[ForeignKey("EndrCodeID")]
public virtual ICollection<OCAPPRenewProPrpCn> OCAPPRenewProPrpCns{get; set;}
[ForeignKey("EndorsementID")]
public virtual ICollection<OCAppDInfoToEndorsement> OCAppDInfoToEndorsements{get; set;}
[ForeignKey("EndrCodeID")]
public virtual ICollection<SpedEndAssgn> SpedEndAssgns{get; set;}
[ForeignKey("EndrCodeID")]
public virtual ICollection<SpedPrepAssgn> SpedPrepAssgns{get; set;}
[ForeignKey("EndorsementID")]
public virtual ICollection<AssignmentToEndorsement> AssignmentToEndorsements{get; set;}
[ForeignKey("EndrCodeID")]
public virtual ICollection<OCUCOProfessionalPrepCn> OCUCOProfessionalPrepCns{get; set;}
}
[Table("EndorsementAudit")]
public partial class EndorsementAudit
:IAudit{ 
public EndorsementAudit()
{
}
[Required]
[Column(name:"Code")]
[StringLength(12)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(250)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
public bool Disabled {get; set;}
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Required]
[Column(name:"EndorsementCategoryID")]
public int EndorsementCategoryID {get; set;}
[Column(name:"HistoricInd")]
public bool? HistoricInd {get; set;}
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
