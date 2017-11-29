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
[Table("PRFImportControlTotals")]
public partial class PRFImportControlTotals
:IAuditable{ 
public PRFImportControlTotals()
{
}
[Column(name:"AssignmentRecordsDeleted")]
public int? AssignmentRecordsDeleted {get; set;}
[Column(name:"AssignmentRecordsInserted")]
public int? AssignmentRecordsInserted {get; set;}
[Column(name:"BVIIndicatorRecordsDeleted")]
public int? BVIIndicatorRecordsDeleted {get; set;}
[Column(name:"BVIIndicatorRecordsInserted")]
public int? BVIIndicatorRecordsInserted {get; set;}
[Column(name:"DHIIndicatorRecordsDeleted")]
public int? DHIIndicatorRecordsDeleted {get; set;}
[Column(name:"DHIIndicatorRecordsInserted")]
public int? DHIIndicatorRecordsInserted {get; set;}
[Column(name:"ESLIndicatorRecordsDeleted")]
public int? ESLIndicatorRecordsDeleted {get; set;}
[Column(name:"ESLIndicatorRecordsInserted")]
public int? ESLIndicatorRecordsInserted {get; set;}
[Column(name:"FederalEthnicityRecordsDeleted")]
public int? FederalEthnicityRecordsDeleted {get; set;}
[Column(name:"FederalEthnicityRecordsInserted")]
public int? FederalEthnicityRecordsInserted {get; set;}
[Column(name:"FederalHispanicRecordsUpdated")]
public int? FederalHispanicRecordsUpdated {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ImportLogID")]
public int? ImportLogID {get; set;}
[Column(name:"POIRecordsDeleted")]
public int? POIRecordsDeleted {get; set;}
[Column(name:"SPEDIndicatorRecordsDeleted")]
public int? SPEDIndicatorRecordsDeleted {get; set;}
[Column(name:"SPEDIndicatorRecordsInserted")]
public int? SPEDIndicatorRecordsInserted {get; set;}
[Column(name:"StaffRecordsDeleted")]
public int? StaffRecordsDeleted {get; set;}
[Column(name:"StaffRecordsInserted")]
public int? StaffRecordsInserted {get; set;}
[Column(name:"UploadType")]
[StringLength(10)]
public string UploadType {get; set;}
[Column(name:"VacancyRecordsDeleted")]
public int? VacancyRecordsDeleted {get; set;}
[Column(name:"VacancyRecordsInserted")]
public int? VacancyRecordsInserted {get; set;}
}
[Table("PRFImportControlTotalsAudit")]
public partial class PRFImportControlTotalsAudit
:IAudit{ 
public PRFImportControlTotalsAudit()
{
}
[Column(name:"AssignmentRecordsDeleted")]
public int? AssignmentRecordsDeleted {get; set;}
[Column(name:"AssignmentRecordsInserted")]
public int? AssignmentRecordsInserted {get; set;}
[Column(name:"BVIIndicatorRecordsDeleted")]
public int? BVIIndicatorRecordsDeleted {get; set;}
[Column(name:"BVIIndicatorRecordsInserted")]
public int? BVIIndicatorRecordsInserted {get; set;}
[Column(name:"DHIIndicatorRecordsDeleted")]
public int? DHIIndicatorRecordsDeleted {get; set;}
[Column(name:"DHIIndicatorRecordsInserted")]
public int? DHIIndicatorRecordsInserted {get; set;}
[Column(name:"ESLIndicatorRecordsDeleted")]
public int? ESLIndicatorRecordsDeleted {get; set;}
[Column(name:"ESLIndicatorRecordsInserted")]
public int? ESLIndicatorRecordsInserted {get; set;}
[Column(name:"FederalEthnicityRecordsDeleted")]
public int? FederalEthnicityRecordsDeleted {get; set;}
[Column(name:"FederalEthnicityRecordsInserted")]
public int? FederalEthnicityRecordsInserted {get; set;}
[Column(name:"FederalHispanicRecordsUpdated")]
public int? FederalHispanicRecordsUpdated {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ImportLogID")]
public int? ImportLogID {get; set;}
[Column(name:"POIRecordsDeleted")]
public int? POIRecordsDeleted {get; set;}
[Column(name:"SPEDIndicatorRecordsDeleted")]
public int? SPEDIndicatorRecordsDeleted {get; set;}
[Column(name:"SPEDIndicatorRecordsInserted")]
public int? SPEDIndicatorRecordsInserted {get; set;}
[Column(name:"StaffRecordsDeleted")]
public int? StaffRecordsDeleted {get; set;}
[Column(name:"StaffRecordsInserted")]
public int? StaffRecordsInserted {get; set;}
[Column(name:"UploadType")]
[StringLength(10)]
public string UploadType {get; set;}
[Column(name:"VacancyRecordsDeleted")]
public int? VacancyRecordsDeleted {get; set;}
[Column(name:"VacancyRecordsInserted")]
public int? VacancyRecordsInserted {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
