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
[Table("PRFAssignmentImportHold")]
public partial class PRFAssignmentImportHold
:IAuditable{ 
public PRFAssignmentImportHold()
{
}
[Column(name:"AssignmentCodeID")]
public int? AssignmentCodeID {get; set;}
[Column(name:"AssignmentFTE",TypeName = "money")]
public decimal? AssignmentFTE {get; set;}
[Column(name:"AttendanceCenterID")]
public int? AttendanceCenterID {get; set;}
[Column(name:"BVIIndicator")]
[StringLength(1)]
public string BVIIndicator {get; set;}
[Column(name:"DHIIndicator")]
[StringLength(1)]
public string DHIIndicator {get; set;}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Column(name:"EDIAttendanceCenterID")]
public int? EDIAttendanceCenterID {get; set;}
[Column(name:"EDIDistrictID")]
public int? EDIDistrictID {get; set;}
[Column(name:"ErrorCode")]
[StringLength(2)]
public string ErrorCode {get; set;}
[Column(name:"ESLIndicator")]
[StringLength(1)]
public string ESLIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IsAtOtherDistrict")]
[StringLength(1)]
public string IsAtOtherDistrict {get; set;}
[Column(name:"IsClassSizeReductionTeacher")]
[StringLength(1)]
public string IsClassSizeReductionTeacher {get; set;}
[Column(name:"IsDigitalCurriculum")]
[StringLength(1)]
public string IsDigitalCurriculum {get; set;}
[Column(name:"IsElectronicDistanceInstruction")]
[StringLength(1)]
public string IsElectronicDistanceInstruction {get; set;}
[Column(name:"IsInterventionTeacher")]
[StringLength(1)]
public string IsInterventionTeacher {get; set;}
[Column(name:"IsPDCTeacher")]
[StringLength(1)]
public string IsPDCTeacher {get; set;}
[Column(name:"LicensureCertificationStatusID")]
public int? LicensureCertificationStatusID {get; set;}
[Column(name:"NumberOfClasses")]
public int? NumberOfClasses {get; set;}
[Column(name:"OtherAttendanceCenterID")]
public int? OtherAttendanceCenterID {get; set;}
[Column(name:"OtherDistrictID")]
public int? OtherDistrictID {get; set;}
[Column(name:"PositionCodeID")]
public int? PositionCodeID {get; set;}
[Column(name:"PRFAssignmentImportLogID")]
public int? PRFAssignmentImportLogID {get; set;}
[Column(name:"PRFID")]
public int? PRFID {get; set;}
[Column(name:"Qtr1")]
[StringLength(1)]
public string Qtr1 {get; set;}
[Column(name:"Qtr2")]
[StringLength(1)]
public string Qtr2 {get; set;}
[Column(name:"Qtr3")]
[StringLength(1)]
public string Qtr3 {get; set;}
[Column(name:"Qtr4")]
[StringLength(1)]
public string Qtr4 {get; set;}
[Column(name:"RawLine")]
[StringLength(100)]
public string RawLine {get; set;}
[Column(name:"SPEDIndicator")]
[StringLength(1)]
public string SPEDIndicator {get; set;}
[Column(name:"Trimester1")]
[StringLength(1)]
public string Trimester1 {get; set;}
[Column(name:"Trimester2")]
[StringLength(1)]
public string Trimester2 {get; set;}
[Column(name:"Trimester3")]
[StringLength(1)]
public string Trimester3 {get; set;}
}
[Table("PRFAssignmentImportHoldAudit")]
public partial class PRFAssignmentImportHoldAudit
:IAudit{ 
public PRFAssignmentImportHoldAudit()
{
}
[Column(name:"AssignmentCodeID")]
public int? AssignmentCodeID {get; set;}
[Column(name:"AssignmentFTE",TypeName = "money")]
public decimal? AssignmentFTE {get; set;}
[Column(name:"AttendanceCenterID")]
public int? AttendanceCenterID {get; set;}
[Column(name:"BVIIndicator")]
[StringLength(1)]
public string BVIIndicator {get; set;}
[Column(name:"DHIIndicator")]
[StringLength(1)]
public string DHIIndicator {get; set;}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Column(name:"EDIAttendanceCenterID")]
public int? EDIAttendanceCenterID {get; set;}
[Column(name:"EDIDistrictID")]
public int? EDIDistrictID {get; set;}
[Column(name:"ErrorCode")]
[StringLength(2)]
public string ErrorCode {get; set;}
[Column(name:"ESLIndicator")]
[StringLength(1)]
public string ESLIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"IsAtOtherDistrict")]
[StringLength(1)]
public string IsAtOtherDistrict {get; set;}
[Column(name:"IsClassSizeReductionTeacher")]
[StringLength(1)]
public string IsClassSizeReductionTeacher {get; set;}
[Column(name:"IsDigitalCurriculum")]
[StringLength(1)]
public string IsDigitalCurriculum {get; set;}
[Column(name:"IsElectronicDistanceInstruction")]
[StringLength(1)]
public string IsElectronicDistanceInstruction {get; set;}
[Column(name:"IsInterventionTeacher")]
[StringLength(1)]
public string IsInterventionTeacher {get; set;}
[Column(name:"IsPDCTeacher")]
[StringLength(1)]
public string IsPDCTeacher {get; set;}
[Column(name:"LicensureCertificationStatusID")]
public int? LicensureCertificationStatusID {get; set;}
[Column(name:"NumberOfClasses")]
public int? NumberOfClasses {get; set;}
[Column(name:"OtherAttendanceCenterID")]
public int? OtherAttendanceCenterID {get; set;}
[Column(name:"OtherDistrictID")]
public int? OtherDistrictID {get; set;}
[Column(name:"PositionCodeID")]
public int? PositionCodeID {get; set;}
[Column(name:"PRFAssignmentImportLogID")]
public int? PRFAssignmentImportLogID {get; set;}
[Column(name:"PRFID")]
public int? PRFID {get; set;}
[Column(name:"Qtr1")]
[StringLength(1)]
public string Qtr1 {get; set;}
[Column(name:"Qtr2")]
[StringLength(1)]
public string Qtr2 {get; set;}
[Column(name:"Qtr3")]
[StringLength(1)]
public string Qtr3 {get; set;}
[Column(name:"Qtr4")]
[StringLength(1)]
public string Qtr4 {get; set;}
[Column(name:"RawLine")]
[StringLength(100)]
public string RawLine {get; set;}
[Column(name:"SPEDIndicator")]
[StringLength(1)]
public string SPEDIndicator {get; set;}
[Column(name:"Trimester1")]
[StringLength(1)]
public string Trimester1 {get; set;}
[Column(name:"Trimester2")]
[StringLength(1)]
public string Trimester2 {get; set;}
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
