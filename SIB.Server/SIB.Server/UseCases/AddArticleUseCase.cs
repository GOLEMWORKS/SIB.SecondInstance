using SIB.Server.Data;
using SIB.Server.UseCases.Interfaces;
using SIB.Server.UseCases.PluginInterfaces;

namespace SIB.Server.UseCases
{
    public class AddArticleUseCase : IAddArticleUseCase
    {
        private readonly IArticleRepository _articleRepository;

        public AddArticleUseCase(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task ExecuteAsync(Article article)
        {
            if (article == null) return;
            await _articleRepository.AddArticleAsync(article);
        }
    }
}
