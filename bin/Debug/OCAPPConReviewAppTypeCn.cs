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
[Table("OCAPPConReviewAppTypeCn")]
public partial class OCAPPConReviewAppTypeCn
:IAuditable{ 
public OCAPPConReviewAppTypeCn()
{
}
[Column(name:"AppTypeID")]
public int? AppTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ConductReviewQuestionID")]
public int? ConductReviewQuestionID {get; set;}
[Required]
[Column(name:"DisplayOrder")]
[StringLength(10)]
public string DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("AppTypeID")]
public virtual ApplicationType ApplicationType{get; set;}
[ForeignKey("ConductReviewQuestionID")]
public virtual OCAPPConReviewSup OCAPPConReviewSup{get; set;}
}
[Table("OCAPPConReviewAppTypeCnAudit")]
public partial class OCAPPConReviewAppTypeCnAudit
:IAudit{ 
public OCAPPConReviewAppTypeCnAudit()
{
}
[Column(name:"AppTypeID")]
public int? AppTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ConductReviewQuestionID")]
public int? ConductReviewQuestionID {get; set;}
[Required]
[Column(name:"DisplayOrder")]
[StringLength(10)]
public string DisplayOrder {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
