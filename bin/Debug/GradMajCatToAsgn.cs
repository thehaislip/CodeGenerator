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
[Table("GradMajCatToAsgn")]
public partial class GradMajCatToAsgn
:IAuditable{ 
public GradMajCatToAsgn()
{
}
[Required]
[Column(name:"AssignmentCodeID")]
public int AssignmentCodeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"GradMajCatID")]
public int GradMajCatID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("GradMajCatID")]
public virtual CommLookup CommLookup1{get; set;}
[ForeignKey("ID")]
public virtual ICollection<GradMajCatToAsgn> SuperGradMajCatToAsgns{get; set;}
}
[Table("GradMajCatToAsgnAudit")]
public partial class GradMajCatToAsgnAudit
:IAudit{ 
public GradMajCatToAsgnAudit()
{
}
[Required]
[Column(name:"AssignmentCodeID")]
public int AssignmentCodeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"GradMajCatID")]
public int GradMajCatID {get; set;}
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
