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
[Table("Vacancy")]
public partial class Vacancy
:IAuditable{ 
public Vacancy()
{
}
[Required]
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistID")]
public int? DistID {get; set;}
[Column(name:"FTE",TypeName = "money")]
public decimal? FTE {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"VacancyReasonID")]
public int? VacancyReasonID {get; set;}
[Column(name:"VacOptionID")]
public int? VacOptionID {get; set;}
[Column(name:"VacPosCnnID")]
public int? VacPosCnnID {get; set;}
[ForeignKey("DistID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("VacOptionID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("VacPosCnnID")]
public virtual VacPosCnn VacPosCnn{get; set;}
}
[Table("VacancyAudit")]
public partial class VacancyAudit
:IAudit{ 
public VacancyAudit()
{
}
[Required]
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistID")]
public int? DistID {get; set;}
[Column(name:"FTE",TypeName = "money")]
public decimal? FTE {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"VacancyReasonID")]
public int? VacancyReasonID {get; set;}
[Column(name:"VacOptionID")]
public int? VacOptionID {get; set;}
[Column(name:"VacPosCnnID")]
public int? VacPosCnnID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
