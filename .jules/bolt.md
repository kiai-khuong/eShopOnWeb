## 2025-05-14 - Artificial Delays in PublicApi
**Learning:** Several PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained `Task.Delay(1000)` calls, likely for simulating latency. Removing these reduced PublicApiIntegrationTests suite duration from ~16s to ~5s.
**Action:** Always check for `Task.Delay` in endpoints when profiling for quick performance wins in this codebase.

## 2025-05-14 - Identity Manager Sync Calls
**Learning:** `UserManager` and `RoleManager` queries in PublicApi were using `.ToList()`, which is synchronous and blocks threads.
**Action:** Use `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` for all Identity manager queries to improve scalability and responsiveness.
