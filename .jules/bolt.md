## 2025-05-18 - Identity PublicApi Endpoints Async Optimization & Delay Removal
**Learning:** `UserListEndpoint` and `RoleListEndpoint` in `PublicApi` contained artificial 1-second delays (`Task.Delay(1000, ct)`) and synchronous Entity Framework queries (`.ToList()`). Switching to `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` and eliminating artificial delays significantly improves throughput and responsiveness.
**Action:** Always check Identity API endpoints for synchronous `.ToList()` calls on `IQueryable` instances and artificial latency delays.
