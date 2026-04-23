## 2025-05-14 - Artificial Delays in PublicApi
**Learning:** Found artificial `Task.Delay(1000, ct)` calls in multiple PublicApi endpoints (`CatalogItemListPaged`, `UserList`, `RoleList`). These were likely added to simulate latency but significantly degrade performance and increase test duration.
**Action:** Always check for and remove artificial delays in API endpoints. Removing them reduced PublicApi integration test time from ~14s to ~5s.

## 2025-05-14 - Synchronous DB Calls on Identity Managers
**Learning:** `UserManager` and `RoleManager` in ASP.NET Core Identity expose `IQueryable` collections (`Users`, `Roles`). Calling `.ToList()` on these inside an async method blocks the request thread.
**Action:** Use `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` to ensure database access is fully asynchronous, improving application scalability.
