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
[Table("DE04CommLookupTypeToCommLookup")]
public partial class DE04CommLookupTypeToCommLookup
:IAuditable{ 
public DE04CommLookupTypeToCommLookup()
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
}
[Table("DE04CommLookupTypeToCommLookupAudit")]
public partial class DE04CommLookupTypeToCommLookupAudit
:IAudit{ 
public DE04CommLookupTypeToCommLookupAudit()
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
