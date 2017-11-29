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
[Table("OCAPPRenewMajorsCn")]
public partial class OCAPPRenewMajorsCn
:IAuditable{ 
public OCAPPRenewMajorsCn()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Credits")]
public double? Credits {get; set;}
[Column(name:"GPA")]
public double? GPA {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"MajorID")]
public int MajorID {get; set;}
[Column(name:"MajorName")]
[StringLength(50)]
public string MajorName {get; set;}
[Column(name:"OCAppEducID")]
public int? OCAppEducID {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("MajorID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("OCAppEducID")]
public virtual OCAPPAppEduc OCAPPAppEduc{get; set;}
}
[Table("OCAPPRenewMajorsCnAudit")]
public partial class OCAPPRenewMajorsCnAudit
:IAudit{ 
public OCAPPRenewMajorsCnAudit()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Credits")]
public double? Credits {get; set;}
[Column(name:"GPA")]
public double? GPA {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"MajorID")]
public int MajorID {get; set;}
[Column(name:"MajorName")]
[StringLength(50)]
public string MajorName {get; set;}
[Column(name:"OCAppEducID")]
public int? OCAppEducID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
