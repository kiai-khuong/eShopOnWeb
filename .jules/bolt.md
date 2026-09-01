## 2025-02-21 - Asynchronous Identity Queries & Latency Removal in PublicApi

**Learning:** Identity manager queries (`userManager.Users`, `roleManager.Roles`) default to synchronous `IQueryable` evaluation if `.ToList()` is called, blocking the execution thread. Combining `Microsoft.EntityFrameworkCore` extension method `ToListAsync(ct)` with removing artificial 1s `Task.Delay` calls in PublicApi endpoints significantly improves throughput and responsiveness.

**Action:** Always import `Microsoft.EntityFrameworkCore` when working with Identity managers (`UserManager`, `RoleManager`) to enable non-blocking `ToListAsync()` queries, and eliminate artificial latency delays in API endpoints.
