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
[Table("CorrDet")]
public partial class CorrDet
:IAuditable{ 
public CorrDet()
{
}
[Column(name:"AnalystID")]
public int? AnalystID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"CorrDate",TypeName = "datetime2")]
public DateTime? CorrDate {get; set;}
[Column(name:"CorrInfoID")]
public int? CorrInfoID {get; set;}
[Column(name:"CorrTypeID")]
public int? CorrTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"InsertedDate",TypeName = "datetime2")]
public DateTime InsertedDate {get; set;}
[Column(name:"LocationID")]
public int? LocationID {get; set;}
[Column(name:"PaymentAmt",TypeName = "money")]
public decimal? PaymentAmt {get; set;}
[Column(name:"PaymentTypeID")]
public int? PaymentTypeID {get; set;}
[ForeignKey("CorrInfoID")]
public virtual CorrInfo CorrInfo{get; set;}
[ForeignKey("CorrTypeID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("PaymentTypeID")]
public virtual CommLookup CommLookup1{get; set;}
}
[Table("CorrDetAudit")]
public partial class CorrDetAudit
:IAudit{ 
public CorrDetAudit()
{
}
[Column(name:"AnalystID")]
public int? AnalystID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"CorrDate",TypeName = "datetime2")]
public DateTime? CorrDate {get; set;}
[Column(name:"CorrInfoID")]
public int? CorrInfoID {get; set;}
[Column(name:"CorrTypeID")]
public int? CorrTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"InsertedDate",TypeName = "datetime2")]
public DateTime InsertedDate {get; set;}
[Column(name:"LocationID")]
public int? LocationID {get; set;}
[Column(name:"PaymentAmt",TypeName = "money")]
public decimal? PaymentAmt {get; set;}
[Column(name:"PaymentTypeID")]
public int? PaymentTypeID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
