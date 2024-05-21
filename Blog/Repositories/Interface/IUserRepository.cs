using Microsoft.AspNetCore.Identity;

namespace Blog.Web.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>>GetAll();
    }
}
