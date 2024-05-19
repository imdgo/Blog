using Blog.Web.Data;
using Blog.Web.Models.Domain;
using Blog.Web.Repositories.Interface;

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

        Task<IEnumerable<BlogPost>> IBlogPostRepository.GetAllPostsAsync()
        {
            throw new NotImplementedException();
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
