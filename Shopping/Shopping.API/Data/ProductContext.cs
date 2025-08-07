//using MongoDB.Driver;
//using Shopping.API.Models;

//namespace Shopping.API.Data;

//public class ProductContext
//{
//    public ProductContext(IConfiguration configuration)
//    {
//        var client = new MongoDB.Driver.MongoClient(configuration["DatabaseSettings:ConnectionString"]);
//        var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);
//        Products = database.GetCollection<Product>(configuration["DatabaseSettings:CollectionName"]);
//        SeedData(Products);
//    }
//    public IMongoCollection<Product> Products { get; }
//    public static void SeedData(IMongoCollection<Product> productCollection)
//    {
//        //can you optimise below code
//        bool existProduct = productCollection.Find(_ => true).Any();
//        if (!existProduct)
//        {
//            productCollection.InsertMany(GetPreConfiguredProducts());
//        }
//    }
//    private static IEnumerable<Product> GetPreConfiguredProducts()
//    {
//        return new List<Product>()
//        { 
//            new Product
//            {
//                Name = "Apple",
//                Category = "Fruits",
//                Description = "Fresh and juicy apples.",
//                ImageFile = "apple.jpg",
//                Price = 3000
//            },
//            new Product
//            {
//                Name = "Banana",
//                Category = "Fruits",
//                Description = "Sweet and ripe bananas.",
//                ImageFile = "banana.jpg",
//                Price = 1200
//            },
//            new Product
//            {
//                Name = "Carrot",
//                Category = "Vegetables",
//                Description = "Crunchy and healthy carrots.",
//                ImageFile = "carrot.jpg",
//                Price = 1700
//            }
//        };
//    }
//}
using Shopping.API;
using Shopping.API.Models;

namespace Shopping.API.Data;

public static class ProductContext
{
    public static readonly List<Product> Products = new()
    {
        new Product
        {
            Id = 1,
            Name = "Apple",
            Category = "Fruits",
            Description = "Fresh and juicy apples.",
            ImageFile = "apple.jpg",
            Price = 0.5m
        },
        new Product
        {
            Id = 2,
            Name = "Banana",
            Category = "Fruits",
            Description = "Sweet and ripe bananas.",
            ImageFile = "banana.jpg",
            Price = 0.3m
        },
        new Product
        {
            Id = 3,
            Name = "Carrot",
            Category = "Vegetables",
            Description = "Crunchy and healthy carrots.",
            ImageFile = "carrot.jpg",
            Price = 0.2m
        }
    };
}
