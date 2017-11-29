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
[Table("OCAppTypeSupt")]
public partial class OCAppTypeSupt
:IAuditable{ 
public OCAppTypeSupt()
{
this.OCAppDInfos = new HashSet<OCAppDInfo>();
this.OCDOESectionCategoryCompletionMatrixs = new HashSet<OCDOESectionCategoryCompletionMatrix>();
}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
[Column(name:"Fee",TypeName = "money")]
public decimal? Fee {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"NEWAPPTYPEID")]
public int? NEWAPPTYPEID {get; set;}
[Column(name:"OneYearFee",TypeName = "money")]
public decimal? OneYearFee {get; set;}
[Column(name:"TenYearFee",TypeName = "money")]
public decimal? TenYearFee {get; set;}
[Column(name:"TenYearReducedFee",TypeName = "money")]
public decimal? TenYearReducedFee {get; set;}
[ForeignKey("OldAppTypeID")]
public virtual ICollection<OCAppDInfo> OCAppDInfos{get; set;}
[ForeignKey("AppTypeID")]
public virtual ICollection<OCDOESectionCategoryCompletionMatrix> OCDOESectionCategoryCompletionMatrixs{get; set;}
}
[Table("OCAppTypeSuptAudit")]
public partial class OCAppTypeSuptAudit
:IAudit{ 
public OCAppTypeSuptAudit()
{
}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
[Column(name:"Fee",TypeName = "money")]
public decimal? Fee {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"NEWAPPTYPEID")]
public int? NEWAPPTYPEID {get; set;}
[Column(name:"OneYearFee",TypeName = "money")]
public decimal? OneYearFee {get; set;}
[Column(name:"TenYearFee",TypeName = "money")]
public decimal? TenYearFee {get; set;}
[Column(name:"TenYearReducedFee",TypeName = "money")]
public decimal? TenYearReducedFee {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
