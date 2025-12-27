namespace InventoryManager.Domain.Entities;

using InventoryManager.Domain.Entities.Base;
public partial class Asset : BaseEntity {
    public Asset() {
        
    }
    public string Name { get; set; } = default!;
    public string SerialNumber { get; set; } = default!;
    public DateTime PurchaseDate { get; set; }
    public Category Category { get; set; } = default!;
    public int CategoryId { get; set; }
    public Location Location { get; set; } = default!;
    public int LocationId { get; set; }
    public AssetStatus Status { get; set; } = default!;
    public int StatusId { get; set; }
}
