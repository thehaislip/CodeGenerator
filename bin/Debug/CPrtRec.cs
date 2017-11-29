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
[Table("CPrtRec")]
public partial class CPrtRec
:IAuditable{ 
public CPrtRec()
{
}
[Column(name:"CertCredID")]
public int? CertCredID {get; set;}
[Column(name:"CertCredTypeID")]
public int? CertCredTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PrintCodeID")]
public int? PrintCodeID {get; set;}
[Column(name:"PrintDate")]
public DateTime? PrintDate {get; set;}
[ForeignKey("CertCredID")]
public virtual Certificate Certificate{get; set;}
[ForeignKey("CertCredTypeID")]
public virtual CertificateType CertificateType{get; set;}
[ForeignKey("PrintCodeID")]
public virtual PrntCode PrntCode{get; set;}
}
[Table("CPrtRecAudit")]
public partial class CPrtRecAudit
:IAudit{ 
public CPrtRecAudit()
{
}
[Column(name:"CertCredID")]
public int? CertCredID {get; set;}
[Column(name:"CertCredTypeID")]
public int? CertCredTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PrintCodeID")]
public int? PrintCodeID {get; set;}
[Column(name:"PrintDate")]
public DateTime? PrintDate {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
