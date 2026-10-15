## 2025-05-18 - Identity Management Endpoints Latency & Synchronous Query Bottlenecks
**Learning:** `UserListEndpoint` and `RoleListEndpoint` contained artificial `Task.Delay(1000)` calls along with synchronous `.ToList()` calls on EF Core `IQueryable` instances (`userManager.Users` and `roleManager.Roles`), causing ~1000ms response delays and thread-pool blocking.
**Action:** Remove `Task.Delay` calls and convert `IQueryable.ToList()` calls to `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` to allow async database queries and non-blocking I/O.
