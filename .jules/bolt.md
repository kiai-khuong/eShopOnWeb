## 2026-06-23 - Artificial delays in PublicApi endpoints
**Learning:** Multiple endpoints in the PublicApi (UserList, RoleList, CatalogItemListPaged) contained artificial 'Task.Delay(1000, ct)' calls, likely for UI demonstration purposes, which significantly slowed down real-world performance and integration tests.
**Action:** Always check for and remove 'Task.Delay' calls in performance-critical paths and convert synchronous materialization (e.g., '.ToList()') to async counterparts ('ToListAsync') to improve scalability.
