using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using StoreAPI.Models;
using StoreAPI.Services;

namespace StoreAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ProductService _service;

    public ProductController(ProductService service)
    {
        _service = service;
    }

    // GET: api/Product
    [HttpGet]
    public IEnumerable<Product> GetProducts()
    {
        return _service.GetProducts();
    }

    [HttpGet]
    [Route("/manufacturers")]
    public IEnumerable<Manufacturer> GetManufacturers()
    {
        return _service.GetManufacturers();
    }
}
