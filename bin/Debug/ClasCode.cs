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
[Table("ClasCode")]
public partial class ClasCode
:IAuditable{ 
public ClasCode()
{
this.CoopClassifids = new HashSet<CoopClassifid>();
this.CSEClasss = new HashSet<CSEClass>();
this.Classfids = new HashSet<Classfid>();
}
[Column(name:"ClassifiedCategoryID")]
public int? ClassifiedCategoryID {get; set;}
[Required]
[Column(name:"ClassifiedCode")]
[StringLength(12)]
public string ClassifiedCode {get; set;}
[Required]
[Column(name:"ClassifiedCodeDesc")]
[StringLength(120)]
public string ClassifiedCodeDesc {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IsValidForContractedSped")]
[StringLength(1)]
public string IsValidForContractedSped {get; set;}
[ForeignKey("ClassCodeID")]
public virtual ICollection<CoopClassifid> CoopClassifids{get; set;}
[ForeignKey("ClassCodeID")]
public virtual ICollection<CSEClass> CSEClasss{get; set;}
[ForeignKey("ClassCodeID")]
public virtual ICollection<Classfid> Classfids{get; set;}
}
[Table("ClasCodeAudit")]
public partial class ClasCodeAudit
:IAudit{ 
public ClasCodeAudit()
{
}
[Column(name:"ClassifiedCategoryID")]
public int? ClassifiedCategoryID {get; set;}
[Required]
[Column(name:"ClassifiedCode")]
[StringLength(12)]
public string ClassifiedCode {get; set;}
[Required]
[Column(name:"ClassifiedCodeDesc")]
[StringLength(120)]
public string ClassifiedCodeDesc {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IsValidForContractedSped")]
[StringLength(1)]
public string IsValidForContractedSped {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
