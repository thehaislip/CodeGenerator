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
[Table("OCAPPPaymentDetail")]
public partial class OCAPPPaymentDetail
:IAuditable{ 
public OCAPPPaymentDetail()
{
}
[Column(name:"AppPaymentID")]
public int? AppPaymentID {get; set;}
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
[Column(name:"ResponseCode")]
[StringLength(1)]
public string ResponseCode {get; set;}
[Required]
[Column(name:"ResponseText")]
[StringLength(500)]
public string ResponseText {get; set;}
[Column(name:"TransactionDate",TypeName = "datetime2")]
public DateTime? TransactionDate {get; set;}
[ForeignKey("AppPaymentID")]
public virtual OCAPPPaymentOption OCAPPPaymentOption{get; set;}
}
[Table("OCAPPPaymentDetailAudit")]
public partial class OCAPPPaymentDetailAudit
:IAudit{ 
public OCAPPPaymentDetailAudit()
{
}
[Column(name:"AppPaymentID")]
public int? AppPaymentID {get; set;}
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
[Column(name:"ResponseCode")]
[StringLength(1)]
public string ResponseCode {get; set;}
[Required]
[Column(name:"ResponseText")]
[StringLength(500)]
public string ResponseText {get; set;}
[Column(name:"TransactionDate",TypeName = "datetime2")]
public DateTime? TransactionDate {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
