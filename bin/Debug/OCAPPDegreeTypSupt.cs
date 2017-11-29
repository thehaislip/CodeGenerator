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
[Table("OCAPPDegreeTypSupt")]
public partial class OCAPPDegreeTypSupt
:IAuditable{ 
public OCAPPDegreeTypSupt()
{
this.OCUCOEducations = new HashSet<OCUCOEducation>();
this.OCAPPAppEducs = new HashSet<OCAPPAppEduc>();
}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("DegreeTypeID")]
public virtual ICollection<OCUCOEducation> OCUCOEducations{get; set;}
[ForeignKey("DegreeTypeID")]
public virtual ICollection<OCAPPAppEduc> OCAPPAppEducs{get; set;}
}
[Table("OCAPPDegreeTypSuptAudit")]
public partial class OCAPPDegreeTypSuptAudit
:IAudit{ 
public OCAPPDegreeTypSuptAudit()
{
}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
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
