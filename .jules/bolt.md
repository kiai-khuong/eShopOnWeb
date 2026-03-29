## 2025-05-14 - Artificial Delays in PublicApi Endpoints
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contain hardcoded `Task.Delay(1000)` calls, likely to simulate network latency during development. Removing these results in a significant and immediate 70-75% reduction in integration test execution time.
**Action:** Always check for and remove artificial `Task.Delay` calls in API endpoints before considering them production-ready.

## 2025-05-14 - Identity Manager Synchronous Operations
**Learning:** Identity manager properties like `UserManager.Users` and `RoleManager.Roles` are `IQueryable`, but calling `.ToList()` on them executes synchronously. Using `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` is necessary to ensure these database operations are fully asynchronous.
**Action:** Use `.ToListAsync(ct)` from the EF Core namespace when materializing Identity queries to improve scalability and thread pool efficiency.
