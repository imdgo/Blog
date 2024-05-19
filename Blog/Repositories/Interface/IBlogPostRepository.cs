using Blog.Web.Models.Domain;

namespace Blog.Web.Repositories.Interface
{
    public interface IBlogPostRepository
    {
        Task<IEnumerable<BlogPost>> GetAllPostsAsync();
        Task<BlogPost?> GetAsync();
        Task<BlogPost> AddAsync(BlogPost post);
        Task<BlogPost?>UpdateAsync(BlogPost post);
        Task<BlogPost?> DeleteAsync(Guid id);

    }
}
