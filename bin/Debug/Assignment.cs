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
[Table("Assignment")]
public partial class Assignment
:IAuditable{ 
public Assignment()
{
this.SubAssgns = new HashSet<SubAssgn>();
this.AssignmentToSpedEndorsements = new HashSet<AssignmentToSpedEndorsement>();
this.DistPlanIntnts = new HashSet<DistPlanIntnt>();
this.AssgnCatCns = new HashSet<AssgnCatCn>();
this.AssignmentToEndorsements = new HashSet<AssignmentToEndorsement>();
this.AssignmentTypeToAssignments = new HashSet<AssignmentTypeToAssignment>();
this.SpedPrepAssgns = new HashSet<SpedPrepAssgn>();
this.SpedSubjAssgns = new HashSet<SpedSubjAssgn>();
this.SPEDTestCombines = new HashSet<SPEDTestCombine>();
this.SPEDTstCombins = new HashSet<SPEDTstCombin>();
this.AssignmentToPositions = new HashSet<AssignmentToPosition>();
this.GenPosASs = new HashSet<GenPosAS>();
this.PRFAssgns = new HashSet<PRFAssgn>();
this.EndOnlyPhsOuts = new HashSet<EndOnlyPhsOut>();
this.POISpedInds = new HashSet<POISpedInd>();
this.PraxisAssgnCns = new HashSet<PraxisAssgnCn>();
this.SpedEndAssgns = new HashSet<SpedEndAssgn>();
}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Required]
[Column(name:"DisabledInd")]
public bool DisabledInd {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PlanOfIntentIndicator")]
public bool? PlanOfIntentIndicator {get; set;}
[Column(name:"SchoolStructure")]
[StringLength(250)]
public string SchoolStructure {get; set;}
[Column(name:"SchoolStructureID")]
public int? SchoolStructureID {get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<SubAssgn> SubAssgns{get; set;}
[ForeignKey("AssignmentID")]
public virtual ICollection<AssignmentToSpedEndorsement> AssignmentToSpedEndorsements{get; set;}
[ForeignKey("AssgnCodeID")]
public virtual ICollection<DistPlanIntnt> DistPlanIntnts{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<AssgnCatCn> AssgnCatCns{get; set;}
[ForeignKey("AssignmentID")]
public virtual ICollection<AssignmentToEndorsement> AssignmentToEndorsements{get; set;}
[ForeignKey("AssignmentID")]
public virtual ICollection<AssignmentTypeToAssignment> AssignmentTypeToAssignments{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<SpedPrepAssgn> SpedPrepAssgns{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<SpedSubjAssgn> SpedSubjAssgns{get; set;}
[ForeignKey("AssgnID")]
public virtual ICollection<SPEDTestCombine> SPEDTestCombines{get; set;}
[ForeignKey("AssgnID")]
public virtual ICollection<SPEDTstCombin> SPEDTstCombins{get; set;}
[ForeignKey("AssignmentID")]
public virtual ICollection<AssignmentToPosition> AssignmentToPositions{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<GenPosAS> GenPosASs{get; set;}
[ForeignKey("AssignCodeID")]
public virtual ICollection<PRFAssgn> PRFAssgns{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<EndOnlyPhsOut> EndOnlyPhsOuts{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<POISpedInd> POISpedInds{get; set;}
[ForeignKey("AssgnID")]
public virtual ICollection<PraxisAssgnCn> PraxisAssgnCns{get; set;}
[ForeignKey("AssignmentCodeID")]
public virtual ICollection<SpedEndAssgn> SpedEndAssgns{get; set;}
[ForeignKey("SchoolStructureID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("AssignmentAudit")]
public partial class AssignmentAudit
:IAudit{ 
public AssignmentAudit()
{
}
[Required]
[Column(name:"Code")]
[StringLength(20)]
public string Code {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"Description")]
[StringLength(255)]
public string Description {get; set;}
[Column(name:"DisabledDate",TypeName = "datetime2")]
public DateTime? DisabledDate {get; set;}
[Required]
[Column(name:"DisabledInd")]
public bool DisabledInd {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"PlanOfIntentIndicator")]
public bool? PlanOfIntentIndicator {get; set;}
[Column(name:"SchoolStructure")]
[StringLength(250)]
public string SchoolStructure {get; set;}
[Column(name:"SchoolStructureID")]
public int? SchoolStructureID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
