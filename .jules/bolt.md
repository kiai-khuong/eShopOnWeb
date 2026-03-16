## 2025-05-14 - Artificial Latency in PublicApi
**Learning:** The PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contained artificial `Task.Delay(1000)` calls, likely for simulating network latency in development. Additionally, Identity Managers were using synchronous `.ToList()` calls on IQueryable.
**Action:** Remove `Task.Delay` and use `await ...ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` to improve response times and scalability.
