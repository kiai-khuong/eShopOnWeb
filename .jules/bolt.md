## 2025-05-14 - [Latency Reduction & Async Optimization]
**Learning:** Found artificial `Task.Delay(1000)` calls in several PublicApi endpoints used to simulate network latency. Additionally, Identity manager calls (`RoleManager`, `UserManager`) were using synchronous `.ToList()` on IQueryable, which blocks threads unnecessarily.
**Action:** Remove `Task.Delay` to improve response time and use `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` to ensure non-blocking I/O in API endpoints.
