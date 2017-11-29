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
[Table("AssignmentType")]
public partial class AssignmentType
:IAuditable{ 
public AssignmentType()
{
this.AssignmentTypeToAssignments = new HashSet<AssignmentTypeToAssignment>();
}
[Required]
[Column(name:"BriefDescription")]
[StringLength(80)]
public string BriefDescription {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"KeyPrefix")]
[StringLength(10)]
public string KeyPrefix {get; set;}
[Required]
[Column(name:"Name")]
[StringLength(80)]
public string Name {get; set;}
[ForeignKey("AssignmentTypeID")]
public virtual ICollection<AssignmentTypeToAssignment> AssignmentTypeToAssignments{get; set;}
}
[Table("AssignmentTypeAudit")]
public partial class AssignmentTypeAudit
:IAudit{ 
public AssignmentTypeAudit()
{
}
[Required]
[Column(name:"BriefDescription")]
[StringLength(80)]
public string BriefDescription {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"KeyPrefix")]
[StringLength(10)]
public string KeyPrefix {get; set;}
[Required]
[Column(name:"Name")]
[StringLength(80)]
public string Name {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
