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
[Table("DECANTLogon")]
public partial class DECANTLogon
:IAuditable{ 
public DECANTLogon()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Required]
[Column(name:"DistShortName")]
[StringLength(5)]
public string DistShortName {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"NTLogonID")]
[StringLength(10)]
public string NTLogonID {get; set;}
}
[Table("DECANTLogonAudit")]
public partial class DECANTLogonAudit
:IAudit{ 
public DECANTLogonAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Required]
[Column(name:"DistShortName")]
[StringLength(5)]
public string DistShortName {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"NTLogonID")]
[StringLength(10)]
public string NTLogonID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
