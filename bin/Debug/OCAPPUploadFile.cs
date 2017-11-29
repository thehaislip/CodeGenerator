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
[Table("OCAPPUploadFile")]
public partial class OCAPPUploadFile
:IAuditable{ 
public OCAPPUploadFile()
{
}
[Required]
[Column(name:"ChoiceID")]
public int ChoiceID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"ContentType")]
[StringLength(50)]
public string ContentType {get; set;}
[Required]
[Column(name:"Extension")]
[StringLength(5)]
public string Extension {get; set;}
[Column(name:"FileDirectorID")]
[StringLength(100)]
public string FileDirectorID {get; set;}
[Required]
[Column(name:"FileName")]
[StringLength(255)]
public string FileName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InFileDirecotr")]
public bool? InFileDirecotr {get; set;}
[Column(name:"UploadDate",TypeName = "datetime2")]
public DateTime? UploadDate {get; set;}
[Column(name:"UploadedFile")]
public byte[] UploadedFile {get; set;}
[ForeignKey("ChoiceID")]
public virtual OCAPPUploadChoice OCAPPUploadChoice{get; set;}
}
[Table("OCAPPUploadFileAudit")]
public partial class OCAPPUploadFileAudit
:IAudit{ 
public OCAPPUploadFileAudit()
{
}
[Required]
[Column(name:"ChoiceID")]
public int ChoiceID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"ContentType")]
[StringLength(50)]
public string ContentType {get; set;}
[Required]
[Column(name:"Extension")]
[StringLength(5)]
public string Extension {get; set;}
[Column(name:"FileDirectorID")]
[StringLength(100)]
public string FileDirectorID {get; set;}
[Required]
[Column(name:"FileName")]
[StringLength(255)]
public string FileName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InFileDirecotr")]
public bool? InFileDirecotr {get; set;}
[Column(name:"UploadDate",TypeName = "datetime2")]
public DateTime? UploadDate {get; set;}
[Column(name:"UploadedFile")]
public byte[] UploadedFile {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
