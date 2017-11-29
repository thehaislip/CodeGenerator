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
[Table("DistrictVacancy")]
public partial class DistrictVacancy
:IAuditable{ 
public DistrictVacancy()
{
}
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"DistrictID")]
public int DistrictID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PositionFilledFirstDay")]
[StringLength(1)]
public string PositionFilledFirstDay {get; set;}
[Required]
[Column(name:"PRFID")]
public int PRFID {get; set;}
[Required]
[Column(name:"PRFIDPreviousYear")]
public int PRFIDPreviousYear {get; set;}
[Required]
[Column(name:"VacOptionID")]
public int VacOptionID {get; set;}
[ForeignKey("DistrictID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("PRFID")]
public virtual PRFInfo PRFInfo{get; set;}
[ForeignKey("PRFIDPreviousYear")]
public virtual PRFInfo PRFInfo1{get; set;}
[ForeignKey("VacOptionID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("DistrictVacancyAudit")]
public partial class DistrictVacancyAudit
:IAudit{ 
public DistrictVacancyAudit()
{
}
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"DistrictID")]
public int DistrictID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PositionFilledFirstDay")]
[StringLength(1)]
public string PositionFilledFirstDay {get; set;}
[Required]
[Column(name:"PRFID")]
public int PRFID {get; set;}
[Required]
[Column(name:"PRFIDPreviousYear")]
public int PRFIDPreviousYear {get; set;}
[Required]
[Column(name:"VacOptionID")]
public int VacOptionID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
