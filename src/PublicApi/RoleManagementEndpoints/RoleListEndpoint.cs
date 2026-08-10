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
        // PERFORMANCE: Removed artificial 1000ms delay and optimized synchronous roleManager.Roles.ToList() to use EF Core ToListAsync(ct)
        // This avoids blocking threads on I/O and reduces response latency by over 1000ms.
        var response = new RoleListResponse();
        response.Roles = await roleManager.Roles.ToListAsync(cancellationToken: ct);
        return response;
    }
}
