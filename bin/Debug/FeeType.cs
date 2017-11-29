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
[Table("FeeType")]
public partial class FeeType
:IAuditable{ 
public FeeType()
{
this.OCAPPProcessingFees = new HashSet<OCAPPProcessingFee>();
this.FeeTypeToCertificateTypes = new HashSet<FeeTypeToCertificateType>();
}
[Required]
[Column(name:"Amount")]
public double Amount {get; set;}
[Column(name:"AnswerID")]
public int? AnswerID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(250)]
public string Description {get; set;}
[Column(name:"EffectiveEndDate",TypeName = "datetime2")]
public DateTime? EffectiveEndDate {get; set;}
[Required]
[Column(name:"EffectiveStartDate",TypeName = "datetime2")]
public DateTime EffectiveStartDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"Name")]
[StringLength(50)]
public string Name {get; set;}
[ForeignKey("AnswerID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("FeeID")]
public virtual ICollection<OCAPPProcessingFee> OCAPPProcessingFees{get; set;}
[ForeignKey("FeeTypeID")]
public virtual ICollection<FeeTypeToCertificateType> FeeTypeToCertificateTypes{get; set;}
}
[Table("FeeTypeAudit")]
public partial class FeeTypeAudit
:IAudit{ 
public FeeTypeAudit()
{
}
[Required]
[Column(name:"Amount")]
public double Amount {get; set;}
[Column(name:"AnswerID")]
public int? AnswerID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(250)]
public string Description {get; set;}
[Column(name:"EffectiveEndDate",TypeName = "datetime2")]
public DateTime? EffectiveEndDate {get; set;}
[Required]
[Column(name:"EffectiveStartDate",TypeName = "datetime2")]
public DateTime EffectiveStartDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"Name")]
[StringLength(50)]
public string Name {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
