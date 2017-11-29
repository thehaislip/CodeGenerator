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
[Table("OCAPPOtherNationalCerts")]
public partial class OCAPPOtherNationalCerts
:IAuditable{ 
public OCAPPOtherNationalCerts()
{
this.OCDOEOtherNationalCertss = new HashSet<OCDOEOtherNationalCerts>();
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Country")]
[StringLength(60)]
public string Country {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"OtherStateID")]
public int? OtherStateID {get; set;}
[ForeignKey("AppID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
[ForeignKey("OCAPPOtherNationalCertsID")]
public virtual ICollection<OCDOEOtherNationalCerts> OCDOEOtherNationalCertss{get; set;}
[ForeignKey("OtherStateID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("OCAPPOtherNationalCertsAudit")]
public partial class OCAPPOtherNationalCertsAudit
:IAudit{ 
public OCAPPOtherNationalCertsAudit()
{
}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Country")]
[StringLength(60)]
public string Country {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"OtherStateID")]
public int? OtherStateID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
