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
[Table("Qualification")]
public partial class Qualification
:IAuditable{ 
public Qualification()
{
this.Requirements = new HashSet<Requirement>();
this.Options = new HashSet<Option>();
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
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Column(name:"DisabledInd")]
public bool? DisabledInd {get; set;}
[Required]
[Column(name:"DisplayOrder")]
public int DisplayOrder {get; set;}
[Column(name:"DocumentationRequiredIndicator")]
public bool? DocumentationRequiredIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"LookupTypeID")]
public int? LookupTypeID {get; set;}
[Column(name:"Type")]
[StringLength(20)]
public string Type {get; set;}
[ForeignKey("QualificationID")]
public virtual ICollection<Requirement> Requirements{get; set;}
[ForeignKey("QualificationID")]
public virtual ICollection<Option> Options{get; set;}
[ForeignKey("LookupTypeID")]
public virtual CommLookupType CommLookupType{get; set;}
}
[Table("QualificationAudit")]
public partial class QualificationAudit
:IAudit{ 
public QualificationAudit()
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
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Column(name:"DisabledInd")]
public bool? DisabledInd {get; set;}
[Required]
[Column(name:"DisplayOrder")]
public int DisplayOrder {get; set;}
[Column(name:"DocumentationRequiredIndicator")]
public bool? DocumentationRequiredIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"LookupTypeID")]
public int? LookupTypeID {get; set;}
[Column(name:"Type")]
[StringLength(20)]
public string Type {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
