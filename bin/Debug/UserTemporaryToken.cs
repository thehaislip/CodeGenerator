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
[Table("UserTemporaryToken")]
public partial class UserTemporaryToken
:IAuditable{ 
public UserTemporaryToken()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ExpirationDate",TypeName = "datetime2")]
public DateTime? ExpirationDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"TemporaryToken")]
public string TemporaryToken {get; set;}
[Column(name:"Type")]
[StringLength(1)]
public string Type {get; set;}
[Required]
[Column(name:"UserID")]
public int UserID {get; set;}
[ForeignKey("UserID")]
public virtual User User{get; set;}
}
[Table("UserTemporaryTokenAudit")]
public partial class UserTemporaryTokenAudit
:IAudit{ 
public UserTemporaryTokenAudit()
{
}
[Column(name:"ConcurrencyID",TypeName = "timestamp")]
[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
[MaxLength(8)]
public byte[] ConcurrencyID {get; set;}
[Column(name:"ExpirationDate",TypeName = "datetime2")]
public DateTime? ExpirationDate {get; set;}
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
[Required]
[Column(name:"ID")]
public int ID {get; set;}
[Required]
[Column(name:"TemporaryToken")]
public string TemporaryToken {get; set;}
[Column(name:"Type")]
[StringLength(1)]
public string Type {get; set;}
[Required]
[Column(name:"UserID")]
public int UserID {get; set;}
public int StampID {get;set;}
public DateTime StampDate {get;set;}
[Column(TypeName = "char")]
public string StampAction {get;set;}
public string StampUser {get;set;}
}
}
