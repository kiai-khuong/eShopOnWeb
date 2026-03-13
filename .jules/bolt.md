## 2025-05-15 - [Identity Endpoints & Read-Only Queries]
**Learning:** PublicApi endpoints for User and Role management were using synchronous `.ToList()` on `IQueryable`, which blocks threads. Additionally, artificial `Task.Delay(1000)` calls were present in several listing endpoints. Read-only catalog specifications were also missing `.AsNoTracking()`, leading to unnecessary overhead.
**Action:** Use `.ToListAsync(ct)` from `Microsoft.EntityFrameworkCore` for Identity queries, remove artificial delays, and apply `.AsNoTracking()` to specifications used exclusively for read-only listings.
