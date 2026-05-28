## ## 2025-05-14 - Artificial Latency in PublicApi
**Learning:** Found artificial 1000ms delays in PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) implemented via 'await Task.Delay(1000, ct)'. These are likely for demo purposes but significantly hurt real performance and test execution time.
**Action:** Always grep for 'Task.Delay' when starting performance profiling in this codebase to identify and remove these artificial bottlenecks early.

## 2025-05-14 - Synchronous IQueryable Materialization in Identity Endpoints
**Learning:** Identity Manager properties like 'UserManager.Users' and 'RoleManager.Roles' are IQueryable. Using '.ToList()' on them blocks the request thread.
**Action:** Use 'await ...ToListAsync(ct)' from 'Microsoft.EntityFrameworkCore' to ensure these operations are fully asynchronous and improve application scalability.