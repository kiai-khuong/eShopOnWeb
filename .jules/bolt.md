
## 2026-06-05 - Artificial delays and sync-over-async in PublicApi
**Learning:** Found 1s artificial Task.Delay calls and synchronous .ToList() on IQueryable in PublicApi endpoints (UserList, RoleList, CatalogItemListPaged). These are common "simulated latency" patterns that significantly slow down both end-user experience and automated test suites.
**Action:** Always search for "Task.Delay" and ".ToList()" on IQueryable in new PublicApi endpoints. Use ".ToListAsync(ct)" from Microsoft.EntityFrameworkCore and remove artificial delays to improve performance and test execution speed.
