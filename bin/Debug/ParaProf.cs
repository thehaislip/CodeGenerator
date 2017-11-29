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
[Table("ParaProf")]
public partial class ParaProf
:IAuditable{ 
public ParaProf()
{
this.ParaFundingFTEPcts = new HashSet<ParaFundingFTEPct>();
this.ParaJobResps = new HashSet<ParaJobResp>();
this.ParaQuals = new HashSet<ParaQual>();
}
[Column(name:"AttCenterID")]
public int? AttCenterID {get; set;}
[Required]
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ContractedID")]
public int? ContractedID {get; set;}
[Column(name:"ContractedOther")]
[StringLength(255)]
public string ContractedOther {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Column(name:"HireDate",TypeName = "datetime2")]
public DateTime? HireDate {get; set;}
[Column(name:"HiredID")]
public int? HiredID {get; set;}
[Column(name:"HQTeachers")]
[StringLength(500)]
public string HQTeachers {get; set;}
[Column(name:"HSDiploma")]
[StringLength(1)]
public string HSDiploma {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"lastName")]
[StringLength(60)]
public string LastName {get; set;}
[Required]
[Column(name:"MI")]
[StringLength(20)]
public string MI {get; set;}
[Column(name:"OptionID")]
public int? OptionID {get; set;}
[Column(name:"ParaSchoolWideTypeID")]
public int? ParaSchoolWideTypeID {get; set;}
[Required]
[Column(name:"ParaYear")]
[StringLength(4)]
public string ParaYear {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[ForeignKey("AttCenterID")]
public virtual AttCtrSS AttCtrSS{get; set;}
[ForeignKey("ContractedID")]
public virtual DistSS DistSS{get; set;}
[ForeignKey("HiredID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("ParaProfID")]
public virtual ICollection<ParaFundingFTEPct> ParaFundingFTEPcts{get; set;}
[ForeignKey("ParaProfID")]
public virtual ICollection<ParaJobResp> ParaJobResps{get; set;}
[ForeignKey("ParaProfID")]
public virtual ICollection<ParaQual> ParaQuals{get; set;}
[ForeignKey("OptionID")]
public virtual CommLookup CommLookup1{get; set;}
[ForeignKey("ParaSchoolWideTypeID")]
public virtual CommLookup CommLookup2{get; set;}
}
[Table("ParaProfAudit")]
public partial class ParaProfAudit
:IAudit{ 
public ParaProfAudit()
{
}
[Column(name:"AttCenterID")]
public int? AttCenterID {get; set;}
[Required]
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ContractedID")]
public int? ContractedID {get; set;}
[Column(name:"ContractedOther")]
[StringLength(255)]
public string ContractedOther {get; set;}
[Required]
[Column(name:"FirstName")]
[StringLength(60)]
public string FirstName {get; set;}
[Column(name:"HireDate",TypeName = "datetime2")]
public DateTime? HireDate {get; set;}
[Column(name:"HiredID")]
public int? HiredID {get; set;}
[Column(name:"HQTeachers")]
[StringLength(500)]
public string HQTeachers {get; set;}
[Column(name:"HSDiploma")]
[StringLength(1)]
public string HSDiploma {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"lastName")]
[StringLength(60)]
public string LastName {get; set;}
[Required]
[Column(name:"MI")]
[StringLength(20)]
public string MI {get; set;}
[Column(name:"OptionID")]
public int? OptionID {get; set;}
[Column(name:"ParaSchoolWideTypeID")]
public int? ParaSchoolWideTypeID {get; set;}
[Required]
[Column(name:"ParaYear")]
[StringLength(4)]
public string ParaYear {get; set;}
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
