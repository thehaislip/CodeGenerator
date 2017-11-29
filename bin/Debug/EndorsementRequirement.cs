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
[Table("EndorsementRequirement")]
public partial class EndorsementRequirement
:IAuditable{ 
public EndorsementRequirement()
{
this.Requirements = new HashSet<Requirement>();
this.Options = new HashSet<Option>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EffectiveDate",TypeName = "datetime2")]
public DateTime? EffectiveDate {get; set;}
[Column(name:"EndDate",TypeName = "datetime2")]
public DateTime? EndDate {get; set;}
[Required]
[Column(name:"EndorsementID")]
public int EndorsementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PreparationID")]
public int PreparationID {get; set;}
[ForeignKey("EndorsementID")]
public virtual Endorsement Endorsement{get; set;}
[ForeignKey("EndorsementRequirementID")]
public virtual ICollection<Requirement> Requirements{get; set;}
[ForeignKey("EndorsementRequirementID")]
public virtual ICollection<Option> Options{get; set;}
[ForeignKey("PreparationID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("EndorsementRequirementAudit")]
public partial class EndorsementRequirementAudit
:IAudit{ 
public EndorsementRequirementAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EffectiveDate",TypeName = "datetime2")]
public DateTime? EffectiveDate {get; set;}
[Column(name:"EndDate",TypeName = "datetime2")]
public DateTime? EndDate {get; set;}
[Required]
[Column(name:"EndorsementID")]
public int EndorsementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PreparationID")]
public int PreparationID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
