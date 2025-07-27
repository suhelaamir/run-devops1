using Microsoft.AspNetCore.Mvc;
using Shopping.API.Data;

namespace Shopping.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController
{
    private readonly ILogger<ProductController> _logger;
    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IEnumerable<Product> Get()
    {
        _logger.LogInformation("Fetching all products");
        //var rng = new Random();
        //return Enumerable.Range(1, 5).Select(index => new Product
        //{
        //    Name = $"Product {index}",
            
        //}).ToArray();
        return ProductContext.Products;
    }
}
