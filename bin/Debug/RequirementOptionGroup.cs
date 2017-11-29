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
[Table("RequirementOptionGroup")]
public partial class RequirementOptionGroup
:IAuditable{ 
public RequirementOptionGroup()
{
this.PlanOfIntentToRequirementOptionGroups = new HashSet<PlanOfIntentToRequirementOptionGroup>();
this.ListGroups = new HashSet<ListGroup>();
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
[Column(name:"NumberRequired")]
public int NumberRequired {get; set;}
[Column(name:"OptionID")]
public int? OptionID {get; set;}
[Column(name:"RequirementID")]
public int? RequirementID {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[ForeignKey("RequirementOptionGroupID")]
public virtual ICollection<PlanOfIntentToRequirementOptionGroup> PlanOfIntentToRequirementOptionGroups{get; set;}
[ForeignKey("RequirementOptionGroupID")]
public virtual ICollection<ListGroup> ListGroups{get; set;}
[ForeignKey("OptionID")]
public virtual Option Option{get; set;}
[ForeignKey("RequirementID")]
public virtual Requirement Requirement{get; set;}
}
[Table("RequirementOptionGroupAudit")]
public partial class RequirementOptionGroupAudit
:IAudit{ 
public RequirementOptionGroupAudit()
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
[Column(name:"NumberRequired")]
public int NumberRequired {get; set;}
[Column(name:"OptionID")]
public int? OptionID {get; set;}
[Column(name:"RequirementID")]
public int? RequirementID {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
