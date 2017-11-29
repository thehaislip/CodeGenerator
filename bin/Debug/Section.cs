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
[Table("Section")]
public partial class Section
:IAuditable{ 
public Section()
{
this.ApplicationTypeToSections = new HashSet<ApplicationTypeToSection>();
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DOEOnlyIndicator")]
public bool? DOEOnlyIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Name")]
[StringLength(60)]
public string Name {get; set;}
[Column(name:"SectionCode")]
[StringLength(4)]
public string SectionCode {get; set;}
[Column(name:"URL")]
[StringLength(100)]
public string URL {get; set;}
[ForeignKey("SectionID")]
public virtual ICollection<ApplicationTypeToSection> ApplicationTypeToSections{get; set;}
}
[Table("SectionAudit")]
public partial class SectionAudit
:IAudit{ 
public SectionAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"DOEOnlyIndicator")]
public bool? DOEOnlyIndicator {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"Name")]
[StringLength(60)]
public string Name {get; set;}
[Column(name:"SectionCode")]
[StringLength(4)]
public string SectionCode {get; set;}
[Column(name:"URL")]
[StringLength(100)]
public string URL {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
