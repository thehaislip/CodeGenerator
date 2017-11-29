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
[Table("SpEdIndAssgn")]
public partial class SpEdIndAssgn
:IAuditable{ 
public SpEdIndAssgn()
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
[Column(name:"PRFAssgnID")]
public int? PRFAssgnID {get; set;}
[Column(name:"PRFAssgnTypeID")]
public int? PRFAssgnTypeID {get; set;}
[Required]
[Column(name:"SpedAssgn")]
[StringLength(1)]
public string SpedAssgn {get; set;}
[ForeignKey("PRFAssgnID")]
public virtual PRFAssgn PRFAssgn{get; set;}
[ForeignKey("PRFAssgnTypeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("SpEdIndAssgnAudit")]
public partial class SpEdIndAssgnAudit
:IAudit{ 
public SpEdIndAssgnAudit()
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
[Column(name:"PRFAssgnID")]
public int? PRFAssgnID {get; set;}
[Column(name:"PRFAssgnTypeID")]
public int? PRFAssgnTypeID {get; set;}
[Required]
[Column(name:"SpedAssgn")]
[StringLength(1)]
public string SpedAssgn {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
