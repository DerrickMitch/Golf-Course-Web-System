namespace StoreAPI.Models;

public class ShoppingCart
{
    /// <summary>
    /// Products that have been added to cart
    /// </summary>
    public List<Product> Products { get; set; }

    /// <summary>
    /// Subtotal cost of all Products in cart
    /// </summary>
    public decimal SubtotalCost { get; set; }

    /// <summary>
    /// Calculated sales tax based on subtotal and purchaser location
    /// </summary>
    public decimal? SalesTax { get; set; }

    /// <summary>
    /// Total cost of Products in cart with Sales Tax added
    /// </summary>
    public decimal TotalCost { get; set; }



    public void AddToCart(Product product)
    {

    }

    public void RemoveFromCart(Product product)
    {
        
    }
}