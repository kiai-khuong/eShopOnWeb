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
        var response = new RoleListResponse();
        // Optimization: Using ToListAsync for non-blocking I/O and removed artificial 1s delay.
        response.Roles = await roleManager.Roles.ToListAsync(ct);
        return response;
    }
}
