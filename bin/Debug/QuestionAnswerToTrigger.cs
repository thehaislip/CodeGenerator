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
[Table("QuestionAnswerToTrigger")]
public partial class QuestionAnswerToTrigger
:IAuditable{ 
public QuestionAnswerToTrigger()
{
}
[Required]
[Column(name:"CommLookupID")]
public int CommLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Message")]
[StringLength(8000)]
public string Message {get; set;}
[Required]
[Column(name:"QuestionId")]
public int QuestionId {get; set;}
[Required]
[Column(name:"TriggerID")]
public int TriggerID {get; set;}
[Column(name:"UploadTypeID")]
public int? UploadTypeID {get; set;}
[ForeignKey("CommLookupID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("QuestionId")]
public virtual Question Question{get; set;}
[ForeignKey("TriggerID")]
public virtual Trigger Trigger{get; set;}
[ForeignKey("UploadTypeID")]
public virtual CommLookup CommLookup1{get; set;}
}
[Table("QuestionAnswerToTriggerAudit")]
public partial class QuestionAnswerToTriggerAudit
:IAudit{ 
public QuestionAnswerToTriggerAudit()
{
}
[Required]
[Column(name:"CommLookupID")]
public int CommLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Message")]
[StringLength(8000)]
public string Message {get; set;}
[Required]
[Column(name:"QuestionId")]
public int QuestionId {get; set;}
[Required]
[Column(name:"TriggerID")]
public int TriggerID {get; set;}
[Column(name:"UploadTypeID")]
public int? UploadTypeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
