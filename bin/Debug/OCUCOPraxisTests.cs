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
[Table("OCUCOPraxisTests")]
public partial class OCUCOPraxisTests
:IAuditable{ 
public OCUCOPraxisTests()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateTaken",TypeName = "datetime2")]
public DateTime? DateTaken {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"Score")]
[StringLength(10)]
public string Score {get; set;}
[Column(name:"StateTestID")]
public int? StateTestID {get; set;}
[Column(name:"UCOProfileID")]
public int? UCOProfileID {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("StateTestID")]
public virtual StateTest StateTest{get; set;}
[ForeignKey("UCOProfileID")]
public virtual OCUCOProfile OCUCOProfile{get; set;}
}
[Table("OCUCOPraxisTestsAudit")]
public partial class OCUCOPraxisTestsAudit
:IAudit{ 
public OCUCOPraxisTestsAudit()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateTaken",TypeName = "datetime2")]
public DateTime? DateTaken {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"Score")]
[StringLength(10)]
public string Score {get; set;}
[Column(name:"StateTestID")]
public int? StateTestID {get; set;}
[Column(name:"UCOProfileID")]
public int? UCOProfileID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
