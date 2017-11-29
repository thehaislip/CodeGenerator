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
[Table("OCDOESectionComp")]
public partial class OCDOESectionComp
:IAuditable{ 
public OCDOESectionComp()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Required]
[Column(name:"Complete")]
[StringLength(1)]
public string Complete {get; set;}
[Required]
[Column(name:"CompletedBy")]
[StringLength(60)]
public string CompletedBy {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateComplete",TypeName = "datetime2")]
public DateTime? DateComplete {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"SectionCode")]
[StringLength(2)]
public string SectionCode {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
}
[Table("OCDOESectionCompAudit")]
public partial class OCDOESectionCompAudit
:IAudit{ 
public OCDOESectionCompAudit()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Required]
[Column(name:"Complete")]
[StringLength(1)]
public string Complete {get; set;}
[Required]
[Column(name:"CompletedBy")]
[StringLength(60)]
public string CompletedBy {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateComplete",TypeName = "datetime2")]
public DateTime? DateComplete {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"SectionCode")]
[StringLength(2)]
public string SectionCode {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
