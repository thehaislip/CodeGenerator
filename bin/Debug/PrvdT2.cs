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
[Table("PrvdT2")]
public partial class PrvdT2
:IAuditable{ 
public PrvdT2()
{
this.CSEPrvds = new HashSet<CSEPrvd>();
}
[Required]
[Column(name:"Code")]
[StringLength(5)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDdisabled",TypeName = "datetime2")]
public DateTime? DateDdisabled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("ProviderID")]
public virtual ICollection<CSEPrvd> CSEPrvds{get; set;}
}
[Table("PrvdT2Audit")]
public partial class PrvdT2Audit
:IAudit{ 
public PrvdT2Audit()
{
}
[Required]
[Column(name:"Code")]
[StringLength(5)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDdisabled",TypeName = "datetime2")]
public DateTime? DateDdisabled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
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
