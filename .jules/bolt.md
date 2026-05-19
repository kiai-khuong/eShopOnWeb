## 2025-05-14 - Artificial delays and sync-over-async in PublicApi
**Learning:** The eShopOnWeb PublicApi contains artificial 1000ms delays in several endpoints (CatalogItemListPaged, UserList, RoleList) to simulate latency. Additionally, Identity endpoints (UserList, RoleList) were using synchronous '.ToList()' on IQueryable properties (UserManager.Users, RoleManager.Roles), which causes sync-over-async and potential thread pool starvation in ASP.NET Core.

**Action:** Remove 'Task.Delay' calls in PublicApi and convert synchronous materialization of Identity queries to 'await ...ToListAsync(ct)' using 'Microsoft.EntityFrameworkCore' extension methods.
