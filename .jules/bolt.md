## 2025-05-15 - Removing Artificial Latency in PublicApi

**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial `Task.Delay(1000)` calls, likely to simulate network latency in a dev environment. Removing these and converting synchronous `.ToList()` calls on Identity managers to `.ToListAsync()` reduced the integration test suite duration by ~65% (from 15s to 5s).

**Action:** Always check for `Task.Delay` in sample/demo codebases as they are often used to simulate load but should be removed for performance profiling or production readiness. Ensure `Microsoft.EntityFrameworkCore` is imported to use `ToListAsync` on `IQueryable`.
