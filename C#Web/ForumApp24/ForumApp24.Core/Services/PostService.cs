using ForumApp24.Core.Contracts;
using ForumApp24.Core.Model;
using ForumApp24.Infrastructure.Data;
using ForumApp24.Infrastructure.Data.Models;
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

        public async Task AddAsync(PostModel model)
        {
            var entity = new Post()
            {
                Title = model.Title,
                Content = model.Content,
            };
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.FindAsync<Post>(id);
            if (entity == null)
            {
                throw new ApplicationException("Invalid Post!");
            }
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(PostModel model)
        {
            var entity = await _context.FindAsync<Post>(model.Id);
            if (entity == null)
            {
                throw new ApplicationException("Invalid Post!");
            }
            entity.Title = model.Title;
            entity.Content = model.Content;

            await _context.SaveChangesAsync();
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

        public async Task<PostModel?> GetByIdAsync(int id)
        {
            return await _context.Posts
                .Where(p => p.Id == id)
                .Select(p => new PostModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content
                }).AsNoTracking()
                .FirstOrDefaultAsync();
        }
    }
}
