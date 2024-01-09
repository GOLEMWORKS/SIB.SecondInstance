using SIB.Server.Data;

namespace SIB.Server.UseCases.Interfaces
{
    public interface IGetAllArticlesUseCase
    {
        Task<List<Article>> ExecuteAsync();
    }
}