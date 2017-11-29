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
[Table("OCUCOOnlineAppCC")]
public partial class OCUCOOnlineAppCC
:IAuditable{ 
public OCUCOOnlineAppCC()
{
}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"login")]
[StringLength(20)]
public string Login {get; set;}
[Required]
[Column(name:"transkey")]
[StringLength(20)]
public string Transkey {get; set;}
}
[Table("OCUCOOnlineAppCCAudit")]
public partial class OCUCOOnlineAppCCAudit
:IAudit{ 
public OCUCOOnlineAppCCAudit()
{
}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"login")]
[StringLength(20)]
public string Login {get; set;}
[Required]
[Column(name:"transkey")]
[StringLength(20)]
public string Transkey {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
