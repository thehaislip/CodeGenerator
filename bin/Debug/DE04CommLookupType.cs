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
[Table("DE04CommLookupType")]
public partial class DE04CommLookupType
:IAuditable{ 
public DE04CommLookupType()
{
}
[Required]
[Column(name:"BriefDescription")]
[StringLength(80)]
public string BriefDescription {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"KeyPrefix")]
[StringLength(10)]
public string KeyPrefix {get; set;}
[Required]
[Column(name:"Name")]
[StringLength(80)]
public string Name {get; set;}
}
[Table("DE04CommLookupTypeAudit")]
public partial class DE04CommLookupTypeAudit
:IAudit{ 
public DE04CommLookupTypeAudit()
{
}
[Required]
[Column(name:"BriefDescription")]
[StringLength(80)]
public string BriefDescription {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"KeyPrefix")]
[StringLength(10)]
public string KeyPrefix {get; set;}
[Required]
[Column(name:"Name")]
[StringLength(80)]
public string Name {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
