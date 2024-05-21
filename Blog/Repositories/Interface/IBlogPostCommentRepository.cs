using Blog.Web.Models.Domain;

namespace Blog.Web.Repositories.Interface
{
    public interface IBlogPostCommentRepository
    {
        Task<BlogPostComment> AddAsync(BlogPostComment blogPostComment);
    }
}
