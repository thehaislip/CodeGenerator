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
[Table("HQTestAssgn")]
public partial class HQTestAssgn
:IAuditable{ 
public HQTestAssgn()
{
}
[Column(name:"AssignID")]
public int? AssignID {get; set;}
[Column(name:"CheckPosition")]
[StringLength(1)]
public string CheckPosition {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PraxisTestID")]
public int? PraxisTestID {get; set;}
[ForeignKey("AssignID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("PraxisTestID")]
public virtual StateTest StateTest{get; set;}
}
[Table("HQTestAssgnAudit")]
public partial class HQTestAssgnAudit
:IAudit{ 
public HQTestAssgnAudit()
{
}
[Column(name:"AssignID")]
public int? AssignID {get; set;}
[Column(name:"CheckPosition")]
[StringLength(1)]
public string CheckPosition {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PraxisTestID")]
public int? PraxisTestID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
