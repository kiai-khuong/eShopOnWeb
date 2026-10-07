## 2025-05-18 - Async Database Queries and Delay Removal in PublicApi Identity Endpoints
**Learning:** Removing artificial `Task.Delay(1000)` calls and replacing synchronous `.ToList()` with EF Core's asynchronous `.ToListAsync(ct)` in `UserListEndpoint` and `RoleListEndpoint` drastically reduces API response times and prevents thread pool starvation.
**Action:** Always check Identity/EF queries in PublicApi endpoints for synchronous execution or artificial delays.
