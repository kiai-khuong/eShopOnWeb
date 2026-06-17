## 2026-06-17 - Artificial delays and synchronous Identity queries in PublicApi
**Learning:** PublicApi endpoints (Catalog, Users, Roles) were found to have artificial 1000ms Task.Delay calls and synchronous .ToList() calls on IQueryable properties (UserManager.Users, RoleManager.Roles). These were likely added for demo purposes but significantly degrade performance and scalability.
**Action:** Always check for Task.Delay and synchronous materialization in new endpoints. Prefer ToListAsync(ct) with Microsoft.EntityFrameworkCore for Identity queries.
