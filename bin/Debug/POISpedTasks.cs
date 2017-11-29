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
[Table("POISpedTasks")]
public partial class POISpedTasks
:IAuditable{ 
public POISpedTasks()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"POIID")]
public int? POIID {get; set;}
[Column(name:"SpedTaskID")]
public int? SpedTaskID {get; set;}
[ForeignKey("POIID")]
public virtual DistPlanIntnt DistPlanIntnt{get; set;}
[ForeignKey("SpedTaskID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("POISpedTasksAudit")]
public partial class POISpedTasksAudit
:IAudit{ 
public POISpedTasksAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"POIID")]
public int? POIID {get; set;}
[Column(name:"SpedTaskID")]
public int? SpedTaskID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
