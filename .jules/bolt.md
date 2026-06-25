## 2026-06-25 - Removed artificial delays and optimized Identity queries
**Learning:** Found artificial 1s delays in PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) and synchronous Materialization of Identity queries. Removing delays and using 'ToListAsync' reduced test suite latency by ~10s.
**Action:** Always check for 'Task.Delay' and sync materialization ('.ToList()') in endpoints, especially those involving Identity Managers.
