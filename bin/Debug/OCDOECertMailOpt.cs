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
[Table("OCDOECertMailOpt")]
public partial class OCDOECertMailOpt
:IAuditable{ 
public OCDOECertMailOpt()
{
}
[Required]
[Column(name:"CertCredID")]
public int CertCredID {get; set;}
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
[Column(name:"MailingOption")]
[StringLength(1)]
public string MailingOption {get; set;}
[ForeignKey("CertCredID")]
public virtual Certificate Certificate{get; set;}
}
[Table("OCDOECertMailOptAudit")]
public partial class OCDOECertMailOptAudit
:IAudit{ 
public OCDOECertMailOptAudit()
{
}
[Required]
[Column(name:"CertCredID")]
public int CertCredID {get; set;}
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
[Column(name:"MailingOption")]
[StringLength(1)]
public string MailingOption {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
