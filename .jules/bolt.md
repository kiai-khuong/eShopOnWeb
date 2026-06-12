## 2025-05-22 - Artificial delays and synchronous materialization in PublicApi
**Learning:** Found artificial `Task.Delay(1000)` calls and synchronous `.ToList()` materialization on `IQueryable` properties (`UserManager.Users`, `RoleManager.Roles`) in PublicApi endpoints. These patterns significantly increase response times and block threads unnecessarily.
**Action:** Remove artificial delays and convert synchronous list materialization to `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore`.
