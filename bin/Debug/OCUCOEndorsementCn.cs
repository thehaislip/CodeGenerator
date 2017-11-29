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
[Table("OCUCOEndorsementCn")]
public partial class OCUCOEndorsementCn
:IAuditable{ 
public OCUCOEndorsementCn()
{
}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"CourseworkRequirement")]
public bool? CourseworkRequirement {get; set;}
[Required]
[Column(name:"EndorsementID")]
public int EndorsementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"MajorRequirement")]
public bool? MajorRequirement {get; set;}
[Column(name:"StateTestRequirement")]
public bool? StateTestRequirement {get; set;}
[Required]
[Column(name:"UCOProfileIID")]
public int UCOProfileIID {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("EndorsementID")]
public virtual Endorsement Endorsement{get; set;}
[ForeignKey("UCOProfileIID")]
public virtual OCUCOProfile OCUCOProfile{get; set;}
}
[Table("OCUCOEndorsementCnAudit")]
public partial class OCUCOEndorsementCnAudit
:IAudit{ 
public OCUCOEndorsementCnAudit()
{
}
[Required]
[Column(name:"AppID")]
public int AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"CourseworkRequirement")]
public bool? CourseworkRequirement {get; set;}
[Required]
[Column(name:"EndorsementID")]
public int EndorsementID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"MajorRequirement")]
public bool? MajorRequirement {get; set;}
[Column(name:"StateTestRequirement")]
public bool? StateTestRequirement {get; set;}
[Required]
[Column(name:"UCOProfileIID")]
public int UCOProfileIID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
