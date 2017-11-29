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
[Table("RollForwardCodeMaintenance")]
public partial class RollForwardCodeMaintenance
:IAuditable{ 
public RollForwardCodeMaintenance()
{
}
[Column(name:"Disabled")]
public bool? Disabled {get; set;}
[Column(name:"EndSchoolYear")]
public int? EndSchoolYear {get; set;}
[Column(name:"NewAssingnments")]
public int? NewAssingnments {get; set;}
[Column(name:"NewCode")]
[StringLength(50)]
public string NewCode {get; set;}
[Column(name:"NewCodeID")]
public int? NewCodeID {get; set;}
[Column(name:"NewDescription")]
[StringLength(50)]
public string NewDescription {get; set;}
[Column(name:"OldCodeID")]
public int? OldCodeID {get; set;}
[Column(name:"OldDescription")]
[StringLength(50)]
public string OldDescription {get; set;}
[Column(name:"OriginalAssignments")]
public int? OriginalAssignments {get; set;}
[Column(name:"OriginalCode")]
[StringLength(50)]
public string OriginalCode {get; set;}
[Column(name:"Swap")]
public bool? Swap {get; set;}
[Column(name:"Validated")]
public bool? Validated {get; set;}
}
[Table("RollForwardCodeMaintenanceAudit")]
public partial class RollForwardCodeMaintenanceAudit
:IAudit{ 
public RollForwardCodeMaintenanceAudit()
{
}
[Column(name:"Disabled")]
public bool? Disabled {get; set;}
[Column(name:"EndSchoolYear")]
public int? EndSchoolYear {get; set;}
[Column(name:"NewAssingnments")]
public int? NewAssingnments {get; set;}
[Column(name:"NewCode")]
[StringLength(50)]
public string NewCode {get; set;}
[Column(name:"NewCodeID")]
public int? NewCodeID {get; set;}
[Column(name:"NewDescription")]
[StringLength(50)]
public string NewDescription {get; set;}
[Column(name:"OldCodeID")]
public int? OldCodeID {get; set;}
[Column(name:"OldDescription")]
[StringLength(50)]
public string OldDescription {get; set;}
[Column(name:"OriginalAssignments")]
public int? OriginalAssignments {get; set;}
[Column(name:"OriginalCode")]
[StringLength(50)]
public string OriginalCode {get; set;}
[Column(name:"Swap")]
public bool? Swap {get; set;}
[Column(name:"Validated")]
public bool? Validated {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
