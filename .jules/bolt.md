## 2025-05-18 - Remove artificial endpoint delays and convert Identity queries to async

**Learning:** `UserListEndpoint` and `RoleListEndpoint` contained artificial `Task.Delay(1000, ct)` calls and synchronous `.ToList()` execution on `IQueryable` Identity collections, introducing an unnecessary 1000ms latency floor and blocking thread pool execution during I/O.
**Action:** Remove `Task.Delay` and convert `.ToList()` to EF Core's `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore`.
