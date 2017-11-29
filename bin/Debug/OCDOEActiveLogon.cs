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
[Table("OCDOEActiveLogon")]
public partial class OCDOEActiveLogon
:IAuditable{ 
public OCDOEActiveLogon()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"LastRequest",TypeName = "datetime2")]
public DateTime? LastRequest {get; set;}
[Column(name:"Logon")]
[StringLength(20)]
public string Logon {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
}
[Table("OCDOEActiveLogonAudit")]
public partial class OCDOEActiveLogonAudit
:IAudit{ 
public OCDOEActiveLogonAudit()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"LastRequest",TypeName = "datetime2")]
public DateTime? LastRequest {get; set;}
[Column(name:"Logon")]
[StringLength(20)]
public string Logon {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
