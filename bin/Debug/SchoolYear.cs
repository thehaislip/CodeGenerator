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
[Table("SchoolYear")]
public partial class SchoolYear
:IAuditable{ 
public SchoolYear()
{
this.PersonNonAuthPositionCodeMaps = new HashSet<PersonNonAuthPositionCodeMap>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"SchoolYear")]
[StringLength(4)]
public string SchoolYearColumn {get; set;}
[Required]
[Column(name:"SchoolYearIsOpen")]
[StringLength(1)]
public string SchoolYearIsOpen {get; set;}
[Required]
[Column(name:"SchoolYearIsOpenForSignedOffDistricts")]
[StringLength(1)]
public string SchoolYearIsOpenForSignedOffDistricts {get; set;}
[ForeignKey("SchoolYearID")]
public virtual ICollection<PersonNonAuthPositionCodeMap> PersonNonAuthPositionCodeMaps{get; set;}
}
[Table("SchoolYearAudit")]
public partial class SchoolYearAudit
:IAudit{ 
public SchoolYearAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"SchoolYear")]
[StringLength(4)]
public string SchoolYearColumn {get; set;}
[Required]
[Column(name:"SchoolYearIsOpen")]
[StringLength(1)]
public string SchoolYearIsOpen {get; set;}
[Required]
[Column(name:"SchoolYearIsOpenForSignedOffDistricts")]
[StringLength(1)]
public string SchoolYearIsOpenForSignedOffDistricts {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
