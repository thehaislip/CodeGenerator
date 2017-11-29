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
[Table("GradUnit")]
public partial class GradUnit
:IAuditable{ 
public GradUnit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Column(name:"GradRASSID")]
public int? GradRASSID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"isPRF")]
[StringLength(1)]
public string IsPRF {get; set;}
[Column(name:"OptionID")]
public int? OptionID {get; set;}
[Column(name:"ParentAssign")]
public int? ParentAssign {get; set;}
[Required]
[Column(name:"SchoolInfor")]
[StringLength(80)]
public string SchoolInfor {get; set;}
[Column(name:"Units",TypeName = "money")]
public decimal? Units {get; set;}
[ForeignKey("DistrictID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("GradRASSID")]
public virtual GradRASS GradRASS{get; set;}
[ForeignKey("OptionID")]
public virtual GradOpts GradOpts{get; set;}
}
[Table("GradUnitAudit")]
public partial class GradUnitAudit
:IAudit{ 
public GradUnitAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictID")]
public int? DistrictID {get; set;}
[Column(name:"GradRASSID")]
public int? GradRASSID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"isPRF")]
[StringLength(1)]
public string IsPRF {get; set;}
[Column(name:"OptionID")]
public int? OptionID {get; set;}
[Column(name:"ParentAssign")]
public int? ParentAssign {get; set;}
[Required]
[Column(name:"SchoolInfor")]
[StringLength(80)]
public string SchoolInfor {get; set;}
[Column(name:"Units",TypeName = "money")]
public decimal? Units {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
