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
[Table("VacPosCnn")]
public partial class VacPosCnn
:IAuditable{ 
public VacPosCnn()
{
this.Vacancys = new HashSet<Vacancy>();
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
[Column(name:"VacCategoryID")]
public int? VacCategoryID {get; set;}
[Column(name:"VacPositionID")]
public int? VacPositionID {get; set;}
[ForeignKey("VacPosCnnID")]
public virtual ICollection<Vacancy> Vacancys{get; set;}
[ForeignKey("VacCategoryID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("VacPositionID")]
public virtual CommLookup CommLookup1{get; set;}
}
[Table("VacPosCnnAudit")]
public partial class VacPosCnnAudit
:IAudit{ 
public VacPosCnnAudit()
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
[Column(name:"VacCategoryID")]
public int? VacCategoryID {get; set;}
[Column(name:"VacPositionID")]
public int? VacPositionID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
