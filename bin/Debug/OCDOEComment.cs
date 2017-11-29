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
[Table("OCDOEComment")]
public partial class OCDOEComment
:IAuditable{ 
public OCDOEComment()
{
}
[Required]
[Column(name:"AddedByLogon")]
[StringLength(20)]
public string AddedByLogon {get; set;}
[Required]
[Column(name:"AddedByName")]
[StringLength(60)]
public string AddedByName {get; set;}
[Required]
[Column(name:"Comment")]
[StringLength(7500)]
public string Comment {get; set;}
[Column(name:"CommentDate",TypeName = "datetime2")]
public DateTime? CommentDate {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"Restricted")]
public bool? Restricted {get; set;}
[Required]
[Column(name:"SectionCode")]
[StringLength(2)]
public string SectionCode {get; set;}
[ForeignKey("PersonnelID")]
public virtual COMMPerson COMMPerson{get; set;}
}
[Table("OCDOECommentAudit")]
public partial class OCDOECommentAudit
:IAudit{ 
public OCDOECommentAudit()
{
}
[Required]
[Column(name:"AddedByLogon")]
[StringLength(20)]
public string AddedByLogon {get; set;}
[Required]
[Column(name:"AddedByName")]
[StringLength(60)]
public string AddedByName {get; set;}
[Required]
[Column(name:"Comment")]
[StringLength(7500)]
public string Comment {get; set;}
[Column(name:"CommentDate",TypeName = "datetime2")]
public DateTime? CommentDate {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"Restricted")]
public bool? Restricted {get; set;}
[Required]
[Column(name:"SectionCode")]
[StringLength(2)]
public string SectionCode {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
