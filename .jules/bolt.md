## 2025-05-18 - Identity PublicApi Endpoints Async Optimization

**Learning:** `UserListEndpoint` and `RoleListEndpoint` in `PublicApi` contained artificial 1-second `Task.Delay` calls and used blocking synchronous `.ToList()` queries on Identity Managers (`UserManager<ApplicationUser>` and `RoleManager<IdentityRole>`). Including `Microsoft.EntityFrameworkCore` allows using `ToListAsync(ct)`, which eliminates thread blocking and latency.
**Action:** Always import `Microsoft.EntityFrameworkCore` when working with Identity managers (`UserManager` / `RoleManager`) to utilize `ToListAsync(ct)` and remove any artificial delays in API endpoints.
