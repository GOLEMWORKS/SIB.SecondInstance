using System.ComponentModel.DataAnnotations;

namespace SIB.Server.Data
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
