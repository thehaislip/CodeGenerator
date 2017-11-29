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
[Table("COMMPerson")]
public partial class COMMPerson
:IAuditable{ 
public COMMPerson()
{
this.CorrInfos = new HashSet<CorrInfo>();
this.OCAppDInfos = new HashSet<OCAppDInfo>();
this.FedEths = new HashSet<FedEth>();
this.CertCreds = new HashSet<CertCred>();
this.Certificates = new HashSet<Certificate>();
this.Degrees = new HashSet<Degree>();
this.Addresss = new HashSet<Address>();
this.IndividualTests = new HashSet<IndividualTest>();
this.OCDOEComments = new HashSet<OCDOEComment>();
this.CertHistorys = new HashSet<CertHistory>();
this.PreviousLastNames = new HashSet<PreviousLastName>();
this.PRFInfos = new HashSet<PRFInfo>();
this.PersonFlaggeds = new HashSet<PersonFlagged>();
this.CommPersonToMajors = new HashSet<CommPersonToMajor>();
}
[Column(name:"BirthDate",TypeName = "datetime2")]
public DateTime? BirthDate {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Country")]
[StringLength(60)]
public string Country {get; set;}
[Column(name:"DayPhone")]
[StringLength(10)]
public string DayPhone {get; set;}
[Column(name:"EmailAddress")]
[StringLength(100)]
public string EmailAddress {get; set;}
[Column(name:"EveningPhone")]
[StringLength(30)]
public string EveningPhone {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Column(name:"HispanicIndicator")]
public bool? HispanicIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(60)]
public string LastName {get; set;}
[Column(name:"MiddleName")]
[StringLength(60)]
public string MiddleName {get; set;}
[Column(name:"Sex")]
[StringLength(1)]
public string Sex {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[ForeignKey("PersonnelID")]
public virtual ICollection<CorrInfo> CorrInfos{get; set;}
[ForeignKey("PersonnelID")]
public virtual ICollection<OCAppDInfo> OCAppDInfos{get; set;}
[ForeignKey("COMMPersonID")]
public virtual ICollection<FedEth> FedEths{get; set;}
[ForeignKey("PersonnelID")]
public virtual ICollection<CertCred> CertCreds{get; set;}
[ForeignKey("PersonID")]
public virtual ICollection<Certificate> Certificates{get; set;}
[ForeignKey("PersonnelID")]
public virtual ICollection<Degree> Degrees{get; set;}
[ForeignKey("PersonneID")]
public virtual ICollection<Address> Addresss{get; set;}
[ForeignKey("PersonnelID")]
public virtual ICollection<IndividualTest> IndividualTests{get; set;}
[ForeignKey("PersonnelID")]
public virtual ICollection<OCDOEComment> OCDOEComments{get; set;}
[ForeignKey("PersonnelID")]
public virtual ICollection<CertHistory> CertHistorys{get; set;}
[ForeignKey("PersonnelID")]
public virtual ICollection<PreviousLastName> PreviousLastNames{get; set;}
[ForeignKey("PersonnelID")]
public virtual ICollection<PRFInfo> PRFInfos{get; set;}
[ForeignKey("PersonnelID")]
public virtual ICollection<PersonFlagged> PersonFlaggeds{get; set;}
[ForeignKey("PersonID")]
public virtual ICollection<CommPersonToMajor> CommPersonToMajors{get; set;}
}
[Table("COMMPersonAudit")]
public partial class COMMPersonAudit
:IAudit{ 
public COMMPersonAudit()
{
}
[Column(name:"BirthDate",TypeName = "datetime2")]
public DateTime? BirthDate {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Country")]
[StringLength(60)]
public string Country {get; set;}
[Column(name:"DayPhone")]
[StringLength(10)]
public string DayPhone {get; set;}
[Column(name:"EmailAddress")]
[StringLength(100)]
public string EmailAddress {get; set;}
[Column(name:"EveningPhone")]
[StringLength(30)]
public string EveningPhone {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Column(name:"HispanicIndicator")]
public bool? HispanicIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"LastName")]
[StringLength(60)]
public string LastName {get; set;}
[Column(name:"MiddleName")]
[StringLength(60)]
public string MiddleName {get; set;}
[Column(name:"Sex")]
[StringLength(1)]
public string Sex {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
