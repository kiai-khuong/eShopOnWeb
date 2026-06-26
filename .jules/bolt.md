## 2025-05-15 - [Identity & Catalog API Bottlenecks]
**Learning:** Found artificial `Task.Delay(1000)` calls and synchronous `.ToList()` materialization in PublicApi endpoints (UserList, RoleList, CatalogItemListPaged), likely left for simulation purposes. Removing these and switching to `ToListAsync` reduced PublicApiIntegrationTests suite time from 16s to 5s (~70% improvement).
**Action:** Prioritize auditing PublicApi endpoints for artificial delays and non-async query materialization when hunting for easy performance wins in this codebase.
