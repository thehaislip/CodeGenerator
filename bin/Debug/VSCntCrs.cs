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
[Table("VSCntCrs")]
public partial class VSCntCrs
:IAuditable{ 
public VSCntCrs()
{
this.VSCourses = new HashSet<VSCourse>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"ContentAreaID")]
public int ContentAreaID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"VSCourseNameID")]
public int VSCourseNameID {get; set;}
[ForeignKey("ContentAreaID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("VSCntCrsID")]
public virtual ICollection<VSCourse> VSCourses{get; set;}
[ForeignKey("VSCourseNameID")]
public virtual CommLookup CommLookup1{get; set;}
}
[Table("VSCntCrsAudit")]
public partial class VSCntCrsAudit
:IAudit{ 
public VSCntCrsAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"ContentAreaID")]
public int ContentAreaID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"VSCourseNameID")]
public int VSCourseNameID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
