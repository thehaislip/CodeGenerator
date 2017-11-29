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
[Table("GradSCSS")]
public partial class GradSCSS
:IAuditable{ 
public GradSCSS()
{
this.GradRASSs = new HashSet<GradRASS>();
}
[Required]
[Column(name:"Comments")]
[StringLength(255)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"GradCatCodeID")]
public int? GradCatCodeID {get; set;}
[Required]
[Column(name:"GradSubcatCode")]
[StringLength(10)]
public string GradSubcatCode {get; set;}
[Required]
[Column(name:"GradSubcatDesc")]
[StringLength(255)]
public string GradSubcatDesc {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"NumUnitsReq",TypeName = "money")]
public decimal? NumUnitsReq {get; set;}
[Required]
[Column(name:"SchoolYear")]
[StringLength(4)]
public string SchoolYear {get; set;}
[ForeignKey("GradCatCodeID")]
public virtual GradCRSS GradCRSS{get; set;}
[ForeignKey("GradSubcatID")]
public virtual ICollection<GradRASS> GradRASSs{get; set;}
}
[Table("GradSCSSAudit")]
public partial class GradSCSSAudit
:IAudit{ 
public GradSCSSAudit()
{
}
[Required]
[Column(name:"Comments")]
[StringLength(255)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"GradCatCodeID")]
public int? GradCatCodeID {get; set;}
[Required]
[Column(name:"GradSubcatCode")]
[StringLength(10)]
public string GradSubcatCode {get; set;}
[Required]
[Column(name:"GradSubcatDesc")]
[StringLength(255)]
public string GradSubcatDesc {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"NumUnitsReq",TypeName = "money")]
public decimal? NumUnitsReq {get; set;}
[Required]
[Column(name:"SchoolYear")]
[StringLength(4)]
public string SchoolYear {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
