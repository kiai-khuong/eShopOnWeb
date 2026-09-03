## 2025-05-18 - Identity Management Endpoint Delays and Synchronous I/O

**Learning:** PublicApi endpoints (`UserListEndpoint` and `RoleListEndpoint`) contained artificial `Task.Delay(1000)` calls and synchronous `.ToList()` queries on EF Core `IQueryable` instances. Removing artificial delays and using asynchronous `ToListAsync()` prevents thread pool starvation and reduces API response time by ~1000ms per call.
**Action:** Always check Identity management endpoints for artificial latency delays and ensure all EF Core database queries use async extension methods (`ToListAsync`, `FirstOrDefaultAsync`).
