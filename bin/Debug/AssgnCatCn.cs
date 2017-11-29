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
[Table("AssgnCatCn")]
public partial class AssgnCatCn
:IAuditable{ 
public AssgnCatCn()
{
}
[Column(name:"AssignmentCategoryID")]
public int? AssignmentCategoryID {get; set;}
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
[ForeignKey("AssignmentCategoryID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual Assignment Assignment{get; set;}
}
[Table("AssgnCatCnAudit")]
public partial class AssgnCatCnAudit
:IAudit{ 
public AssgnCatCnAudit()
{
}
[Column(name:"AssignmentCategoryID")]
public int? AssignmentCategoryID {get; set;}
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
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
