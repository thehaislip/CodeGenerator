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
[Table("OCAPPAppEduc")]
public partial class OCAPPAppEduc
:IAuditable{ 
public OCAPPAppEduc()
{
this.OCDOETranscriptss = new HashSet<OCDOETranscripts>();
this.OCUCOEducations = new HashSet<OCUCOEducation>();
this.OCAPPRenewMajorsCns = new HashSet<OCAPPRenewMajorsCn>();
this.OCUCOAppEducVerifications = new HashSet<OCUCOAppEducVerification>();
}
[Column(name:"AltProgram")]
[StringLength(1)]
public string AltProgram {get; set;}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"AttainmentDate",TypeName = "datetime2")]
public DateTime? AttainmentDate {get; set;}
[Column(name:"AttainmentTypeID")]
public int? AttainmentTypeID {get; set;}
[Column(name:"AttendedFrom",TypeName = "datetime2")]
public DateTime? AttendedFrom {get; set;}
[Column(name:"AttendedTo",TypeName = "datetime2")]
public DateTime? AttendedTo {get; set;}
[Required]
[Column(name:"City")]
[StringLength(40)]
public string City {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Country")]
[StringLength(60)]
public string Country {get; set;}
[Column(name:"DegreeTypeID")]
public int? DegreeTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Major")]
[StringLength(100)]
public string Major {get; set;}
[Column(name:"Minor")]
[StringLength(100)]
public string Minor {get; set;}
[Column(name:"OtherUniv")]
[StringLength(100)]
public string OtherUniv {get; set;}
[Column(name:"SDUnivID")]
public int? SDUnivID {get; set;}
[Column(name:"SpecializationText")]
[StringLength(100)]
public string SpecializationText {get; set;}
[Column(name:"State")]
[StringLength(40)]
public string State {get; set;}
[Column(name:"StateID")]
public int? StateID {get; set;}
[Column(name:"StudentID")]
[StringLength(30)]
public string StudentID {get; set;}
[Required]
[Column(name:"TranscriptComing")]
[StringLength(1)]
public string TranscriptComing {get; set;}
[Column(name:"UCOSignoffRequired")]
[StringLength(1)]
public string UCOSignoffRequired {get; set;}
[Column(name:"Zip")]
[StringLength(10)]
public string Zip {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("AttainmentTypeID")]
public virtual OCAPPAttTypeSup OCAPPAttTypeSup{get; set;}
[ForeignKey("DegreeTypeID")]
public virtual OCAPPDegreeTypSupt OCAPPDegreeTypSupt{get; set;}
[ForeignKey("OCAPPAppEducID")]
public virtual ICollection<OCDOETranscripts> OCDOETranscriptss{get; set;}
[ForeignKey("AppEducationID")]
public virtual ICollection<OCUCOEducation> OCUCOEducations{get; set;}
[ForeignKey("OCAppEducID")]
public virtual ICollection<OCAPPRenewMajorsCn> OCAPPRenewMajorsCns{get; set;}
[ForeignKey("AppEducID")]
public virtual ICollection<OCUCOAppEducVerification> OCUCOAppEducVerifications{get; set;}
[ForeignKey("SDUnivID")]
public virtual OCAPPSDUnivSupt OCAPPSDUnivSupt{get; set;}
}
[Table("OCAPPAppEducAudit")]
public partial class OCAPPAppEducAudit
:IAudit{ 
public OCAPPAppEducAudit()
{
}
[Column(name:"AltProgram")]
[StringLength(1)]
public string AltProgram {get; set;}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"AttainmentDate",TypeName = "datetime2")]
public DateTime? AttainmentDate {get; set;}
[Column(name:"AttainmentTypeID")]
public int? AttainmentTypeID {get; set;}
[Column(name:"AttendedFrom",TypeName = "datetime2")]
public DateTime? AttendedFrom {get; set;}
[Column(name:"AttendedTo",TypeName = "datetime2")]
public DateTime? AttendedTo {get; set;}
[Required]
[Column(name:"City")]
[StringLength(40)]
public string City {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Country")]
[StringLength(60)]
public string Country {get; set;}
[Column(name:"DegreeTypeID")]
public int? DegreeTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Major")]
[StringLength(100)]
public string Major {get; set;}
[Column(name:"Minor")]
[StringLength(100)]
public string Minor {get; set;}
[Column(name:"OtherUniv")]
[StringLength(100)]
public string OtherUniv {get; set;}
[Column(name:"SDUnivID")]
public int? SDUnivID {get; set;}
[Column(name:"SpecializationText")]
[StringLength(100)]
public string SpecializationText {get; set;}
[Column(name:"State")]
[StringLength(40)]
public string State {get; set;}
[Column(name:"StateID")]
public int? StateID {get; set;}
[Column(name:"StudentID")]
[StringLength(30)]
public string StudentID {get; set;}
[Required]
[Column(name:"TranscriptComing")]
[StringLength(1)]
public string TranscriptComing {get; set;}
[Column(name:"UCOSignoffRequired")]
[StringLength(1)]
public string UCOSignoffRequired {get; set;}
[Column(name:"Zip")]
[StringLength(10)]
public string Zip {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
