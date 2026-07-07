## 2026-07-07 - Artificial Delays and Synchronous Identity Queries in PublicApi
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial `Task.Delay(1000)` calls likely used for simulating latency. Additionally, Identity queries were using synchronous `.ToList()` which blocks threads.
**Action:** Always scan for `Task.Delay` and synchronous `.ToList()` on `IQueryable` (especially in Identity endpoints) as they are common performance anti-patterns in this codebase. Removing them reduced PublicApi integration test duration by ~68%.
