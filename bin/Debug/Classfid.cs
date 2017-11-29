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
[Table("Classfid")]
public partial class Classfid
:IAuditable{ 
public Classfid()
{
}
[Column(name:"ClassCodeID")]
public int? ClassCodeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictSnapshotID")]
public int? DistrictSnapshotID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"TotalReportedNumber",TypeName = "money")]
public decimal? TotalReportedNumber {get; set;}
[ForeignKey("ClassCodeID")]
public virtual ClasCode ClasCode{get; set;}
[ForeignKey("DistrictSnapshotID")]
public virtual DistSS DistSS{get; set;}
}
[Table("ClassfidAudit")]
public partial class ClassfidAudit
:IAudit{ 
public ClassfidAudit()
{
}
[Column(name:"ClassCodeID")]
public int? ClassCodeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictSnapshotID")]
public int? DistrictSnapshotID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"TotalReportedNumber",TypeName = "money")]
public decimal? TotalReportedNumber {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
