using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Services;

public class ProductService
{
    private IWebHostEnvironment webHostEnvironment;
    private ProductContext context;

    public ProductService(IWebHostEnvironment _webHostEnvironment, ProductContext _context)
    {
        webHostEnvironment = _webHostEnvironment;
        context = _context;
    }

    public IEnumerable<Product> GetProducts()
    {
        
    }
}