namespace StoreAPI.Models;

public class Product
{
    /// <summary>
    /// Represents Unique ID for Database
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of Product
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Model info of Product
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Id of Manufacturer (for API)
    /// </summary>
    public int ManufacturerId { get; set; }

    /// <summary>
    /// Manufacturer instance
    /// </summary>
    public Manufacturer Manufacturer { get; set; }

    /// <summary>
    /// True if stock count is greater than 1
    /// </summary>
    public bool InStock 
    { 
        get 
        {
            return StockCount > 0;
        } 
    }

    /// <summary>
    /// Number of items in stock available for purchase
    /// </summary>
    public int StockCount { get; set; }

    /// <summary>
    /// Set price for sale
    /// </summary>
    public decimal SalePrice { get; set; }

    /// <summary>
    /// Represents cost of aquisition, used to calculate profits
    /// </summary>
    public decimal PurchasePrice { get; set; }

    /// <summary>
    /// Represents quanity sold
    /// </summary>
    public int SoldCount { get; set; }
}