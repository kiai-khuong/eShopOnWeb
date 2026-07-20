using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FastEndpoints;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
        // PERFORMANCE: Removed artificial 1-second delay (Task.Delay) to significantly reduce API response time
        // and avoid thread pool blocking or artificial latency in test suites and production.

        var response = new RoleListResponse();

        // PERFORMANCE: Converted synchronous .ToList() database query to asynchronous .ToListAsync()
        // to avoid blocking the request thread and improve overall application throughput.
        response.Roles = await roleManager.Roles.ToListAsync(cancellationToken: ct);
        return response;
    }
}
