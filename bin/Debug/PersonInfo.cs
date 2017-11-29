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
[Table("PersonInfo")]
public partial class PersonInfo
:IAuditable{ 
public PersonInfo()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Country")]
[StringLength(30)]
public string Country {get; set;}
[Required]
[Column(name:"DayPhone")]
[StringLength(10)]
public string DayPhone {get; set;}
[Required]
[Column(name:"EmailAddress")]
[StringLength(100)]
public string EmailAddress {get; set;}
[Required]
[Column(name:"EveningPhone")]
[StringLength(10)]
public string EveningPhone {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
}
[Table("PersonInfoAudit")]
public partial class PersonInfoAudit
:IAudit{ 
public PersonInfoAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Country")]
[StringLength(30)]
public string Country {get; set;}
[Required]
[Column(name:"DayPhone")]
[StringLength(10)]
public string DayPhone {get; set;}
[Required]
[Column(name:"EmailAddress")]
[StringLength(100)]
public string EmailAddress {get; set;}
[Required]
[Column(name:"EveningPhone")]
[StringLength(10)]
public string EveningPhone {get; set;}
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
