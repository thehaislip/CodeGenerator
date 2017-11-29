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
[Table("User")]
public partial class User
:IAuditable{ 
public User()
{
this.UserTemporaryTokens = new HashSet<UserTemporaryToken>();
}
[Column(name:"CertificateNumber")]
public int? CertificateNumber {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Email")]
[StringLength(100)]
public string Email {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"NonUSCitizenInd")]
public bool? NonUSCitizenInd {get; set;}
[Required]
[Column(name:"Password")]
public string Password {get; set;}
[Column(name:"RecoveryEmail")]
[StringLength(100)]
public string RecoveryEmail {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[Column(name:"ValidatedIndicator")]
public bool? ValidatedIndicator {get; set;}
[ForeignKey("UserID")]
public virtual ICollection<UserTemporaryToken> UserTemporaryTokens{get; set;}
}
[Table("UserAudit")]
public partial class UserAudit
:IAudit{ 
public UserAudit()
{
}
[Column(name:"CertificateNumber")]
public int? CertificateNumber {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Email")]
[StringLength(100)]
public string Email {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"NonUSCitizenInd")]
public bool? NonUSCitizenInd {get; set;}
[Required]
[Column(name:"Password")]
public string Password {get; set;}
[Column(name:"RecoveryEmail")]
[StringLength(100)]
public string RecoveryEmail {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[Column(name:"ValidatedIndicator")]
public bool? ValidatedIndicator {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
