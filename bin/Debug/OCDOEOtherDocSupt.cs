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
[Table("OCDOEOtherDocSupt")]
public partial class OCDOEOtherDocSupt
:IAuditable{ 
public OCDOEOtherDocSupt()
{
}
[Column(name:"Code")]
[StringLength(2)]
public string Code {get; set;}
[Column(name:"Description")]
[StringLength(200)]
public string Description {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Link")]
[StringLength(200)]
public string Link {get; set;}
[Column(name:"ShortDescription")]
[StringLength(60)]
public string ShortDescription {get; set;}
}
[Table("OCDOEOtherDocSuptAudit")]
public partial class OCDOEOtherDocSuptAudit
:IAudit{ 
public OCDOEOtherDocSuptAudit()
{
}
[Column(name:"Code")]
[StringLength(2)]
public string Code {get; set;}
[Column(name:"Description")]
[StringLength(200)]
public string Description {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Link")]
[StringLength(200)]
public string Link {get; set;}
[Column(name:"ShortDescription")]
[StringLength(60)]
public string ShortDescription {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
