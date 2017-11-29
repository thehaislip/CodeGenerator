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
[Table("CPMAJR")]
public partial class CPMAJR
:IAuditable{ 
public CPMAJR()
{
}
[Column(name:"COMMLookupID")]
public int? COMMLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DE04CertCredID")]
public int? DE04CertCredID {get; set;}
[Column(name:"ExpirationDate",TypeName = "datetime2")]
public DateTime? ExpirationDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("COMMLookupID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("DE04CertCredID")]
public virtual Certificate Certificate{get; set;}
}
[Table("CPMAJRAudit")]
public partial class CPMAJRAudit
:IAudit{ 
public CPMAJRAudit()
{
}
[Column(name:"COMMLookupID")]
public int? COMMLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DE04CertCredID")]
public int? DE04CertCredID {get; set;}
[Column(name:"ExpirationDate",TypeName = "datetime2")]
public DateTime? ExpirationDate {get; set;}
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
