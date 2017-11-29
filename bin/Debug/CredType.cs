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
[Table("CredType")]
public partial class CredType
:IAuditable{ 
public CredType()
{
}
[Required]
[Column(name:"AuthToAct")]
public bool AuthToAct {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"CredentialTypeCode")]
[StringLength(12)]
public string CredentialTypeCode {get; set;}
[Required]
[Column(name:"CredentialTypeDesc")]
[StringLength(120)]
public string CredentialTypeDesc {get; set;}
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
[Table("CredTypeAudit")]
public partial class CredTypeAudit
:IAudit{ 
public CredTypeAudit()
{
}
[Required]
[Column(name:"AuthToAct")]
public bool AuthToAct {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"CredentialTypeCode")]
[StringLength(12)]
public string CredentialTypeCode {get; set;}
[Required]
[Column(name:"CredentialTypeDesc")]
[StringLength(120)]
public string CredentialTypeDesc {get; set;}
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
