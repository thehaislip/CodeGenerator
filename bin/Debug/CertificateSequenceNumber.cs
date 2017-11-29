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
[Table("CertificateSequenceNumber")]
public partial class CertificateSequenceNumber
:IAuditable{ 
public CertificateSequenceNumber()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SequentialNumber")]
public int? SequentialNumber {get; set;}
}
[Table("CertificateSequenceNumberAudit")]
public partial class CertificateSequenceNumberAudit
:IAudit{ 
public CertificateSequenceNumberAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SequentialNumber")]
public int? SequentialNumber {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
