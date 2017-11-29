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
[Table("ApplicationType")]
public partial class ApplicationType
:IAuditable{ 
public ApplicationType()
{
this.OCAppDInfos = new HashSet<OCAppDInfo>();
this.ApplicationTypeToCertificateTypes = new HashSet<ApplicationTypeToCertificateType>();
this.ApplicationTypeToSections = new HashSet<ApplicationTypeToSection>();
this.OCAPPConReviewAppTypeCns = new HashSet<OCAPPConReviewAppTypeCn>();
}
[Column(name:"ApplicationCategoryID")]
public int? ApplicationCategoryID {get; set;}
[Required]
[Column(name:"ApplicationTypeID")]
public int ApplicationTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Description")]
[StringLength(1500)]
public string Description {get; set;}
[Column(name:"EffectiveEndDate",TypeName = "datetime2")]
public DateTime? EffectiveEndDate {get; set;}
[Required]
[Column(name:"EffectiveStartDate",TypeName = "datetime2")]
public DateTime EffectiveStartDate {get; set;}
[Column(name:"HistoricInd")]
public bool? HistoricInd {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("ApplicationCategoryID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("ApplicationTypeID")]
public virtual CommLookup CommLookup1{get; set;}
[ForeignKey("AppTypeID")]
public virtual ICollection<OCAppDInfo> OCAppDInfos{get; set;}
[ForeignKey("ApplicationTypeID")]
public virtual ICollection<ApplicationTypeToCertificateType> ApplicationTypeToCertificateTypes{get; set;}
[ForeignKey("ApplicationTypeID")]
public virtual ICollection<ApplicationTypeToSection> ApplicationTypeToSections{get; set;}
[ForeignKey("AppTypeID")]
public virtual ICollection<OCAPPConReviewAppTypeCn> OCAPPConReviewAppTypeCns{get; set;}
}
[Table("ApplicationTypeAudit")]
public partial class ApplicationTypeAudit
:IAudit{ 
public ApplicationTypeAudit()
{
}
[Column(name:"ApplicationCategoryID")]
public int? ApplicationCategoryID {get; set;}
[Required]
[Column(name:"ApplicationTypeID")]
public int ApplicationTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Description")]
[StringLength(1500)]
public string Description {get; set;}
[Column(name:"EffectiveEndDate",TypeName = "datetime2")]
public DateTime? EffectiveEndDate {get; set;}
[Required]
[Column(name:"EffectiveStartDate",TypeName = "datetime2")]
public DateTime EffectiveStartDate {get; set;}
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
