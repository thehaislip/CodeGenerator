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
[Table("ApplicationTypeToSection")]
public partial class ApplicationTypeToSection
:IAuditable{ 
public ApplicationTypeToSection()
{
this.SectionToQuestions = new HashSet<SectionToQuestion>();
this.OCAPPSectionCompletes = new HashSet<OCAPPSectionComplete>();
}
[Required]
[Column(name:"ApplicationTypeID")]
public int ApplicationTypeID {get; set;}
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
[Column(name:"Order")]
public int Order {get; set;}
[Required]
[Column(name:"SectionID")]
public int SectionID {get; set;}
[ForeignKey("ApplicationTypeID")]
public virtual ApplicationType ApplicationType{get; set;}
[ForeignKey("ApplicationTypeToSectionID")]
public virtual ICollection<SectionToQuestion> SectionToQuestions{get; set;}
[ForeignKey("ApplicationTypeToSectionID")]
public virtual ICollection<OCAPPSectionComplete> OCAPPSectionCompletes{get; set;}
[ForeignKey("SectionID")]
public virtual Section Section{get; set;}
}
[Table("ApplicationTypeToSectionAudit")]
public partial class ApplicationTypeToSectionAudit
:IAudit{ 
public ApplicationTypeToSectionAudit()
{
}
[Required]
[Column(name:"ApplicationTypeID")]
public int ApplicationTypeID {get; set;}
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
[Column(name:"Order")]
public int Order {get; set;}
[Required]
[Column(name:"SectionID")]
public int SectionID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
