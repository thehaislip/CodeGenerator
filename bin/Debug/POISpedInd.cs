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
[Table("POISpedInd")]
public partial class POISpedInd
:IAuditable{ 
public POISpedInd()
{
}
[Required]
[Column(name:"AlreadyTakenPraxis")]
[StringLength(1)]
public string AlreadyTakenPraxis {get; set;}
[Column(name:"AssignmentCodeID")]
public int? AssignmentCodeID {get; set;}
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
[Column(name:"PubNonPub")]
[StringLength(1)]
public string PubNonPub {get; set;}
[Required]
[Column(name:"ReqAddlAuth")]
[StringLength(1)]
public string ReqAddlAuth {get; set;}
[Required]
[Column(name:"ReqCrsworkTest")]
[StringLength(1)]
public string ReqCrsworkTest {get; set;}
[Required]
[Column(name:"ReqPraxisAndDegree")]
[StringLength(1)]
public string ReqPraxisAndDegree {get; set;}
[Required]
[Column(name:"ReqPraxisAndSpedCrswrk")]
[StringLength(1)]
public string ReqPraxisAndSpedCrswrk {get; set;}
[Required]
[Column(name:"ReqPraxisAndSpedDegree")]
[StringLength(1)]
public string ReqPraxisAndSpedDegree {get; set;}
[Required]
[Column(name:"ThreeYearsExp")]
[StringLength(1)]
public string ThreeYearsExp {get; set;}
[Required]
[Column(name:"ValidCoursework")]
[StringLength(1)]
public string ValidCoursework {get; set;}
[Required]
[Column(name:"WillTakePraxis")]
[StringLength(1)]
public string WillTakePraxis {get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual Assignment Assignment{get; set;}
}
[Table("POISpedIndAudit")]
public partial class POISpedIndAudit
:IAudit{ 
public POISpedIndAudit()
{
}
[Required]
[Column(name:"AlreadyTakenPraxis")]
[StringLength(1)]
public string AlreadyTakenPraxis {get; set;}
[Column(name:"AssignmentCodeID")]
public int? AssignmentCodeID {get; set;}
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
[Column(name:"PubNonPub")]
[StringLength(1)]
public string PubNonPub {get; set;}
[Required]
[Column(name:"ReqAddlAuth")]
[StringLength(1)]
public string ReqAddlAuth {get; set;}
[Required]
[Column(name:"ReqCrsworkTest")]
[StringLength(1)]
public string ReqCrsworkTest {get; set;}
[Required]
[Column(name:"ReqPraxisAndDegree")]
[StringLength(1)]
public string ReqPraxisAndDegree {get; set;}
[Required]
[Column(name:"ReqPraxisAndSpedCrswrk")]
[StringLength(1)]
public string ReqPraxisAndSpedCrswrk {get; set;}
[Required]
[Column(name:"ReqPraxisAndSpedDegree")]
[StringLength(1)]
public string ReqPraxisAndSpedDegree {get; set;}
[Required]
[Column(name:"ThreeYearsExp")]
[StringLength(1)]
public string ThreeYearsExp {get; set;}
[Required]
[Column(name:"ValidCoursework")]
[StringLength(1)]
public string ValidCoursework {get; set;}
[Required]
[Column(name:"WillTakePraxis")]
[StringLength(1)]
public string WillTakePraxis {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
