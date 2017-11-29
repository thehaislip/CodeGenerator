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
[Table("ListGroup")]
public partial class ListGroup
:IAuditable{ 
public ListGroup()
{
this.PlanOfIntentToRequirementOptionGroupToListGroups = new HashSet<PlanOfIntentToRequirementOptionGroupToListGroup>();
}
[Required]
[Column(name:"CommonLookupID")]
public int CommonLookupID {get; set;}
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
[Column(name:"RequirementOptionGroupID")]
public int RequirementOptionGroupID {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[Required]
[Column(name:"SuperGroupID")]
public Guid SuperGroupID {get; set;}
[ForeignKey("CommonLookupID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("ListGroupID")]
public virtual ICollection<PlanOfIntentToRequirementOptionGroupToListGroup> PlanOfIntentToRequirementOptionGroupToListGroups{get; set;}
[ForeignKey("RequirementOptionGroupID")]
public virtual RequirementOptionGroup RequirementOptionGroup{get; set;}
}
[Table("ListGroupAudit")]
public partial class ListGroupAudit
:IAudit{ 
public ListGroupAudit()
{
}
[Required]
[Column(name:"CommonLookupID")]
public int CommonLookupID {get; set;}
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
[Column(name:"RequirementOptionGroupID")]
public int RequirementOptionGroupID {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[Required]
[Column(name:"SuperGroupID")]
public Guid SuperGroupID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
