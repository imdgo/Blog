using Blog.Web.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class BlogsController : Controller
    {
        private readonly IBlogPostRepository BlogPostRepository;

        public BlogsController(IBlogPostRepository blogPostRepository)
        {
            BlogPostRepository = blogPostRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string urlHandle)
        {
            var blogPost = await BlogPostRepository.GetByUrlHandleAsync(urlHandle);

            return View(blogPost);
        }
    }
}
