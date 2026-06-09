## 2025-05-14 - Artificial Delay and Sync-over-Async in PublicApi
**Learning:** The PublicApi endpoints for Catalog listing and Identity management (Users/Roles) contained 1000ms artificial delays and used synchronous `.ToList()` on IQueryable properties.
**Action:** Remove `Task.Delay` and convert to `ToListAsync(ct)` using `Microsoft.EntityFrameworkCore` to significantly improve response times and resource utilization.
