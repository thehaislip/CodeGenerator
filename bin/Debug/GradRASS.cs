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
[Table("GradRASS")]
public partial class GradRASS
:IAuditable{ 
public GradRASS()
{
this.GradUnits = new HashSet<GradUnit>();
}
[Column(name:"AssignID")]
public int? AssignID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"GradSubcatID")]
public int? GradSubcatID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"SchoolYear")]
[StringLength(4)]
public string SchoolYear {get; set;}
[ForeignKey("GradSubcatID")]
public virtual GradSCSS GradSCSS{get; set;}
[ForeignKey("GradRASSID")]
public virtual ICollection<GradUnit> GradUnits{get; set;}
}
[Table("GradRASSAudit")]
public partial class GradRASSAudit
:IAudit{ 
public GradRASSAudit()
{
}
[Column(name:"AssignID")]
public int? AssignID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"GradSubcatID")]
public int? GradSubcatID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"SchoolYear")]
[StringLength(4)]
public string SchoolYear {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
