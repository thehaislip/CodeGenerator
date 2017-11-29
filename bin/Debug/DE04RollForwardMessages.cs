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
[Table("DE04RollForwardMessages")]
public partial class DE04RollForwardMessages
:IAuditable{ 
public DE04RollForwardMessages()
{
}
[Column(name:"Message")]
[StringLength(500)]
public string Message {get; set;}
[Column(name:"MessageDate")]
public DateTime? MessageDate {get; set;}
[Column(name:"ProcedureName")]
[StringLength(255)]
public string ProcedureName {get; set;}
[Column(name:"RecordInformation")]
[StringLength(2000)]
public string RecordInformation {get; set;}
}
[Table("DE04RollForwardMessagesAudit")]
public partial class DE04RollForwardMessagesAudit
:IAudit{ 
public DE04RollForwardMessagesAudit()
{
}
[Column(name:"Message")]
[StringLength(500)]
public string Message {get; set;}
[Column(name:"MessageDate")]
public DateTime? MessageDate {get; set;}
[Column(name:"ProcedureName")]
[StringLength(255)]
public string ProcedureName {get; set;}
[Column(name:"RecordInformation")]
[StringLength(2000)]
public string RecordInformation {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
