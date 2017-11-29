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
[Table("CertType")]
public partial class CertType
:IAuditable{ 
public CertType()
{
}
[Required]
[Column(name:"AuthToAct")]
public bool AuthToAct {get; set;}
[Required]
[Column(name:"CertifiedTypeCode")]
[StringLength(12)]
public string CertifiedTypeCode {get; set;}
[Required]
[Column(name:"CertifiedTypeDesc")]
[StringLength(120)]
public string CertifiedTypeDesc {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Disabled")]
public bool Disabled {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ValidLengthOfYears")]
public int? ValidLengthOfYears {get; set;}
}
[Table("CertTypeAudit")]
public partial class CertTypeAudit
:IAudit{ 
public CertTypeAudit()
{
}
[Required]
[Column(name:"AuthToAct")]
public bool AuthToAct {get; set;}
[Required]
[Column(name:"CertifiedTypeCode")]
[StringLength(12)]
public string CertifiedTypeCode {get; set;}
[Required]
[Column(name:"CertifiedTypeDesc")]
[StringLength(120)]
public string CertifiedTypeDesc {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Disabled")]
public bool Disabled {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ValidLengthOfYears")]
public int? ValidLengthOfYears {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
