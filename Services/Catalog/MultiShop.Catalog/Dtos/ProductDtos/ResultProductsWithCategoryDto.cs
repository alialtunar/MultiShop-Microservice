using MultiShop.Catalog.Dtos.CategoryDtos;

namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class ResultProductsWithCategoryDto
    {
        public String ProductID { get; set; }

        public String ProductName { get; set; }

        public Decimal ProductPrice { get; set; }

        public String ProductImageUrl { get; set; }

        public String ProductDescription { get; set; }

        public String CategoryId { get; set; }
        public ResultCategoryDto Category { get; set; }
    }
}
