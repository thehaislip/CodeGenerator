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
[Table("OCAPPRenewScreenCn")]
public partial class OCAPPRenewScreenCn
:IAuditable{ 
public OCAPPRenewScreenCn()
{
}
[Required]
[Column(name:"CategoryCode")]
[StringLength(2)]
public string CategoryCode {get; set;}
[Column(name:"CodeID")]
public int? CodeID {get; set;}
[Column(name:"CompletionCertificateRequired")]
[StringLength(1)]
public string CompletionCertificateRequired {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EmploymentVerificationRequired")]
[StringLength(1)]
public string EmploymentVerificationRequired {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"LevelIndicator")]
public int? LevelIndicator {get; set;}
[Required]
[Column(name:"Requirements")]
[StringLength(1)]
public string Requirements {get; set;}
[Required]
[Column(name:"Screen")]
[StringLength(1)]
public string Screen {get; set;}
[Required]
[Column(name:"UCOSignOffRequired")]
[StringLength(1)]
public string UCOSignOffRequired {get; set;}
[Required]
[Column(name:"VerificationLetterRequired")]
[StringLength(1)]
public string VerificationLetterRequired {get; set;}
}
[Table("OCAPPRenewScreenCnAudit")]
public partial class OCAPPRenewScreenCnAudit
:IAudit{ 
public OCAPPRenewScreenCnAudit()
{
}
[Required]
[Column(name:"CategoryCode")]
[StringLength(2)]
public string CategoryCode {get; set;}
[Column(name:"CodeID")]
public int? CodeID {get; set;}
[Column(name:"CompletionCertificateRequired")]
[StringLength(1)]
public string CompletionCertificateRequired {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EmploymentVerificationRequired")]
[StringLength(1)]
public string EmploymentVerificationRequired {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"LevelIndicator")]
public int? LevelIndicator {get; set;}
[Required]
[Column(name:"Requirements")]
[StringLength(1)]
public string Requirements {get; set;}
[Required]
[Column(name:"Screen")]
[StringLength(1)]
public string Screen {get; set;}
[Required]
[Column(name:"UCOSignOffRequired")]
[StringLength(1)]
public string UCOSignOffRequired {get; set;}
[Required]
[Column(name:"VerificationLetterRequired")]
[StringLength(1)]
public string VerificationLetterRequired {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
