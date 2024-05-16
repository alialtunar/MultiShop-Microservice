using MultiShop.Catalog.Dtos.FeatureSliderDtos;

namespace MultiShop.Catalog.Services.FeatureSliderServices
{
    public interface IFeatureSliderService
    {
        Task<List<ResultFeatureSliderDto>> GetAllFeatureSliderAsync();

        Task CreateFeatureSliderAsync(CreateFeatureSliderDto createFeatureSliderDto);


        Task UpdateFeatureSliderAsync(UpdateFeatureSliderDto updateFeatureSliderDto);

        Task DeleteFeatureSliderAsync(string id);

        Task<GetByIdFeatureSliderDto> GetByIdFeatureSliderAsync(String id);

        Task FeatureSliderChangesStatusToTrue(string id);
        Task FeatureSliderChangesStatusToFalse(string id);

    }
}
