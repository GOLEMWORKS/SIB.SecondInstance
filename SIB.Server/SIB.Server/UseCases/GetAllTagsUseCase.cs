using SIB.Server.Data;
using SIB.Server.UseCases.Interfaces;
using SIB.Server.UseCases.PluginInterfaces;

namespace SIB.Server.UseCases
{
    public class GetAllTagsUseCase : IGetAllTagsUseCase
    {
        private ITagsRepository _tagsRepository;
        public GetAllTagsUseCase(ITagsRepository tagsRepository)
        {
            _tagsRepository = tagsRepository;
        }

        public async Task<List<Tag>> ExecuteAsync()
        {
            return await _tagsRepository.GatAllTagsAsync();
        }
    }
}
