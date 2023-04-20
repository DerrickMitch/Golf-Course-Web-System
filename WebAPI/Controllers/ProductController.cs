using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers;

[Route("api/product")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ProductService _service;

    public ProductController(ProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Product> GetProducts()
    {
        return _service.GetProducts();
    }

    [HttpGet("{id}")]
    public Product GetProduct(int id)
    {
        Product output = _service.GetProducts().ToList().Where(x => x.Id == id).First();
        return output;
    }

    [HttpGet]
    [Route("api/manufacturers")]
    public IEnumerable<Manufacturer> GetManufacturers()
    {
        return _service.GetManufacturers();
    }

    // api/product
    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        await _service.AddProduct(product);
        return CreatedAtAction("GetProduct", new { id = product.Id }, product);
    }
}
