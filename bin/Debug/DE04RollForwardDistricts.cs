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
[Table("DE04RollForwardDistricts")]
public partial class DE04RollForwardDistricts
:IAuditable{ 
public DE04RollForwardDistricts()
{
}
[Column(name:"County")]
[StringLength(50)]
public string County {get; set;}
[Column(name:"CountyID")]
[StringLength(50)]
public string CountyID {get; set;}
[Column(name:"CountyName")]
[StringLength(50)]
public string CountyName {get; set;}
[Column(name:"Description")]
[StringLength(50)]
public string Description {get; set;}
[Column(name:"DistrictCodeNumber")]
[StringLength(50)]
public string DistrictCodeNumber {get; set;}
[Column(name:"DistrictName")]
[StringLength(50)]
public string DistrictName {get; set;}
[Column(name:"DistrictNumber")]
[StringLength(50)]
public string DistrictNumber {get; set;}
[Column(name:"DistrictType")]
[StringLength(50)]
public string DistrictType {get; set;}
[Column(name:"DistrictTypeID")]
[StringLength(50)]
public string DistrictTypeID {get; set;}
[Column(name:"SchoolYear")]
[StringLength(50)]
public string SchoolYear {get; set;}
}
[Table("DE04RollForwardDistrictsAudit")]
public partial class DE04RollForwardDistrictsAudit
:IAudit{ 
public DE04RollForwardDistrictsAudit()
{
}
[Column(name:"County")]
[StringLength(50)]
public string County {get; set;}
[Column(name:"CountyID")]
[StringLength(50)]
public string CountyID {get; set;}
[Column(name:"CountyName")]
[StringLength(50)]
public string CountyName {get; set;}
[Column(name:"Description")]
[StringLength(50)]
public string Description {get; set;}
[Column(name:"DistrictCodeNumber")]
[StringLength(50)]
public string DistrictCodeNumber {get; set;}
[Column(name:"DistrictName")]
[StringLength(50)]
public string DistrictName {get; set;}
[Column(name:"DistrictNumber")]
[StringLength(50)]
public string DistrictNumber {get; set;}
[Column(name:"DistrictType")]
[StringLength(50)]
public string DistrictType {get; set;}
[Column(name:"DistrictTypeID")]
[StringLength(50)]
public string DistrictTypeID {get; set;}
[Column(name:"SchoolYear")]
[StringLength(50)]
public string SchoolYear {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
