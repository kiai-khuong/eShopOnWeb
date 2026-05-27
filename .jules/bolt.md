## 2025-05-14 - [Artificial delays and Synchronous Materialization in PublicApi]
**Learning:** Found 1000ms artificial delays in multiple PublicApi endpoints (CatalogItemListPaged, UserList, RoleList). Also identified synchronous .ToList() calls on IQueryable properties (UserManager.Users, RoleManager.Roles) which can block threads.
**Action:** Remove artificial Task.Delay calls and convert synchronous materialization to await ...ToListAsync(ct) using Microsoft.EntityFrameworkCore to improve response times and thread pool utilization.
