using SIB.Server.Data;

namespace SIB.Server.UseCases.Interfaces
{
    public interface IGetAllTagsUseCase
    {
        Task<List<Tag>> ExecuteAsync();
    }
}