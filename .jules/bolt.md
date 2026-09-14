## 2025-05-20 - Asynchronous Identity Queries and Removing Artificial Delays

**Learning:** PublicApi endpoints (UserListEndpoint, RoleListEndpoint) previously contained artificial `Task.Delay(1000, ct)` calls and synchronous `.ToList()` execution on `IQueryable` Identity collections, causing unnecessary response delays and blocking ASP.NET thread pool threads.

**Action:** Remove artificial delays in PublicApi endpoints and convert synchronous Identity `IQueryable.ToList()` calls to asynchronous EF Core `ToListAsync(ct)` queries using `Microsoft.EntityFrameworkCore`.
