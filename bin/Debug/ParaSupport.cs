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
[Table("ParaSupport")]
public partial class ParaSupport
:IAuditable{ 
public ParaSupport()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Paraprof")]
[StringLength(50)]
public string Paraprof {get; set;}
[Column(name:"ParaType")]
[StringLength(50)]
public string ParaType {get; set;}
}
[Table("ParaSupportAudit")]
public partial class ParaSupportAudit
:IAudit{ 
public ParaSupportAudit()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Paraprof")]
[StringLength(50)]
public string Paraprof {get; set;}
[Column(name:"ParaType")]
[StringLength(50)]
public string ParaType {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
