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
[Table("DistSS")]
public partial class DistSS
:IAuditable{ 
public DistSS()
{
this.ParaProfs = new HashSet<ParaProf>();
this.AssurDsQs = new HashSet<AssurDsQ>();
this.AssurDsSs = new HashSet<AssurDsS>();
this.Classfids = new HashSet<Classfid>();
this.CoopClassifids = new HashSet<CoopClassifid>();
this.CoopClassifid1s = new HashSet<CoopClassifid>();
this.BaseSalarys = new HashSet<BaseSalary>();
this.BusDrivrs = new HashSet<BusDrivr>();
this.DistBuss = new HashSet<DistBus>();
this.Answers = new HashSet<Answer>();
this.AttCtrSSs = new HashSet<AttCtrSS>();
this.GradUnits = new HashSet<GradUnit>();
this.PRFAssgns = new HashSet<PRFAssgn>();
this.PRFAssgn1s = new HashSet<PRFAssgn>();
this.ParaStudInfos = new HashSet<ParaStudInfo>();
this.Vacancys = new HashSet<Vacancy>();
this.VirtualSchools = new HashSet<VirtualSchool>();
this.PRFInfos = new HashSet<PRFInfo>();
this.CSEAssgns = new HashSet<CSEAssgn>();
this.CSEClasss = new HashSet<CSEClass>();
this.DistrictVacancys = new HashSet<DistrictVacancy>();
this.DistSpeds = new HashSet<DistSped>();
this.DistVacs = new HashSet<DistVac>();
this.PRFAssgn1s = new HashSet<PRFAssgn>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"CountyCode")]
[StringLength(2)]
public string CountyCode {get; set;}
[Required]
[Column(name:"CountyCodeDescription")]
[StringLength(80)]
public string CountyCodeDescription {get; set;}
[Column(name:"CountyCodeID")]
public int? CountyCodeID {get; set;}
[Required]
[Column(name:"DistrictCodeNum")]
[StringLength(2)]
public string DistrictCodeNum {get; set;}
[Required]
[Column(name:"DistrictFacilityType")]
[StringLength(1)]
public string DistrictFacilityType {get; set;}
[Required]
[Column(name:"DistrictFacilityTypeDesc")]
[StringLength(80)]
public string DistrictFacilityTypeDesc {get; set;}
[Column(name:"GraduateCredits")]
public int? GraduateCredits {get; set;}
[Column(name:"HasClssStaff")]
[StringLength(1)]
public string HasClssStaff {get; set;}
[Column(name:"HasParaProf")]
[StringLength(1)]
public string HasParaProf {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InsertedDate",TypeName = "datetime2")]
public DateTime? InsertedDate {get; set;}
[Required]
[Column(name:"SchoolDistrictName")]
[StringLength(80)]
public string SchoolDistrictName {get; set;}
[Column(name:"SchoolFacilityTypeID")]
public int? SchoolFacilityTypeID {get; set;}
[Required]
[Column(name:"SchoolYear")]
[StringLength(4)]
public string SchoolYear {get; set;}
[Required]
[Column(name:"ShortName")]
[StringLength(5)]
public string ShortName {get; set;}
[ForeignKey("ContractedID")]
public virtual ICollection<ParaProf> ParaProfs{get; set;}
[ForeignKey("DistID")]
public virtual ICollection<AssurDsQ> AssurDsQs{get; set;}
[ForeignKey("DistID")]
public virtual ICollection<AssurDsS> AssurDsSs{get; set;}
[ForeignKey("DistrictSnapshotID")]
public virtual ICollection<Classfid> Classfids{get; set;}
[ForeignKey("DistSSID")]
public virtual ICollection<CoopClassifid> CoopClassifids{get; set;}
[ForeignKey("DictrictReceivingServicesID")]
public virtual ICollection<CoopClassifid> CoopClassifid1s{get; set;}
[ForeignKey("DistID")]
public virtual ICollection<BaseSalary> BaseSalarys{get; set;}
[ForeignKey("DistID")]
public virtual ICollection<BusDrivr> BusDrivrs{get; set;}
[ForeignKey("DistID")]
public virtual ICollection<DistBus> DistBuss{get; set;}
[ForeignKey("DistrictID")]
public virtual ICollection<Answer> Answers{get; set;}
[ForeignKey("DistSSID")]
public virtual ICollection<AttCtrSS> AttCtrSSs{get; set;}
[ForeignKey("DistrictID")]
public virtual ICollection<GradUnit> GradUnits{get; set;}
[ForeignKey("OtherPayingDistrictID")]
public virtual ICollection<PRFAssgn> PRFAssgns{get; set;}
[ForeignKey("EDIDistrictID")]
public virtual ICollection<PRFAssgn> PRFAssgn1s{get; set;}
[ForeignKey("DistSSID")]
public virtual ICollection<ParaStudInfo> ParaStudInfos{get; set;}
[ForeignKey("DistID")]
public virtual ICollection<Vacancy> Vacancys{get; set;}
[ForeignKey("DistSSID")]
public virtual ICollection<VirtualSchool> VirtualSchools{get; set;}
[ForeignKey("DistrictSnapshotID")]
public virtual ICollection<PRFInfo> PRFInfos{get; set;}
[ForeignKey("DistID")]
public virtual ICollection<CSEAssgn> CSEAssgns{get; set;}
[ForeignKey("DistID")]
public virtual ICollection<CSEClass> CSEClasss{get; set;}
[ForeignKey("DistrictID")]
public virtual ICollection<DistrictVacancy> DistrictVacancys{get; set;}
[ForeignKey("DistID")]
public virtual ICollection<DistSped> DistSpeds{get; set;}
[ForeignKey("DistID")]
public virtual ICollection<DistVac> DistVacs{get; set;}
[ForeignKey("OtherDistrictID")]
public virtual ICollection<PRFAssgn> PRFAssgn2s{get; set;}
}
[Table("DistSSAudit")]
public partial class DistSSAudit
:IAudit{ 
public DistSSAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Required]
[Column(name:"CountyCode")]
[StringLength(2)]
public string CountyCode {get; set;}
[Required]
[Column(name:"CountyCodeDescription")]
[StringLength(80)]
public string CountyCodeDescription {get; set;}
[Column(name:"CountyCodeID")]
public int? CountyCodeID {get; set;}
[Required]
[Column(name:"DistrictCodeNum")]
[StringLength(2)]
public string DistrictCodeNum {get; set;}
[Required]
[Column(name:"DistrictFacilityType")]
[StringLength(1)]
public string DistrictFacilityType {get; set;}
[Required]
[Column(name:"DistrictFacilityTypeDesc")]
[StringLength(80)]
public string DistrictFacilityTypeDesc {get; set;}
[Column(name:"GraduateCredits")]
public int? GraduateCredits {get; set;}
[Column(name:"HasClssStaff")]
[StringLength(1)]
public string HasClssStaff {get; set;}
[Column(name:"HasParaProf")]
[StringLength(1)]
public string HasParaProf {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InsertedDate",TypeName = "datetime2")]
public DateTime? InsertedDate {get; set;}
[Required]
[Column(name:"SchoolDistrictName")]
[StringLength(80)]
public string SchoolDistrictName {get; set;}
[Column(name:"SchoolFacilityTypeID")]
public int? SchoolFacilityTypeID {get; set;}
[Required]
[Column(name:"SchoolYear")]
[StringLength(4)]
public string SchoolYear {get; set;}
[Required]
[Column(name:"ShortName")]
[StringLength(5)]
public string ShortName {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
