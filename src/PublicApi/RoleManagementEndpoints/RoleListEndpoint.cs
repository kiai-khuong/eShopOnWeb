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
        // PERFORMANCE: Removed the artificial 1-second delay (Task.Delay(1000)) to reduce request latency and speed up test execution.
        // Also converted synchronous .ToList() call to asynchronous .ToListAsync(ct) using Entity Framework Core extension methods
        // to free up thread pool threads and improve scalability.
        var response = new RoleListResponse();
        response.Roles = await roleManager.Roles.ToListAsync(ct);
        return response;
    }
}
