## 2026-05-21 - [Anti-pattern: Artificial Latency]
**Learning:** Found 1000ms artificial 'Task.Delay' calls in PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) used to simulate latency. These significantly slow down integration tests and real-world performance. Also found synchronous '.ToList()' calls on IQueryable Identity managers.
**Action:** Always check PublicApi endpoints for 'Task.Delay' and sync-over-async calls on UserManager/RoleManager. Use 'ToListAsync(ct)' from 'Microsoft.EntityFrameworkCore' and remove simulation delays.
