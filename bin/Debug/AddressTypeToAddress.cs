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
[Table("AddressTypeToAddress")]
public partial class AddressTypeToAddress
:IAuditable{ 
public AddressTypeToAddress()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"ObjectID")]
public int ObjectID {get; set;}
[Required]
[Column(name:"TypeID")]
public int TypeID {get; set;}
[ForeignKey("TypeID")]
public virtual AddressType AddressType{get; set;}
}
[Table("AddressTypeToAddressAudit")]
public partial class AddressTypeToAddressAudit
:IAudit{ 
public AddressTypeToAddressAudit()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"ObjectID")]
public int ObjectID {get; set;}
[Required]
[Column(name:"TypeID")]
public int TypeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
