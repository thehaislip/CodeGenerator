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
[Table("PlanOfIntentToRequirementOptionGroupToListGroup")]
public partial class PlanOfIntentToRequirementOptionGroupToListGroup
:IAuditable{ 
public PlanOfIntentToRequirementOptionGroupToListGroup()
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
[Column(name:"ListGroupID")]
public int ListGroupID {get; set;}
[Required]
[Column(name:"PlanOfIntentToRequirementOptionGroupID")]
public int PlanOfIntentToRequirementOptionGroupID {get; set;}
[ForeignKey("ListGroupID")]
public virtual ListGroup ListGroup{get; set;}
[ForeignKey("PlanOfIntentToRequirementOptionGroupID")]
public virtual PlanOfIntentToRequirementOptionGroup PlanOfIntentToRequirementOptionGroup{get; set;}
}
[Table("PlanOfIntentToRequirementOptionGroupToListGroupAudit")]
public partial class PlanOfIntentToRequirementOptionGroupToListGroupAudit
:IAudit{ 
public PlanOfIntentToRequirementOptionGroupToListGroupAudit()
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
[Column(name:"ListGroupID")]
public int ListGroupID {get; set;}
[Required]
[Column(name:"PlanOfIntentToRequirementOptionGroupID")]
public int PlanOfIntentToRequirementOptionGroupID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
