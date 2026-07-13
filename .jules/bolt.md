## 2025-05-14 - Artificial delays and synchronous Identity queries in PublicApi
**Learning:** Multiple PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contain artificial `Task.Delay(1000)` calls that significantly increase latency. Additionally, using synchronous `.ToList()` on Identity managers' `IQueryable` properties blocks threads and can be optimized using EF Core's `ToListAsync`.
**Action:** Always check for `Task.Delay` and synchronous materialization in PublicApi endpoints. Ensure `Microsoft.EntityFrameworkCore` is imported for async extensions.
