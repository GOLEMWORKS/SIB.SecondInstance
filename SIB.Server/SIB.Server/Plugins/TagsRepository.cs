using Microsoft.EntityFrameworkCore;
using SIB.Server.Data;
using SIB.Server.UseCases.PluginInterfaces;

namespace SIB.Server.Plugins
{
    public class TagsRepository : ITagsRepository
    {
        private readonly ApplicationDbContext _context;

        public TagsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tag>> GatAllTagsAsync()
        {
            return await _context.Tags.ToListAsync();
        }
    }
}
