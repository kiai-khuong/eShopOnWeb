# Bolt's Journal - Critical Performance Learnings

## 2025-05-14 - Identity Management Async Optimization
**Learning:** Identity Manager properties like `UserManager.Users` and `RoleManager.Roles` are `IQueryable`. Using synchronous `.ToList()` on them blocks thread pool threads.
**Action:** Always use `await ...ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` to ensure non-blocking database operations in PublicApi endpoints.

## 2025-05-14 - Artificial Delays in PublicApi
**Learning:** Several PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contain explicit `await Task.Delay(1000, ct)` calls, likely for simulating latency.
**Action:** Removing these delays provides immediate performance gains for end-users and significantly speeds up the integration test suite (from ~16s to ~5s for PublicApi tests).
