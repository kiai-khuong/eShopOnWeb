## 2025-05-14 - Artificial Delays in PublicApi
**Learning:** Several PublicApi endpoints (`CatalogItemListPaged`, `UserList`, `RoleList`) contained hardcoded `await Task.Delay(1000)` calls, likely for simulating latency during development. Removing these reduces endpoint response time by 1 second.
**Action:** Always check for `Task.Delay` in performance-critical paths, especially in sample or template codebases.

## 2025-05-14 - Read-only Specifications with AsNoTracking
**Learning:** Using `Query.AsNoTracking()` in `Ardalis.Specification` based specifications informs Entity Framework Core to skip change tracking. This is highly effective for paginated lists and filter queries to reduce memory and CPU overhead.
**Action:** Apply `AsNoTracking()` to specifications used exclusively for read-only UI or API responses.

## 2025-05-14 - Identity Manager Async Operations
**Learning:** Identity's `UserManager` and `RoleManager` provide `IQueryable` properties (e.g., `.Users`, `.Roles`). Using synchronous `.ToList()` on these blocks the calling thread. Using `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` ensures true async execution.
**Action:** Use `ToListAsync` for Identity manager queries to improve server scalability.
