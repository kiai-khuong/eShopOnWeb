## 2026-05-26 - [Artificial Delays and Async LINQ in PublicApi]
**Learning:** Found 1000ms artificial delays in UserList, RoleList, and CatalogItemListPaged endpoints. Also identified synchronous .ToList() calls on IQueryable properties in Identity endpoints.
**Action:** Always check for Task.Delay and synchronous materialization in PublicApi endpoints. Use ToListAsync(ct) from Microsoft.EntityFrameworkCore for better asynchrony.
