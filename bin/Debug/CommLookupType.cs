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
[Table("CommLookupType")]
public partial class CommLookupType
:IAuditable{ 
public CommLookupType()
{
this.CommLookupTypeToCommLookups = new HashSet<CommLookupTypeToCommLookup>();
this.Degrees = new HashSet<Degree>();
this.Qualifications = new HashSet<Qualification>();
this.VSCourse2016s = new HashSet<VSCourse2016>();
this.Questions = new HashSet<Question>();
}
[Required]
[Column(name:"BriefDescription")]
[StringLength(80)]
public string BriefDescription {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"KeyPrefix")]
[StringLength(15)]
public string KeyPrefix {get; set;}
[Required]
[Column(name:"Name")]
[StringLength(80)]
public string Name {get; set;}
[ForeignKey("CommLookupTypeID")]
public virtual ICollection<CommLookupTypeToCommLookup> CommLookupTypeToCommLookups{get; set;}
[ForeignKey("MajMinTypeID")]
public virtual ICollection<Degree> Degrees{get; set;}
[ForeignKey("LookupTypeID")]
public virtual ICollection<Qualification> Qualifications{get; set;}
[ForeignKey("VSSchoolTypeID")]
public virtual ICollection<VSCourse2016> VSCourse2016s{get; set;}
[ForeignKey("CommLookupTypeID")]
public virtual ICollection<Question> Questions{get; set;}
}
[Table("CommLookupTypeAudit")]
public partial class CommLookupTypeAudit
:IAudit{ 
public CommLookupTypeAudit()
{
}
[Required]
[Column(name:"BriefDescription")]
[StringLength(80)]
public string BriefDescription {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"KeyPrefix")]
[StringLength(15)]
public string KeyPrefix {get; set;}
[Required]
[Column(name:"Name")]
[StringLength(80)]
public string Name {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
