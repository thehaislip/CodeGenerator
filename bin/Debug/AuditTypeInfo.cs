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
internal class AuditTypeInfo
{
internal AuditTypeInfo()
{
this.AuditProperties = new Collection<string>();
}
internal Type EntityType { get; set; }
internal Type AuditEntityType { get; set; }
internal Collection<string> AuditProperties { get; set; }
}
}
