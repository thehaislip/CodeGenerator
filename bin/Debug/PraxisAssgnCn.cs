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
[Table("PraxisAssgnCn")]
public partial class PraxisAssgnCn
:IAuditable{ 
public PraxisAssgnCn()
{
}
[Required]
[Column(name:"AlreadyTakenPraxis")]
[StringLength(1)]
public string AlreadyTakenPraxis {get; set;}
[Column(name:"AssgnID")]
public int? AssgnID {get; set;}
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
[Column(name:"LapsedCert")]
[StringLength(1)]
public string LapsedCert {get; set;}
[Column(name:"PraxisID")]
public int? PraxisID {get; set;}
[Required]
[Column(name:"PubNonPub")]
[StringLength(1)]
public string PubNonPub {get; set;}
[Required]
[Column(name:"PursueCert")]
[StringLength(1)]
public string PursueCert {get; set;}
[Required]
[Column(name:"RegOrSped")]
[StringLength(1)]
public string RegOrSped {get; set;}
[Column(name:"Req2ndTest")]
public int? Req2ndTest {get; set;}
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
[Column(name:"Retire")]
[StringLength(1)]
public string Retire {get; set;}
[Required]
[Column(name:"TempHire")]
[StringLength(1)]
public string TempHire {get; set;}
[Required]
[Column(name:"ThreeYearsExp")]
[StringLength(1)]
public string ThreeYearsExp {get; set;}
[Required]
[Column(name:"ValidCoursework")]
[StringLength(1)]
public string ValidCoursework {get; set;}
[Column(name:"WillTakePraxis")]
[StringLength(1)]
public string WillTakePraxis {get; set;}
[Required]
[Column(name:"WorkExp")]
[StringLength(1)]
public string WorkExp {get; set;}
[ForeignKey("AssgnID")]
public virtual Assignment Assignment{get; set;}
[ForeignKey("PraxisID")]
public virtual StateTest StateTest{get; set;}
}
[Table("PraxisAssgnCnAudit")]
public partial class PraxisAssgnCnAudit
:IAudit{ 
public PraxisAssgnCnAudit()
{
}
[Required]
[Column(name:"AlreadyTakenPraxis")]
[StringLength(1)]
public string AlreadyTakenPraxis {get; set;}
[Column(name:"AssgnID")]
public int? AssgnID {get; set;}
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
[Column(name:"LapsedCert")]
[StringLength(1)]
public string LapsedCert {get; set;}
[Column(name:"PraxisID")]
public int? PraxisID {get; set;}
[Required]
[Column(name:"PubNonPub")]
[StringLength(1)]
public string PubNonPub {get; set;}
[Required]
[Column(name:"PursueCert")]
[StringLength(1)]
public string PursueCert {get; set;}
[Required]
[Column(name:"RegOrSped")]
[StringLength(1)]
public string RegOrSped {get; set;}
[Column(name:"Req2ndTest")]
public int? Req2ndTest {get; set;}
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
[Column(name:"Retire")]
[StringLength(1)]
public string Retire {get; set;}
[Required]
[Column(name:"TempHire")]
[StringLength(1)]
public string TempHire {get; set;}
[Required]
[Column(name:"ThreeYearsExp")]
[StringLength(1)]
public string ThreeYearsExp {get; set;}
[Required]
[Column(name:"ValidCoursework")]
[StringLength(1)]
public string ValidCoursework {get; set;}
[Column(name:"WillTakePraxis")]
[StringLength(1)]
public string WillTakePraxis {get; set;}
[Required]
[Column(name:"WorkExp")]
[StringLength(1)]
public string WorkExp {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
