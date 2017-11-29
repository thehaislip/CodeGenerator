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
[Table("OCUCOEducation")]
public partial class OCUCOEducation
:IAuditable{ 
public OCUCOEducation()
{
this.OCUCOAppEducVerifications = new HashSet<OCUCOAppEducVerification>();
}
[Column(name:"AppEducationID")]
public int? AppEducationID {get; set;}
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
[Column(name:"City")]
[StringLength(40)]
public string City {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Correction")]
[StringLength(1)]
public string Correction {get; set;}
[Column(name:"Country")]
[StringLength(40)]
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
[Column(name:"ReleaseToUniversity")]
[StringLength(1)]
public string ReleaseToUniversity {get; set;}
[Column(name:"SDUnivID")]
public int? SDUnivID {get; set;}
[Column(name:"State")]
[StringLength(40)]
public string State {get; set;}
[Column(name:"StudentID")]
[StringLength(30)]
public string StudentID {get; set;}
[Column(name:"TranscriptComing")]
[StringLength(1)]
public string TranscriptComing {get; set;}
[Column(name:"UCOEducID")]
public int? UCOEducID {get; set;}
[Column(name:"UCOProfileID")]
public int? UCOProfileID {get; set;}
[Column(name:"Zip")]
[StringLength(10)]
public string Zip {get; set;}
[ForeignKey("AppEducationID")]
public virtual OCAPPAppEduc OCAPPAppEduc{get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("AttainmentTypeID")]
public virtual OCAPPAttTypeSup OCAPPAttTypeSup{get; set;}
[ForeignKey("DegreeTypeID")]
public virtual OCAPPDegreeTypSupt OCAPPDegreeTypSupt{get; set;}
[ForeignKey("UCOEducID")]
public virtual ICollection<OCUCOAppEducVerification> OCUCOAppEducVerifications{get; set;}
[ForeignKey("SDUnivID")]
public virtual OCAPPSDUnivSupt OCAPPSDUnivSupt{get; set;}
[ForeignKey("UCOProfileID")]
public virtual OCUCOProfile OCUCOProfile{get; set;}
}
[Table("OCUCOEducationAudit")]
public partial class OCUCOEducationAudit
:IAudit{ 
public OCUCOEducationAudit()
{
}
[Column(name:"AppEducationID")]
public int? AppEducationID {get; set;}
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
[Column(name:"City")]
[StringLength(40)]
public string City {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Correction")]
[StringLength(1)]
public string Correction {get; set;}
[Column(name:"Country")]
[StringLength(40)]
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
[Column(name:"ReleaseToUniversity")]
[StringLength(1)]
public string ReleaseToUniversity {get; set;}
[Column(name:"SDUnivID")]
public int? SDUnivID {get; set;}
[Column(name:"State")]
[StringLength(40)]
public string State {get; set;}
[Column(name:"StudentID")]
[StringLength(30)]
public string StudentID {get; set;}
[Column(name:"TranscriptComing")]
[StringLength(1)]
public string TranscriptComing {get; set;}
[Column(name:"UCOEducID")]
public int? UCOEducID {get; set;}
[Column(name:"UCOProfileID")]
public int? UCOProfileID {get; set;}
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
