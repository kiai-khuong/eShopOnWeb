using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FastEndpoints;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.eShopWeb.Infrastructure.Identity;
using Microsoft.eShopWeb.PublicApi.Extensions;

namespace Microsoft.eShopWeb.PublicApi.UserManagementEndpoints;

public class UserListEndpoint(UserManager<ApplicationUser> userManager):EndpointWithoutRequest<UserListResponse>
{

    public override void Configure()
    {
        Get("api/users");
        Roles(BlazorShared.Authorization.Constants.Roles.ADMINISTRATORS);
        AuthSchemes(JwtBearerDefaults.AuthenticationScheme);
        Description(d => d.Produces<UserListResponse>()
        .WithTags("UserManagementEndpoints"));
    }

    public override async Task<UserListResponse> ExecuteAsync(CancellationToken ct)
    {
        // PERFORMANCE: Removed 1s artificial delay and converted synchronous EF query to async ToListAsync for thread pool efficiency and lower response latency.
        var response = new UserListResponse();
        var users = await userManager.Users.ToListAsync(ct);
        foreach ( var user in users)
        {
            response.Users.Add(user.ToUserDto());
        }
        return response;
    }
}
