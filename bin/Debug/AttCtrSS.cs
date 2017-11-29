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
[Table("AttCtrSS")]
public partial class AttCtrSS
:IAuditable{ 
public AttCtrSS()
{
this.ParaProfs = new HashSet<ParaProf>();
this.PRFAssgns = new HashSet<PRFAssgn>();
this.PRFAssgn1s = new HashSet<PRFAssgn>();
this.PRFAssgn1s = new HashSet<PRFAssgn>();
this.ParaAttns = new HashSet<ParaAttn>();
this.PRFAssgn1s = new HashSet<PRFAssgn>();
this.DistPlanIntnts = new HashSet<DistPlanIntnt>();
this.Answers = new HashSet<Answer>();
this.TimeOpts = new HashSet<TimeOpt>();
}
[Required]
[Column(name:"AttendanceCenterName")]
[StringLength(80)]
public string AttendanceCenterName {get; set;}
[Required]
[Column(name:"AttendanceCenterNum")]
[StringLength(3)]
public string AttendanceCenterNum {get; set;}
[Column(name:"AveWeeklyFTE")]
public int? AveWeeklyFTE {get; set;}
[Required]
[Column(name:"BegGradeSpan")]
[StringLength(2)]
public string BegGradeSpan {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistSSID")]
public int? DistSSID {get; set;}
[Required]
[Column(name:"EndGradeSpan")]
[StringLength(2)]
public string EndGradeSpan {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SchoolTermCodeID")]
public int? SchoolTermCodeID {get; set;}
[Column(name:"SchoolTypeID")]
public int? SchoolTypeID {get; set;}
[Column(name:"TotalIntermission")]
public int? TotalIntermission {get; set;}
[ForeignKey("DistSSID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("AttCenterID")]
public virtual ICollection<ParaProf> ParaProfs{get; set;}
[ForeignKey("OtherAttendanceCenterID")]
public virtual ICollection<PRFAssgn> PRFAssgns{get; set;}
[ForeignKey("OtherPayingAttendanceCenterID")]
public virtual ICollection<PRFAssgn> PRFAssgn1s{get; set;}
[ForeignKey("EDIAttendanceCenterID")]
public virtual ICollection<PRFAssgn> PRFAssgn2s{get; set;}
[ForeignKey("AttCenterID")]
public virtual ICollection<ParaAttn> ParaAttns{get; set;}
[ForeignKey("AttCenterID")]
public virtual ICollection<PRFAssgn> PRFAssgn3s{get; set;}
[ForeignKey("AttCtrID")]
public virtual ICollection<DistPlanIntnt> DistPlanIntnts{get; set;}
[ForeignKey("AttendanceCenterID")]
public virtual ICollection<Answer> Answers{get; set;}
[ForeignKey("AttendanceCenterID")]
public virtual ICollection<TimeOpt> TimeOpts{get; set;}
[ForeignKey("SchoolTermCodeID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("SchoolTypeID")]
public virtual CommLookup CommLookup1{get; set;}
}
[Table("AttCtrSSAudit")]
public partial class AttCtrSSAudit
:IAudit{ 
public AttCtrSSAudit()
{
}
[Required]
[Column(name:"AttendanceCenterName")]
[StringLength(80)]
public string AttendanceCenterName {get; set;}
[Required]
[Column(name:"AttendanceCenterNum")]
[StringLength(3)]
public string AttendanceCenterNum {get; set;}
[Column(name:"AveWeeklyFTE")]
public int? AveWeeklyFTE {get; set;}
[Required]
[Column(name:"BegGradeSpan")]
[StringLength(2)]
public string BegGradeSpan {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistSSID")]
public int? DistSSID {get; set;}
[Required]
[Column(name:"EndGradeSpan")]
[StringLength(2)]
public string EndGradeSpan {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SchoolTermCodeID")]
public int? SchoolTermCodeID {get; set;}
[Column(name:"SchoolTypeID")]
public int? SchoolTypeID {get; set;}
[Column(name:"TotalIntermission")]
public int? TotalIntermission {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
