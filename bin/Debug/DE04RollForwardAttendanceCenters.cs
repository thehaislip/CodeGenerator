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
[Table("DE04RollForwardAttendanceCenters")]
public partial class DE04RollForwardAttendanceCenters
:IAuditable{ 
public DE04RollForwardAttendanceCenters()
{
}
[Column(name:"BegGradeSpan")]
[StringLength(50)]
public string BegGradeSpan {get; set;}
[Column(name:"DistrictNumber")]
[StringLength(50)]
public string DistrictNumber {get; set;}
[Column(name:"EndingGradeSpan")]
[StringLength(50)]
public string EndingGradeSpan {get; set;}
[Column(name:"ID")]
[StringLength(50)]
public string ID {get; set;}
[Column(name:"SchoolName")]
[StringLength(80)]
public string SchoolName {get; set;}
[Column(name:"SchoolNumber")]
[StringLength(50)]
public string SchoolNumber {get; set;}
[Column(name:"SortCode")]
[StringLength(50)]
public string SortCode {get; set;}
}
[Table("DE04RollForwardAttendanceCentersAudit")]
public partial class DE04RollForwardAttendanceCentersAudit
:IAudit{ 
public DE04RollForwardAttendanceCentersAudit()
{
}
[Column(name:"BegGradeSpan")]
[StringLength(50)]
public string BegGradeSpan {get; set;}
[Column(name:"DistrictNumber")]
[StringLength(50)]
public string DistrictNumber {get; set;}
[Column(name:"EndingGradeSpan")]
[StringLength(50)]
public string EndingGradeSpan {get; set;}
[Column(name:"ID")]
[StringLength(50)]
public string ID {get; set;}
[Column(name:"SchoolName")]
[StringLength(80)]
public string SchoolName {get; set;}
[Column(name:"SchoolNumber")]
[StringLength(50)]
public string SchoolNumber {get; set;}
[Column(name:"SortCode")]
[StringLength(50)]
public string SortCode {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
