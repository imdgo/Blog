using Blog.Web.Data;
using Blog.Web.Models.Domain;
using Blog.Web.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Repositories
{
    public class BlogPostLikeRepository : IBlogPostLikeRepository
    {
        private readonly BlogDbContext blogDbContext;

        public BlogPostLikeRepository(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }

        public async Task<BlogPostLike> AddLikeForBlog(BlogPostLike blogPostLike)
        {
            await blogDbContext.AddAsync(blogPostLike);
            await blogDbContext.SaveChangesAsync();

            return blogPostLike;
        }

        public async Task<int> GetTotalLikes(Guid blogPostId)
        {
            return await blogDbContext.BlogPostLike.CountAsync(x => x.BlogPostId == blogPostId);

        }
    }
}
