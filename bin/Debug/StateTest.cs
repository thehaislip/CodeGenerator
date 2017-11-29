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
[Table("StateTest")]
public partial class StateTest
:IAuditable{ 
public StateTest()
{
this.OCDOEPraxisTests = new HashSet<OCDOEPraxisTest>();
this.OCUCOPraxisTestss = new HashSet<OCUCOPraxisTests>();
this.IndivTsts = new HashSet<IndivTst>();
this.OCAPPPraxisTestss = new HashSet<OCAPPPraxisTests>();
this.HQTestAssgns = new HashSet<HQTestAssgn>();
this.PraxisAssgnCns = new HashSet<PraxisAssgnCn>();
this.OCETSPraxisTests = new HashSet<OCETSPraxisTest>();
this.SPEDTestCombines = new HashSet<SPEDTestCombine>();
this.SPEDTstCombins = new HashSet<SPEDTstCombin>();
this.IndividualTests = new HashSet<IndividualTest>();
}
[Column(name:"BeginDate",TypeName = "datetime2")]
public DateTime? BeginDate {get; set;}
[Column(name:"CategoryID")]
public int? CategoryID {get; set;}
[Required]
[Column(name:"Code")]
[StringLength(12)]
public string Code {get; set;}
[Required]
[Column(name:"Comments")]
[StringLength(255)]
public string Comments {get; set;}
[Column(name:"CommLookupID")]
public int? CommLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisbaled",TypeName = "datetime2")]
public DateTime? DateDisbaled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DOEGroupID")]
public int? DOEGroupID {get; set;}
[Column(name:"EndDate",TypeName = "datetime2")]
public DateTime? EndDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ParentID")]
public int? ParentID {get; set;}
[Required]
[Column(name:"QualifyingHighScore")]
[StringLength(10)]
public string QualifyingHighScore {get; set;}
[Required]
[Column(name:"QualifyingLowScore")]
[StringLength(10)]
public string QualifyingLowScore {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[Column(name:"TypeID")]
public int? TypeID {get; set;}
[Required]
[Column(name:"ValidForCutScore")]
[StringLength(1)]
public string ValidForCutScore {get; set;}
[Required]
[Column(name:"ValidForSouthDakota")]
[StringLength(1)]
public string ValidForSouthDakota {get; set;}
[ForeignKey("CategoryID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("CommLookupID")]
public virtual CommLookup CommLookup1{get; set;}
[ForeignKey("StateTestID")]
public virtual ICollection<OCDOEPraxisTest> OCDOEPraxisTests{get; set;}
[ForeignKey("StateTestID")]
public virtual ICollection<OCUCOPraxisTests> OCUCOPraxisTestss{get; set;}
[ForeignKey("StateTestID")]
public virtual ICollection<IndivTst> IndivTsts{get; set;}
[ForeignKey("StateTestID")]
public virtual ICollection<OCAPPPraxisTests> OCAPPPraxisTestss{get; set;}
[ForeignKey("PraxisTestID")]
public virtual ICollection<HQTestAssgn> HQTestAssgns{get; set;}
[ForeignKey("PraxisID")]
public virtual ICollection<PraxisAssgnCn> PraxisAssgnCns{get; set;}
[ForeignKey("StateTestID")]
public virtual ICollection<OCETSPraxisTest> OCETSPraxisTests{get; set;}
[ForeignKey("StateTestID")]
public virtual ICollection<SPEDTestCombine> SPEDTestCombines{get; set;}
[ForeignKey("StateTestID")]
public virtual ICollection<SPEDTstCombin> SPEDTstCombins{get; set;}
[ForeignKey("StateTestID")]
public virtual ICollection<IndividualTest> IndividualTests{get; set;}
}
[Table("StateTestAudit")]
public partial class StateTestAudit
:IAudit{ 
public StateTestAudit()
{
}
[Column(name:"BeginDate",TypeName = "datetime2")]
public DateTime? BeginDate {get; set;}
[Column(name:"CategoryID")]
public int? CategoryID {get; set;}
[Required]
[Column(name:"Code")]
[StringLength(12)]
public string Code {get; set;}
[Required]
[Column(name:"Comments")]
[StringLength(255)]
public string Comments {get; set;}
[Column(name:"CommLookupID")]
public int? CommLookupID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DateDisbaled",TypeName = "datetime2")]
public DateTime? DateDisbaled {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Required]
[Column(name:"Disabled")]
[StringLength(1)]
public string Disabled {get; set;}
[Column(name:"DOEGroupID")]
public int? DOEGroupID {get; set;}
[Column(name:"EndDate",TypeName = "datetime2")]
public DateTime? EndDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ParentID")]
public int? ParentID {get; set;}
[Required]
[Column(name:"QualifyingHighScore")]
[StringLength(10)]
public string QualifyingHighScore {get; set;}
[Required]
[Column(name:"QualifyingLowScore")]
[StringLength(10)]
public string QualifyingLowScore {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
[Column(name:"TypeID")]
public int? TypeID {get; set;}
[Required]
[Column(name:"ValidForCutScore")]
[StringLength(1)]
public string ValidForCutScore {get; set;}
[Required]
[Column(name:"ValidForSouthDakota")]
[StringLength(1)]
public string ValidForSouthDakota {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
