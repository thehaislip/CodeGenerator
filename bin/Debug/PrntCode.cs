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
[Table("PrntCode")]
public partial class PrntCode
:IAuditable{ 
public PrntCode()
{
this.Certificates = new HashSet<Certificate>();
this.CPrtRecs = new HashSet<CPrtRec>();
}
[Column(name:"concurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"datedisabled",TypeName = "datetime2")]
public DateTime? Datedisabled {get; set;}
[Required]
[Column(name:"disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"dollaramount",TypeName = "money")]
public decimal? Dollaramount {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"printcode")]
[StringLength(12)]
public string Printcode {get; set;}
[Required]
[Column(name:"printcodedescription")]
[StringLength(120)]
public string Printcodedescription {get; set;}
[Column(name:"printreceiptid")]
public int? Printreceiptid {get; set;}
[ForeignKey("PrintCodeID")]
public virtual ICollection<Certificate> Certificates{get; set;}
[ForeignKey("PrintCodeID")]
public virtual ICollection<CPrtRec> CPrtRecs{get; set;}
}
[Table("PrntCodeAudit")]
public partial class PrntCodeAudit
:IAudit{ 
public PrntCodeAudit()
{
}
[Column(name:"concurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"datedisabled",TypeName = "datetime2")]
public DateTime? Datedisabled {get; set;}
[Required]
[Column(name:"disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"dollaramount",TypeName = "money")]
public decimal? Dollaramount {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"printcode")]
[StringLength(12)]
public string Printcode {get; set;}
[Required]
[Column(name:"printcodedescription")]
[StringLength(120)]
public string Printcodedescription {get; set;}
[Column(name:"printreceiptid")]
public int? Printreceiptid {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
