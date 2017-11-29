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
[Table("ApplicationTypeToCertificateType")]
public partial class ApplicationTypeToCertificateType
:IAuditable{ 
public ApplicationTypeToCertificateType()
{
}
[Required]
[Column(name:"ApplicationTypeID")]
public int ApplicationTypeID {get; set;}
[Required]
[Column(name:"CertificateTypeID")]
public int CertificateTypeID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("ApplicationTypeID")]
public virtual ApplicationType ApplicationType{get; set;}
[ForeignKey("CertificateTypeID")]
public virtual CertificateType CertificateType{get; set;}
}
[Table("ApplicationTypeToCertificateTypeAudit")]
public partial class ApplicationTypeToCertificateTypeAudit
:IAudit{ 
public ApplicationTypeToCertificateTypeAudit()
{
}
[Required]
[Column(name:"ApplicationTypeID")]
public int ApplicationTypeID {get; set;}
[Required]
[Column(name:"CertificateTypeID")]
public int CertificateTypeID {get; set;}
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
