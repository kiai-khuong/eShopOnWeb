## 2026-07-08 - [Identity API Optimization]
**Learning:** Multiple PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contain artificial 'Task.Delay(1000, ct)' calls and synchronous '.ToList()' calls on Identity IQueryables. Removing these delays and converting to 'ToListAsync(ct)' significantly reduces API latency and improves thread pool efficiency.
**Action:** Always check for 'Task.Delay' in PublicApi endpoints and ensure Identity queries are asynchronous using 'ToListAsync(ct)' from 'Microsoft.EntityFrameworkCore'.
