## 2025-05-15 - [Artificial Latency in PublicApi]
**Learning:** The PublicApi endpoints (RoleList, UserList, CatalogItemListPaged) contain artificial `Task.Delay(1000)` calls, likely to simulate network latency in demo scenarios. These are low-hanging fruit for significant performance gains.
**Action:** Always check for and remove `Task.Delay` in API endpoints unless they serve a specific functional purpose (e.g., rate limiting, which isn't the case here).

## 2025-05-15 - [Async Identity Operations]
**Learning:** Identity managers (RoleManager, UserManager) in the PublicApi were using `.ToList()` on IQueryable properties. Using `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` is preferred to avoid blocking threads.
**Action:** Use `ToListAsync(ct)` for database-backed IQueryable operations in endpoints.
