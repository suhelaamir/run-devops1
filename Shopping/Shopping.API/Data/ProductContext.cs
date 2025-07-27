using Shopping.API;

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
