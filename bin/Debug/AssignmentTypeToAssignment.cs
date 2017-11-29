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
[Table("AssignmentTypeToAssignment")]
public partial class AssignmentTypeToAssignment
:IAuditable{ 
public AssignmentTypeToAssignment()
{
}
[Required]
[Column(name:"AssignmentID")]
public int AssignmentID {get; set;}
[Required]
[Column(name:"AssignmentTypeID")]
public int AssignmentTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("AssignmentID")]
public virtual Assignment Assignment{get; set;}
[ForeignKey("AssignmentTypeID")]
public virtual AssignmentType AssignmentType{get; set;}
}
[Table("AssignmentTypeToAssignmentAudit")]
public partial class AssignmentTypeToAssignmentAudit
:IAudit{ 
public AssignmentTypeToAssignmentAudit()
{
}
[Required]
[Column(name:"AssignmentID")]
public int AssignmentID {get; set;}
[Required]
[Column(name:"AssignmentTypeID")]
public int AssignmentTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
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
