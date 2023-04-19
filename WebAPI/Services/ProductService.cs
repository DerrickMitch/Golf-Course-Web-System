using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Services;

public class ProductService
{
    private ProductContext _context;

    public ProductService(ProductContext _context)
    {
        this._context = _context;
    }

    public IEnumerable<Product> GetProducts()
    {
        var output = _context.Products;
        return output;
    }

    public IEnumerable<Manufacturer> GetManufacturers()
    {
        return _context.Manufacturers;
    }

    public async Task AddProduct(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }
}