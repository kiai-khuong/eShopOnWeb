## 2025-05-18 - Artificial Latency and Sync Queries in PublicApi Endpoints
**Learning:** PublicApi endpoints (`CatalogItemListPaged`, `UserList`, `RoleList`) contained artificial 1-second `Task.Delay(1000)` calls and synchronous `.ToList()` Identity queries that blocked thread pool threads and added unnecessary latency.
**Action:** Remove `Task.Delay` and convert `.ToList()` to EF Core `ToListAsync(ct)` with `using Microsoft.EntityFrameworkCore;` in PublicApi endpoints to improve API throughput and lower latency.
