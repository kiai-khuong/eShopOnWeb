# Bolt Performance Journal

## 2025-05-18 - PublicApi Identity Endpoints Artificial Delays & Async Optimizations
**Learning:** `UserListEndpoint` and `RoleListEndpoint` in `PublicApi` contain artificial `Task.Delay(1000, ct)` calls and synchronous `.ToList()` EF Core database queries.
**Action:** Remove `Task.Delay` and convert `userManager.Users.ToList()` / `roleManager.Roles.ToList()` to `ToListAsync(ct)` with `using Microsoft.EntityFrameworkCore;`.
