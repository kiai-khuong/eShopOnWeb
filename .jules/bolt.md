## 2025-05-18 - Identity Management Endpoints Async Conversion and Artificial Delay Removal
**Learning:** `UserListEndpoint` and `RoleListEndpoint` in `PublicApi` contained synchronous `.ToList()` queries on Identity managers and artificial 1000ms `Task.Delay` calls that blocked endpoint latency and degraded thread pool efficiency.
**Action:** Remove `Task.Delay(1000, ct)` calls and convert `userManager.Users.ToList()` and `roleManager.Roles.ToList()` to `ToListAsync(ct)` by adding `Microsoft.EntityFrameworkCore` extension methods to eliminate non-blocking I/O bottlenecks.
