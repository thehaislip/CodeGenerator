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
[Table("OCAPPSubjAssgnCn")]
public partial class OCAPPSubjAssgnCn
:IAuditable{ 
public OCAPPSubjAssgnCn()
{
}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Required]
[Column(name:"COMMLookupID")]
public int COMMLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("COMMLookupID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("OCAPPSubjAssgnCnAudit")]
public partial class OCAPPSubjAssgnCnAudit
:IAudit{ 
public OCAPPSubjAssgnCnAudit()
{
}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Required]
[Column(name:"COMMLookupID")]
public int COMMLookupID {get; set;}
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
