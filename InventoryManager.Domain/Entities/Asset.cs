namespace InventoryManager.Domain.Entities;

using InventoryManager.Domain.Entities.Base;
public class Asset : BaseEntity {
    public string Name { get; set; } = default!;
    public string SerialNumber { get; set; } = default!;
    public DateTime PurchaseDate { get; set; }
    public int CategoryId { get; set; }
    public int LocationId { get; set; }
    public string Status { get; set; } = default!;
}
