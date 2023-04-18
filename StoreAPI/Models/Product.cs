namespace StoreAPI.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public int ManufacturerId { get; set; }
    public Manufacturer Manufacturer { get; set; }
    public bool InStock 
    { 
        get 
        {
            return StockCount > 0;
        } 
    }
    public int StockCount { get; set; }
    public decimal SalePrice { get; set; }
    public decimal PurchasePrice { get; set; }
    public int SoldCount { get; set; }
}