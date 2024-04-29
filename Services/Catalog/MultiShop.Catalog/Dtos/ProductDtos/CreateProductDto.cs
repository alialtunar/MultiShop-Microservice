namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class CreateProductDto
    {

        public String ProductName { get; set; }

        public Decimal ProductPrice { get; set; }

        public String ProductImageUrl { get; set; }

        public String ProductDescription { get; set; }
    }
}
