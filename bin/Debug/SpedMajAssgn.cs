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
[Table("SpedMajAssgn")]
public partial class SpedMajAssgn
:IAuditable{ 
public SpedMajAssgn()
{
}
[Column(name:"AssignmentCodeID")]
public int? AssignmentCodeID {get; set;}
[Required]
[Column(name:"ConcurrencyID")]
public int ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"MajorCodeID")]
public int? MajorCodeID {get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual PRFAssgn PRFAssgn{get; set;}
[ForeignKey("MajorCodeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("SpedMajAssgnAudit")]
public partial class SpedMajAssgnAudit
:IAudit{ 
public SpedMajAssgnAudit()
{
}
[Column(name:"AssignmentCodeID")]
public int? AssignmentCodeID {get; set;}
[Required]
[Column(name:"ConcurrencyID")]
public int ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"MajorCodeID")]
public int? MajorCodeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
