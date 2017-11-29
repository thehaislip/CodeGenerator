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
[Table("OCDOESectionCategoryCompletionMatrix")]
public partial class OCDOESectionCategoryCompletionMatrix
:IAuditable{ 
public OCDOESectionCategoryCompletionMatrix()
{
}
[Required]
[Column(name:"AppTypeID")]
public int AppTypeID {get; set;}
[Column(name:"CategoryCode")]
[StringLength(2)]
public string CategoryCode {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SectionCode")]
[StringLength(2)]
public string SectionCode {get; set;}
[ForeignKey("AppTypeID")]
public virtual OCAppTypeSupt OCAppTypeSupt{get; set;}
}
[Table("OCDOESectionCategoryCompletionMatrixAudit")]
public partial class OCDOESectionCategoryCompletionMatrixAudit
:IAudit{ 
public OCDOESectionCategoryCompletionMatrixAudit()
{
}
[Required]
[Column(name:"AppTypeID")]
public int AppTypeID {get; set;}
[Column(name:"CategoryCode")]
[StringLength(2)]
public string CategoryCode {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"SectionCode")]
[StringLength(2)]
public string SectionCode {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
