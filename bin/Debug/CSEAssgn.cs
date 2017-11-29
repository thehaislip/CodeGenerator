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
[Table("CSEAssgn")]
public partial class CSEAssgn
:IAuditable{ 
public CSEAssgn()
{
this.CSEPrvds = new HashSet<CSEPrvd>();
}
[Column(name:"AssgnCodeID")]
public int? AssgnCodeID {get; set;}
[Column(name:"AssgnFTE",TypeName = "money")]
public decimal? AssgnFTE {get; set;}
[Column(name:"AssgnFTE3to5",TypeName = "money")]
public decimal? AssgnFTE3to5 {get; set;}
[Column(name:"AssgnFTE6to21",TypeName = "money")]
public decimal? AssgnFTE6to21 {get; set;}
[Column(name:"AttnCtrID")]
public int? AttnCtrID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistID")]
public int? DistID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("AssgnCodeID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("DistID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("CSEAssgnID")]
public virtual ICollection<CSEPrvd> CSEPrvds{get; set;}
}
[Table("CSEAssgnAudit")]
public partial class CSEAssgnAudit
:IAudit{ 
public CSEAssgnAudit()
{
}
[Column(name:"AssgnCodeID")]
public int? AssgnCodeID {get; set;}
[Column(name:"AssgnFTE",TypeName = "money")]
public decimal? AssgnFTE {get; set;}
[Column(name:"AssgnFTE3to5",TypeName = "money")]
public decimal? AssgnFTE3to5 {get; set;}
[Column(name:"AssgnFTE6to21",TypeName = "money")]
public decimal? AssgnFTE6to21 {get; set;}
[Column(name:"AttnCtrID")]
public int? AttnCtrID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistID")]
public int? DistID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
