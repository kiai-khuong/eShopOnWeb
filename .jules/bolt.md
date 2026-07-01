## 2026-07-01 - Artificial delays in PublicApi
**Learning:** Multiple PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contain artificial 'Task.Delay(1000, ct)' calls likely used to simulate latency; removing these and converting synchronous Identity queries to 'ToListAsync' significantly improves response times.
**Action:** Always check for 'Task.Delay' and synchronous materialization in PublicApi endpoints during initial profiling.
