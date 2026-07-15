## 2025-05-15 - [Anti-pattern] Artificial delays and synchronous queries in PublicApi
**Learning:** Multiple PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contained artificial 'Task.Delay(1000, ct)' calls likely used to simulate latency. Additionally, Identity managers were using synchronous '.ToList()' which blocks the thread.
**Action:** Removed artificial delays and converted synchronous queries to 'ToListAsync(ct)' with 'using Microsoft.EntityFrameworkCore;'. This reduced 'PublicApiIntegrationTests' suite execution time from 16s to 4s.
