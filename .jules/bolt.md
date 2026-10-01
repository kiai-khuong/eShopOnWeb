## 2025-10-01 - Artificial Delays and Synchronous I/O in PublicApi Endpoints

**Learning:** PublicApi endpoints (`UserListEndpoint`, `RoleListEndpoint`, `CatalogItemListPagedEndpoint`) contained hardcoded `Task.Delay(1000)` calls simulating latency, as well as synchronous `ToList()` queries on EF Core `IQueryable` instances. Switching to asynchronous `ToListAsync()` with `using Microsoft.EntityFrameworkCore;` prevents thread pool blocking, and removing artificial delays drastically improves endpoint response times and test suite duration.

**Action:** Always check API endpoints for legacy simulated delays (`Task.Delay`) and synchronous database calls (`.ToList()`), replacing them with `ToListAsync(ct)` for non-blocking execution.
