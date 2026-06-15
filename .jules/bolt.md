## 2026-06-15 - [Artificial Delays and Sync-over-Async in PublicApi]
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial `Task.Delay(1000)` calls and synchronous `.ToList()` calls on Identity manager `IQueryable` properties. These patterns significantly inflate response times and risk thread pool starvation.
**Action:** Always check for `Task.Delay` and synchronous materialization of `IQueryable` (like `.ToList()`, `.FirstOrDefault()`) in API endpoints. Replace with asynchronous equivalents (`ToListAsync(ct)`) and remove artificial delays.
