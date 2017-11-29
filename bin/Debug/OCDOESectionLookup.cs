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
[Table("OCDOESectionLookup")]
public partial class OCDOESectionLookup
:IAuditable{ 
public OCDOESectionLookup()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SectionCategoryCode")]
[StringLength(2)]
public string SectionCategoryCode {get; set;}
[Required]
[Column(name:"SectionCode")]
[StringLength(2)]
public string SectionCode {get; set;}
[Column(name:"SectionDescription")]
[StringLength(200)]
public string SectionDescription {get; set;}
}
[Table("OCDOESectionLookupAudit")]
public partial class OCDOESectionLookupAudit
:IAudit{ 
public OCDOESectionLookupAudit()
{
}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SectionCategoryCode")]
[StringLength(2)]
public string SectionCategoryCode {get; set;}
[Required]
[Column(name:"SectionCode")]
[StringLength(2)]
public string SectionCode {get; set;}
[Column(name:"SectionDescription")]
[StringLength(200)]
public string SectionDescription {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
