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
[Table("IndivTst")]
public partial class IndivTst
:IAuditable{ 
public IndivTst()
{
}
[Required]
[Column(name:"Comments")]
[StringLength(200)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateTaken",TypeName = "datetime2")]
public DateTime? DateTaken {get; set;}
[Column(name:"GradClassID")]
public int? GradClassID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InsertedBy")]
[StringLength(80)]
public string InsertedBy {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Required]
[Column(name:"Score")]
[StringLength(10)]
public string Score {get; set;}
[Column(name:"StateID")]
public int? StateID {get; set;}
[Column(name:"StateTestID")]
public int? StateTestID {get; set;}
[ForeignKey("StateID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("StateTestID")]
public virtual StateTest StateTest{get; set;}
}
[Table("IndivTstAudit")]
public partial class IndivTstAudit
:IAudit{ 
public IndivTstAudit()
{
}
[Required]
[Column(name:"Comments")]
[StringLength(200)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateTaken",TypeName = "datetime2")]
public DateTime? DateTaken {get; set;}
[Column(name:"GradClassID")]
public int? GradClassID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InsertedBy")]
[StringLength(80)]
public string InsertedBy {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Required]
[Column(name:"Score")]
[StringLength(10)]
public string Score {get; set;}
[Column(name:"StateID")]
public int? StateID {get; set;}
[Column(name:"StateTestID")]
public int? StateTestID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
