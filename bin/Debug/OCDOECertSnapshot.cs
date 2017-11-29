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
[Table("OCDOECertSnapshot")]
public partial class OCDOECertSnapshot
:IAuditable{ 
public OCDOECertSnapshot()
{
this.OCDOECertSSDetails = new HashSet<OCDOECertSSDetail>();
}
[Column(name:"CertCredID")]
public int? CertCredID {get; set;}
[Column(name:"CertificateExpirationDate")]
public DateTime? CertificateExpirationDate {get; set;}
[Column(name:"CertificateIssueDate")]
public DateTime? CertificateIssueDate {get; set;}
[Column(name:"CertificateNumber")]
public int? CertificateNumber {get; set;}
[Column(name:"CertificateRevisionNumber")]
public int? CertificateRevisionNumber {get; set;}
[Required]
[Column(name:"CertificateTitle")]
[StringLength(255)]
public string CertificateTitle {get; set;}
[Required]
[Column(name:"CertifiedTypeCode")]
[StringLength(12)]
public string CertifiedTypeCode {get; set;}
[Required]
[Column(name:"CertifiedTypeDescription")]
[StringLength(255)]
public string CertifiedTypeDescription {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Required]
[Column(name:"HighestDegree")]
[StringLength(255)]
public string HighestDegree {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(60)]
public string LastName {get; set;}
[Required]
[Column(name:"MiddleName")]
[StringLength(60)]
public string MiddleName {get; set;}
[Column(name:"SnapshotDate")]
public DateTime? SnapshotDate {get; set;}
[Required]
[Column(name:"SnapshotUser")]
[StringLength(30)]
public string SnapshotUser {get; set;}
[ForeignKey("SnapshotID")]
public virtual ICollection<OCDOECertSSDetail> OCDOECertSSDetails{get; set;}
}
[Table("OCDOECertSnapshotAudit")]
public partial class OCDOECertSnapshotAudit
:IAudit{ 
public OCDOECertSnapshotAudit()
{
}
[Column(name:"CertCredID")]
public int? CertCredID {get; set;}
[Column(name:"CertificateExpirationDate")]
public DateTime? CertificateExpirationDate {get; set;}
[Column(name:"CertificateIssueDate")]
public DateTime? CertificateIssueDate {get; set;}
[Column(name:"CertificateNumber")]
public int? CertificateNumber {get; set;}
[Column(name:"CertificateRevisionNumber")]
public int? CertificateRevisionNumber {get; set;}
[Required]
[Column(name:"CertificateTitle")]
[StringLength(255)]
public string CertificateTitle {get; set;}
[Required]
[Column(name:"CertifiedTypeCode")]
[StringLength(12)]
public string CertifiedTypeCode {get; set;}
[Required]
[Column(name:"CertifiedTypeDescription")]
[StringLength(255)]
public string CertifiedTypeDescription {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Required]
[Column(name:"HighestDegree")]
[StringLength(255)]
public string HighestDegree {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(60)]
public string LastName {get; set;}
[Required]
[Column(name:"MiddleName")]
[StringLength(60)]
public string MiddleName {get; set;}
[Column(name:"SnapshotDate")]
public DateTime? SnapshotDate {get; set;}
[Required]
[Column(name:"SnapshotUser")]
[StringLength(30)]
public string SnapshotUser {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
