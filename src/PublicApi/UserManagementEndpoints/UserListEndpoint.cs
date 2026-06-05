using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FastEndpoints;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        // PERFORMANCE: Removing 1s artificial delay to improve response time.
        var response = new UserListResponse();
        // PERFORMANCE: Using ToListAsync to avoid blocking threads during I/O.
        var users = await userManager.Users.ToListAsync(ct);
        foreach (var user in users)
        {
            response.Users.Add(user.ToUserDto());
        }
        return response;
    }
}
