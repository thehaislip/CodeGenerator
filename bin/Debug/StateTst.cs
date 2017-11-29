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
[Table("StateTst")]
public partial class StateTst
:IAuditable{ 
public StateTst()
{
}
[Column(name:"BeginDate",TypeName = "datetime2")]
public DateTime? BeginDate {get; set;}
[Required]
[Column(name:"Code")]
[StringLength(12)]
public string Code {get; set;}
[Required]
[Column(name:"Comments")]
[StringLength(255)]
public string Comments {get; set;}
[Required]
[Column(name:"ConcurrencyID")]
public int ConcurrencyID {get; set;}
[Column(name:"DateDisbaled",TypeName = "datetime2")]
public DateTime? DateDisbaled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DOEGroupID")]
public int? DOEGroupID {get; set;}
[Column(name:"EndDate",TypeName = "datetime2")]
public DateTime? EndDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ParentID")]
public int? ParentID {get; set;}
[Required]
[Column(name:"QualifyingHighScore")]
[StringLength(10)]
public string QualifyingHighScore {get; set;}
[Required]
[Column(name:"QualifyingLowScore")]
[StringLength(10)]
public string QualifyingLowScore {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[Column(name:"TypeID")]
public int? TypeID {get; set;}
[Required]
[Column(name:"ValidForCutScore")]
[StringLength(1)]
public string ValidForCutScore {get; set;}
[Required]
[Column(name:"ValidForSouthDakota")]
[StringLength(1)]
public string ValidForSouthDakota {get; set;}
}
[Table("StateTstAudit")]
public partial class StateTstAudit
:IAudit{ 
public StateTstAudit()
{
}
[Column(name:"BeginDate",TypeName = "datetime2")]
public DateTime? BeginDate {get; set;}
[Required]
[Column(name:"Code")]
[StringLength(12)]
public string Code {get; set;}
[Required]
[Column(name:"Comments")]
[StringLength(255)]
public string Comments {get; set;}
[Required]
[Column(name:"ConcurrencyID")]
public int ConcurrencyID {get; set;}
[Column(name:"DateDisbaled",TypeName = "datetime2")]
public DateTime? DateDisbaled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DOEGroupID")]
public int? DOEGroupID {get; set;}
[Column(name:"EndDate",TypeName = "datetime2")]
public DateTime? EndDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ParentID")]
public int? ParentID {get; set;}
[Required]
[Column(name:"QualifyingHighScore")]
[StringLength(10)]
public string QualifyingHighScore {get; set;}
[Required]
[Column(name:"QualifyingLowScore")]
[StringLength(10)]
public string QualifyingLowScore {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[Column(name:"TypeID")]
public int? TypeID {get; set;}
[Required]
[Column(name:"ValidForCutScore")]
[StringLength(1)]
public string ValidForCutScore {get; set;}
[Required]
[Column(name:"ValidForSouthDakota")]
[StringLength(1)]
public string ValidForSouthDakota {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
