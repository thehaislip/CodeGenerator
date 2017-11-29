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
[Table("OCUCOComments")]
public partial class OCUCOComments
:IAuditable{ 
public OCUCOComments()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Required]
[Column(name:"Comment")]
[StringLength(4000)]
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
[Column(name:"UCOProfileID")]
public int? UCOProfileID {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("UCOProfileID")]
public virtual OCUCOProfile OCUCOProfile{get; set;}
}
[Table("OCUCOCommentsAudit")]
public partial class OCUCOCommentsAudit
:IAudit{ 
public OCUCOCommentsAudit()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Required]
[Column(name:"Comment")]
[StringLength(4000)]
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
[Column(name:"UCOProfileID")]
public int? UCOProfileID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
