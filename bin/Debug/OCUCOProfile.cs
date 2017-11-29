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
[Table("OCUCOProfile")]
public partial class OCUCOProfile
:IAuditable{ 
public OCUCOProfile()
{
this.OCUCOCommentss = new HashSet<OCUCOComments>();
this.OCUCOMajorsCns = new HashSet<OCUCOMajorsCn>();
this.OCUCOPraxisTestss = new HashSet<OCUCOPraxisTests>();
this.OCUCOEndorsementCns = new HashSet<OCUCOEndorsementCn>();
this.OCUCOSectionCompletes = new HashSet<OCUCOSectionComplete>();
this.OCUCOEducations = new HashSet<OCUCOEducation>();
this.OCUCOAppDInfoToCertificateTypes = new HashSet<OCUCOAppDInfoToCertificateType>();
this.OCUCOAppDInfoToPreparations = new HashSet<OCUCOAppDInfoToPreparation>();
this.OCUCOAppSignOffs = new HashSet<OCUCOAppSignOff>();
this.OCUCOAppEducVerifications = new HashSet<OCUCOAppEducVerification>();
this.OCUCOProfessionalPrepCns = new HashSet<OCUCOProfessionalPrepCn>();
this.OCUCOActiveUsers = new HashSet<OCUCOActiveUser>();
}
[Required]
[Column(name:"Address1")]
[StringLength(40)]
public string Address1 {get; set;}
[Column(name:"Address2")]
[StringLength(40)]
public string Address2 {get; set;}
[Required]
[Column(name:"ApplicantSubmissionNotification")]
[StringLength(1)]
public string ApplicantSubmissionNotification {get; set;}
[Required]
[Column(name:"City")]
[StringLength(40)]
public string City {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ContactList")]
[StringLength(1)]
public string ContactList {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Required]
[Column(name:"Email")]
[StringLength(100)]
public string Email {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(60)]
public string LastName {get; set;}
[Column(name:"MustChangePassword")]
[StringLength(1)]
public string MustChangePassword {get; set;}
[Column(name:"Password")]
[StringLength(80)]
public string Password {get; set;}
[Required]
[Column(name:"Phone")]
[StringLength(10)]
public string Phone {get; set;}
[Column(name:"SDUnivID")]
public int? SDUnivID {get; set;}
[Column(name:"StateID")]
public int? StateID {get; set;}
[Required]
[Column(name:"UCONotificationSubmission")]
[StringLength(1)]
public string UCONotificationSubmission {get; set;}
[Required]
[Column(name:"Username")]
[StringLength(80)]
public string Username {get; set;}
[Required]
[Column(name:"Zip")]
[StringLength(9)]
public string Zip {get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOComments> OCUCOCommentss{get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOMajorsCn> OCUCOMajorsCns{get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOPraxisTests> OCUCOPraxisTestss{get; set;}
[ForeignKey("UCOProfileIID")]
public virtual ICollection<OCUCOEndorsementCn> OCUCOEndorsementCns{get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOSectionComplete> OCUCOSectionCompletes{get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOEducation> OCUCOEducations{get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOAppDInfoToCertificateType> OCUCOAppDInfoToCertificateTypes{get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOAppDInfoToPreparation> OCUCOAppDInfoToPreparations{get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOAppSignOff> OCUCOAppSignOffs{get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOAppEducVerification> OCUCOAppEducVerifications{get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOProfessionalPrepCn> OCUCOProfessionalPrepCns{get; set;}
[ForeignKey("UCOProfileID")]
public virtual ICollection<OCUCOActiveUser> OCUCOActiveUsers{get; set;}
[ForeignKey("SDUnivID")]
public virtual OCAPPSDUnivSupt OCAPPSDUnivSupt{get; set;}
[ForeignKey("StateID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("OCUCOProfileAudit")]
public partial class OCUCOProfileAudit
:IAudit{ 
public OCUCOProfileAudit()
{
}
[Required]
[Column(name:"Address1")]
[StringLength(40)]
public string Address1 {get; set;}
[Column(name:"Address2")]
[StringLength(40)]
public string Address2 {get; set;}
[Required]
[Column(name:"ApplicantSubmissionNotification")]
[StringLength(1)]
public string ApplicantSubmissionNotification {get; set;}
[Required]
[Column(name:"City")]
[StringLength(40)]
public string City {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ContactList")]
[StringLength(1)]
public string ContactList {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Required]
[Column(name:"Email")]
[StringLength(100)]
public string Email {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(60)]
public string LastName {get; set;}
[Column(name:"MustChangePassword")]
[StringLength(1)]
public string MustChangePassword {get; set;}
[Column(name:"Password")]
[StringLength(80)]
public string Password {get; set;}
[Required]
[Column(name:"Phone")]
[StringLength(10)]
public string Phone {get; set;}
[Column(name:"SDUnivID")]
public int? SDUnivID {get; set;}
[Column(name:"StateID")]
public int? StateID {get; set;}
[Required]
[Column(name:"UCONotificationSubmission")]
[StringLength(1)]
public string UCONotificationSubmission {get; set;}
[Required]
[Column(name:"Username")]
[StringLength(80)]
public string Username {get; set;}
[Required]
[Column(name:"Zip")]
[StringLength(9)]
public string Zip {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
