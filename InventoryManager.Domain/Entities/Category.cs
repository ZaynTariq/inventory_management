namespace InventoryManager.Domain.Entities;

using InventoryManager.Domain.Entities.Base;

public class Category : BaseEntity {
    public Category() {
        
    }
    public string Name { get; set; } = default!;
    public List<Asset> Assets { get; set; } = default!;
}
