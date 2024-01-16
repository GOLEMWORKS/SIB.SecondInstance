using Microsoft.EntityFrameworkCore;
using SIB.Server.Data;
using SIB.Server.UseCases.PluginInterfaces;
using System.Linq.Dynamic.Core;

namespace SIB.Server.Plugins
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddArticleAsync(Article article)
        {
            if (_context.Articles.Any(a => a.Title.ToLower() == article.Title.ToLower())) return;

            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Article>> GetArticlesById(int articleID)
        {
            return await _context.Articles.Where(a => a.Id == articleID).ToListAsync();
        }

        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await _context.Articles.ToListAsync();
        }
    }
}
