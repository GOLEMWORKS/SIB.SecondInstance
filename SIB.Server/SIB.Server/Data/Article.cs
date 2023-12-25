using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIB.Server.Data
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Author { get; set; }
        [ForeignKey(nameof(Author))]
        public required ApplicationUser IdentityUser { get; set; }
        [Required]
        public DateTime DOC { get; set; } = DateTime.Now;
        public int Views { get; set; }
    }
}
