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
[Table("CertificatePrint")]
public partial class CertificatePrint
:IAuditable{ 
public CertificatePrint()
{
}
[Required]
[Column(name:"CertificateID")]
public int CertificateID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PrintDate",TypeName = "datetime2")]
public DateTime? PrintDate {get; set;}
[ForeignKey("CertificateID")]
public virtual Certificate Certificate{get; set;}
}
[Table("CertificatePrintAudit")]
public partial class CertificatePrintAudit
:IAudit{ 
public CertificatePrintAudit()
{
}
[Required]
[Column(name:"CertificateID")]
public int CertificateID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PrintDate",TypeName = "datetime2")]
public DateTime? PrintDate {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
