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
[Table("OCAPPUploadChoice")]
public partial class OCAPPUploadChoice
:IAuditable{ 
public OCAPPUploadChoice()
{
this.OCAPPUploadFiles = new HashSet<OCAPPUploadFile>();
}
[Required]
[Column(name:"appID")]
public int AppID {get; set;}
[Required]
[Column(name:"choice")]
public int Choice {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ObjectID")]
public int? ObjectID {get; set;}
[Column(name:"ObjectName")]
[StringLength(100)]
public string ObjectName {get; set;}
[Required]
[Column(name:"type")]
public int Type {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("ChoiceID")]
public virtual ICollection<OCAPPUploadFile> OCAPPUploadFiles{get; set;}
}
[Table("OCAPPUploadChoiceAudit")]
public partial class OCAPPUploadChoiceAudit
:IAudit{ 
public OCAPPUploadChoiceAudit()
{
}
[Required]
[Column(name:"appID")]
public int AppID {get; set;}
[Required]
[Column(name:"choice")]
public int Choice {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ObjectID")]
public int? ObjectID {get; set;}
[Column(name:"ObjectName")]
[StringLength(100)]
public string ObjectName {get; set;}
[Required]
[Column(name:"type")]
public int Type {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
