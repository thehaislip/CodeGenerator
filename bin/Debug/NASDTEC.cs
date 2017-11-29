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
[Table("NASDTEC")]
public partial class NASDTEC
:IAuditable{ 
public NASDTEC()
{
}
[Column(name:"Birthdate",TypeName = "datetime2")]
public DateTime? Birthdate {get; set;}
[Required]
[Column(name:"corrIndicator")]
[StringLength(5)]
public string CorrIndicator {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(100)]
public string FirstName {get; set;}
[Required]
[Column(name:"Id")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(40)]
public string LastName {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[Required]
[Column(name:"state")]
[StringLength(2)]
public string State {get; set;}
}
[Table("NASDTECAudit")]
public partial class NASDTECAudit
:IAudit{ 
public NASDTECAudit()
{
}
[Column(name:"Birthdate",TypeName = "datetime2")]
public DateTime? Birthdate {get; set;}
[Required]
[Column(name:"corrIndicator")]
[StringLength(5)]
public string CorrIndicator {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(100)]
public string FirstName {get; set;}
[Required]
[Column(name:"Id")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(40)]
public string LastName {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[Required]
[Column(name:"state")]
[StringLength(2)]
public string State {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
