namespace StoreAPI.Models;

public class ShoppingCart
{
    public List<Product> Products { get; set; }
    public decimal SubtotalCost { get; set; }
    public decimal SalesTax { get; set; }
    public decimal TotalCost { get; set; }

    public void AddToCart(Product product)
    {

    }

    public void RemoveFromCart(Product product)
    {
        
    }
}