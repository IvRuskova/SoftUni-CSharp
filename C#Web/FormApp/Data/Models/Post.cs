using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static FormApp.Data.DataConstants;

namespace FormApp.Data.Models
{
    public class Post
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null;

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null;
        public DbSet<Post> Posts { get; init; }

    }
}
