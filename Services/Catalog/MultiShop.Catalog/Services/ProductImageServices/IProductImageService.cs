using MultiShop.Catalog.Dtos.ProductImageDto;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {
        Task<List<ResultProductImageDto>> GetAllProductImageAsync();

        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);


        Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);

        Task DeleteProductImageAsync(String id);

        Task<GetByIdProductImageDto> GetByIdProductImageAsync(String id);
    }
}
