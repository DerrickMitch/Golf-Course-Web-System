namespace StoreAPI.Models;

public class Manufacturer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Product> Products { get; set; }
    public string Location { get; set; }
}