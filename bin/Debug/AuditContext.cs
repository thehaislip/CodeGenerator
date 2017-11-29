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
public class AuditContext : DbContext
{
private const string AuditActionColumnName = "StampAction";
private const string AuditStampUserColumnName = "StampUser";
private const string AuditStampDateColumnName = "StampDate";
private const string AuditStampIDColumnName = "StampID";

private static Dictionary<Type, AuditTypeInfo> auditTypes = new Dictionary<Type, AuditTypeInfo>();

#region Constructors
/// <summary>
/// Initializes a new instance of the AuditDbContext class
/// using the given string as the name or connection string
/// for the database to which a connection will be made.
/// </summary>
/// <param name="nameOrConnectionString">Either the database name or the connection string.</param>
public AuditContext(string nameOrConnectionString)
: base(nameOrConnectionString)
{
}

#endregion Constructors


public static bool AuditEnabled { get; private set; }

/// <summary>
/// Registers and type for auditing.
/// </summary>
/// <param name="auditableEntityType">Type to audit, must implement IAuditable.</param>
/// <param name="auditEntityType">Type of audit entity, must implement IAudit.</param>
public static void RegisterAuditType(Type auditableEntityType, Type auditEntityType)
{
AuditEnabled = true;
// Basic parameter validation.
if (auditableEntityType == null)
{
throw new ArgumentNullException("auditableEntityType");
}

if (auditTypes.ContainsKey(auditableEntityType))
{
return;
}

// Validate the entity.
var iface = auditableEntityType.GetInterface("IAuditable");
if (iface == null)
{
throw new ArgumentException("Entity does implement IAuditable", "auditableEntityType");
}

AuditTypeInfo info = new AuditTypeInfo { EntityType = auditableEntityType, AuditEntityType = auditEntityType };

// Validate the auditEntity
if (auditEntityType != null)
{
iface = auditEntityType.GetInterface("IAudit");
if (iface == null)
{
throw new ArgumentException("Entity does implement IAudit", "auditEntityType");
}

// Extract the list of properties to audit.
var properties = auditEntityType.GetProperties();
var entityProperties = auditableEntityType.GetProperties().ToDictionary(x => x.Name);
foreach (var property in properties)
{
if (entityProperties.ContainsKey(property.Name))
{
if (property.PropertyType == entityProperties[property.Name].PropertyType)
{
info.AuditProperties.Add(property.Name);
}
}
}
}

// Valid so register.
auditTypes.Add(auditableEntityType, info);
}

/// <summary>
/// Reloads the entity from the database overwriting any property values with values from the database.
/// The entity will be in the Unchanged state after calling this method.
/// </summary>
/// <param name="entity">The entity object to reload.</param>
public void Reload(object entity)
{
this.Entry(entity).Reload();
}

  public string GetClaimValue(IPrincipal currentPrincipal, string key)
  {
      var identity = currentPrincipal.Identity as ClaimsIdentity;
      if (identity == null)
          return WindowsIdentity.GetCurrent().Name;
      var claim = identity.Claims.FirstOrDefault(c => c.Type == key);
      if (claim == null)
      {
          return WindowsIdentity.GetCurrent().Name;
      }
      return claim.Value;
  }

/// <summary>
/// Saves all changes made in this context to the underlying database
/// using the current windows user for auditing.
/// </summary>
/// <returns>The number of objects written to the underlying database.</returns>
public override int SaveChanges()
{
var stampuser = GetClaimValue(System.Web.HttpContext.Current.User,ClaimTypes.Sid);
return this.SaveChanges(stampuser);
}

/// <summary>
/// Saves all changes made in this context to the underlying database
/// using the user parameter passed for auditing.
/// </summary>
/// <param name="user">User name for auditing.</param>
/// <returns>The number of objects written to the underlying database.</returns>
    public int SaveChanges(string user)
 {
if (AuditEnabled)
{
    // Track all audit entities created in this transaction, will be removed from context on exception.
    List<IAudit> audits = new List<IAudit>();

// Use the same datetime for all updates in this transaction, retrieved from server when first used.
DateTime? updateDateTime = null;

// Process any audit-able objects.
foreach (DbEntityEntry<IAuditable> auditable in this.ChangeTracker.Entries<IAuditable>())
{
if (auditable.State == EntityState.Added
|| auditable.State == EntityState.Modified
|| auditable.State == EntityState.Deleted)
{
    // Need datetime for the audits.
    if (updateDateTime.HasValue == false)
    {
        updateDateTime = DateTime.Now;
    }

// Create an audit entity.
if (auditable.State == EntityState.Modified
 || auditable.State == EntityState.Added)
{
    // TODO: Find a better way of doing this proxy check.
    Type entityType = auditable.Entity.GetType();
    if (auditTypes.ContainsKey(entityType) && auditTypes[entityType].AuditEntityType != null)
    {
        audits.Add(this.AuditEntity(auditable, auditTypes[entityType], updateDateTime.Value, user));
    }
}
else if (auditable.State == EntityState.Deleted)
{
    Type entityType = auditable.Entity.GetType().BaseType;
           if (entityType == typeof(object))
{
   entityType = auditable.Entity.GetType();
}
    audits.Add(this.AuditEntity(auditable, auditTypes[entityType], updateDateTime.Value, user));
}

    }
}

// Perform the updates.
try
{
    var changes = ChangeTracker.Entries<IAuditable>().Where(e => e.State == EntityState.Added).ToList();
    base.SaveChanges();
    var completedChanges = new List<DbEntityEntry<IAuditable>>();

foreach (var audit in audits)
{

foreach (var change in changes)
{
    if (audit.StampID == 0 && audit.GetType() == auditTypes[change.Entity.GetType()].AuditEntityType
            && completedChanges.IndexOf(change) == -1)
    {
        audit.StampID = change.Entity.ID;
        completedChanges.Add(change);
    }


    }
}
return base.SaveChanges();

}
catch (Exception ex)
{
    // Updated failed so remove the audit entities.
    foreach (var item in audits)
    {
        this.Set(item.GetType()).Remove(item);
    }

throw;
    }
}
else
{
    return base.SaveChanges();
}
 }

 private IAudit AuditEntity(DbEntityEntry entityEntry, AuditTypeInfo auditTypeInfo, DateTime auditDateTime, string user)
 {
// Create audit entity.
DbSet set = this.Set(auditTypeInfo.AuditEntityType);
IAudit auditEntity = set.Create() as IAudit;
set.Add(auditEntity);

// Copy the properties.
DbEntityEntry auditEntityEntry = this.Entry(auditEntity);
foreach (string propertyName in auditTypeInfo.AuditProperties)
{
if (entityEntry.State == EntityState.Deleted)
{
    if (propertyName.ToLower() != "id")
    {
        auditEntityEntry.Property(propertyName).CurrentValue = entityEntry.OriginalValues[propertyName];
    }
    else
    {
        auditEntityEntry.Property(AuditStampIDColumnName).CurrentValue = entityEntry.OriginalValues[propertyName];
    }
}
else
{
    if (propertyName.ToLower() != "id")
    {
        auditEntityEntry.Property(propertyName).CurrentValue = entityEntry.Property(propertyName).CurrentValue;
    }
    else
    {
        auditEntityEntry.Property(AuditStampIDColumnName).CurrentValue = entityEntry.Property(propertyName).CurrentValue;
    }
}
}

// Set the audit columns.
auditEntityEntry.Property(AuditStampDateColumnName).CurrentValue = auditDateTime;
auditEntityEntry.Property(AuditStampUserColumnName).CurrentValue = user;
auditEntityEntry.Property(AuditStampIDColumnName).CurrentValue = entityEntry.Property("ID").CurrentValue;
switch (entityEntry.State)
{
case EntityState.Modified:
    auditEntityEntry.Property(AuditActionColumnName).CurrentValue = "U";
    break;
case EntityState.Added:
    auditEntityEntry.Property(AuditActionColumnName).CurrentValue = "I";
    break;
case EntityState.Deleted:
    auditEntityEntry.Property(AuditActionColumnName).CurrentValue = "D";
    break;
default:
    break;
}

     return auditEntity;
 }
}
}
