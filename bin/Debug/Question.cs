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
[Table("Question")]
public partial class Question
:IAuditable{ 
public Question()
{
this.Answers = new HashSet<Answer>();
this.QuestionAnswerToTriggers = new HashSet<QuestionAnswerToTrigger>();
this.SectionToQuestions = new HashSet<SectionToQuestion>();
}
[Column(name:"CommLookupTypeID")]
public int? CommLookupTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Column(name:"DisabledInd")]
public bool? DisabledInd {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"QuestionText")]
[StringLength(2000)]
public string QuestionText {get; set;}
[Column(name:"Title")]
[StringLength(500)]
public string Title {get; set;}
[Column(name:"Type")]
[StringLength(250)]
public string Type {get; set;}
[ForeignKey("CommLookupTypeID")]
public virtual CommLookupType CommLookupType{get; set;}
[ForeignKey("QuestionID")]
public virtual ICollection<Answer> Answers{get; set;}
[ForeignKey("QuestionId")]
public virtual ICollection<QuestionAnswerToTrigger> QuestionAnswerToTriggers{get; set;}
[ForeignKey("QuestionID")]
public virtual ICollection<SectionToQuestion> SectionToQuestions{get; set;}
}
[Table("QuestionAudit")]
public partial class QuestionAudit
:IAudit{ 
public QuestionAudit()
{
}
[Column(name:"CommLookupTypeID")]
public int? CommLookupTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Column(name:"DisabledInd")]
public bool? DisabledInd {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"QuestionText")]
[StringLength(2000)]
public string QuestionText {get; set;}
[Column(name:"Title")]
[StringLength(500)]
public string Title {get; set;}
[Column(name:"Type")]
[StringLength(250)]
public string Type {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
