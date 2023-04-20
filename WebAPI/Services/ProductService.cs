using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Services;

public class ProductService
{
    private readonly ProductContext _context;

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