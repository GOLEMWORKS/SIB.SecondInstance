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
        [Required]
        public string Author { get; set; }
        [Required]
        public string Content { get; set; }
        public List<Tag> Tags { get; set; }
        public DateTime DOC { get; set; } = DateTime.Now;
        public int Views { get; set; }
        public bool IsVisible { get; set; } = true;
    }
}
