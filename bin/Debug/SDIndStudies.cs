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
[Table("SDIndStudies")]
public partial class SDIndStudies
:IAuditable{ 
public SDIndStudies()
{
}
[Required]
[Column(name:"CertCredID")]
public int CertCredID {get; set;}
[Required]
[Column(name:"Completed")]
[StringLength(1)]
public string Completed {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("CertCredID")]
public virtual Certificate Certificate{get; set;}
}
[Table("SDIndStudiesAudit")]
public partial class SDIndStudiesAudit
:IAudit{ 
public SDIndStudiesAudit()
{
}
[Required]
[Column(name:"CertCredID")]
public int CertCredID {get; set;}
[Required]
[Column(name:"Completed")]
[StringLength(1)]
public string Completed {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
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
