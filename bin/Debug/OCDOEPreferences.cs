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
[Table("OCDOEPreferences")]
public partial class OCDOEPreferences
:IAuditable{ 
public OCDOEPreferences()
{
}
[Column(name:"AppTypes")]
[StringLength(20)]
public string AppTypes {get; set;}
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
[Column(name:"Logon")]
[StringLength(20)]
public string Logon {get; set;}
[Required]
[Column(name:"SectionCategoryFilter")]
[StringLength(2)]
public string SectionCategoryFilter {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
}
[Table("OCDOEPreferencesAudit")]
public partial class OCDOEPreferencesAudit
:IAudit{ 
public OCDOEPreferencesAudit()
{
}
[Column(name:"AppTypes")]
[StringLength(20)]
public string AppTypes {get; set;}
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
[Column(name:"Logon")]
[StringLength(20)]
public string Logon {get; set;}
[Required]
[Column(name:"SectionCategoryFilter")]
[StringLength(2)]
public string SectionCategoryFilter {get; set;}
[Column(name:"SortOrder")]
public int? SortOrder {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
