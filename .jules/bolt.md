## 2025-05-20 - Non-blocking async queries and artificial delay removal in PublicApi endpoints

**Learning:** PublicApi endpoints (UserList, RoleList, CatalogItemListPaged) previously contained artificial `Task.Delay(1000)` calls and synchronous `.ToList()` Identity queries that blocked thread execution. Removing the delays and converting `.ToList()` to EF Core's `ToListAsync()` drastically improves API throughput and reduces integration test execution time from 16s down to 5s (~68% execution time reduction).
**Action:** Always search for artificial delay calls or synchronous database operations in endpoint handlers and replace them with true async calls (`ToListAsync`, `FirstOrDefaultAsync`, etc.) to maximize thread pool efficiency and minimize request latency.
