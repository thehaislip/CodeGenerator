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
[Table("Answer")]
public partial class Answer
:IAuditable{ 
public Answer()
{
this.AnswerToCommlookups = new HashSet<AnswerToCommlookup>();
}
[Column(name:"AnswerText")]
[StringLength(5000)]
public string AnswerText {get; set;}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Column(name:"AttendanceCenterID")]
public int? AttendanceCenterID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"QuestionID")]
public int QuestionID {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("AttendanceCenterID")]
public virtual AttCtrSS AttCtrSS{get; set;}
[ForeignKey("DistrictID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("AnswerID")]
public virtual ICollection<AnswerToCommlookup> AnswerToCommlookups{get; set;}
[ForeignKey("QuestionID")]
public virtual Question Question{get; set;}
}
[Table("AnswerAudit")]
public partial class AnswerAudit
:IAudit{ 
public AnswerAudit()
{
}
[Column(name:"AnswerText")]
[StringLength(5000)]
public string AnswerText {get; set;}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Column(name:"AttendanceCenterID")]
public int? AttendanceCenterID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"QuestionID")]
public int QuestionID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
