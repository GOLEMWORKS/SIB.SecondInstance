using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIB.Server.Data
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime DOC { get; set; } = DateTime.Now;
        public int Views { get; set; }
    }
}
