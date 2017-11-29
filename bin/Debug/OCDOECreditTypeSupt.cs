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
[Table("OCDOECreditTypeSupt")]
public partial class OCDOECreditTypeSupt
:IAuditable{ 
public OCDOECreditTypeSupt()
{
this.OCAPPRenewalCredits = new HashSet<OCAPPRenewalCredit>();
}
[Column(name:"Code")]
[StringLength(50)]
public string Code {get; set;}
[Column(name:"Description")]
[StringLength(200)]
public string Description {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ShortDescription")]
[StringLength(50)]
public string ShortDescription {get; set;}
[ForeignKey("CreditTypeID")]
public virtual ICollection<OCAPPRenewalCredit> OCAPPRenewalCredits{get; set;}
}
[Table("OCDOECreditTypeSuptAudit")]
public partial class OCDOECreditTypeSuptAudit
:IAudit{ 
public OCDOECreditTypeSuptAudit()
{
}
[Column(name:"Code")]
[StringLength(50)]
public string Code {get; set;}
[Column(name:"Description")]
[StringLength(200)]
public string Description {get; set;}
[Column(name:"DisplayOrder")]
public int? DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ShortDescription")]
[StringLength(50)]
public string ShortDescription {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
