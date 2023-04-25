using Microsoft.AspNetCore.Identity;

namespace MyFirstDemo.Api.Repositories
{
    public interface ITokenRepository
    {
        string CreateJwtToken(IdentityUser user,List<string> roles);
    }
}
