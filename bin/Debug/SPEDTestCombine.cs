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
[Table("SPEDTestCombine")]
public partial class SPEDTestCombine
:IAuditable{ 
public SPEDTestCombine()
{
}
[Column(name:"AssgnID")]
public int? AssgnID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IncludeOnPOI")]
[StringLength(1)]
public string IncludeOnPOI {get; set;}
[Column(name:"StateTestID")]
public int? StateTestID {get; set;}
[ForeignKey("AssgnID")]
public virtual Assignment Assignment{get; set;}
[ForeignKey("StateTestID")]
public virtual StateTest StateTest{get; set;}
}
[Table("SPEDTestCombineAudit")]
public partial class SPEDTestCombineAudit
:IAudit{ 
public SPEDTestCombineAudit()
{
}
[Column(name:"AssgnID")]
public int? AssgnID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IncludeOnPOI")]
[StringLength(1)]
public string IncludeOnPOI {get; set;}
[Column(name:"StateTestID")]
public int? StateTestID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
