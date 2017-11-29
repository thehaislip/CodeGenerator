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
[Table("Degree")]
public partial class Degree
:IAuditable{ 
public Degree()
{
this.CommPersonToMajors = new HashSet<CommPersonToMajor>();
}
[Column(name:"CompletedDate")]
[StringLength(5)]
public string CompletedDate {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DegreeID")]
public int? DegreeID {get; set;}
[Column(name:"DegreeTypeID")]
public int? DegreeTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InstitutionID")]
public int? InstitutionID {get; set;}
[Column(name:"MajMinID")]
public int? MajMinID {get; set;}
[Column(name:"MajMinOther")]
[StringLength(80)]
public string MajMinOther {get; set;}
[Column(name:"MajMinTypeID")]
public int? MajMinTypeID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[ForeignKey("DegreeID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("DegreeTypeID")]
public virtual CommLookup CommLookup1{get; set;}
[ForeignKey("DegreeID")]
public virtual ICollection<CommPersonToMajor> CommPersonToMajors{get; set;}
[ForeignKey("InstitutionID")]
public virtual CommLookup CommLookup2{get; set;}
[ForeignKey("MajMinID")]
public virtual CommLookup CommLookup3{get; set;}
[ForeignKey("MajMinTypeID")]
public virtual CommLookupType CommLookupType{get; set;}
[ForeignKey("PersonnelID")]
public virtual COMMPerson COMMPerson{get; set;}
}
[Table("DegreeAudit")]
public partial class DegreeAudit
:IAudit{ 
public DegreeAudit()
{
}
[Column(name:"CompletedDate")]
[StringLength(5)]
public string CompletedDate {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DegreeID")]
public int? DegreeID {get; set;}
[Column(name:"DegreeTypeID")]
public int? DegreeTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InstitutionID")]
public int? InstitutionID {get; set;}
[Column(name:"MajMinID")]
public int? MajMinID {get; set;}
[Column(name:"MajMinOther")]
[StringLength(80)]
public string MajMinOther {get; set;}
[Column(name:"MajMinTypeID")]
public int? MajMinTypeID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
