﻿namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class GetByIdProductDto
    {
        public String ProductID { get; set; }

        public String ProductName { get; set; }

        public Decimal ProductPrice { get; set; }

        public String ProductImageUrl { get; set; }

        public String ProductDescription { get; set; }
    }
}