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
[Table("ParaQual")]
public partial class ParaQual
:IAuditable{ 
public ParaQual()
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
[Required]
[Column(name:"ParaProfID")]
public int ParaProfID {get; set;}
[Required]
[Column(name:"QualificationTypeID")]
public int QualificationTypeID {get; set;}
[ForeignKey("ParaProfID")]
public virtual ParaProf ParaProf{get; set;}
[ForeignKey("QualificationTypeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("ParaQualAudit")]
public partial class ParaQualAudit
:IAudit{ 
public ParaQualAudit()
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
[Required]
[Column(name:"ParaProfID")]
public int ParaProfID {get; set;}
[Required]
[Column(name:"QualificationTypeID")]
public int QualificationTypeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
