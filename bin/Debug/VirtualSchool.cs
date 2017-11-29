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
[Table("VirtualSchool")]
public partial class VirtualSchool
:IAuditable{ 
public VirtualSchool()
{
this.VSCourses = new HashSet<VSCourse>();
this.VSCourse2016s = new HashSet<VSCourse2016>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"DistSSID")]
public int DistSSID {get; set;}
[Required]
[Column(name:"HasCourses")]
[StringLength(1)]
public string HasCourses {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("DistSSID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("VirtualSchoolID")]
public virtual ICollection<VSCourse> VSCourses{get; set;}
[ForeignKey("VirtualSchoolID")]
public virtual ICollection<VSCourse2016> VSCourse2016s{get; set;}
}
[Table("VirtualSchoolAudit")]
public partial class VirtualSchoolAudit
:IAudit{ 
public VirtualSchoolAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"DistSSID")]
public int DistSSID {get; set;}
[Required]
[Column(name:"HasCourses")]
[StringLength(1)]
public string HasCourses {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
