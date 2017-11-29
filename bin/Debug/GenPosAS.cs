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
[Table("GenPosAS")]
public partial class GenPosAS
:IAuditable{ 
public GenPosAS()
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
[Column(name:"PositionCodeID")]
public int? PositionCodeID {get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual Assignment Assignment{get; set;}
[ForeignKey("PositionCodeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("GenPosASAudit")]
public partial class GenPosASAudit
:IAudit{ 
public GenPosASAudit()
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
[Column(name:"PositionCodeID")]
public int? PositionCodeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
