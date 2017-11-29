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
[Table("CDstSort")]
public partial class CDstSort
:IAuditable{ 
public CDstSort()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SortCodeID")]
public int? SortCodeID {get; set;}
}
[Table("CDstSortAudit")]
public partial class CDstSortAudit
:IAudit{ 
public CDstSortAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SortCodeID")]
public int? SortCodeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
