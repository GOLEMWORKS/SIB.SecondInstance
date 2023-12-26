using SIB.Server.Data;

namespace SIB.Server.UseCases.PluginInterfaces
{
    public interface IArticleRepository
    {
        Task AddArticleAsync(Article article);
        Task<IEnumerable<Article>> GetArticlesById(int articleID);
    }
}