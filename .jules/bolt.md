## 2025-05-18 - Artificial Latency and Synchronous DB Queries in PublicApi List Endpoints
**Learning:** Multiple PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial `Task.Delay(1000)` calls along with synchronous `.ToList()` calls on Identity queryables. Removing the delays and switching to EF Core's async `ToListAsync()` reduced PublicApi integration test suite execution time from 15s to 5s.
**Action:** Always check API list endpoints for artificial delays and synchronous IEnumerable/IQueryable execution before searching for complex database optimizations.
