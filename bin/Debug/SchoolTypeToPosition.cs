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
[Table("SchoolTypeToPosition")]
public partial class SchoolTypeToPosition
:IAuditable{ 
public SchoolTypeToPosition()
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
[Column(name:"PositionCodeID")]
public int? PositionCodeID {get; set;}
[Column(name:"SchoolTypeID")]
public int? SchoolTypeID {get; set;}
[ForeignKey("PositionCodeID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("SchoolTypeID")]
public virtual CommLookup CommLookup1{get; set;}
}
[Table("SchoolTypeToPositionAudit")]
public partial class SchoolTypeToPositionAudit
:IAudit{ 
public SchoolTypeToPositionAudit()
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
[Column(name:"PositionCodeID")]
public int? PositionCodeID {get; set;}
[Column(name:"SchoolTypeID")]
public int? SchoolTypeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
