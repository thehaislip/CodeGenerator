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
[Table("OCAPPProfPrepCn")]
public partial class OCAPPProfPrepCn
:IAuditable{ 
public OCAPPProfPrepCn()
{
}
[Column(name:"ApplicationID")]
public int? ApplicationID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ProfPrepID")]
public int? ProfPrepID {get; set;}
[ForeignKey("ApplicationID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("ProfPrepID")]
public virtual OCAPPProfPrep OCAPPProfPrep{get; set;}
}
[Table("OCAPPProfPrepCnAudit")]
public partial class OCAPPProfPrepCnAudit
:IAudit{ 
public OCAPPProfPrepCnAudit()
{
}
[Column(name:"ApplicationID")]
public int? ApplicationID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ProfPrepID")]
public int? ProfPrepID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
