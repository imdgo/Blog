using Blog.Web.Models.Domain;

namespace Blog.Web.Repositories.Interface
{
    public interface IBlogPostRepository
    {
        Task<IEnumerable<BlogPost>> GetAllPostsAsync();
        Task<BlogPost?> GetAsync(Guid id);
        Task<BlogPost> AddAsync(BlogPost post);
        Task<BlogPost?>UpdateAsync(BlogPost post);
        Task<BlogPost?> DeleteAsync(Guid id);

    }
}
