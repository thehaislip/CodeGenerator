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
[Table("CTEndr")]
public partial class CTEndr
:IAuditable{ 
public CTEndr()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DE04CertCredID")]
public int? DE04CertCredID {get; set;}
[Column(name:"DE04CertCredTypeID")]
public int? DE04CertCredTypeID {get; set;}
[Column(name:"DE04EndrCodeID")]
public int? DE04EndrCodeID {get; set;}
[Column(name:"ExpirationDate",TypeName = "datetime2")]
public DateTime? ExpirationDate {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
}
[Table("CTEndrAudit")]
public partial class CTEndrAudit
:IAudit{ 
public CTEndrAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DE04CertCredID")]
public int? DE04CertCredID {get; set;}
[Column(name:"DE04CertCredTypeID")]
public int? DE04CertCredTypeID {get; set;}
[Column(name:"DE04EndrCodeID")]
public int? DE04EndrCodeID {get; set;}
[Column(name:"ExpirationDate",TypeName = "datetime2")]
public DateTime? ExpirationDate {get; set;}
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
