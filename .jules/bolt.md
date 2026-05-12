## 2026-05-12 - Removing Artificial Delays and Using Async Materialization
**Learning:** The PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained 1000ms artificial delays and synchronous `.ToList()` calls on Identity manager queries.
**Action:** Always check for `Task.Delay` and synchronous materialization in new endpoints. Use `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` for IQueryable sources to improve scalability and reduce latency.
