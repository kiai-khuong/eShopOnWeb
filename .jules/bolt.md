## 2026-04-13 - [Artificial delays and synchronous DB calls in PublicApi]
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial 1-second delays and synchronous '.ToList()' calls on IQueryable. These significantly inflated response times and blocked threads during I/O. Removing these reduced PublicApiIntegrationTests execution time by ~65% (17s -> 6s).
**Action:** Always check for simulated latency or missing async DB operations when profiling API endpoints in this codebase.
