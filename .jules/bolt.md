## 2025-05-18 - Identity Query Async Conversion & Artificial Latency Removal
**Learning:** PublicApi UserList and RoleList endpoints contained hardcoded artificial `Task.Delay(1000)` calls and synchronous `.ToList()` queries on EF Core IQueryables (`userManager.Users`, `roleManager.Roles`).
**Action:** Remove the artificial delays and replace synchronous execution with `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` to eliminate latency and free up thread pool threads.
