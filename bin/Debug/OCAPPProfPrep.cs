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
[Table("OCAPPProfPrep")]
public partial class OCAPPProfPrep
:IAuditable{ 
public OCAPPProfPrep()
{
this.OCAPPProfPrepCns = new HashSet<OCAPPProfPrepCn>();
}
[Column(name:"AdministrativeRuleLink")]
[StringLength(200)]
public string AdministrativeRuleLink {get; set;}
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
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"RequirementsDescription")]
[StringLength(2000)]
public string RequirementsDescription {get; set;}
[Column(name:"UCOSignoffRequired")]
[StringLength(1)]
public string UCOSignoffRequired {get; set;}
[Column(name:"VerifyExperience")]
[StringLength(1)]
public string VerifyExperience {get; set;}
[ForeignKey("ProfPrepID")]
public virtual ICollection<OCAPPProfPrepCn> OCAPPProfPrepCns{get; set;}
}
[Table("OCAPPProfPrepAudit")]
public partial class OCAPPProfPrepAudit
:IAudit{ 
public OCAPPProfPrepAudit()
{
}
[Column(name:"AdministrativeRuleLink")]
[StringLength(200)]
public string AdministrativeRuleLink {get; set;}
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
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"RequirementsDescription")]
[StringLength(2000)]
public string RequirementsDescription {get; set;}
[Column(name:"UCOSignoffRequired")]
[StringLength(1)]
public string UCOSignoffRequired {get; set;}
[Column(name:"VerifyExperience")]
[StringLength(1)]
public string VerifyExperience {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
