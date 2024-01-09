using SIB.Server.Data;
using SIB.Server.UseCases.Interfaces;
using SIB.Server.UseCases.PluginInterfaces;

namespace SIB.Server.UseCases
{
    public class GetAllArticlesUseCase : IGetAllArticlesUseCase
    {
        private IArticleRepository _articleRepository;
        public GetAllArticlesUseCase(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<List<Article>> ExecuteAsync()
        {
            return await _articleRepository.GetAllArticlesAsync();
        }
    }
}
