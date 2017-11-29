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
[Table("EndOnlyPhsOut")]
public partial class EndOnlyPhsOut
:IAuditable{ 
public EndOnlyPhsOut()
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
[Column(name:"Level3ID")]
public int? Level3ID {get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual Assignment Assignment{get; set;}
[ForeignKey("Level3ID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("EndOnlyPhsOutAudit")]
public partial class EndOnlyPhsOutAudit
:IAudit{ 
public EndOnlyPhsOutAudit()
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
[Column(name:"Level3ID")]
public int? Level3ID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
