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
[Table("OCDOETranscriptMatchLog")]
public partial class OCDOETranscriptMatchLog
:IAuditable{ 
public OCDOETranscriptMatchLog()
{
}
[Column(name:"DateMatched",TypeName = "datetime2")]
public DateTime? DateMatched {get; set;}
[Column(name:"FileName")]
[StringLength(40)]
public string FileName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"StampUser")]
[StringLength(15)]
public string StampUser {get; set;}
}
[Table("OCDOETranscriptMatchLogAudit")]
public partial class OCDOETranscriptMatchLogAudit
:IAudit{ 
public OCDOETranscriptMatchLogAudit()
{
}
[Column(name:"DateMatched",TypeName = "datetime2")]
public DateTime? DateMatched {get; set;}
[Column(name:"FileName")]
[StringLength(40)]
public string FileName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"StampUser")]
[StringLength(15)]
public string StampUser {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
}
}
