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
[Table("ParaStudInfo")]
public partial class ParaStudInfo
:IAuditable{ 
public ParaStudInfo()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistSSID")]
public int? DistSSID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"NotQualifiedFTE",TypeName = "money")]
public decimal? NotQualifiedFTE {get; set;}
[Column(name:"QualifiedFTE",TypeName = "money")]
public decimal? QualifiedFTE {get; set;}
[Column(name:"StudentInfoTypeID")]
public int? StudentInfoTypeID {get; set;}
[ForeignKey("DistSSID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("StudentInfoTypeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("ParaStudInfoAudit")]
public partial class ParaStudInfoAudit
:IAudit{ 
public ParaStudInfoAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistSSID")]
public int? DistSSID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"NotQualifiedFTE",TypeName = "money")]
public decimal? NotQualifiedFTE {get; set;}
[Column(name:"QualifiedFTE",TypeName = "money")]
public decimal? QualifiedFTE {get; set;}
[Column(name:"StudentInfoTypeID")]
public int? StudentInfoTypeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
