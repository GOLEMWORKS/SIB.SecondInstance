using SIB.Server.Data;

namespace SIB.Server.UseCases.Interfaces
{
    public interface IAddArticleUseCase
    {
        Task ExecuteAsync(Article article);
    }
}