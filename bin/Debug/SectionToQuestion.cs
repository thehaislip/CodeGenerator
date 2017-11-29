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
[Table("SectionToQuestion")]
public partial class SectionToQuestion
:IAuditable{ 
public SectionToQuestion()
{
}
[Column(name:"ApplicationTypeToSectionID")]
public int? ApplicationTypeToSectionID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"QuestionID")]
public int? QuestionID {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[ForeignKey("ApplicationTypeToSectionID")]
public virtual ApplicationTypeToSection ApplicationTypeToSection{get; set;}
[ForeignKey("QuestionID")]
public virtual Question Question{get; set;}
}
[Table("SectionToQuestionAudit")]
public partial class SectionToQuestionAudit
:IAudit{ 
public SectionToQuestionAudit()
{
}
[Column(name:"ApplicationTypeToSectionID")]
public int? ApplicationTypeToSectionID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"QuestionID")]
public int? QuestionID {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
