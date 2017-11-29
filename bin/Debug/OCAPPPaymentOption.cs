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
[Table("OCAPPPaymentOption")]
public partial class OCAPPPaymentOption
:IAuditable{ 
public OCAPPPaymentOption()
{
this.OCAPPPaymentDetails = new HashSet<OCAPPPaymentDetail>();
}
[Column(name:"Amount",TypeName = "money")]
public decimal? Amount {get; set;}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PaymentTypeID")]
public int PaymentTypeID {get; set;}
[Column(name:"TransactionDate",TypeName = "datetime2")]
public DateTime? TransactionDate {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("AppPaymentID")]
public virtual ICollection<OCAPPPaymentDetail> OCAPPPaymentDetails{get; set;}
[ForeignKey("PaymentTypeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("OCAPPPaymentOptionAudit")]
public partial class OCAPPPaymentOptionAudit
:IAudit{ 
public OCAPPPaymentOptionAudit()
{
}
[Column(name:"Amount",TypeName = "money")]
public decimal? Amount {get; set;}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PaymentTypeID")]
public int PaymentTypeID {get; set;}
[Column(name:"TransactionDate",TypeName = "datetime2")]
public DateTime? TransactionDate {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
