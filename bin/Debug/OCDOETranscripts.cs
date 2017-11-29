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
[Table("OCDOETranscripts")]
public partial class OCDOETranscripts
:IAuditable{ 
public OCDOETranscripts()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Country")]
[StringLength(40)]
public string Country {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"OCAPPAppEducID")]
public int? OCAPPAppEducID {get; set;}
[Column(name:"OCAPPRenewalCreditID")]
public int? OCAPPRenewalCreditID {get; set;}
[Column(name:"SDUniversityID")]
public int? SDUniversityID {get; set;}
[Column(name:"StateID")]
public int? StateID {get; set;}
[Required]
[Column(name:"TranscriptReceived")]
[StringLength(1)]
public string TranscriptReceived {get; set;}
[Required]
[Column(name:"UniversityName")]
[StringLength(100)]
public string UniversityName {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("OCAPPAppEducID")]
public virtual OCAPPAppEduc OCAPPAppEduc{get; set;}
[ForeignKey("OCAPPRenewalCreditID")]
public virtual OCAPPRenewalCredit OCAPPRenewalCredit{get; set;}
[ForeignKey("SDUniversityID")]
public virtual OCAPPSDUnivSupt OCAPPSDUnivSupt{get; set;}
[ForeignKey("StateID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("OCDOETranscriptsAudit")]
public partial class OCDOETranscriptsAudit
:IAudit{ 
public OCDOETranscriptsAudit()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Country")]
[StringLength(40)]
public string Country {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"OCAPPAppEducID")]
public int? OCAPPAppEducID {get; set;}
[Column(name:"OCAPPRenewalCreditID")]
public int? OCAPPRenewalCreditID {get; set;}
[Column(name:"SDUniversityID")]
public int? SDUniversityID {get; set;}
[Column(name:"StateID")]
public int? StateID {get; set;}
[Required]
[Column(name:"TranscriptReceived")]
[StringLength(1)]
public string TranscriptReceived {get; set;}
[Required]
[Column(name:"UniversityName")]
[StringLength(100)]
public string UniversityName {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
