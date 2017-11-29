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
[Table("BusDrivr")]
public partial class BusDrivr
:IAuditable{ 
public BusDrivr()
{
}
[Column(name:"ARSDTraining")]
[StringLength(1)]
public string ARSDTraining {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistID")]
public int? DistID {get; set;}
[Required]
[Column(name:"EmployeeType")]
[StringLength(1)]
public string EmployeeType {get; set;}
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
[Required]
[Column(name:"MiddleName")]
[StringLength(60)]
public string MiddleName {get; set;}
[Column(name:"OverrideComments")]
[StringLength(255)]
public string OverrideComments {get; set;}
[Column(name:"RegEdFTE",TypeName = "money")]
public decimal? RegEdFTE {get; set;}
[Column(name:"SpecEdFTE",TypeName = "money")]
public decimal? SpecEdFTE {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[Column(name:"TrainingDate")]
[StringLength(6)]
public string TrainingDate {get; set;}
[Column(name:"TrainingOverride")]
[StringLength(1)]
public string TrainingOverride {get; set;}
[ForeignKey("DistID")]
public virtual DistSS DistSS{get; set;}
}
[Table("BusDrivrAudit")]
public partial class BusDrivrAudit
:IAudit{ 
public BusDrivrAudit()
{
}
[Column(name:"ARSDTraining")]
[StringLength(1)]
public string ARSDTraining {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistID")]
public int? DistID {get; set;}
[Required]
[Column(name:"EmployeeType")]
[StringLength(1)]
public string EmployeeType {get; set;}
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
[Required]
[Column(name:"MiddleName")]
[StringLength(60)]
public string MiddleName {get; set;}
[Column(name:"OverrideComments")]
[StringLength(255)]
public string OverrideComments {get; set;}
[Column(name:"RegEdFTE",TypeName = "money")]
public decimal? RegEdFTE {get; set;}
[Column(name:"SpecEdFTE",TypeName = "money")]
public decimal? SpecEdFTE {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[Column(name:"TrainingDate")]
[StringLength(6)]
public string TrainingDate {get; set;}
[Column(name:"TrainingOverride")]
[StringLength(1)]
public string TrainingOverride {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
