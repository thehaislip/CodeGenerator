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
[Table("DegreeToDegreeType")]
public partial class DegreeToDegreeType
:IAuditable{ 
public DegreeToDegreeType()
{
}
[Column(name:"DegreeID")]
public int? DegreeID {get; set;}
[Column(name:"DegreeTypeID")]
public int? DegreeTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[ForeignKey("DegreeID")]
public virtual CommLookup CommLookup{get; set;}
[ForeignKey("DegreeTypeID")]
public virtual CommLookup CommLookup1{get; set;}
}
[Table("DegreeToDegreeTypeAudit")]
public partial class DegreeToDegreeTypeAudit
:IAudit{ 
public DegreeToDegreeTypeAudit()
{
}
[Column(name:"DegreeID")]
public int? DegreeID {get; set;}
[Column(name:"DegreeTypeID")]
public int? DegreeTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
