## 2026-07-12 - Artificial Delays and Synchronous Identity Queries in PublicApi
**Learning:** Multiple PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial `Task.Delay(1000, ct)` calls, likely for simulating latency. Additionally, Identity queries were using synchronous `.ToList()` which blocks threads.
**Action:** Remove `Task.Delay` and convert synchronous Identity queries to `await ...ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` to significantly improve response times and scalability.
