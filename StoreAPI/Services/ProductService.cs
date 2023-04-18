using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Services;

public class ProductService
{
    private ProductContext context;

    public ProductService(ProductContext _context)
    {
        context = _context;
    }

    public IEnumerable<Product> GetProducts()
    {
        var output = context.Products;
        return output;
    }

    public IEnumerable<Manufacturer> GetManufacturers()
    {
        return context.Manufacturers;
    }
}