## 2025-05-15 - Artificial Delays in PublicApi
**Learning:** Several endpoints in the PublicApi (CatalogItemListPaged, UserList, RoleList) contain artificial `Task.Delay(1000)` calls to simulate latency. These significantly bloat response times and test duration.
**Action:** Always check for and remove `Task.Delay` in PublicApi endpoints when profiling for performance wins.

## 2025-05-15 - Synchronous Identity Queries
**Learning:** `UserManager.Users` and `RoleManager.Roles` are `IQueryable` but were being materialized with `.ToList()` in API endpoints, blocking threads.
**Action:** Use `await ...ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` for these queries to ensure non-blocking I/O.
