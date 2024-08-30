using ForumApp24.Core.Contracts;
using ForumApp24.Core.Model;
using ForumApp24.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp24.Core.Sevices
{
    public class PostService : IPostService
    {
        private readonly ForumDbContext _context;
        public PostService(ForumDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PostModel>> GetAllPostsAsync()
        {
            return await _context.Posts
                .Select(p => new PostModel()
                {
                    Content = p.Content,
                    Id = p.Id,
                    Title = p.Title
                })
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
