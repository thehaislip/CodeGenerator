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
[Table("Address")]
public partial class Address
:IAuditable{ 
public Address()
{
}
[Column(name:"Address1")]
[StringLength(40)]
public string Address1 {get; set;}
[Column(name:"Address2")]
[StringLength(40)]
public string Address2 {get; set;}
[Column(name:"City")]
[StringLength(40)]
public string City {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonneID")]
public int? PersonneID {get; set;}
[Column(name:"State")]
[StringLength(40)]
public string State {get; set;}
[Column(name:"Zip")]
[StringLength(10)]
public string Zip {get; set;}
[ForeignKey("PersonneID")]
public virtual COMMPerson COMMPerson{get; set;}
}
[Table("AddressAudit")]
public partial class AddressAudit
:IAudit{ 
public AddressAudit()
{
}
[Column(name:"Address1")]
[StringLength(40)]
public string Address1 {get; set;}
[Column(name:"Address2")]
[StringLength(40)]
public string Address2 {get; set;}
[Column(name:"City")]
[StringLength(40)]
public string City {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PersonneID")]
public int? PersonneID {get; set;}
[Column(name:"State")]
[StringLength(40)]
public string State {get; set;}
[Column(name:"Zip")]
[StringLength(10)]
public string Zip {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
