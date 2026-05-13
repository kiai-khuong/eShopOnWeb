## 2025-05-22 - Artificial Delays and Synchronous I/O in PublicApi
**Learning:** The PublicApi endpoints (Catalog, User, Role) contained artificial 1-second delays (`Task.Delay(1000)`) and synchronous list materialization (`ToList()`) on IQueryable properties. Removing these delays and using `ToListAsync()` significantly reduced response times and test duration (from 17s to 5s).
**Action:** Always check for `Task.Delay` and synchronous I/O on `IQueryable` in API endpoints as they are common low-hanging fruit for performance wins in this codebase.
