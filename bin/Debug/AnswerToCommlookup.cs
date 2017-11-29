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
[Table("AnswerToCommlookup")]
public partial class AnswerToCommlookup
:IAuditable{ 
public AnswerToCommlookup()
{
}
[Required]
[Column(name:"AnswerID")]
public int AnswerID {get; set;}
[Column(name:"CommlookupID")]
public int? CommlookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"OtherText")]
[StringLength(500)]
public string OtherText {get; set;}
[ForeignKey("AnswerID")]
public virtual Answer Answer{get; set;}
[ForeignKey("CommlookupID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("AnswerToCommlookupAudit")]
public partial class AnswerToCommlookupAudit
:IAudit{ 
public AnswerToCommlookupAudit()
{
}
[Required]
[Column(name:"AnswerID")]
public int AnswerID {get; set;}
[Column(name:"CommlookupID")]
public int? CommlookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"OtherText")]
[StringLength(500)]
public string OtherText {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
