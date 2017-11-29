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
[Table("ParaAttn")]
public partial class ParaAttn
:IAuditable{ 
public ParaAttn()
{
}
[Column(name:"AttCenterID")]
public int? AttCenterID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(2000)]
public string Description {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"ParaRec")]
[StringLength(1)]
public string ParaRec {get; set;}
[Column(name:"PartD")]
[StringLength(1)]
public string PartD {get; set;}
[Required]
[Column(name:"SchoolWide")]
[StringLength(1)]
public string SchoolWide {get; set;}
[Required]
[Column(name:"TargeteDAst")]
[StringLength(1)]
public string TargeteDAst {get; set;}
[ForeignKey("AttCenterID")]
public virtual AttCtrSS AttCtrSS{get; set;}
}
[Table("ParaAttnAudit")]
public partial class ParaAttnAudit
:IAudit{ 
public ParaAttnAudit()
{
}
[Column(name:"AttCenterID")]
public int? AttCenterID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(2000)]
public string Description {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"ParaRec")]
[StringLength(1)]
public string ParaRec {get; set;}
[Column(name:"PartD")]
[StringLength(1)]
public string PartD {get; set;}
[Required]
[Column(name:"SchoolWide")]
[StringLength(1)]
public string SchoolWide {get; set;}
[Required]
[Column(name:"TargeteDAst")]
[StringLength(1)]
public string TargeteDAst {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
