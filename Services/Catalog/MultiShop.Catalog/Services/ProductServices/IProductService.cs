using AutoMapper;
using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {

        Task<List<ResultProductDto>> GetAllProductAsync();

        Task CreateProductAsync(CreateProductDto createProductDto);


        Task UpdateProductAsync(UpdateProductDto updateProductDto);

        Task DeleteProductAsync(String id);

        Task<GetByIdProductDto> GetByIdProductAsync(String id);

        Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryAsync();
    }
}
