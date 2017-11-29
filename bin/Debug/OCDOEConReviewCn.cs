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
[Table("OCDOEConReviewCn")]
public partial class OCDOEConReviewCn
:IAuditable{ 
public OCDOEConReviewCn()
{
}
[Required]
[Column(name:"Answer")]
[StringLength(1)]
public string Answer {get; set;}
[Required]
[Column(name:"ApplicationID")]
public int ApplicationID {get; set;}
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"ConductReviewQuestionID")]
public int ConductReviewQuestionID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("ApplicationID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("ConductReviewQuestionID")]
public virtual OCAPPConReviewSup OCAPPConReviewSup{get; set;}
}
[Table("OCDOEConReviewCnAudit")]
public partial class OCDOEConReviewCnAudit
:IAudit{ 
public OCDOEConReviewCnAudit()
{
}
[Required]
[Column(name:"Answer")]
[StringLength(1)]
public string Answer {get; set;}
[Required]
[Column(name:"ApplicationID")]
public int ApplicationID {get; set;}
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"ConductReviewQuestionID")]
public int ConductReviewQuestionID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
