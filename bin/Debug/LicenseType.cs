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
[Table("LicenseType")]
public partial class LicenseType
:IAuditable{ 
public LicenseType()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EffectiveEndDate",TypeName = "datetime2")]
public DateTime? EffectiveEndDate {get; set;}
[Column(name:"EffectiveStartDate",TypeName = "datetime2")]
public DateTime? EffectiveStartDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"LicenseNumber")]
public int? LicenseNumber {get; set;}
[Column(name:"LicenseTypeID")]
public int? LicenseTypeID {get; set;}
}
[Table("LicenseTypeAudit")]
public partial class LicenseTypeAudit
:IAudit{ 
public LicenseTypeAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"EffectiveEndDate",TypeName = "datetime2")]
public DateTime? EffectiveEndDate {get; set;}
[Column(name:"EffectiveStartDate",TypeName = "datetime2")]
public DateTime? EffectiveStartDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"LicenseNumber")]
public int? LicenseNumber {get; set;}
[Column(name:"LicenseTypeID")]
public int? LicenseTypeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
