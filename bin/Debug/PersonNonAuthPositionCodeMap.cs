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
[Table("PersonNonAuthPositionCodeMap")]
public partial class PersonNonAuthPositionCodeMap
:IAuditable{ 
public PersonNonAuthPositionCodeMap()
{
}
[Required]
[Column(name:"AssignmentCode")]
[StringLength(5)]
public string AssignmentCode {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictNumber")]
[StringLength(5)]
public string DistrictNumber {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PositionCode")]
[StringLength(5)]
public string PositionCode {get; set;}
[Column(name:"SchoolNumber")]
[StringLength(3)]
public string SchoolNumber {get; set;}
[Column(name:"SchoolYearID")]
public int? SchoolYearID {get; set;}
[Required]
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[ForeignKey("SchoolYearID")]
public virtual SchoolYear SchoolYear{get; set;}
}
[Table("PersonNonAuthPositionCodeMapAudit")]
public partial class PersonNonAuthPositionCodeMapAudit
:IAudit{ 
public PersonNonAuthPositionCodeMapAudit()
{
}
[Required]
[Column(name:"AssignmentCode")]
[StringLength(5)]
public string AssignmentCode {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DistrictNumber")]
[StringLength(5)]
public string DistrictNumber {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"PositionCode")]
[StringLength(5)]
public string PositionCode {get; set;}
[Column(name:"SchoolNumber")]
[StringLength(3)]
public string SchoolNumber {get; set;}
[Column(name:"SchoolYearID")]
public int? SchoolYearID {get; set;}
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
