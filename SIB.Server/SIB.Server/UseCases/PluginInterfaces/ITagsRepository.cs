using SIB.Server.Data;

namespace SIB.Server.UseCases.PluginInterfaces
{
    public interface ITagsRepository
    {
        Task<List<Tag>> GatAllTagsAsync();
    }
}