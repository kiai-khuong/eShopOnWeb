## 2025-05-18 - Artificial Latency Delays and Synchronous Identity Database Queries in PublicApi

**Learning:** PublicApi user and role management endpoints (`UserListEndpoint`, `RoleListEndpoint`) contained artificial `Task.Delay(1000, ct)` calls and synchronous `.ToList()` operations on ASP.NET Core Identity `IQueryable` properties, adding at least 1000ms latency per request and blocking thread pool workers.

**Action:** Remove artificial delays and convert Identity `IQueryable` materialization to asynchronous `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` to improve response times and maximize thread pool efficiency.
