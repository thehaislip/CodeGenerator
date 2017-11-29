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
[Table("VSCourse")]
public partial class VSCourse
:IAuditable{ 
public VSCourse()
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
[Column(name:"VSCntCrsID")]
public int VSCntCrsID {get; set;}
[Required]
[Column(name:"VSSchoolTypeID")]
public int VSSchoolTypeID {get; set;}
[ForeignKey("VirtualSchoolID")]
public virtual VirtualSchool VirtualSchool{get; set;}
[ForeignKey("VSCntCrsID")]
public virtual VSCntCrs VSCntCrs{get; set;}
[ForeignKey("VSSchoolTypeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("VSCourseAudit")]
public partial class VSCourseAudit
:IAudit{ 
public VSCourseAudit()
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
[Column(name:"VSCntCrsID")]
public int VSCntCrsID {get; set;}
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
