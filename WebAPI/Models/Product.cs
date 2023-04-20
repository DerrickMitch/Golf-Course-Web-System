namespace WebAPI.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Manufacturer? Manufacturer { get; set; }
    public int? ManufacturerId { get; set; }
    public int StockCount { get; set; }
    public int SoldCount { get; set; }
    public decimal Price { get; set; }
}