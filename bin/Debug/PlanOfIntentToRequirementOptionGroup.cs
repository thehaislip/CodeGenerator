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
[Table("PlanOfIntentToRequirementOptionGroup")]
public partial class PlanOfIntentToRequirementOptionGroup
:IAuditable{ 
public PlanOfIntentToRequirementOptionGroup()
{
this.PlanOfIntentToRequirementOptionGroupToListGroups = new HashSet<PlanOfIntentToRequirementOptionGroupToListGroup>();
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
[Required]
[Column(name:"PlanOfIntentID")]
public int PlanOfIntentID {get; set;}
[Required]
[Column(name:"RequirementOptionGroupID")]
public int RequirementOptionGroupID {get; set;}
[ForeignKey("PlanOfIntentToRequirementOptionGroupID")]
public virtual ICollection<PlanOfIntentToRequirementOptionGroupToListGroup> PlanOfIntentToRequirementOptionGroupToListGroups{get; set;}
[ForeignKey("PlanOfIntentID")]
public virtual DistPlanIntnt DistPlanIntnt{get; set;}
[ForeignKey("RequirementOptionGroupID")]
public virtual RequirementOptionGroup RequirementOptionGroup{get; set;}
}
[Table("PlanOfIntentToRequirementOptionGroupAudit")]
public partial class PlanOfIntentToRequirementOptionGroupAudit
:IAudit{ 
public PlanOfIntentToRequirementOptionGroupAudit()
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
[Required]
[Column(name:"PlanOfIntentID")]
public int PlanOfIntentID {get; set;}
[Required]
[Column(name:"RequirementOptionGroupID")]
public int RequirementOptionGroupID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
