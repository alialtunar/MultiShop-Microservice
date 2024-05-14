using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.DtoLayer.CatalogDtos.ProductDtos
{
    public class UpdateProductDto
    {
        public String ProductID { get; set; }

        public String ProductName { get; set; }

        public Decimal ProductPrice { get; set; }

        public String ProductImageUrl { get; set; }

        public String ProductDescription { get; set; }

        public String CategoryId { get; set; }
    }
}
