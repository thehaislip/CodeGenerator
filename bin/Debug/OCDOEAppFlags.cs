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
[Table("OCDOEAppFlags")]
public partial class OCDOEAppFlags
:IAuditable{ 
public OCDOEAppFlags()
{
}
[Required]
[Column(name:"ApplicationID")]
public int ApplicationID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"FlagDate",TypeName = "datetime2")]
public DateTime? FlagDate {get; set;}
[Required]
[Column(name:"FlaggedBy")]
[StringLength(60)]
public string FlaggedBy {get; set;}
[Required]
[Column(name:"FlagTypeCode")]
[StringLength(2)]
public string FlagTypeCode {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("ApplicationID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
}
[Table("OCDOEAppFlagsAudit")]
public partial class OCDOEAppFlagsAudit
:IAudit{ 
public OCDOEAppFlagsAudit()
{
}
[Required]
[Column(name:"ApplicationID")]
public int ApplicationID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"FlagDate",TypeName = "datetime2")]
public DateTime? FlagDate {get; set;}
[Required]
[Column(name:"FlaggedBy")]
[StringLength(60)]
public string FlaggedBy {get; set;}
[Required]
[Column(name:"FlagTypeCode")]
[StringLength(2)]
public string FlagTypeCode {get; set;}
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
