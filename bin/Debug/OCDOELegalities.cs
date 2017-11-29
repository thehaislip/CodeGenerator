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
[Table("OCDOELegalities")]
public partial class OCDOELegalities
:IAuditable{ 
public OCDOELegalities()
{
}
[Required]
[Column(name:"AffirmationOathSigned")]
[StringLength(1)]
public string AffirmationOathSigned {get; set;}
[Required]
[Column(name:"AllegianceOathSigned")]
[StringLength(1)]
public string AllegianceOathSigned {get; set;}
[Required]
[Column(name:"ApplicantID")]
public int ApplicantID {get; set;}
[Column(name:"CitizenshipCountry")]
[StringLength(100)]
public string CitizenshipCountry {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"ConductReviewAnyYesResponses")]
[StringLength(1)]
public string ConductReviewAnyYesResponses {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SubmittedOnline")]
[StringLength(1)]
public string SubmittedOnline {get; set;}
[Column(name:"USCitizenship")]
[StringLength(1)]
public string USCitizenship {get; set;}
[ForeignKey("ApplicantID")]
public virtual OCAppDInfo OCAppDInfo{get; set;}
}
[Table("OCDOELegalitiesAudit")]
public partial class OCDOELegalitiesAudit
:IAudit{ 
public OCDOELegalitiesAudit()
{
}
[Required]
[Column(name:"AffirmationOathSigned")]
[StringLength(1)]
public string AffirmationOathSigned {get; set;}
[Required]
[Column(name:"AllegianceOathSigned")]
[StringLength(1)]
public string AllegianceOathSigned {get; set;}
[Required]
[Column(name:"ApplicantID")]
public int ApplicantID {get; set;}
[Column(name:"CitizenshipCountry")]
[StringLength(100)]
public string CitizenshipCountry {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"ConductReviewAnyYesResponses")]
[StringLength(1)]
public string ConductReviewAnyYesResponses {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SubmittedOnline")]
[StringLength(1)]
public string SubmittedOnline {get; set;}
[Column(name:"USCitizenship")]
[StringLength(1)]
public string USCitizenship {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
