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
[Table("AddressType")]
public partial class AddressType
:IAuditable{ 
public AddressType()
{
this.AddressTypeToAddresss = new HashSet<AddressTypeToAddress>();
}
[Required]
[Column(name:"BriefDescription")]
[StringLength(80)]
public string BriefDescription {get; set;}
[Required]
[Column(name:"ConcurrencyID")]
public int ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"KeyPrefix")]
[StringLength(10)]
public string KeyPrefix {get; set;}
[Required]
[Column(name:"Name")]
[StringLength(80)]
public string Name {get; set;}
[ForeignKey("TypeID")]
public virtual ICollection<AddressTypeToAddress> AddressTypeToAddresss{get; set;}
}
[Table("AddressTypeAudit")]
public partial class AddressTypeAudit
:IAudit{ 
public AddressTypeAudit()
{
}
[Required]
[Column(name:"BriefDescription")]
[StringLength(80)]
public string BriefDescription {get; set;}
[Required]
[Column(name:"ConcurrencyID")]
public int ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"KeyPrefix")]
[StringLength(10)]
public string KeyPrefix {get; set;}
[Required]
[Column(name:"Name")]
[StringLength(80)]
public string Name {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
