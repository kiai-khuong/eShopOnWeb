## 2026-06-14 - Removed artificial delays and fixed sync-over-async in PublicApi
**Learning:** The PublicApi project contained several endpoints with artificial 1-second delays and synchronous .ToList() calls on IQueryable properties.
**Action:** Always check PublicApi endpoints for Task.Delay and ensure IQueryable results are materialized using ToListAsync(ct) from Microsoft.EntityFrameworkCore.
