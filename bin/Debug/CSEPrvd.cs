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
[Table("CSEPrvd")]
public partial class CSEPrvd
:IAuditable{ 
public CSEPrvd()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ContractType")]
public int? ContractType {get; set;}
[Column(name:"CSEAssgnID")]
public int? CSEAssgnID {get; set;}
[Column(name:"CSEClassID")]
public int? CSEClassID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"Provider")]
[StringLength(80)]
public string Provider {get; set;}
[Column(name:"ProviderID")]
public int? ProviderID {get; set;}
[Column(name:"ProviderName")]
[StringLength(255)]
public string ProviderName {get; set;}
[Column(name:"ProviderType")]
public int? ProviderType {get; set;}
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
[ForeignKey("CSEAssgnID")]
public virtual CSEAssgn CSEAssgn{get; set;}
[ForeignKey("CSEClassID")]
public virtual CSEClass CSEClass{get; set;}
[ForeignKey("ProviderID")]
public virtual PrvdT2 PrvdT2{get; set;}
[ForeignKey("ProviderType")]
public virtual CommLookup CommLookup{get; set;}
}
[Table("CSEPrvdAudit")]
public partial class CSEPrvdAudit
:IAudit{ 
public CSEPrvdAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ContractType")]
public int? ContractType {get; set;}
[Column(name:"CSEAssgnID")]
public int? CSEAssgnID {get; set;}
[Column(name:"CSEClassID")]
public int? CSEClassID {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"Provider")]
[StringLength(80)]
public string Provider {get; set;}
[Column(name:"ProviderID")]
public int? ProviderID {get; set;}
[Column(name:"ProviderName")]
[StringLength(255)]
public string ProviderName {get; set;}
[Column(name:"ProviderType")]
public int? ProviderType {get; set;}
[Column(name:"SSN")]
[StringLength(9)]
public string SSN {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
