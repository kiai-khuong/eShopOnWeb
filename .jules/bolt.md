## 2025-05-14 - Artificial Delays and Synchronous Materialization in PublicApi
**Learning:** The PublicApi project contains several endpoints with 1000ms artificial delays (`Task.Delay(1000)`) and synchronous list materialization (`ToList()`) on Identity `IQueryable` properties. These patterns significantly impact response times and test suite duration.
**Action:** Always check for `Task.Delay` and synchronous `ToList()` on database-backed queries in new or existing endpoints. Use `ToListAsync()` from `Microsoft.EntityFrameworkCore` for non-blocking I/O.
