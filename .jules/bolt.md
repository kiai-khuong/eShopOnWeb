## 2026-07-10 - [PublicApi Artificial Delays and Sync Identity Queries]
**Learning:** Multiple PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contained artificial 'Task.Delay(1000, ct)' calls, likely for simulation. Additionally, Identity queries were using synchronous '.ToList()' on IQueryable properties, causing thread pool blocking.
**Action:** Remove 'Task.Delay' calls and convert synchronous Identity queries to 'await ...ToListAsync(ct)' by adding 'using Microsoft.EntityFrameworkCore;'. This reduced PublicApiIntegrationTests execution time from 16s to 7s.
