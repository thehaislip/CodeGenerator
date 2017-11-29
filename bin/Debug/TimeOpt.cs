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
[Table("TimeOpt")]
public partial class TimeOpt
:IAuditable{ 
public TimeOpt()
{
}
[Column(name:"AttendanceCenterID")]
public int? AttendanceCenterID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"TimeOption")]
[StringLength(2)]
public string TimeOption {get; set;}
[Column(name:"TotalWeeklyMinutes")]
public int? TotalWeeklyMinutes {get; set;}
[ForeignKey("AttendanceCenterID")]
public virtual AttCtrSS AttCtrSS{get; set;}
}
[Table("TimeOptAudit")]
public partial class TimeOptAudit
:IAudit{ 
public TimeOptAudit()
{
}
[Column(name:"AttendanceCenterID")]
public int? AttendanceCenterID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"TimeOption")]
[StringLength(2)]
public string TimeOption {get; set;}
[Column(name:"TotalWeeklyMinutes")]
public int? TotalWeeklyMinutes {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
