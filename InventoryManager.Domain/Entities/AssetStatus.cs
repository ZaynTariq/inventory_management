namespace InventoryManager.Domain.Entities;

using InventoryManager.Domain.Entities.Base;

public class AssetStatus : BaseEntity {
    public string Name { get; set; } = default!;
    public List<Asset> Assets { get; set; } = default!;
}
