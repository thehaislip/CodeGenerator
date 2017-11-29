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
[Table("GradOpts")]
public partial class GradOpts
:IAuditable{ 
public GradOpts()
{
this.GradUnits = new HashSet<GradUnit>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"OptAction")]
[StringLength(2)]
public string OptAction {get; set;}
[Required]
[Column(name:"OptCode")]
[StringLength(5)]
public string OptCode {get; set;}
[Required]
[Column(name:"OptDesc")]
[StringLength(80)]
public string OptDesc {get; set;}
[ForeignKey("OptionID")]
public virtual ICollection<GradUnit> GradUnits{get; set;}
}
[Table("GradOptsAudit")]
public partial class GradOptsAudit
:IAudit{ 
public GradOptsAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"OptAction")]
[StringLength(2)]
public string OptAction {get; set;}
[Required]
[Column(name:"OptCode")]
[StringLength(5)]
public string OptCode {get; set;}
[Required]
[Column(name:"OptDesc")]
[StringLength(80)]
public string OptDesc {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
