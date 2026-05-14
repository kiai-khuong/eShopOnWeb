## 2025-05-14 - Artificial latency and sync-over-async in PublicApi
**Learning:** The PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial `Task.Delay(1000)` calls to simulate latency. Additionally, Identity managers were using synchronous `.ToList()` on `IQueryable` properties, which can lead to thread pool starvation.
**Action:** Always check for `Task.Delay` and synchronous materialization (`.ToList()`, `.ToArray()`) in API endpoints, especially when they can be easily converted to `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore`.
