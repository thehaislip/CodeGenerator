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
[Table("PRFAssgn")]
public partial class PRFAssgn
:IAuditable{ 
public PRFAssgn()
{
this.OtherActs = new HashSet<OtherAct>();
this.SpEdIndAssgns = new HashSet<SpEdIndAssgn>();
this.SpedMajAssgns = new HashSet<SpedMajAssgn>();
}
[Column(name:"AssignCodeID")]
public int? AssignCodeID {get; set;}
[Column(name:"AttCenterID")]
public int? AttCenterID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EDIAttendanceCenterID")]
public int? EDIAttendanceCenterID {get; set;}
[Column(name:"EDIDistrictID")]
public int? EDIDistrictID {get; set;}
[Column(name:"FTE",TypeName = "money")]
public decimal? FTE {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IsAtOtherDistrictInd")]
public bool? IsAtOtherDistrictInd {get; set;}
[Column(name:"IsAtOtherPayingDistrictInd")]
public bool? IsAtOtherPayingDistrictInd {get; set;}
[Column(name:"IsClassSizeReductionTeacherInd")]
public bool? IsClassSizeReductionTeacherInd {get; set;}
[Column(name:"IsDigitalCurriculumInd")]
public bool? IsDigitalCurriculumInd {get; set;}
[Column(name:"IsElectronicDistanceInstructionInd")]
public bool? IsElectronicDistanceInstructionInd {get; set;}
[Column(name:"IsInterventionTeacherInd")]
public bool? IsInterventionTeacherInd {get; set;}
[Column(name:"ISPDCTeacherInd")]
public bool? ISPDCTeacherInd {get; set;}
[Column(name:"LicenseStatusID")]
public int? LicenseStatusID {get; set;}
[Column(name:"NumberOfClasses")]
public int? NumberOfClasses {get; set;}
[Column(name:"OtherAttendanceCenterID")]
public int? OtherAttendanceCenterID {get; set;}
[Column(name:"OtherDistrictID")]
public int? OtherDistrictID {get; set;}
[Column(name:"OtherPayingAttendanceCenterID")]
public int? OtherPayingAttendanceCenterID {get; set;}
[Column(name:"OtherPayingDistrictID")]
public int? OtherPayingDistrictID {get; set;}
[Column(name:"PositionCodeID")]
public int? PositionCodeID {get; set;}
[Column(name:"PRFInfoID")]
public int? PRFInfoID {get; set;}
[Required]
[Column(name:"Qtr1")]
[StringLength(1)]
public string Qtr1 {get; set;}
[Required]
[Column(name:"Qtr2")]
[StringLength(1)]
public string Qtr2 {get; set;}
[Required]
[Column(name:"Qtr3")]
[StringLength(1)]
public string Qtr3 {get; set;}
[Required]
[Column(name:"Qtr4")]
[StringLength(1)]
public string Qtr4 {get; set;}
[Column(name:"TimeOptionID")]
public int? TimeOptionID {get; set;}
[Column(name:"TotalWeeklyMinutes")]
public int? TotalWeeklyMinutes {get; set;}
[Required]
[Column(name:"Trimester1")]
[StringLength(1)]
public string Trimester1 {get; set;}
[Required]
[Column(name:"Trimester2")]
[StringLength(1)]
public string Trimester2 {get; set;}
[Required]
[Column(name:"Trimester3")]
[StringLength(1)]
public string Trimester3 {get; set;}
[ForeignKey("AssignCodeID")]
public virtual Assignment Assignment{get; set;}
[ForeignKey("AttCenterID")]
public virtual AttCtrSS AttCtrSS{get; set;}
[ForeignKey("EDIAttendanceCenterID")]
public virtual AttCtrSS AttCtrSS1{get; set;}
[ForeignKey("EDIDistrictID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("PRFAssgnID")]
public virtual ICollection<OtherAct> OtherActs{get; set;}
[ForeignKey("PRFAssgnID")]
public virtual ICollection<SpEdIndAssgn> SpEdIndAssgns{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<SpedMajAssgn> SpedMajAssgns{get; set;}
[ForeignKey("LicenseStatusID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("OtherAttendanceCenterID")]
public virtual AttCtrSS AttCtrSS2{get; set;}
[ForeignKey("OtherDistrictID")]
public virtual DistSS DistSS1{get; set;}
[ForeignKey("OtherPayingAttendanceCenterID")]
public virtual AttCtrSS AttCtrSS3{get; set;}
[ForeignKey("OtherPayingDistrictID")]
public virtual DistSS DistSS2{get; set;}
[ForeignKey("PositionCodeID")]
public virtual CommLookup CommLookup1{get; set;}
[ForeignKey("PRFInfoID")]
public virtual PRFInfo PRFInfo{get; set;}
}
[Table("PRFAssgnAudit")]
public partial class PRFAssgnAudit
:IAudit{ 
public PRFAssgnAudit()
{
}
[Column(name:"AssignCodeID")]
public int? AssignCodeID {get; set;}
[Column(name:"AttCenterID")]
public int? AttCenterID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EDIAttendanceCenterID")]
public int? EDIAttendanceCenterID {get; set;}
[Column(name:"EDIDistrictID")]
public int? EDIDistrictID {get; set;}
[Column(name:"FTE",TypeName = "money")]
public decimal? FTE {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IsAtOtherDistrictInd")]
public bool? IsAtOtherDistrictInd {get; set;}
[Column(name:"IsAtOtherPayingDistrictInd")]
public bool? IsAtOtherPayingDistrictInd {get; set;}
[Column(name:"IsClassSizeReductionTeacherInd")]
public bool? IsClassSizeReductionTeacherInd {get; set;}
[Column(name:"IsDigitalCurriculumInd")]
public bool? IsDigitalCurriculumInd {get; set;}
[Column(name:"IsElectronicDistanceInstructionInd")]
public bool? IsElectronicDistanceInstructionInd {get; set;}
[Column(name:"IsInterventionTeacherInd")]
public bool? IsInterventionTeacherInd {get; set;}
[Column(name:"ISPDCTeacherInd")]
public bool? ISPDCTeacherInd {get; set;}
[Column(name:"LicenseStatusID")]
public int? LicenseStatusID {get; set;}
[Column(name:"NumberOfClasses")]
public int? NumberOfClasses {get; set;}
[Column(name:"OtherAttendanceCenterID")]
public int? OtherAttendanceCenterID {get; set;}
[Column(name:"OtherDistrictID")]
public int? OtherDistrictID {get; set;}
[Column(name:"OtherPayingAttendanceCenterID")]
public int? OtherPayingAttendanceCenterID {get; set;}
[Column(name:"OtherPayingDistrictID")]
public int? OtherPayingDistrictID {get; set;}
[Column(name:"PositionCodeID")]
public int? PositionCodeID {get; set;}
[Column(name:"PRFInfoID")]
public int? PRFInfoID {get; set;}
[Required]
[Column(name:"Qtr1")]
[StringLength(1)]
public string Qtr1 {get; set;}
[Required]
[Column(name:"Qtr2")]
[StringLength(1)]
public string Qtr2 {get; set;}
[Required]
[Column(name:"Qtr3")]
[StringLength(1)]
public string Qtr3 {get; set;}
[Required]
[Column(name:"Qtr4")]
[StringLength(1)]
public string Qtr4 {get; set;}
[Column(name:"TimeOptionID")]
public int? TimeOptionID {get; set;}
[Column(name:"TotalWeeklyMinutes")]
public int? TotalWeeklyMinutes {get; set;}
[Required]
[Column(name:"Trimester1")]
[StringLength(1)]
public string Trimester1 {get; set;}
[Required]
[Column(name:"Trimester2")]
[StringLength(1)]
public string Trimester2 {get; set;}
[Required]
[Column(name:"Trimester3")]
[StringLength(1)]
public string Trimester3 {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
