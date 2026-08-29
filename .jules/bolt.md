## 2025-05-18 - Identity Query Async Conversion & Delay Removal

**Learning:** `UserManager<T>` and `RoleManager<T>` expose `IQueryable` properties (`Users` and `Roles`), which default to synchronous execution with `.ToList()`. Converting these queries to EF Core's `ToListAsync(ct)` prevents blocking thread pool threads during database retrieval. Furthermore, removing artificial `Task.Delay` calls in management endpoints significantly reduces endpoint latency and speeds up integration test execution times from 17s down to 5s.

**Action:** Always check Identity endpoints (`UserListEndpoint`, `RoleListEndpoint`) for synchronous LINQ executions or artificial delays, and convert query executions to `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore`.
