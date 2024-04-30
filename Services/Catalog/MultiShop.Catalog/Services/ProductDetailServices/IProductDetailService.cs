﻿using MultiShop.Catalog.Dtos.ProductDetailDtos;

namespace MultiShop.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {
        Task<List<ResultProductDetailDto>> GetAllProductDetailAsync();

        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);


        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);

        Task DeleteProductDetailAsync(String id);

        Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(String id);
    }
}
