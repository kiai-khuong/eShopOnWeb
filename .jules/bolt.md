## 2026-06-01 - Artificial Delays and Synchronous Materialization in PublicApi
**Learning:** Found multiple endpoints in `PublicApi` (CatalogItemListPaged, UserList, RoleList) using `await Task.Delay(1000)` to simulate latency and synchronous `.ToList()` on `IQueryable` properties. These patterns significantly degrade response times and scalability.
**Action:** Always check for artificial delays and convert synchronous materialization to `await ...ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` in PublicApi endpoints to improve performance and test execution speed.
