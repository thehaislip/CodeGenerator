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
[Table("AssurDsQ")]
public partial class AssurDsQ
:IAuditable{ 
public AssurDsQ()
{
}
[Required]
[Column(name:"Answer")]
[StringLength(1)]
public string Answer {get; set;}
[Column(name:"AssurQuesID")]
public int? AssurQuesID {get; set;}
[Required]
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistID")]
public int? DistID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("AssurQuesID")]
public virtual AssurQues AssurQues{get; set;}
[ForeignKey("DistID")]
public virtual DistSS DistSS{get; set;}
}
[Table("AssurDsQAudit")]
public partial class AssurDsQAudit
:IAudit{ 
public AssurDsQAudit()
{
}
[Required]
[Column(name:"Answer")]
[StringLength(1)]
public string Answer {get; set;}
[Column(name:"AssurQuesID")]
public int? AssurQuesID {get; set;}
[Required]
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistID")]
public int? DistID {get; set;}
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
