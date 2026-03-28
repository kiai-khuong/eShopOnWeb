## 2025-05-14 - Artificial Latency in PublicApi Endpoints
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contain hardcoded `await Task.Delay(1000, ct);` calls. These are likely leftover from development to simulate network latency but significantly impact real-world performance and test execution speed.
**Action:** Always check for `Task.Delay` in API endpoints when profiling for latency. Removing these resulted in a ~75% reduction in PublicApi integration test duration (from ~16s to ~4s).

## 2025-05-14 - Identity Manager Synchronous Enumeration
**Learning:** `UserManager<T>.Users` and `RoleManager<T>.Roles` return `IQueryable<T>`, but calling `.ToList()` on them blocks the thread while the database query executes.
**Action:** Use `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` to ensure non-blocking database access in Identity-related endpoints.
