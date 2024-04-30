using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entities
{
    public class ProductDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String ProductDetailID { get; set; }

        public String ProductDescription { get; set; }

        public String ProductInfo { get; set; }

        public String ProductId { get; set; }

        [BsonIgnore]
        public Product Product { get; set; }

    }
}
