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
[Table("OCAPPConReviewSup")]
public partial class OCAPPConReviewSup
:IAuditable{ 
public OCAPPConReviewSup()
{
this.OCAPPConReviewCns = new HashSet<OCAPPConReviewCn>();
this.OCDOEConReviewCns = new HashSet<OCDOEConReviewCn>();
this.OCAPPConReviewAppTypeCns = new HashSet<OCAPPConReviewAppTypeCn>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"QuestionHTML")]
[StringLength(2400)]
public string QuestionHTML {get; set;}
[Required]
[Column(name:"RequiresCourtDocumentation")]
[StringLength(1)]
public string RequiresCourtDocumentation {get; set;}
[Required]
[Column(name:"RequiresReviewIfYes")]
[StringLength(1)]
public string RequiresReviewIfYes {get; set;}
[Column(name:"YesResponseInstructionsHTML")]
[StringLength(2000)]
public string YesResponseInstructionsHTML {get; set;}
[ForeignKey("ConductReviewQuestionID")]
public virtual ICollection<OCAPPConReviewCn> OCAPPConReviewCns{get; set;}
[ForeignKey("ConductReviewQuestionID")]
public virtual ICollection<OCDOEConReviewCn> OCDOEConReviewCns{get; set;}
[ForeignKey("ConductReviewQuestionID")]
public virtual ICollection<OCAPPConReviewAppTypeCn> OCAPPConReviewAppTypeCns{get; set;}
}
[Table("OCAPPConReviewSupAudit")]
public partial class OCAPPConReviewSupAudit
:IAudit{ 
public OCAPPConReviewSupAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisabled",TypeName = "datetime2")]
public DateTime? DateDisabled {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"QuestionHTML")]
[StringLength(2400)]
public string QuestionHTML {get; set;}
[Required]
[Column(name:"RequiresCourtDocumentation")]
[StringLength(1)]
public string RequiresCourtDocumentation {get; set;}
[Required]
[Column(name:"RequiresReviewIfYes")]
[StringLength(1)]
public string RequiresReviewIfYes {get; set;}
[Column(name:"YesResponseInstructionsHTML")]
[StringLength(2000)]
public string YesResponseInstructionsHTML {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
