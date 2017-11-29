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
[Table("OtherAct")]
public partial class OtherAct
:IAuditable{ 
public OtherAct()
{
}
[Required]
[Column(name:"ActivityDescr")]
[StringLength(300)]
public string ActivityDescr {get; set;}
[Column(name:"ActivityID")]
public int? ActivityID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PRFAssgnID")]
public int? PRFAssgnID {get; set;}
[ForeignKey("PRFAssgnID")]
public virtual PRFAssgn PRFAssgn{get; set;}
}
[Table("OtherActAudit")]
public partial class OtherActAudit
:IAudit{ 
public OtherActAudit()
{
}
[Required]
[Column(name:"ActivityDescr")]
[StringLength(300)]
public string ActivityDescr {get; set;}
[Column(name:"ActivityID")]
public int? ActivityID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PRFAssgnID")]
public int? PRFAssgnID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
