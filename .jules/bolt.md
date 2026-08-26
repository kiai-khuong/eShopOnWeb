## 2025-08-26 - PublicApi Latency and Sync Identity Queries

**Learning:** PublicApi endpoints (`CatalogItemListPagedEndpoint`, `UserListEndpoint`, `RoleListEndpoint`) contained artificial `Task.Delay(1000)` calls as well as synchronous `ToList()` query executions on Identity `IQueryable` instances. Removing the artificial delays and converting synchronous database evaluations to EF Core's `ToListAsync(ct)` drastically improves throughput and decreases API integration test execution time from ~16s to ~4s.

**Action:** When working on PublicApi or web API endpoints, inspect for artificial delay calls and synchronous database query executions on `IQueryable` instances (e.g., `UserManager.Users` or `RoleManager.Roles`), and convert them to `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore`.
