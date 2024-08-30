using ForumApp24.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp24.Infrastructure.Data.Models
{
    public class Post
    {
        [Key]
        [Comment("Post identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.titleMaxLength)]
        [Comment("Post title")]
        public string? Title { get; set; }

        [Required]
        [MaxLength(ValidationConstants.contentMaxLength)]
        [MinLength(ValidationConstants.contentMinLength)]
        [Comment("Post content")]
        public string? Content { get; set; }
    }
}
