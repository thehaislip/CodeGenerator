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
[Table("PRFImportLog")]
public partial class PRFImportLog
:IAuditable{ 
public PRFImportLog()
{
this.PRFImportHolds = new HashSet<PRFImportHold>();
}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Column(name:"ErrorRecords")]
public int? ErrorRecords {get; set;}
[Column(name:"FileName")]
[StringLength(500)]
public string FileName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ImportDateTime")]
public DateTime? ImportDateTime {get; set;}
[Column(name:"RecordsImported")]
public int? RecordsImported {get; set;}
[Column(name:"RecordsUploaded")]
public int? RecordsUploaded {get; set;}
[Column(name:"StampUser")]
[StringLength(15)]
public string StampUser {get; set;}
[Column(name:"UploadDateTime")]
public DateTime? UploadDateTime {get; set;}
[ForeignKey("PRFImportLogID")]
public virtual ICollection<PRFImportHold> PRFImportHolds{get; set;}
}
[Table("PRFImportLogAudit")]
public partial class PRFImportLogAudit
:IAudit{ 
public PRFImportLogAudit()
{
}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Column(name:"ErrorRecords")]
public int? ErrorRecords {get; set;}
[Column(name:"FileName")]
[StringLength(500)]
public string FileName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ImportDateTime")]
public DateTime? ImportDateTime {get; set;}
[Column(name:"RecordsImported")]
public int? RecordsImported {get; set;}
[Column(name:"RecordsUploaded")]
public int? RecordsUploaded {get; set;}
[Column(name:"StampUser")]
[StringLength(15)]
public string StampUser {get; set;}
[Column(name:"UploadDateTime")]
public DateTime? UploadDateTime {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
}
}
