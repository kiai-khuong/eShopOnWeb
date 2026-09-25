## 2025-05-18 - PublicApi Artificial Delay Removal and Async EF Identity Queries

**Learning:** `CatalogItemListPagedEndpoint`, `UserListEndpoint`, and `RoleListEndpoint` contained artificial `Task.Delay(1000, ct)` statements simulating network latency. Furthermore, `UserListEndpoint` and `RoleListEndpoint` were invoking synchronous EF Core queries (`.ToList()`) on Identity managers. Removing these delays and converting queries to `ToListAsync()` drastically improved test execution speed and API response latency.

**Action:** Always scan for artificial delays (`Task.Delay`) and synchronous database calls (`.ToList()`) in API endpoints when addressing performance issues. Ensure `Microsoft.EntityFrameworkCore` namespace is included when using EF Core async extensions on ASP.NET Core Identity managers.
