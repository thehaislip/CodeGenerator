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
[Table("VSCourse2016")]
public partial class VSCourse2016
:IAuditable{ 
public VSCourse2016()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"StudentCnt")]
public int StudentCnt {get; set;}
[Required]
[Column(name:"VirtualSchoolID")]
public int VirtualSchoolID {get; set;}
[Required]
[Column(name:"VSCourseID")]
public int VSCourseID {get; set;}
[Required]
[Column(name:"VSSchoolTypeID")]
public int VSSchoolTypeID {get; set;}
[ForeignKey("VirtualSchoolID")]
public virtual VirtualSchool VirtualSchool{get; set;}
[ForeignKey("VSCourseID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("VSSchoolTypeID")]
public virtual CommLookupType CommLookupType{get; set;}
}
[Table("VSCourse2016Audit")]
public partial class VSCourse2016Audit
:IAudit{ 
public VSCourse2016Audit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"StudentCnt")]
public int StudentCnt {get; set;}
[Required]
[Column(name:"VirtualSchoolID")]
public int VirtualSchoolID {get; set;}
[Required]
[Column(name:"VSCourseID")]
public int VSCourseID {get; set;}
[Required]
[Column(name:"VSSchoolTypeID")]
public int VSSchoolTypeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
