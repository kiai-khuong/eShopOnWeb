## 2026-04-28 - Removed artificial delays in PublicApi
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial 1-second delays (Task.Delay) to simulate latency. Removing these significantly improved response times and reduced integration test suite duration by ~60%.
**Action:** Always check for Task.Delay in API endpoints when profiling for latency in this codebase.
