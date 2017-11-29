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
[Table("FDImportLog")]
public partial class FDImportLog
:IAuditable{ 
public FDImportLog()
{
}
[Column(name:"DocumentType")]
[StringLength(50)]
public string DocumentType {get; set;}
[Column(name:"FileName")]
[StringLength(500)]
public string FileName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"Result")]
[StringLength(500)]
public string Result {get; set;}
[Column(name:"StampDateTime",TypeName = "datetime2")]
public DateTime? StampDateTime {get; set;}
[Column(name:"StampUser")]
[StringLength(15)]
public string StampUser {get; set;}
}
[Table("FDImportLogAudit")]
public partial class FDImportLogAudit
:IAudit{ 
public FDImportLogAudit()
{
}
[Column(name:"DocumentType")]
[StringLength(50)]
public string DocumentType {get; set;}
[Column(name:"FileName")]
[StringLength(500)]
public string FileName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"Result")]
[StringLength(500)]
public string Result {get; set;}
[Column(name:"StampDateTime",TypeName = "datetime2")]
public DateTime? StampDateTime {get; set;}
[Column(name:"StampUser")]
[StringLength(15)]
public string StampUser {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
}
}
