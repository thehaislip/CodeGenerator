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
[Table("GraduateMajorCategoryCnn")]
public partial class GraduateMajorCategoryCnn
:IAuditable{ 
public GraduateMajorCategoryCnn()
{
}
[Required]
[Column(name:"CategoryID")]
public int CategoryID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"GradMajorID")]
public int GradMajorID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("CategoryID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("GradMajorID")]
public virtual CommLookup CommLookup1{get; set;}
[ForeignKey("ID")]
public virtual ICollection<GraduateMajorCategoryCnn> SuperGraduateMajorCategoryCnns{get; set;}
}
[Table("GraduateMajorCategoryCnnAudit")]
public partial class GraduateMajorCategoryCnnAudit
:IAudit{ 
public GraduateMajorCategoryCnnAudit()
{
}
[Required]
[Column(name:"CategoryID")]
public int CategoryID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"GradMajorID")]
public int GradMajorID {get; set;}
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
