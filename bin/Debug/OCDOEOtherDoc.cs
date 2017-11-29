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
[Table("OCDOEOtherDoc")]
public partial class OCDOEOtherDoc
:IAuditable{ 
public OCDOEOtherDoc()
{
}
[Column(name:"AddedByDOE")]
[StringLength(1)]
public string AddedByDOE {get; set;}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"AssociatedRecordID")]
public int? AssociatedRecordID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Description")]
[StringLength(200)]
public string Description {get; set;}
[Column(name:"DocumentTypeID")]
public int? DocumentTypeID {get; set;}
[Column(name:"ElectronicEntry")]
[StringLength(1)]
public string ElectronicEntry {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"Received")]
[StringLength(1)]
public string Received {get; set;}
}
[Table("OCDOEOtherDocAudit")]
public partial class OCDOEOtherDocAudit
:IAudit{ 
public OCDOEOtherDocAudit()
{
}
[Column(name:"AddedByDOE")]
[StringLength(1)]
public string AddedByDOE {get; set;}
[Column(name:"AppID")]
public int? AppID {get; set;}
[Column(name:"AssociatedRecordID")]
public int? AssociatedRecordID {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"Description")]
[StringLength(200)]
public string Description {get; set;}
[Column(name:"DocumentTypeID")]
public int? DocumentTypeID {get; set;}
[Column(name:"ElectronicEntry")]
[StringLength(1)]
public string ElectronicEntry {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"Received")]
[StringLength(1)]
public string Received {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
