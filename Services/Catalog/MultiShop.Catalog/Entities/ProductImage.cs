using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entities
{
    public class ProductImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String ProductImageID { get; set; }

        public String Image1 { get; set; }

        public String Image2 { get; set; }

        public String Image3 { get; set; }

        public String ProductId { get; set; }

        [BsonIgnore]
        public Product Product { get; set; }
    }
}
