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
[Table("OCDOECertSSDetail")]
public partial class OCDOECertSSDetail
:IAuditable{ 
public OCDOECertSSDetail()
{
}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"CodeID")]
public int? CodeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Column(name:"ExpirationDate")]
public DateTime? ExpirationDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LevelID")]
public int LevelID {get; set;}
[Required]
[Column(name:"SnapshotID")]
public int SnapshotID {get; set;}
[ForeignKey("SnapshotID")]
public virtual OCDOECertSnapshot OCDOECertSnapshot{get; set;}
}
[Table("OCDOECertSSDetailAudit")]
public partial class OCDOECertSSDetailAudit
:IAudit{ 
public OCDOECertSSDetailAudit()
{
}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"CodeID")]
public int? CodeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Column(name:"ExpirationDate")]
public DateTime? ExpirationDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LevelID")]
public int LevelID {get; set;}
[Required]
[Column(name:"SnapshotID")]
public int SnapshotID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
