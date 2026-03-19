using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Microsoft.eShopWeb.PublicApi.RoleManagementEndpoints;

public class RoleListEndpoint(RoleManager<IdentityRole> roleManager):EndpointWithoutRequest<RoleListResponse>
{

    public override void Configure()
    {
        Get("api/roles");
        Roles(BlazorShared.Authorization.Constants.Roles.ADMINISTRATORS);
        AuthSchemes(JwtBearerDefaults.AuthenticationScheme);
        Description(d => d.Produces<RoleListResponse>()
        .WithTags("RoleManagementEndpoints"));
    }

    public override async Task<RoleListResponse> ExecuteAsync(CancellationToken ct)
    {
        // PERFORMANCE: Removed artificial delay to improve endpoint responsiveness.
        var response = new RoleListResponse();
        // PERFORMANCE: Using ToListAsync to ensure the operation is fully asynchronous and avoids blocking threads.
        response.Roles = await roleManager.Roles.ToListAsync(ct);
        return response;
    }
}
