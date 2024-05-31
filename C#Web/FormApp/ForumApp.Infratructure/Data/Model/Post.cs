using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Infratructure.Data.Model
{
    public class Post
    {
        [Key]
        [Comment("Post Identifier")]
        public int Id { get; set; }
    }
}
