## 2025-05-18 - Identity PublicApi Endpoints Async Conversion and Delay Removal

**Learning:** PublicApi endpoints `UserListEndpoint` and `RoleListEndpoint` contained artificial `Task.Delay(1000, ct)` calls and performed synchronous `ToList()` queries on EF Core `IQueryable` instances (`userManager.Users` and `roleManager.Roles`). Converting `ToList()` to `ToListAsync(ct)` via `Microsoft.EntityFrameworkCore` prevents thread pool starvation under concurrent load, while removing artificial `Task.Delay` calls eliminates 2000ms of simulated latency per request cycle.

**Action:** Always check `PublicApi` endpoints for artificial `Task.Delay` calls and synchronous `ToList()` calls on EF Core `IQueryable` properties, replacing them with `ToListAsync(ct)` and async execution.
