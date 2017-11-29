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
[Table("CorrInfo")]
public partial class CorrInfo
:IAuditable{ 
public CorrInfo()
{
this.CorrDets = new HashSet<CorrDet>();
}
[Column(name:"BlueSheeted")]
[StringLength(1)]
public string BlueSheeted {get; set;}
[Column(name:"BlueSheetMailDate",TypeName = "datetime2")]
public DateTime? BlueSheetMailDate {get; set;}
[Column(name:"CertRunDate",TypeName = "datetime2")]
public DateTime? CertRunDate {get; set;}
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InitialDate",TypeName = "datetime2")]
public DateTime? InitialDate {get; set;}
[Column(name:"MaidenName")]
[StringLength(40)]
public string MaidenName {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"ReturnFicheDate",TypeName = "datetime2")]
public DateTime? ReturnFicheDate {get; set;}
[Column(name:"WentFicheDate",TypeName = "datetime2")]
public DateTime? WentFicheDate {get; set;}
[ForeignKey("CorrInfoID")]
public virtual ICollection<CorrDet> CorrDets{get; set;}
[ForeignKey("PersonnelID")]
public virtual COMMPerson COMMPerson{get; set;}
}
[Table("CorrInfoAudit")]
public partial class CorrInfoAudit
:IAudit{ 
public CorrInfoAudit()
{
}
[Column(name:"BlueSheeted")]
[StringLength(1)]
public string BlueSheeted {get; set;}
[Column(name:"BlueSheetMailDate",TypeName = "datetime2")]
public DateTime? BlueSheetMailDate {get; set;}
[Column(name:"CertRunDate",TypeName = "datetime2")]
public DateTime? CertRunDate {get; set;}
[Column(name:"Comments")]
[StringLength(2000)]
public string Comments {get; set;}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Column(name:"InitialDate",TypeName = "datetime2")]
public DateTime? InitialDate {get; set;}
[Column(name:"MaidenName")]
[StringLength(40)]
public string MaidenName {get; set;}
[Column(name:"PersonnelID")]
public int? PersonnelID {get; set;}
[Column(name:"ReturnFicheDate",TypeName = "datetime2")]
public DateTime? ReturnFicheDate {get; set;}
[Column(name:"WentFicheDate",TypeName = "datetime2")]
public DateTime? WentFicheDate {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
