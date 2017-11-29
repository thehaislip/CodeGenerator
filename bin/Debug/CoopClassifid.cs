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
[Table("CoopClassifid")]
public partial class CoopClassifid
:IAuditable{ 
public CoopClassifid()
{
}
[Column(name:"ClassCodeID")]
public int? ClassCodeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DictrictReceivingServicesID")]
public int? DictrictReceivingServicesID {get; set;}
[Column(name:"DistSSID")]
public int? DistSSID {get; set;}
[Required]
[Column(name:"FTE",TypeName = "money")]
public decimal FTE {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("ClassCodeID")]
public virtual ClasCode ClasCode{get; set;}
[ForeignKey("DictrictReceivingServicesID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("DistSSID")]
public virtual DistSS DistSS1{get; set;}
}
[Table("CoopClassifidAudit")]
public partial class CoopClassifidAudit
:IAudit{ 
public CoopClassifidAudit()
{
}
[Column(name:"ClassCodeID")]
public int? ClassCodeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DictrictReceivingServicesID")]
public int? DictrictReceivingServicesID {get; set;}
[Column(name:"DistSSID")]
public int? DistSSID {get; set;}
[Required]
[Column(name:"FTE",TypeName = "money")]
public decimal FTE {get; set;}
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
