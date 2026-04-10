## 2025-05-14 - Artificial Delays and Synchronous Calls in PublicApi
**Learning:** The PublicApi endpoints (CatalogItemListPaged, UserList, RoleList) contained artificial `Task.Delay(1000)` calls simulating latency and used synchronous `.ToList()` calls on IQueryable. Removing these delays and converting to asynchronous `ToListAsync(ct)` significantly improves response times and test duration.
**Action:** Always scan for artificial delays in API endpoints and ensure database operations are fully asynchronous using `Microsoft.EntityFrameworkCore` extensions.
