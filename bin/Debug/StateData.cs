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
[Table("StateData")]
public partial class StateData
:IAuditable{ 
public StateData()
{
}
[Required]
[Column(name:"CertCredID")]
public int CertCredID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"DegreeDate")]
[StringLength(5)]
public string DegreeDate {get; set;}
[Required]
[Column(name:"DegreeID")]
public int DegreeID {get; set;}
[Required]
[Column(name:"DegreeTypeID")]
public int DegreeTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"InstitutionID")]
public int InstitutionID {get; set;}
[Required]
[Column(name:"MajMinID")]
public int MajMinID {get; set;}
[Required]
[Column(name:"MajMinTypeID")]
public int MajMinTypeID {get; set;}
}
[Table("StateDataAudit")]
public partial class StateDataAudit
:IAudit{ 
public StateDataAudit()
{
}
[Required]
[Column(name:"CertCredID")]
public int CertCredID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"DegreeDate")]
[StringLength(5)]
public string DegreeDate {get; set;}
[Required]
[Column(name:"DegreeID")]
public int DegreeID {get; set;}
[Required]
[Column(name:"DegreeTypeID")]
public int DegreeTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"InstitutionID")]
public int InstitutionID {get; set;}
[Required]
[Column(name:"MajMinID")]
public int MajMinID {get; set;}
[Required]
[Column(name:"MajMinTypeID")]
public int MajMinTypeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
