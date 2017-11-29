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
[Table("CommPersonToMajor")]
public partial class CommPersonToMajor
:IAuditable{ 
public CommPersonToMajor()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Credits")]
public double? Credits {get; set;}
[Column(name:"DegreeID")]
public int? DegreeID {get; set;}
[Column(name:"GPA")]
public double? GPA {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"IsNationalBoard")]
public bool IsNationalBoard {get; set;}
[Required]
[Column(name:"MajorID")]
public int MajorID {get; set;}
[Column(name:"MajorMinor")]
[StringLength(25)]
public string MajorMinor {get; set;}
[Column(name:"Other")]
[StringLength(250)]
public string Other {get; set;}
[Required]
[Column(name:"PersonID")]
public int PersonID {get; set;}
[ForeignKey("DegreeID")]
public virtual Degree Degree{get; set;}
[ForeignKey("MajorID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("PersonID")]
public virtual COMMPerson COMMPerson{get; set;}
}
[Table("CommPersonToMajorAudit")]
public partial class CommPersonToMajorAudit
:IAudit{ 
public CommPersonToMajorAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Credits")]
public double? Credits {get; set;}
[Column(name:"DegreeID")]
public int? DegreeID {get; set;}
[Column(name:"GPA")]
public double? GPA {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"IsNationalBoard")]
public bool IsNationalBoard {get; set;}
[Required]
[Column(name:"MajorID")]
public int MajorID {get; set;}
[Column(name:"MajorMinor")]
[StringLength(25)]
public string MajorMinor {get; set;}
[Column(name:"Other")]
[StringLength(250)]
public string Other {get; set;}
[Required]
[Column(name:"PersonID")]
public int PersonID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
