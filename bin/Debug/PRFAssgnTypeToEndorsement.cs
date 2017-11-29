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
[Table("PRFAssgnTypeToEndorsement")]
public partial class PRFAssgnTypeToEndorsement
:IAuditable{ 
public PRFAssgnTypeToEndorsement()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"EndorsementID")]
public int EndorsementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PRFAssgnTypeID")]
public int PRFAssgnTypeID {get; set;}
[ForeignKey("EndorsementID")]
public virtual Endorsement Endorsement{get; set;}
[ForeignKey("PRFAssgnTypeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("PRFAssgnTypeToEndorsementAudit")]
public partial class PRFAssgnTypeToEndorsementAudit
:IAudit{ 
public PRFAssgnTypeToEndorsementAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"EndorsementID")]
public int EndorsementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PRFAssgnTypeID")]
public int PRFAssgnTypeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
