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
[Table("Requirement")]
public partial class Requirement
:IAuditable{ 
public Requirement()
{
this.RequirementOptionGroups = new HashSet<RequirementOptionGroup>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"EndorsementRequirementID")]
public int EndorsementRequirementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"QualificationID")]
public int QualificationID {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[Column(name:"Text")]
public string Text {get; set;}
[Required]
[Column(name:"Type")]
[StringLength(50)]
public string Type {get; set;}
[ForeignKey("EndorsementRequirementID")]
public virtual EndorsementRequirement EndorsementRequirement{get; set;}
[ForeignKey("RequirementID")]
public virtual ICollection<RequirementOptionGroup> RequirementOptionGroups{get; set;}
[ForeignKey("QualificationID")]
public virtual Qualification Qualification{get; set;}
}
[Table("RequirementAudit")]
public partial class RequirementAudit
:IAudit{ 
public RequirementAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"EndorsementRequirementID")]
public int EndorsementRequirementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"QualificationID")]
public int QualificationID {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[Column(name:"Text")]
public string Text {get; set;}
[Required]
[Column(name:"Type")]
[StringLength(50)]
public string Type {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
