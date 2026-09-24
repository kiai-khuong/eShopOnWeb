## 2025-05-18 - Eliminating Artificial Latency and Synchronous Queries in Identity Endpoints

**Learning:** PublicApi Identity endpoints (like `UserListEndpoint`) had hardcoded `Task.Delay(1000)` calls and synchronous `.ToList()` execution on `IQueryable`. Removing the 1s delay eliminates response latency and converting `.ToList()` to EF Core's `ToListAsync()` avoids thread pool blocking.

**Action:** Always check `IQueryable` endpoints in PublicApi for artificial `Task.Delay` calls and ensure `Microsoft.EntityFrameworkCore` is imported to use `ToListAsync(ct)`.
