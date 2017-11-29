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
[Table("RevkDriv")]
public partial class RevkDriv
:IAuditable{ 
public RevkDriv()
{
}
[Required]
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(60)]
public string LastName {get; set;}
[Column(name:"LiceseStatus")]
public int? LiceseStatus {get; set;}
[Required]
[Column(name:"MiddleName")]
[StringLength(60)]
public string MiddleName {get; set;}
[Column(name:"RecivedDate",TypeName = "datetime2")]
public DateTime? RecivedDate {get; set;}
[Column(name:"SentDate",TypeName = "datetime2")]
public DateTime? SentDate {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[ForeignKey("LiceseStatus")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("RevkDrivAudit")]
public partial class RevkDrivAudit
:IAudit{ 
public RevkDrivAudit()
{
}
[Required]
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(60)]
public string LastName {get; set;}
[Column(name:"LiceseStatus")]
public int? LiceseStatus {get; set;}
[Required]
[Column(name:"MiddleName")]
[StringLength(60)]
public string MiddleName {get; set;}
[Column(name:"RecivedDate",TypeName = "datetime2")]
public DateTime? RecivedDate {get; set;}
[Column(name:"SentDate",TypeName = "datetime2")]
public DateTime? SentDate {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
