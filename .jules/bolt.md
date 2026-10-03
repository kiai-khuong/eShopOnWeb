## 2025-05-18 - Identity Query Async Optimization and Latency Removal

**Learning:** PublicApi user and role endpoints (`UserListEndpoint` and `RoleListEndpoint`) contained artificial 1-second delays (`Task.Delay(1000)`) and blocking synchronous EF query executions (`.ToList()`). Converting `userManager.Users` and `roleManager.Roles` queries to EF Core's `.ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` while removing artificial delays eliminates thread starvation and reduces test suite execution time for PublicApi integration tests from 16s to 9s.

**Action:** Always import `Microsoft.EntityFrameworkCore` when working with ASP.NET Core Identity managers (`UserManager` / `RoleManager`) to enable EF Core async extension methods (`ToListAsync`, `FirstOrDefaultAsync`), and eliminate artificial latency delays in production API endpoints.
