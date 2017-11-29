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
[Table("PersonFlagged")]
public partial class PersonFlagged
:IAuditable{ 
public PersonFlagged()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"FlagAddedBy")]
[StringLength(60)]
public string FlagAddedBy {get; set;}
[Column(name:"FlagDate",TypeName = "datetime2")]
public DateTime? FlagDate {get; set;}
[Required]
[Column(name:"FlagTypeCode")]
[StringLength(2)]
public string FlagTypeCode {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[ForeignKey("PersonnelID")]
public virtual COMMPerson COMMPerson{get; set;}
}
[Table("PersonFlaggedAudit")]
public partial class PersonFlaggedAudit
:IAudit{ 
public PersonFlaggedAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"FlagAddedBy")]
[StringLength(60)]
public string FlagAddedBy {get; set;}
[Column(name:"FlagDate",TypeName = "datetime2")]
public DateTime? FlagDate {get; set;}
[Required]
[Column(name:"FlagTypeCode")]
[StringLength(2)]
public string FlagTypeCode {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
