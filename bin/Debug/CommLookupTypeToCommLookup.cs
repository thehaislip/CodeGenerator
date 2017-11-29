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
[Table("CommLookupTypeToCommLookup")]
public partial class CommLookupTypeToCommLookup
:IAuditable{ 
public CommLookupTypeToCommLookup()
{
}
[Required]
[Column(name:"CommLookupID")]
public int CommLookupID {get; set;}
[Required]
[Column(name:"CommLookupTypeID")]
public int CommLookupTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("CommLookupID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("CommLookupTypeID")]
public virtual CommLookupType CommLookupType{get; set;}
}
[Table("CommLookupTypeToCommLookupAudit")]
public partial class CommLookupTypeToCommLookupAudit
:IAudit{ 
public CommLookupTypeToCommLookupAudit()
{
}
[Required]
[Column(name:"CommLookupID")]
public int CommLookupID {get; set;}
[Required]
[Column(name:"CommLookupTypeID")]
public int CommLookupTypeID {get; set;}
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
