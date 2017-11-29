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
[Table("DE04RollForwardSortCodes")]
public partial class DE04RollForwardSortCodes
:IAuditable{ 
public DE04RollForwardSortCodes()
{
}
[Column(name:"DistrictNumber")]
[StringLength(50)]
public string DistrictNumber {get; set;}
[Column(name:"SortCode")]
[StringLength(50)]
public string SortCode {get; set;}
}
[Table("DE04RollForwardSortCodesAudit")]
public partial class DE04RollForwardSortCodesAudit
:IAudit{ 
public DE04RollForwardSortCodesAudit()
{
}
[Column(name:"DistrictNumber")]
[StringLength(50)]
public string DistrictNumber {get; set;}
[Column(name:"SortCode")]
[StringLength(50)]
public string SortCode {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
