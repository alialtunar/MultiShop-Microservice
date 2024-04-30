using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String ProductID { get; set; }

        public String ProductName { get; set; }

        public Decimal ProductPrice { get; set; }

        public String ProductImageUrl { get; set; }

        public String ProductDescription { get; set; }

        public String CategoryId { get; set; }

        [BsonIgnore]
        public Category Category { get; set; }
    }
}
