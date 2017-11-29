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
[Table("AssurDsS")]
public partial class AssurDsS
:IAuditable{ 
public AssurDsS()
{
}
[Required]
[Column(name:"AssurName")]
[StringLength(120)]
public string AssurName {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateSigned",TypeName = "datetime2")]
public DateTime? DateSigned {get; set;}
[Column(name:"DistID")]
public int? DistID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"Signed")]
[StringLength(1)]
public string Signed {get; set;}
[Required]
[Column(name:"Title")]
[StringLength(120)]
public string Title {get; set;}
[ForeignKey("DistID")]
public virtual DistSS DistSS{get; set;}
}
[Table("AssurDsSAudit")]
public partial class AssurDsSAudit
:IAudit{ 
public AssurDsSAudit()
{
}
[Required]
[Column(name:"AssurName")]
[StringLength(120)]
public string AssurName {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateSigned",TypeName = "datetime2")]
public DateTime? DateSigned {get; set;}
[Column(name:"DistID")]
public int? DistID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"Signed")]
[StringLength(1)]
public string Signed {get; set;}
[Required]
[Column(name:"Title")]
[StringLength(120)]
public string Title {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
