using ForumApp24.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp24.Core.Contracts
{
    public interface IPostService
    {
        Task<IEnumerable<PostModel>> GetAllPostsAsync();
    }
}
