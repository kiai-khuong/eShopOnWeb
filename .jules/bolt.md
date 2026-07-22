## 2025-02-15 - [API Endpoint Latency Optimization]
**Learning:** Multiple PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) contain artificial `Task.Delay(1000, ct)` calls likely used to simulate latency; removing these and converting synchronous Identity queries (e.g. `ToList()`) to `ToListAsync()` significantly improves response times.
**Action:** Always inspect endpoints for artificial delays or synchronous db materialization on hot paths and convert to fully asynchronous execution.
