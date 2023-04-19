namespace StoreAPI.Models;

public class Manufacturer
{
    /// <summary>
    /// Represents unique identifer in Database
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of Manufacturer
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// List of all products associated with Manufacturer
    /// </summary>
    public List<Product> Products { get; set; }

    /// <summary>
    /// Address of Manufacturer headquarters
    /// </summary>
    public string Location { get; set; }
}