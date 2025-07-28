using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController
{
    private readonly ILogger<ProductController> _logger;
    private readonly ProductContext _productContext;
    public ProductController(ILogger<ProductController> logger, ProductContext productContext)
    {
        _logger = logger?? throw new ArgumentNullException(nameof(logger));
        _productContext = productContext?? throw new ArgumentNullException(nameof(productContext));
    }
    [HttpGet]
    public async Task<IEnumerable<Product>> Get()
    {
        _logger.LogInformation("Fetching all products");
        //var rng = new Random();
        //return Enumerable.Range(1, 5).Select(index => new Product
        //{
        //    Name = $"Product {index}",

        //}).ToArray();
        //return ProductContext.Products;
        return await _productContext
                                .Products
                                .Find(_ => true)
                                .ToListAsync();
    }
}
