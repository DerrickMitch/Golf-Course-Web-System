namespace StoreAPI.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public Manufacturer Manufacturer { get; set; }
    public string StorageLocation { get; set; }
    public bool InStock { get; set; }
    public int StockCount { get; set; }
    public decimal SalePrice { get; set; }
    public decimal PurchasePrice { get; set; }
    public int SoldCount { get; set; }
}