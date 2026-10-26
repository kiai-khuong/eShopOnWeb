## 2025-05-15 - Identity Endpoint Latency and Async Query Optimization
**Learning:** PublicApi identity management endpoints contained artificial `Task.Delay(1000)` calls and synchronous `.ToList()` database queries on `UserManager` and `RoleManager`. Converting to `ToListAsync()` with EF Core and removing delays significantly improves API latency and thread pool utilization.
**Action:** Always check Identity endpoint implementations for artificial delays and sync DB queries, and convert them to `ToListAsync(ct)`.
