namespace InventoryManager.Domain.Entities;

using InventoryManager.Domain.Entities.Base;
using InventoryManager.Shared.Enums;

public class User : BaseEntity {
    public string Username { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Email { get; set; } = default!;
    public Role Role { get; set; } = default!;
    public List<Asset> Assets { get; set; } = default!;
}
