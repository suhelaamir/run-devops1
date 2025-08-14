using MongoDB.Bson.Serialization.Attributes;

namespace Shopping.API.Models;

public class Product
{
    //[BsonId]
    //[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public Int32 Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageFile { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
