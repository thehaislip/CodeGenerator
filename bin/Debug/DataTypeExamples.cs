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
[Table("DataTypeExamples")]
public partial class DataTypeExamples
:IAuditable{ 
public DataTypeExamples()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"xbit")]
public bool? Xbit {get; set;}
[Column(name:"xdate",TypeName = "datetime2")]
public DateTime? Xdate {get; set;}
[Column(name:"xdatetime",TypeName = "datetime2")]
public DateTime? Xdatetime {get; set;}
[Column(name:"xdatetime2",TypeName = "datetime2")]
public DateTime? Xdatetime2 {get; set;}
[Column(name:"xdecimal")]
public decimal? Xdecimal {get; set;}
[Required]
[Column(name:"xfloat")]
public double Xfloat {get; set;}
[Column(name:"xinteger")]
public int? Xinteger {get; set;}
[Column(name:"xmoney",TypeName = "money")]
public decimal? Xmoney {get; set;}
[Column(name:"xtimestamp",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] Xtimestamp {get; set;}
[Required]
[Column(name:"xuniqueidentifier")]
public Guid Xuniqueidentifier {get; set;}
[Column(name:"xvarchar")]
[StringLength(500)]
public string Xvarchar {get; set;}
}
[Table("DataTypeExamplesAudit")]
public partial class DataTypeExamplesAudit
:IAudit{ 
public DataTypeExamplesAudit()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"xbit")]
public bool? Xbit {get; set;}
[Column(name:"xdate",TypeName = "datetime2")]
public DateTime? Xdate {get; set;}
[Column(name:"xdatetime",TypeName = "datetime2")]
public DateTime? Xdatetime {get; set;}
[Column(name:"xdatetime2",TypeName = "datetime2")]
public DateTime? Xdatetime2 {get; set;}
[Column(name:"xdecimal")]
public decimal? Xdecimal {get; set;}
[Required]
[Column(name:"xfloat")]
public double Xfloat {get; set;}
[Column(name:"xinteger")]
public int? Xinteger {get; set;}
[Column(name:"xmoney",TypeName = "money")]
public decimal? Xmoney {get; set;}
[Column(name:"xtimestamp",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] Xtimestamp {get; set;}
[Required]
[Column(name:"xuniqueidentifier")]
public Guid Xuniqueidentifier {get; set;}
[Column(name:"xvarchar")]
[StringLength(500)]
public string Xvarchar {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
