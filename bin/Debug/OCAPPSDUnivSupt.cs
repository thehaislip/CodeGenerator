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
[Table("OCAPPSDUnivSupt")]
public partial class OCAPPSDUnivSupt
:IAuditable{ 
public OCAPPSDUnivSupt()
{
this.OCAPPRenewalCredits = new HashSet<OCAPPRenewalCredit>();
this.OCUCOProfiles = new HashSet<OCUCOProfile>();
this.OCDOETranscriptss = new HashSet<OCDOETranscripts>();
this.OCUCOEducations = new HashSet<OCUCOEducation>();
this.OCAPPAppEducs = new HashSet<OCAPPAppEduc>();
this.OCAPPOverrideQueues = new HashSet<OCAPPOverrideQueue>();
}
[Required]
[Column(name:"Address1")]
[StringLength(100)]
public string Address1 {get; set;}
[Required]
[Column(name:"City")]
[StringLength(60)]
public string City {get; set;}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"State")]
[StringLength(2)]
public string State {get; set;}
[Column(name:"TranscriptCode")]
[StringLength(2)]
public string TranscriptCode {get; set;}
[Column(name:"UCOSignOff")]
[StringLength(1)]
public string UCOSignOff {get; set;}
[Required]
[Column(name:"Zip")]
[StringLength(9)]
public string Zip {get; set;}
[ForeignKey("SDUnivID")]
public virtual ICollection<OCAPPRenewalCredit> OCAPPRenewalCredits{get; set;}
[ForeignKey("SDUnivID")]
public virtual ICollection<OCUCOProfile> OCUCOProfiles{get; set;}
[ForeignKey("SDUniversityID")]
public virtual ICollection<OCDOETranscripts> OCDOETranscriptss{get; set;}
[ForeignKey("SDUnivID")]
public virtual ICollection<OCUCOEducation> OCUCOEducations{get; set;}
[ForeignKey("SDUnivID")]
public virtual ICollection<OCAPPAppEduc> OCAPPAppEducs{get; set;}
[ForeignKey("SDUnivID")]
public virtual ICollection<OCAPPOverrideQueue> OCAPPOverrideQueues{get; set;}
}
[Table("OCAPPSDUnivSuptAudit")]
public partial class OCAPPSDUnivSuptAudit
:IAudit{ 
public OCAPPSDUnivSuptAudit()
{
}
[Required]
[Column(name:"Address1")]
[StringLength(100)]
public string Address1 {get; set;}
[Required]
[Column(name:"City")]
[StringLength(60)]
public string City {get; set;}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"State")]
[StringLength(2)]
public string State {get; set;}
[Column(name:"TranscriptCode")]
[StringLength(2)]
public string TranscriptCode {get; set;}
[Column(name:"UCOSignOff")]
[StringLength(1)]
public string UCOSignOff {get; set;}
[Required]
[Column(name:"Zip")]
[StringLength(9)]
public string Zip {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
