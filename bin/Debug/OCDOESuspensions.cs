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
[Table("OCDOESuspensions")]
public partial class OCDOESuspensions
:IAuditable{ 
public OCDOESuspensions()
{
}
[Column(name:"CertificateID")]
public int? CertificateID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SuspensionDate",TypeName = "datetime2")]
public DateTime? SuspensionDate {get; set;}
[Column(name:"SuspensionEndDate",TypeName = "datetime2")]
public DateTime? SuspensionEndDate {get; set;}
[ForeignKey("CertificateID")]
public virtual Certificate Certificate{get; set;}
}
[Table("OCDOESuspensionsAudit")]
public partial class OCDOESuspensionsAudit
:IAudit{ 
public OCDOESuspensionsAudit()
{
}
[Column(name:"CertificateID")]
public int? CertificateID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SuspensionDate",TypeName = "datetime2")]
public DateTime? SuspensionDate {get; set;}
[Column(name:"SuspensionEndDate",TypeName = "datetime2")]
public DateTime? SuspensionEndDate {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
