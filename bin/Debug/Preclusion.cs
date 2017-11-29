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
[Table("Preclusion")]
public partial class Preclusion
:IAuditable{ 
public Preclusion()
{
}
[Required]
[Column(name:"Comments")]
[StringLength(255)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"TargetID")]
public int? TargetID {get; set;}
[Required]
[Column(name:"TargetType")]
[StringLength(2)]
public string TargetType {get; set;}
[Column(name:"WouldPrecludeID")]
public int? WouldPrecludeID {get; set;}
[Required]
[Column(name:"WouldPrecludeType")]
[StringLength(2)]
public string WouldPrecludeType {get; set;}
}
[Table("PreclusionAudit")]
public partial class PreclusionAudit
:IAudit{ 
public PreclusionAudit()
{
}
[Required]
[Column(name:"Comments")]
[StringLength(255)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"TargetID")]
public int? TargetID {get; set;}
[Required]
[Column(name:"TargetType")]
[StringLength(2)]
public string TargetType {get; set;}
[Column(name:"WouldPrecludeID")]
public int? WouldPrecludeID {get; set;}
[Required]
[Column(name:"WouldPrecludeType")]
[StringLength(2)]
public string WouldPrecludeType {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
