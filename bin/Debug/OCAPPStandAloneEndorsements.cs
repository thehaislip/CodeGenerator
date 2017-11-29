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
[Table("OCAPPStandAloneEndorsements")]
public partial class OCAPPStandAloneEndorsements
:IAuditable{ 
public OCAPPStandAloneEndorsements()
{
}
[Column(name:"CodeID")]
public int? CodeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"LevelIndicator")]
public int? LevelIndicator {get; set;}
[Column(name:"URL")]
[StringLength(200)]
public string URL {get; set;}
}
[Table("OCAPPStandAloneEndorsementsAudit")]
public partial class OCAPPStandAloneEndorsementsAudit
:IAudit{ 
public OCAPPStandAloneEndorsementsAudit()
{
}
[Column(name:"CodeID")]
public int? CodeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"LevelIndicator")]
public int? LevelIndicator {get; set;}
[Column(name:"URL")]
[StringLength(200)]
public string URL {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
