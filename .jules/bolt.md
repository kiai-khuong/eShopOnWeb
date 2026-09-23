## 2025-05-18 - Async Identity Endpoint Queries & Delay Removal
**Learning:** PublicApi identity management endpoints (`UserListEndpoint` and `RoleListEndpoint`) contained artificial `Task.Delay(1000)` latency calls and executed synchronous EF Core queries via `ToList()`.
**Action:** Remove artificial delays and convert Identity manager queries to asynchronous `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` to improve response times and prevent thread pool blocking.
