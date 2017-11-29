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
[Table("CSEClass")]
public partial class CSEClass
:IAuditable{ 
public CSEClass()
{
this.CSEPrvds = new HashSet<CSEPrvd>();
}
[Column(name:"AttnCtrID")]
public int? AttnCtrID {get; set;}
[Column(name:"ClassCodeID")]
public int? ClassCodeID {get; set;}
[Column(name:"ClassFldFTE",TypeName = "money")]
public decimal? ClassFldFTE {get; set;}
[Column(name:"ClassFTE3to5",TypeName = "money")]
public decimal? ClassFTE3to5 {get; set;}
[Column(name:"ClassFTE6to21",TypeName = "money")]
public decimal? ClassFTE6to21 {get; set;}
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
[ForeignKey("ClassCodeID")]
public virtual ClasCode ClasCode{get; set;}
[ForeignKey("DistID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("CSEClassID")]
public virtual ICollection<CSEPrvd> CSEPrvds{get; set;}
}
[Table("CSEClassAudit")]
public partial class CSEClassAudit
:IAudit{ 
public CSEClassAudit()
{
}
[Column(name:"AttnCtrID")]
public int? AttnCtrID {get; set;}
[Column(name:"ClassCodeID")]
public int? ClassCodeID {get; set;}
[Column(name:"ClassFldFTE",TypeName = "money")]
public decimal? ClassFldFTE {get; set;}
[Column(name:"ClassFTE3to5",TypeName = "money")]
public decimal? ClassFTE3to5 {get; set;}
[Column(name:"ClassFTE6to21",TypeName = "money")]
public decimal? ClassFTE6to21 {get; set;}
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
