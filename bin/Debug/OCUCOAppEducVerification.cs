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
[Table("OCUCOAppEducVerification")]
public partial class OCUCOAppEducVerification
:IAuditable{ 
public OCUCOAppEducVerification()
{
}
[Column(name:"AppEducID")]
public int? AppEducID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"UCOEducID")]
public int? UCOEducID {get; set;}
[Column(name:"UCOProfileID")]
public int? UCOProfileID {get; set;}
[Required]
[Column(name:"UCOResponse")]
[StringLength(1)]
public string UCOResponse {get; set;}
[ForeignKey("AppEducID")]
public virtual OCAPPAppEduc OCAPPAppEduc{get; set;}
[ForeignKey("UCOEducID")]
public virtual OCUCOEducation OCUCOEducation{get; set;}
[ForeignKey("UCOProfileID")]
public virtual OCUCOProfile OCUCOProfile{get; set;}
}
[Table("OCUCOAppEducVerificationAudit")]
public partial class OCUCOAppEducVerificationAudit
:IAudit{ 
public OCUCOAppEducVerificationAudit()
{
}
[Column(name:"AppEducID")]
public int? AppEducID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"UCOEducID")]
public int? UCOEducID {get; set;}
[Column(name:"UCOProfileID")]
public int? UCOProfileID {get; set;}
[Required]
[Column(name:"UCOResponse")]
[StringLength(1)]
public string UCOResponse {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
