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
[Table("GradCRSS")]
public partial class GradCRSS
:IAuditable{ 
public GradCRSS()
{
this.GradSCSSs = new HashSet<GradSCSS>();
}
[Required]
[Column(name:"Comments")]
[StringLength(255)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"GradCatCode")]
[StringLength(10)]
public string GradCatCode {get; set;}
[Required]
[Column(name:"GradCatDesc")]
[StringLength(255)]
public string GradCatDesc {get; set;}
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
public virtual ICollection<GradSCSS> GradSCSSs{get; set;}
}
[Table("GradCRSSAudit")]
public partial class GradCRSSAudit
:IAudit{ 
public GradCRSSAudit()
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
[Required]
[Column(name:"GradCatCode")]
[StringLength(10)]
public string GradCatCode {get; set;}
[Required]
[Column(name:"GradCatDesc")]
[StringLength(255)]
public string GradCatDesc {get; set;}
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
