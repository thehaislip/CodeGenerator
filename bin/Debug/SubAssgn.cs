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
[Table("SubAssgn")]
public partial class SubAssgn
:IAuditable{ 
public SubAssgn()
{
}
[Column(name:"AssignmentCodeID")]
public int? AssignmentCodeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SubjectAssignmentCodeID")]
public int? SubjectAssignmentCodeID {get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual Assignment Assignment{get; set;}
[ForeignKey("SubjectAssignmentCodeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("SubAssgnAudit")]
public partial class SubAssgnAudit
:IAudit{ 
public SubAssgnAudit()
{
}
[Column(name:"AssignmentCodeID")]
public int? AssignmentCodeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SubjectAssignmentCodeID")]
public int? SubjectAssignmentCodeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
