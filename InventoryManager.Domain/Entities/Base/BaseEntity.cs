namespace InventoryManager.Domain.Entities.Base;

using System;
public interface IEntity;

public interface ITrackedEntity : IEntity {
    public DateTime CreatedOn { get; }
    public DateTime? ModifiedOn { get; }
}

public interface IAuditableEntity<TId> {
    public TId? CreatedBy { get; }
    public TId? ModifiedBy { get; }
} 
public class BaseEntity<TId> : ITrackedEntity, IAuditableEntity<TId> {
    public TId Id { get; set; } = default!;
    public TId? CreatedBy { get; set; }
    public TId? ModifiedBy { get; set; }
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    public DateTime? ModifiedOn { get; set; }
}


public class BaseEntity : BaseEntity<long>;

