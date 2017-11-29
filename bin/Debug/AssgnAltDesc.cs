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
[Table("AssgnAltDesc")]
public partial class AssgnAltDesc
:IAuditable{ 
public AssgnAltDesc()
{
}
[Required]
[Column(name:"AltDescription")]
[StringLength(300)]
public string AltDescription {get; set;}
[Column(name:"CommLookupID")]
public int? CommLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
}
[Table("AssgnAltDescAudit")]
public partial class AssgnAltDescAudit
:IAudit{ 
public AssgnAltDescAudit()
{
}
[Required]
[Column(name:"AltDescription")]
[StringLength(300)]
public string AltDescription {get; set;}
[Column(name:"CommLookupID")]
public int? CommLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
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
