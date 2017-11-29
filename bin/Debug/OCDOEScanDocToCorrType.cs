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
[Table("OCDOEScanDocToCorrType")]
public partial class OCDOEScanDocToCorrType
:IAuditable{ 
public OCDOEScanDocToCorrType()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"CorrespondenceTypeID")]
public int? CorrespondenceTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ScanDocumentType")]
[StringLength(100)]
public string ScanDocumentType {get; set;}
[ForeignKey("CorrespondenceTypeID")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("OCDOEScanDocToCorrTypeAudit")]
public partial class OCDOEScanDocToCorrTypeAudit
:IAudit{ 
public OCDOEScanDocToCorrTypeAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"CorrespondenceTypeID")]
public int? CorrespondenceTypeID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"ScanDocumentType")]
[StringLength(100)]
public string ScanDocumentType {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
