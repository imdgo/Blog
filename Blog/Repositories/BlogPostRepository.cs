using Blog.Web.Data;
using Blog.Web.Models.Domain;
using Blog.Web.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly BlogDbContext blogDbContext;

        public BlogPostRepository(BlogDbContext blogDbContext)
        {
            this.blogDbContext = blogDbContext;
        }

        public async Task<BlogPost> AddAsync(BlogPost blogPost)
        {
            await blogDbContext.AddAsync(blogPost);
            await blogDbContext.SaveChangesAsync();

            return blogPost;
        }

        Task<BlogPost?> IBlogPostRepository.DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BlogPost>> GetAllPostsAsync()
        {
            return await blogDbContext.BlogPosts.Include(x => x.Tags).ToListAsync();
        }

        Task<BlogPost?> IBlogPostRepository.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<BlogPost?> IBlogPostRepository.UpdateAsync(BlogPost post)
        {
            throw new NotImplementedException();
        }
    }
}
